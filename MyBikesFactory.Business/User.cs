using MyBikesFactory.Business.Delegates;
using MyBikesFactory.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Business
{
    public class User : IValidatable
    {
        private string _username;
        private string _password;
        private string _invalidMessage;

        public event Notify? GotInvalidNotification;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string InvalidMessage { get => _invalidMessage; set => _invalidMessage = value; }

        public User(string initialUsername, string initialPassword)
        {
            _username = initialUsername;
            _password = initialPassword;
        }

        public bool IsValid()
        {
            if(_username == "")
            {
                TriggerGotInvalid("Username required");
                return false;
            }
            else if (_password == "")
            {
                TriggerGotInvalid("Password required");
                return false;
            }
            return true;
        }

        private void TriggerGotInvalid(string message)
        {
            if (GotInvalidNotification == null)
                throw new Exception("Make sure an event handler is " +
                                    "assigned to GotINvalidNotification " +
                                    "before calling the IsValid method");
            _invalidMessage = message;
            GotInvalidNotification(message);
        }
    }
}

