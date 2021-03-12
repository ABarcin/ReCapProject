using Core.Utilities.Results.Abstract;
using Entitites.Concrete;
using Entitites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService:IServiceBase<Rental>
    {
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
    }
}
