using COVID19Game.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID19Game.Driver
{
    public class Pages
    {
        public static HomePage Homepage
        {
            get { return new HomePage(); }
        }

        public static SignUp Signup
        {
            get { return new SignUp(); }
        }

        public static LoginPage Loginpage
        {
            get { return new LoginPage(); }
        }

        public static LoginedPage Loginedpage
        {
            get { return new LoginedPage(); }
        }
    }
}
