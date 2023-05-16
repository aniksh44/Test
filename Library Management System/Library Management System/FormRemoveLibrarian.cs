using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Entity;


namespace Library_Management_System
{
    public partial class FormRemoveLibrarian : Form
    {
        private FormAdminDashBoard AdminDashBoard { set; get; }
        UserInfo[] user;
        private UserInfoRepository UserRepositary { set; get; }
        public FormRemoveLibrarian()
        {
            InitializeComponent();
            this.UserRepositary = new UserInfoRepository();
        }
        public FormRemoveLibrarian(FormAdminDashBoard adminDashBoard) : this()
        {
            this.AdminDashBoard = adminDashBoard;
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminDashBoard.Visible = true;
        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {

            try
            {
                user = UserRepositary.SearchByUserId(this.txtSearchById.Text).ToArray();
                if (user[0].Role.Trim() == "Librarian")
                {
                    this.txtName.Text = user[0].Name.Trim();
                    this.txtEmail.Text = user[0].Email.Trim();
                    this.txtGender.Text = user[0].Gender.Trim();
                    this.txtPassword.Text = user[0].Password.Trim();
                }
                else
                {
                    user[0] = null;
                    Clear();
                    MessageBox.Show("Enter Valid Id");
                }


            }
            catch (Exception ex)
            {
                Clear();
                MessageBox.Show("Enter Valid Id");
            }
        }
        private void Clear()
        {
            this.txtPassword.Text = "";
            this.txtName.Text = "";
            this.txtEmail.Text = "";
            this.txtGender.Text = "";
        }

        private void btnRemoveLibrarian_Click(object sender, EventArgs e)
        {
            if (user[0] == null)
            {
                MessageBox.Show("Failed");
                return;
            }
            else
            {
                int check = this.UserRepositary.RemoveUser(user[0].UserId);
                if (check == 1)
                {
                    MessageBox.Show("Success.");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
                Clear();
            }
        }
    }
}
