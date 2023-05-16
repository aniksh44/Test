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
    
    public partial class FormAddMember : Form
    {
        private UserInfo User { set; get; }
        private dynamic LibrarianDashBoard { set; get; }
        public FormAddMember()
        {
            InitializeComponent();
        }
        public FormAddMember(dynamic LibrarianDashBoard) : this()
        {
            this.LibrarianDashBoard = LibrarianDashBoard;
        }
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LibrarianDashBoard.Visible = true;
        }
        private bool MyValidator()
        {
            if (Validation.IsStringValid(User.UserId, User.Gender,
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
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            CreateObject();
            //validation....
            if (MyValidator())
            {
                UserInfoRepository userRepository = new UserInfoRepository();
                bool success = userRepository.AddUser(User);
                if (success)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failed to add librarian. ...");
                }
            }
           
        }
        private void CreateObject()
        {
            this.User = new UserInfo();
            User.UserId = txtUserId.Text;
            User.Name = txtName.Text;
            if (radioBtnMale.Checked)
            {
                User.Gender = "Male";
            }
            else if (radioBtnFemale.Checked)
            {
                User.Gender = "Female";
            }
            User.Email = txtEmail.Text;
            User.Role = "Member";
        }

       
    }
       
    
}
