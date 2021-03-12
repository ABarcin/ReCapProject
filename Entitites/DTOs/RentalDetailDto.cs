using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitites.DTOs
{
    public class RentalDetailDto:IDto
    {
        public string CarBrandName { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public DateTime? RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string CompanyName { get; set; }
    }
}
