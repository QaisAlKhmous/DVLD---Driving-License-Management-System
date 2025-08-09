using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_businessLogic
{
    public class clsGlobalSettings
    {

        public static clsUser _LogedInUser;

        public static void SetCurrentUser(string UserName)
        {
            _LogedInUser=clsUser.Find(UserName);
        }




    }
}
