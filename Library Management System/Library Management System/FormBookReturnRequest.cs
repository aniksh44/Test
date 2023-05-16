using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Entity;

namespace Library_Management_System
{
    public partial class FormBookReturnRequest : Form
    {
        
        BorrowInfo Borrow { set; get; }
        BorrowInfoRepository borrowRepository { set; get; }
        private dynamic LibrarianDashBoard { set; get; }
        public FormBookReturnRequest(dynamic LibrarianDashBoard) 
        {
            InitializeComponent();
            this.LibrarianDashBoard = LibrarianDashBoard;
            borrowRepository = new BorrowInfoRepository();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LibrarianDashBoard.Visible = true;

        }

        private void btnReturnReqBookId_Click(object sender, EventArgs e)
        {
            GetNames();
            



        }
        private void GetNames()
        {
            Borrow = borrowRepository.GetBorrowInfo(this.txtBorrowkId.Text);
            if (Borrow == null)
            {
                MessageBox.Show("Enter Valid Id");
                return;
            }
            string sql = @"select Name  from UserInfo
                          where UserId='" + this.Borrow.UserId + "';";
            this.textMemberName.Text = borrowRepository.Get(sql);

            sql = @"select Name  from BookInfo
                          where BookId='" + this.Borrow.BookId + "';";
            this.TxtReturnBookName.Text = borrowRepository.Get(sql);
            this.dtpBorrowDate.Text = Borrow.BorrowDate;
        }
        private void ClearScreen()
        {
            this.txtBorrowkId.Text = "";
            this.textMemberName.Text = "";
            this.TxtReturnBookName.Text = "";
            this.TxtReturnBookName.Text = "";
            this.dtpBorrowDate.Text = "";
        }

        private void BtnReturnReqReturn_Click(object sender, EventArgs e)
        {
            int check = borrowRepository.DeleteBorrowInfo(this.txtBorrowkId.Text);
            if (check == 1)
            {
                string sql = @"select Quantity  from BookInfo
                          where BookId='" + this.Borrow.BookId + "';";
                int newQuantity= Int32.Parse(borrowRepository.Get(sql));
                newQuantity++;
                borrowRepository.UpdateQuantity(Borrow.BookId, newQuantity.ToString());


                ClearScreen();
                MessageBox.Show("Success");
                return;

            }
            MessageBox.Show("Something went Wrong");
            ClearScreen();
        }
    }
    
}
