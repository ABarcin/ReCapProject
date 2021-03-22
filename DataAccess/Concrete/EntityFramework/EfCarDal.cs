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
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {

                var result = from ca in context.Cars
                             join co in context.Colors
                             on ca.ColorId equals co.ColorId
                             join b in context.Brands
                             on ca.BrandId equals b.BrandId
                             join image in context.CarImages
                             select new CarDetailDto
                             {
                                 CarName = ca.CarName,
                                 CarId = ca.CarId,
                                 BrandName = b.BrandName,
                                 BrandId = ca.BrandId,
                                 ColorName = co.ColorName,
                                 ColorId = ca.ColorId,
                                 DailyPrice = ca.DailyPrice,
                                 ModelYear = ca.ModelYear,
                                 Description = ca.Description,
                             };
                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
            }
        }
    }
}
