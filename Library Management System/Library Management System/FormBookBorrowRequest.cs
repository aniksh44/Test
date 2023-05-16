using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Entity;
using LibraryManagementSystem.Framework;

namespace Library_Management_System
{

    public partial class FormBookBorrowRequest : Form
    {
        BorrowInfoRepository borrowRepository { set; get; }
        BorrowInfo Borrow { set; get; }
        UserInfoRepository UserRepositor;
        UserInfo[] user;
        BookInfoRepository BookRepository;
        BookInfo[] book;
        private dynamic LibrarianDashBoard { set; get; }
        public FormBookBorrowRequest(dynamic LibrarianDashBoard)
        {
            InitializeComponent();
            this.LibrarianDashBoard = LibrarianDashBoard;
            UserRepositor = new UserInfoRepository();
            BookRepository = new BookInfoRepository();
            borrowRepository = new BorrowInfoRepository();
            Borrow = new BorrowInfo();
            
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LibrarianDashBoard.Visible = true;
        }
        
        private bool GetUser(string s1)
        {
            try
            {
                 user = UserRepositor.SearchByUserId(s1).ToArray();
                if (user[0].Role.Trim() == "Member")
                {
                    this.TxtReturnBookAuthor.Text = user[0].Name;
                    return true;
                }
                else
                {
                    MessageBox.Show("Enter valid MemberID");
                    user[0] = null;
                    ClearScreen();
                    return false;
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter valid MemberID");
                ClearScreen();
                return false;
            }

        }
        private void GetBook(string s1)
        {
            try
            {
                book = BookRepository.SearchByBookId(s1).ToArray();
                if (book[0].Quantity.Trim() == "0")
                {
                    MessageBox.Show("This Book not Available Right Now");
                    book[0] = null;
                    ClearScreen();
                }
                else
                {
                    this.TxtReturnBookName.Text = book[0].Name;
                    this.TxtReturnBookAuthor.Text = book[0].Author;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Enter Vlid BookID");
                ClearScreen();
            }
           
            
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            borrowRepository = new BorrowInfoRepository();

            bool check=this.GetUser(this.textUserID.Text);
            if (check)
            {
                this.GetBook(this.txtBookId.Text);
            }
            


        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {

            if (Validation.IsStringValid(this.TxtBookBorrowId.Text))
            {
                
                Borrow.BorrowId = this.TxtBookBorrowId.Text;
                Borrow.BorrowDate = this.dtpBorrowedDate.Text;
                Borrow.BookId = this.txtBookId.Text;
                Borrow.UserId = this.textUserID.Text;
                int check = borrowRepository.AddBorrwInfo(Borrow);
                if (check == 1)
                {
                    MessageBox.Show("Success ");
                    int newQuantity = Int32.Parse(book[0].Quantity.Trim());
                    newQuantity--;
                    borrowRepository.UpdateQuantity(book[0].BookId, newQuantity.ToString());
                    book[0] = null;
                    ClearScreen();

                }
                else
                {
                    MessageBox.Show("Something went Worng . Try provide Valid Info");
                    ClearScreen();
                }
            }
            else
            {
                MessageBox.Show("Please Enter  MemberID And BookID first ");
                ClearScreen();
            }
            
        }
        private void ClearScreen()
        {
            this.txtBookId.Text = "";
            this.textUserID.Text = "";
            this.dtpBorrowedDate.Text = "";
            this.TxtReturnBookAuthor.Text = "";
            this.TxtReturnBookName.Text = "";
            this.TxtBookBorrowId.Text = "";
        }

      
    }
}
