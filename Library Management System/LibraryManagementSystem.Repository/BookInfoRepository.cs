using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entity;
using LibraryManagementSystem.Framework;

namespace LibraryManagementSystem.Repository
{
    public class BookInfoRepository
    {

        public bool AddBook(BookInfo book)
        {
            try
            {
                string sql = @"INSERT INTO BookInfo
                        VALUES('" + book.BookId + "', '" + book.Name + "', '" + book.Author + "', '" + book.Category + "', '" + book.Publisher + "', '" + book.Quantity + "');  ";

                int check = DataAccess.ExecuteDmlQuery(sql);
                if (check == 1)
                {
                    return true;
                }
                else
                {
                   
                    return false;

                }
            }
            catch (Exception ex)
            {

                return false;
            }

        }

        public int RemoveBook(string s1)
        {
            string sql;
            sql = "DELETE FROM BookInfo WHERE BookId = '"+s1+"';";
            return DataAccess.ExecuteDmlQuery(sql) ;
        }
        public List<BookInfo> SearchByCategory(string s1)
        {
             string sql;
             sql = "select *  from BookInfo where Category= '" + s1 + "'; ";
            return SearchBook(sql);
        }
        public List<BookInfo> SearchByBookId(string s1)
        {
            string sql;
            sql = "select *  from BookInfo where BookId= '" + s1 + "'; ";
            return SearchBook(sql);
        }
        public List<BookInfo> SearchByName(string s1)
        {
            string sql;
            sql = "select *  from BookInfo where Name= '" + s1 + "'; ";
            return SearchBook(sql);
        }
        private List<BookInfo> SearchBook(string sql)
        {
            try
            {
                List<BookInfo> bookList = new List<BookInfo>();
                var dataTable = DataAccess.ExecuteQueryTable(sql);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    BookInfo book = ConvertTOEntity(dataTable.Rows[i]);
                    bookList.Add(book);

                }

                return bookList;


            }
            catch
            {

                return null;
            }
        }
        private BookInfo ConvertTOEntity(DataRow row)
        {
            if(row==null)
            { 
                return null;
            }
            else
            {
                var book = new BookInfo();
                book.BookId = row[0].ToString();
                book.Name = row[1].ToString();
                book.Author = row[2].ToString();
                book.Category = row[3].ToString();
                book.Publisher = row[4].ToString();
                book.Quantity = row[5].ToString();
                return book;
                
            }
        }
        
    }
}

