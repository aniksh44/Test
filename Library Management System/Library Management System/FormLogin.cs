using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Framework;

namespace Library_Management_System
{
    public partial class FormLogin : Form
    {
        private UserInfoRepository UserRepository { set; get; }
        public FormLogin()
        {
            InitializeComponent();
            this.UserRepository= new UserInfoRepository();
        }
        private void ClearScreen()
        {
            txtUserId.Text = "";
            txtUserPass.Text = "";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Validation.IsStringValid(txtUserId.Text, txtUserPass.Text))
            {
                MessageBox.Show("Enter userName and Password ...");
                ClearScreen();
                return;
            }
            var userInfo = UserRepository.Login(txtUserId.Text, txtUserPass.Text);

            try
            {
                if (userInfo.Role.Trim().ToLower() ==("admin").ToLower())
                {
                    FormAdminDashBoard adminDashBoard = new FormAdminDashBoard(this);
                    adminDashBoard.Visible = true;
                    this.Visible = false;
                }
                else if (userInfo.Role.Trim().ToLower()== ("Librarian").ToLower())

                {
                    FormLibrarianDashboard librarianDashboard = new FormLibrarianDashboard(this);
                    librarianDashboard.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Login Error...");
                }
                ClearScreen();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Login Error...");
                ClearScreen();
            }

           

        }
    }
}
