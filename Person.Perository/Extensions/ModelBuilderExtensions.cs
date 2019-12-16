using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Repository.Extensions
{
    using Domain = Person.Domain.Domains;
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            //Person
            modelBuilder.Entity<Domain.Person>().HasData(

               new Domain.Person()
               {
                   Id = 1,
                   LastName = "Test1",
                   FirstName = "Test1",
                   City = "Test1",
                   Gender = Domain.Gender.Male,
                   PrivateNumber = "11111111111",
                   BirthDate = new DateTime(1992, 1, 1)
               }
               ,
               new Domain.Person()
               {
                   Id = 2,
                   LastName = "Test2",
                   FirstName = "Test2",
                   City = "Tbl",
                   Gender = Domain.Gender.Male,
                   PrivateNumber = "11111111111",
                   BirthDate = new DateTime(1995, 2, 7)
               },
               new Domain.Person()
               {
                   Id = 3,
                   LastName = "Test3",
                   FirstName = "Test3",
                   City = "Tbilisi",
                   Gender = Domain.Gender.Female,
                   PrivateNumber = "11111111111",
                   BirthDate = new DateTime(1994, 4, 22)
               },
                new Domain.Person()
                {
                    Id = 4,
                    LastName = "Test4",
                    FirstName = "Test4",
                    City = "Test3",
                    Gender = Domain.Gender.Female,
                    PrivateNumber = "11111111111",
                    BirthDate = new DateTime(2001, 2, 8)
                },
                new Domain.Person()
                {
                    Id = 5,
                    LastName = "Test5",
                    FirstName = "Test5",
                    City = "Test3",
                    Gender = Domain.Gender.Female,
                    PrivateNumber = "11111111111",
                    BirthDate = new DateTime(2000, 5, 13)
                },
                new Domain.Person()
                {
                    Id = 6,
                    LastName = "Test6",
                    FirstName = "Test6",
                    City = "Test6",
                    Gender = Domain.Gender.Female,
                    PrivateNumber = "11111111111",
                    BirthDate = new DateTime(2000, 5, 10)
                }

           );

            //Relation

            modelBuilder.Entity<Domain.Relation>().HasData(
                new Domain.Relation()
                {
                    FromId = 1,
                    ToId = 3,
                    RelationType = Domain.RelationType.Other
                },
                new Domain.Relation()
                {
                    FromId = 1,
                    ToId = 2,
                    RelationType = Domain.RelationType.Relative
                },
                new Domain.Relation()
                {
                    FromId = 3,
                    ToId = 4,
                    RelationType = Domain.RelationType.Other
                },
                new Domain.Relation()
                {
                    FromId = 3,
                    ToId = 6,
                    RelationType = Domain.RelationType.Other
                },
                new Domain.Relation()
                {
                    FromId = 5,
                    ToId = 1,
                    RelationType = Domain.RelationType.Colleague
                },
                new Domain.Relation()
                {
                    FromId = 6,
                    ToId = 2,
                    RelationType = Domain.RelationType.Colleague
                },
                new Domain.Relation()
                {
                    FromId = 4,
                    ToId = 1,
                    RelationType = Domain.RelationType.Colleague
                },
                new Domain.Relation()
                {
                    FromId = 2,
                    ToId = 5,
                    RelationType = Domain.RelationType.Colleague
                }
            );

            //PhoneNumber
            modelBuilder.Entity<Domain.PhoneNumber>().HasData(
                new Domain.PhoneNumber()
                {
                    Id = 1,
                    Number = "123123",
                    NumberType = Domain.NumberType.Mobile,
                    PersonId = 2
                },

               new Domain.PhoneNumber()
               {
                   Id = 2,
                   Number = "456456",
                   NumberType = Domain.NumberType.Office,
                   PersonId = 2
               },
               new Domain.PhoneNumber()
               {
                   Id = 3,
                   Number = "777777",
                   NumberType = Domain.NumberType.Home,
                   PersonId = 1
               },
               new Domain.PhoneNumber()
               {
                   Id = 4,
                   Number = "888888",
                   NumberType = Domain.NumberType.Home,
                   PersonId = 2
               },
               new Domain.PhoneNumber()
               {
                   Id = 5,
                   Number = "55555555",
                   NumberType = Domain.NumberType.Home,
                   PersonId = 3
               },
               new Domain.PhoneNumber()
               {
                   Id = 6,
                   Number = "66666666",
                   NumberType = Domain.NumberType.Mobile,
                   PersonId = 4
               },
               new Domain.PhoneNumber()
               {
                   Id = 7,
                   Number = "77777777",
                   NumberType = Domain.NumberType.Office,
                   PersonId = 5
               },
               new Domain.PhoneNumber()
               {
                   Id = 8,
                   Number = "77777777",
                   NumberType = Domain.NumberType.Office,
                   PersonId = 6
               }
           );
        }
    }
}
