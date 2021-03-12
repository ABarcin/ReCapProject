using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entitites.Concrete;
using Entitites.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from ca in context.Cars
                             join re in context.Rentals
                             on ca.CarId equals re.CarId
                             join br in context.Brands
                             on ca.BrandId equals br.BrandId
                             join cu in context.Customers
                             on re.CustomerId equals cu.UserId
                             join us in context.Users
                             on cu.UserId equals us.Id
                             select new RentalDetailDto
                             {
                                 CustomerFirstName=us.FirstName,
                                 CustomerLastName=us.LastName,
                                 CarBrandName=br.BrandName,
                                 RentDate=re.RentDate,
                                 ReturnDate=re.ReturnDate,
                                 CompanyName=cu.CompanyName
                             };
                return result.ToList();
            }
        }
        public bool CheckCarRented(int id)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Rental>().Any(c => c.CarId == id && c.ReturnDate == null);
            }
        }

        public bool HaveCar(int id)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Car>().Any(c => c.CarId == id);
            }
        }
    }
}
