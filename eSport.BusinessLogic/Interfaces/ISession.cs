using System;
using System.Collections.Generic;
using System.Text;
using eSport.Domain.Entities.User;
using eSport.Domain.Model.User;

namespace eSport.BusinessLogic.Interfaces
{//declaram metoda
    public interface ISession
    {
        void UserRegister(UDbTable data);
    }
}


