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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentACarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from cu in context.Customers
                             join us in context.Users
                             on cu.UserId equals us.Id
                             select new CustomerDetailDto
                             {
                                 FirstName=us.FirstName,
                                 LastName=us.LastName,
                                 CompanyName=cu.CompanyName
                             };
                return result.ToList();
            }
        }
    }
}
