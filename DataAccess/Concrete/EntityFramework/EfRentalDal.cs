using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entitites.Concrete;
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
