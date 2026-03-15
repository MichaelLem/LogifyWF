using Logify;
using LogifyWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Logify
{
    public class Authenticate
    {
        private UserProfiles user = new UserProfiles();

        public Authenticate()
        {
        }

        private int UserNameLength = 4;
        private int PasswordLength = 4;

        public string ErrorMessage = string.Empty;

        ErrorMessages errorMessages = new ErrorMessages();

        public bool isValidUserName(string userName)
        {
            string userNameStored = user.UserName;

            if ((userName == "") || (userName.Length < UserNameLength))
            {
                ErrorMessage = errorMessages.UserNameLength;
                return false;
            }
            else if (userName != userNameStored)
            {
                ErrorMessage = errorMessages.UserNameInvalid;
                return false;
            }
            else
            {
                ErrorMessage = string.Empty;
                return true;
            }
        }

        public bool isValidPassword(string password)
        {
            string passwordStored = user.Password;

            if ((password == "") || (password.Length < PasswordLength))
            {
                ErrorMessage = errorMessages.PasswordLength;
                return false;
            }
            else if (password != passwordStored)
            {
                ErrorMessage = errorMessages.PasswordInvalid;
                return false;
            }
            else
            {
                ErrorMessage = string.Empty;
                return true;
            }
        }

        public string GetFullName()
        {
            string fullName = string.Empty;
            fullName = user.FirstName + " " + user.LastName;
            return fullName;
        }
    }
}