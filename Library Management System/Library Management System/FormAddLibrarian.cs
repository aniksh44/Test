using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibraryManagementSystem.Entity;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Framework;
namespace Library_Management_System
{
    public partial class FormAddLibrarian : Form
    {
        private FormAdminDashBoard AdminDashBoard { set; get; }
        private UserInfo User { set; get; }
        public FormAddLibrarian()
        {
            InitializeComponent();
            
        }
        public FormAddLibrarian(FormAdminDashBoard adminDashBoard) : this()
        {
            this.AdminDashBoard = adminDashBoard;
        }

       

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            AdminDashBoard.Visible = true;
            this.Visible = false;
        }
        private bool Validator()
        {
            if (Validation.IsStringValid(User.UserId, User.Password, User.Gender,
                User.Email, User.Role, User.Name))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Pleae Enter Valid information");
                return false;
            }
        }
        private void btnAddLibrarian_Click(object sender, EventArgs e)
        {
            CreateObject();
            //validation....
            if (Validator())
            {
                UserInfoRepository userRepository = new UserInfoRepository();
                bool success = userRepository.AddUser(User);
                if (success)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failed to add Member. ...");
                }
            }
        }
        private void CreateObject()
        {
            this.User = new UserInfo();
            User.UserId = txtUserId.Text;
            User.Password = txtPassword.Text;
            User.Name = txtName.Text;
            if (radioBtnMale.Checked)
            {
                User.Gender = "Male";
            }
            else if(radioBtnFemale.Checked)
            {
                User.Gender = "Female";
            }
            User.Email = txtEmail.Text;
            User.Role = "Librarian";
            
        }

        
    }
}
