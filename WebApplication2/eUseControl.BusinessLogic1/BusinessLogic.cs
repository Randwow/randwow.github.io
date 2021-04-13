using eUseControl.BusinessLogic1;
using eUseControl.BusinessLogic1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic
{
   
    public class BusinessLogic

    {

        public ISession GetSessionBL()

        {

            return new SessionBL();

        }

    }

}
