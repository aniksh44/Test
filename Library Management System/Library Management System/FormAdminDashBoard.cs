using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class FormAdminDashBoard : Form
    {
        private FormLogin Logout { set; get; }
        public FormAdminDashBoard(FormLogin logout)
        {
            InitializeComponent() ;
            this.Logout = logout;
        }

        private void BtnAdminSearchBooks_Click(object sender, EventArgs e)
        {
            FormSearchBook searchBooks = new FormSearchBook(this);
            searchBooks.Visible = true;
            this.Visible = false;

        }

        private void BtnAdminAddBooks_Click(object sender, EventArgs e)
        {
            FormAddBooks addBooks= new FormAddBooks(this);
            addBooks.Visible = true;
            this.Visible = false;

        }

        private void BtnAdminRemoveBooks_Click(object sender, EventArgs e)
        {
            FormRemoveBooks removeBooks= new FormRemoveBooks(this);
            removeBooks.Visible = true;
            this.Visible = false;

        }

        private void BtnAdminAddLibrarian_Click(object sender, EventArgs e)
        {
            FormAddLibrarian addLibrarian = new FormAddLibrarian(this);
            addLibrarian.Visible = true;
            this.Visible = false;

        }

        private void BtnAdminRemoveLibrarian_Click(object sender, EventArgs e)
        {
            FormRemoveLibrarian removeLibrarian = new FormRemoveLibrarian(this);
            removeLibrarian.Visible = true;
            this.Visible = false;

        }

       

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LogOut Successfull");
            this.Visible = false;
            Logout.Visible = true;
        }
    }
}
