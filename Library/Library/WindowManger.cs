using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Library
{
    public sealed class WindowManger
    {
        private static WindowManger instance=null;
      
        public static WindowManger Instance
        {
            get {

            if(instance==null)
                { 
                    instance=new WindowManger();
                }
                return instance;
            }
                    }

        public void CreateWindowInSperateThread()
        {
            Window window = null;
           // Thread thread = new Thread(() =>
           //{
               window = new BookShelfWindow();
                window.Show();

           //});
           // thread.IsBackground= true;
           // thread.SetApartmentState(ApartmentState.STA);
           // thread.Start();
        }


    }
}
