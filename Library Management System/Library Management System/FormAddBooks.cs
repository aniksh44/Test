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
    public partial class FormAddBooks : Form
    {
        private BookInfo Book { set; get; }
        private FormAdminDashBoard AdminDashBoard { set; get; }
        public FormAddBooks()
        {
            InitializeComponent();
        }
        public FormAddBooks(FormAdminDashBoard adminDashBoard) : this()
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
            if(Validation.IsStringValid(Book.BookId, Book.Name, Book.Author,
                Book.Category, Book.Publisher) && Validation.isIntValid(Book.Quantity))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Pleae Enter Valid information");
                return false;
            }
        }
       

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            
            CreateObject();
            if (Validator())
            {
                BookInfoRepository bookRepository = new BookInfoRepository();
                bool success = bookRepository.AddBook(Book);
                if (success)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failed to add Book ...");
                }
            }
            

        }
        private void CreateObject()
        {
            Book = new BookInfo();
            Book.BookId = txtBookId.Text ;
            Book.Name = txtBookName.Text;
            Book.Author = txtBookAuthor.Text;
            Book.Category = txtCategory.Text;
            Book.Publisher = txtPublisher.Text;
            Book.Quantity = txtQuantity.Text;
        }
    }
}
