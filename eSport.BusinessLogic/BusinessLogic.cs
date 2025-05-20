using System;
using eSport.BusinessLogic.BlStruct;
using eSport.BusinessLogic.Interfaces;

namespace eSport.BusinessLogic
{//implimentarea la metoda
    public class BusinessLogic
    {
        public ISession GetAuthBl()
        {
            return new LoginBl();
        }

    }
}