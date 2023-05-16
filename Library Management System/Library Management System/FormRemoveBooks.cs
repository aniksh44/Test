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
    public partial class FormRemoveBooks : Form
    {
        private FormAdminDashBoard AdminDashBoard { set; get; }
        private BookInfoRepository BookRepository { set; get; }
        BookInfo[] book;
        public FormRemoveBooks()
        {
            InitializeComponent();
        }
        public FormRemoveBooks(FormAdminDashBoard adminDashBoard) : this()
        {
            this.AdminDashBoard = adminDashBoard;
            this.BookRepository = new BookInfoRepository();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            AdminDashBoard.Visible = true;
            this.Visible = false;
        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            try
            {
                book = BookRepository.SearchByBookId(this.txtSearchBooks.Text).ToArray();
                this.txtBookName.Text = book[0].BookId.Trim();
                this.txtQuantity.Text = book[0].Quantity.Trim();
                this.txtRemoveQuantity.Text = book[0].Quantity.Trim();
            }
            catch(Exception ex)
            {

            }


        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (this.txtRemoveQuantity.Text == book[0].Quantity.Trim()) ;
            {
                int check = this.BookRepository.RemoveBook(txtSearchBooks.Text);
                if (check == 1)
                {
                    MessageBox.Show("Success.");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
                this.txtBookName.Text = "";
                this.txtQuantity.Text = "";
                this.txtRemoveQuantity.Text = "";
            }
        }

        
    }
}
