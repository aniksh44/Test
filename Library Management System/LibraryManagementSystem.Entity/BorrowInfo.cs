using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem.Entity
{
    public class BorrowInfo
    {
        public string BorrowId { set; get; }
        public string BorrowDate { set; get; }
        public string BookId { set; get; }
        public string UserId { set; get; }
    }
}
