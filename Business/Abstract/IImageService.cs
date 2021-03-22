using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IImageService<T>
    {
        IResult Add(IFormFile file, T entity);
        IResult Delete(T entity);
        IResult Update(IFormFile file, T entity);
        IDataResult<T> GetById(int id);
        IDataResult<List<T>> GetByCarId(int carId);
        IDataResult<List<T>> GetAll();
    }
}
