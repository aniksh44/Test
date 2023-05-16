using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entity;

namespace LibraryManagementSystem.Repository
{
    public class BorrowInfoRepository
    {  
        BorrowInfo Borrow { set; get; }

       
        public BorrowInfoRepository()
        {
            Borrow = new BorrowInfo();
        }

        public int AddBorrwInfo(BorrowInfo borrow)
        {
            int check=0;
            try
            {
                string sql = @"INSERT INTO BorrowInfo 
                                  VALUES('"+borrow.BorrowId+"', '"+borrow.BorrowDate+"', '"+borrow.BookId+"', '"+borrow.UserId+"'); ";
                check = DataAccess.ExecuteDmlQuery(sql);
                return check;
            }
            catch (Exception ex)
            {
                return check;
            }

        }
        public void UpdateQuantity(string bookId,string newQuantity)
        {
            try
            {
                string sql = @"UPDATE BookInfo SET Quantity = '"+newQuantity+"'WHERE BookId = '"+bookId+"';";
                DataAccess.ExecuteDmlQuery(sql);
            }
            catch(Exception ex)
            {

            }
        }
        public BorrowInfo GetBorrowInfo(string s1)
        {
            string sql = @"select * from BorrowInfo
                          where BorrowId = '"+s1+"';";
            try
            {
                var dataTable = DataAccess.ExecuteQueryTable(sql);
                List<BorrowInfo> borrowList = new List<BorrowInfo>();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    ConvertToEntity(dataTable.Rows[i]);
                    borrowList.Add(Borrow);

                }

                return borrowList[0];
            }
            catch(Exception ex)
            {
                return null;
            }

        }
        private void ConvertToEntity(DataRow dr)
        {
            Borrow.BorrowId = dr[0].ToString();
            Borrow.BorrowDate = dr[1].ToString();
            Borrow.BookId = dr[2].ToString();
            Borrow.UserId = dr[3].ToString();
        }
        public string Get(string sql)
        {
            try
            {
               var v= DataAccess.ExecuteQueryTable(sql);
               string Name = v.Rows[0][0].ToString();
                return Name;
            }
            catch
            {
                return null;
            }
        }
        public int DeleteBorrowInfo(string s1)
        {
            string sql = "DELETE FROM BorrowInfo WHERE BorrowId = '" + s1 + "';";
            return DataAccess.ExecuteDmlQuery(sql);
        }


    }
}
