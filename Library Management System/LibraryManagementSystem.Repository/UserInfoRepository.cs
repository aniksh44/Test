using System;
using System.Collections.Generic;
using System.Data;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entity;

namespace LibraryManagementSystem.Repository
{
    public class UserInfoRepository
    {
        
        private UserInfo User { set; get; }
        public UserInfoRepository()
        {
            this.User = new UserInfo();

        }
        public UserInfo Login(string id, string password)
        {
            string sql;
            try
            {
               
                sql = " select * from UserInfo where UserId = '" + id + "' and Password = '" + password + "';";
                var userInfo = DataAccess.ExecuteQueryTable(sql);
                if (userInfo == null)
                {
                    return null;
                }
                ConvertToEntity(userInfo.Rows[0]);
                return User;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }
        
        private void ConvertToEntity(DataRow dr)
        {
            User.UserId = dr[0].ToString();
            User.Password = dr[1].ToString();
            User.Name = dr[2].ToString();
            User.Gender = dr[3].ToString();
            User.Email = dr[4].ToString();
            User.Role = dr[5].ToString();
            


        }
        public bool AddUser(UserInfo user)
        {
            try
            {
                string sql = @"INSERT INTO UserInfo
                        VALUES('" + user.UserId + "', '" + user.Password + "', '" + user.Name + "', '" + user.Gender + "', '" + user.Email + "', '" + user.Role + "'); ";
               
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
        public int RemoveUser(string s1)
        {
            string sql;
            sql = "DELETE FROM UserInfo WHERE UserId = '" + s1 + "';";
            return DataAccess.ExecuteDmlQuery(sql);
        }
        public List<UserInfo> SearchByUserId(string s1)
        {
            string sql;
            sql = "select *  from UserInfo where UserId= '" + s1 + "'; ";
            return SearchUser(sql);
        }
        public string FindUserName(string s1)
        {
            string sql;
            sql = @"select Name 
                      from UserInfo where UserId='" + s1 + "';";
            var userTable=DataAccess.ExecuteQueryTable(sql);
            var userRow = userTable.Rows[0][0].ToString();
            //var userName = userRow[0].ToString();
            return userRow;
        }
        private List<UserInfo> SearchUser(string sql)
        {
            try
            {
                List<UserInfo> userList = new List<UserInfo>();
                var dataTable = DataAccess.ExecuteQueryTable(sql);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    ConvertToEntity(dataTable.Rows[i]);
                    userList.Add(User);

                }

                return userList;


            }
            catch
            {

                return null;
            }
        }
        


    }
}
