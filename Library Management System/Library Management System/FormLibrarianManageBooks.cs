using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class FormLibrarianManageBooks : Form
    {
        private dynamic LibrarianDashBoard { set; get; }
        public FormLibrarianManageBooks()
        {
            InitializeComponent();
        }
        public FormLibrarianManageBooks(dynamic LibrarianDashBoard) : this()
        {
            this.LibrarianDashBoard = LibrarianDashBoard;
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        { 
            this.Visible = false;
            LibrarianDashBoard.Visible = true;
            
        }

        private void BtnManageBooksReturnRequest_Click(object sender, EventArgs e)
        {
            FormBookReturnRequest returnRequest = new FormBookReturnRequest(LibrarianDashBoard);
            this.Visible = false;
            returnRequest.Visible = true;
        }

        private void BtnManageBooksBorrowRequest_Click(object sender, EventArgs e)
        {
            FormBookBorrowRequest borrowRequest = new FormBookBorrowRequest(LibrarianDashBoard);
            this.Visible = false;
            borrowRequest.Visible = true;
        }
    }
}
