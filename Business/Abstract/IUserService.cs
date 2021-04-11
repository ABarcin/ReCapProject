using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{

    public interface IUserService 
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        IDataResult<User> GetByMail(string email);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);
    }
}
