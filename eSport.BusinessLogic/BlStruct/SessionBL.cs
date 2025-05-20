using eSport.BusinessLogic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSport.BusinessLogic.Interfaces;
using eSport.Domain.Entities.User;
using eSport.Domain.Model.User;
using System.Data.Entity;
using System.Web;
using eSport.BusinessLogic.DBModel;
using eSport.Domain.Entities;


namespace eSport.BusinessLogic.BlStruct
{
    public class SessionBL : UserAPI, ISession
    {
        public void UserRegister(UDbTable data)
        {
            UserRegisterAction(data);
        }

    }

}
