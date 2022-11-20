using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    internal class BookData
    {
        private string bookName{get;}
        private string authorName { get;}

        public BookData(string bookName,string authorName)
        {
            this.bookName = bookName;
            this.authorName = authorName;   
        }


    }
}
