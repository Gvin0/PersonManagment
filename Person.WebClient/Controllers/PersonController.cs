using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Person.Domain.Interfaces;
using Person.Services;
using Person.WebClient.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Person.WebClient.Utilities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Person.Domain.Domains;

namespace Person.WebClient.Controllers
{
    using Domain = Person.Domain.Domains;
    public class PersonController : BaseController<Domain.Person, IPersonService>
    {
        private readonly IPhoneNumberService _phoneNumberService;
        private readonly IRelationService _relationService;
        private readonly IWebHostEnvironment _env;
        public PersonController(IPersonService service,
                                IPhoneNumberService phoneNumberService,
                                IRelationService relationService,
                                IWebHostEnvironment env) : base(service)
        {
            _phoneNumberService = phoneNumberService;
            _relationService = relationService;
            _env = env;
        }

        public async Task<IActionResult> Index(string searchString, string currentFilter, int? pageNumber)
        {
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            var persons = _service.Set()
                                        .Where(p => p.FirstName.Contains(searchString) ||
                                                    p.LastName.Contains(searchString) ||
                                                    p.PrivateNumber.Contains(searchString)
                                                    || searchString == null
                                        );
            int pageSize = 3;
            return View(await PaginatedList<Domain.Person>.CreateAsync(persons.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Persons = _service.Set().Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.LastName
            }).ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(PersonCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadFile(model);
                Domain.Person newPerson = new Domain.Person
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    BirthDate = model.BirthDate,
                    City = model.City,
                    Gender = model.Gender,
                    PrivateNumber = model.PrivateNumber,
                    PhotoPath = uniqueFileName,
                    PhoneNumbers = model.PhoneNumbers.Select(p => new Domain.PhoneNumber
                    {
                        Number = p.Number,
                        NumberType = p.NumberType
                    }).ToArray(),
                    RelatedTo = model.Relations.Select(r => new Domain.Relation
                    {
                        ToId = int.Parse(r.Value),
                        RelationType = r.RelationType
                    }).ToArray()
                };

                _service.Save(newPerson);
                _service.Commit();
                return RedirectToAction("Details", new { id = newPerson.Id });
            }
            return View();           
        }

        [HttpPost]
        public ViewResult Edit(PersonEditViewModel model)
        {
            return View();
        }
        [HttpGet]
        public ViewResult Edit(int id)
        {
            var person = _service.Fetch(id);
            PersonEditViewModel model = new PersonEditViewModel
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName,
                Gender = person.Gender,
                City = person.City,
                BirthDate = person.BirthDate,
                PrivateNumber = person.PrivateNumber,
                ExistingPhotoPath = person.PhotoPath,
                PhoneNumbers = person.PhoneNumbers.Select(pn => new PhoneNumberViewModel
                {
                    Number = pn.Number,
                    NumberType = pn.NumberType
                }).ToArray(),
                Relations = person.RelatedFrom.Select(r => new RelationViewModel 
                {
                    Value = r.ToId.ToString(),
                    RelationType = r.RelationType
                }).ToArray()
            };

            ViewBag.Persons = _service.Set().Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.LastName
            }).ToList();

            return View(model);
        }


        public IActionResult Details(int? id)
        {
            var person = _service.Fetch(id.Value);
            if (person == null)
            {
                Response.StatusCode = 404;
                return View("PersonNotFound", id.Value);
            }
            return View(person);
        }
        [HttpPost]
        public IActionResult DeletePerson(int id)
        {
            var person = _service.Set().FirstOrDefault(p => p.Id == id);
            var personNumbers = _phoneNumberService.Set().Where(ph => ph.PersonId == id);
            var relations = _relationService.Set().Where(r => r.FromId == id || r.ToId == id);
            if (personNumbers != null)
            {
                foreach (var pn in personNumbers)
                {
                    _phoneNumberService.Delete(pn.Id);
                }
                _phoneNumberService.Commit();
            }
            if (relations != null)
            {
                foreach (var r in relations)
                {
                    _relationService.Delete(r);
                }
                _relationService.Commit();
            }
            
            _service.Delete(id);
            _service.Commit();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [HttpGet]
        public async Task<IActionResult> IsPrivateNumberInUse(string privateNumber)
        {
            var person = await _service.Set().FirstOrDefaultAsync(p => p.PrivateNumber == privateNumber);
            if (person == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"privateNumber {privateNumber} is already in use");
            }
        }
        private string UploadFile(PersonCreateViewModel model)
        {
            string uniqueFileName = null;
            if (model.Photo != null)
            {                
                string uploadsFolder = Path.Combine(_env.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileStream);
                }              
            }
            return uniqueFileName;
        }
    }
}
