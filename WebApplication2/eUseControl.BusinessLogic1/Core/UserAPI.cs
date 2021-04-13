using eUseControl.BusinessLogic1.DBModel;
using eUseControl.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic1.Core
{
    class UserAPI
    {
        internal ULoginResp UserLoginAction(ULoginData data)
        {

            using (var db = new UserContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Username == data.Credential);
            }
            using (var db = new UserContext())
            {
                var user = (from u in db.Users where u.Username == data.Credential select u).FirstOrDefault();
            }

            return new ULoginResp { Status = true };
        }
    }
}
