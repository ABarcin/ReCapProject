﻿using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICreditCardCheckService
    {
        bool CheckCreditCard(CreditCard creditCard);
    }
}
