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
                   LastName = "Levani",
                   FirstName = "Gviniashvili",
                   City = "Tbilisi",
                   Gender = Domain.Gender.Male,
                   PrivateNumber = "11111111111",
                   BirthDate = new DateTime(1992, 1, 1)
               }
               ,
               new Domain.Person()
               {
                   Id = 2,
                   LastName = "Levaniii",
                   FirstName = "Gviniashvilii",
                   City = "Tbilisi",
                   Gender = Domain.Gender.Male,
                   PrivateNumber = "11111111111",
                   BirthDate = new DateTime(1992, 1, 1)
               },
               new Domain.Person()
               {
                   Id = 3,
                   LastName = "Keti",
                   FirstName = "Sssssssss",
                   City = "Tbilisi",
                   Gender = Domain.Gender.Female,
                   PrivateNumber = "3333333",
                   BirthDate = new DateTime(1994, 4, 22)
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
                    ToId = 1,
                    RelationType = Domain.RelationType.Other
                },
                new Domain.Relation()
                {
                    FromId = 1,
                    ToId = 1,
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
               }
           );
        }
    }
}
