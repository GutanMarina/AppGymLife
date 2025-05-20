using System;
using System.Collections.Generic;
using System.Text;
using eSport.BusinessLogic.Core;
using eSport.BusinessLogic.Interfaces;
using eSport.Domain.Entities.User;
using eSport.Domain.Model.User;

namespace eSport.BusinessLogic.BlStruct
{//legatura businesslog cu metoda, declararea metodei, implementare din interfata cu parametru in useriapi
    public class LoginBl : UserAPI, ISession
    {

        public string UserAuthLogic(UserLoginDTO data)
        {
            return UserAuthLogicAction(data);
        }


        public void UserRegister(UDbTable data)
        {
            throw new NotImplementedException();
        }
    }
}
