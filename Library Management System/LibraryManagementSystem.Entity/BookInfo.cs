using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem.Entity
{
    public class BookInfo
    {
        public string BookId { set; get; }
        public string Name { set; get; }
        public string Author { set; get; }
        public string Category { set; get; }
        public string Publisher { set; get; }
        public string Quantity { set; get; }
    }
}
