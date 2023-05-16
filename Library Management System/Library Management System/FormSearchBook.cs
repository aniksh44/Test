using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Framework;

namespace Library_Management_System
{
    public partial class FormSearchBook : Form
    {
        private dynamic DashBoard { set; get; }
        private BookInfoRepository BookRepository { set; get; }

        public FormSearchBook()
        {
            InitializeComponent();
            this.BookRepository = new BookInfoRepository();
        }
        public FormSearchBook(dynamic dashBoard) : this()
        {
            this.DashBoard = dashBoard;
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DashBoard.Visible = true;
        }

        private bool MyValidator(string s1)
        {
            return Validation.IsStringValid(s1);
        }
        private void btnSearchByCategory_Click(object sender, EventArgs e)
        {
            if (!MyValidator(this.txtSearchByCategory.Text))
            {
                MessageBox.Show("Error ");
                return;
            }
            this.dgvSearchBook.AutoGenerateColumns = false;
            this.dgvSearchBook.DataSource = this.BookRepository.SearchByCategory(this.txtSearchByCategory.Text).ToList();
        }
        
        private void btnSearchByName_Click(object sender, EventArgs e)
        {

            if (!MyValidator(this.txtSearchByName.Text))
            {
                MessageBox.Show("Error ");
                return;
            }
            this.dgvSearchBook.AutoGenerateColumns = false;
            this.dgvSearchBook.DataSource = this.BookRepository.SearchByName(this.txtSearchByName.Text).ToList();
        }

       

        private void btnSearchByBookId_Click(object sender, EventArgs e)
        {
            if (!MyValidator(this.txtSearchByBookId.Text))
            {
                MessageBox.Show("Error ");
                return;
            }
            this.dgvSearchBook.AutoGenerateColumns = false;
            this.dgvSearchBook.DataSource = this.BookRepository.SearchByBookId(this.txtSearchByBookId.Text).ToList();
        }
    }
}
