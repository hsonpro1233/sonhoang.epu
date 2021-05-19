using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class FormProvider
    {
        public static LoginForm MainMenu
        {
            get
            {
                if (_mainMenu == null)
                {
                    _mainMenu = new LoginForm();
                }
                return _mainMenu;
            }
        }
        private static LoginForm _mainMenu;
    }
}
