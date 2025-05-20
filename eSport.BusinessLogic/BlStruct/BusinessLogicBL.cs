using eSport.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSport.BusinessLogic.BlStruct
{
    public class BusinessLogicBL
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();

        }
    }
}

