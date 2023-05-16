using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class FormLibrarianDashboard : Form
    {
        private FormLogin Logout { set; get; }
        public FormLibrarianDashboard(FormLogin logout)
        {
            InitializeComponent();
            this.Logout = logout;
        }

        private void btnLibrarianSearchbooks_Click(object sender, EventArgs e)
        { 
            FormSearchBook searchBooks= new FormSearchBook(this);
            this.Visible = false;
            searchBooks.Visible = true;
        }

        private void BtnLibrarianAddMember_Click(object sender, EventArgs e)
        {
            FormAddMember addMember = new FormAddMember(this);
            this.Visible = false;
            addMember.Visible = true;
        }

        private void BtnLibrarianRemoveMember_Click(object sender, EventArgs e)
        {
            FormRemoveMember removeMember = new FormRemoveMember(this);
            this.Visible = false;
            removeMember.Visible = true;
        }

        private void BtnMangerBooks_Click(object sender, EventArgs e)
        {
            FormLibrarianManageBooks manageBooks = new FormLibrarianManageBooks(this);
            this.Visible = false;
            manageBooks.Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LogOut Successfull");
            this.Visible = false;
            Logout.Visible = true;
           
        }
    }
}
