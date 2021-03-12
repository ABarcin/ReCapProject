using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitites.DTOs
{
    public class CustomerDetailDto:IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
    }
}
