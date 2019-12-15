using Microsoft.AspNetCore.Mvc;
using Person.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Person.WebClient.Controllers
{
    public class BaseController<TEntity, TService> : Controller
        where TEntity : class
        where TService : IBaseService<TEntity>
    {
        protected readonly TService _service;
        public BaseController(TService service)
        {
            _service = service;
        }
    }
}
