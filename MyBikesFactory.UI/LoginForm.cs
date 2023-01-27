using MyBikesFactory.Business;
using MyBikesFactory.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBikesFactory.UI
{
    public partial class LoginForm : Form
    {
        private List<User> listOfUsers = UserSequentialData.Load();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var myUser = new User(txtUsername.Text, txtPassword.Text);

            myUser.GotInvalidNotification += MyUser_GotInvalidNotification;
            
            //if (!myUser.IsValid())
            if(!Validator.CheckValidity(myUser))
                return;

            bool existingUser = false;

            foreach (var user in listOfUsers)
            {
                if (user.Username == txtUsername.Text && user.Password == txtPassword.Text)
                {
                    existingUser = true;
                    break;
                }
            }

            if (existingUser)
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                var frmMainForm = new MainForm(this);//passing a reference of the login form/itself
                frmMainForm.Show();//displays the mainform
                this.Hide();//this hides the login form
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

        }

        private void MyUser_GotInvalidNotification(string message)
        {
            MessageBox.Show(message);
        }
    }
}
