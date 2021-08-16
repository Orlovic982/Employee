using Employee.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Server.Pages
{
    public partial class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Empolyee> Empolyees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmpolyee);
        }

        private void LoadEmpolyee()
        {
            System.Threading.Thread.Sleep(3000);


            Empolyee e1 = new Empolyee
            {

                Id = 1,
                FirstName = "Milan",
                LastName = "Milankovic",
                Email = "milankovic@gmail.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DeparmentId = 1,
                PhotoPath = "images/default.png"


            };

            Empolyee e2 = new Empolyee
            {

                Id = 2,
                FirstName = "Dusan",
                LastName = "Milankovic",
                Email = "milankovic@gmail.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DeparmentId = 2,
                PhotoPath = "images/joker.png"


            };

            Empolyee e3 = new Empolyee
            {

                Id = 3,
                FirstName = "Srdjan",
                LastName = "Srdjanovic",
                Email = "milankovic@gmail.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DeparmentId =  3,
                PhotoPath = "images/default.png"


            };
            Empolyee e4 = new Empolyee
            {

                Id = 5,
                FirstName = "Mane",
                LastName = "Ivanovic",
                Email = "milankovic@gmail.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DeparmentId = 2,
                PhotoPath = "images/joker.png"


            };


            Empolyees = new List<Empolyee> { e1, e2, e3, e4 };

        }




    }
}
