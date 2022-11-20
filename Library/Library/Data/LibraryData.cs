using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Library.Data
{
    internal class LibraryData
    {
        ObservableCollection<BookData> libraryCollection= new ObservableCollection<BookData>();
        

        public void AddLibraryCollection(BookData bookData)
        {
            libraryCollection.Add(bookData);
            MessageBox.Show("Book Added");
        }
    }
}
