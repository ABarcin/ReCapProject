using Business.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Adapters
{
    public class CreditCardServiceAdapter : ICreditCardCheckService
    {
        public bool CheckCreditCard(CreditCard creditCard)
        {
            //simulasyon için aşağıdaki kodlar kullanıldı
            if (creditCard.FirstName == "Ahmet" && creditCard.LastName == "Barçın" && creditCard.CreditCardNumber == "1111111111111111" && creditCard.Year == "21"&&creditCard.Month=="09"&&creditCard.CVC=="111")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
