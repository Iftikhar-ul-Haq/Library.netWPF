
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Library.ViewModels
{
	public class MainViewModel : ViewModelsBase
	{
		public MainViewModel() {
            ViewBookCommand = new RelayCommand(showBooks);
            AddBookCommand = new RelayCommand(showMessage);
			
			
		}

		private string? bookName;
		public string BookName
		{
			get
			{
				return bookName;

			}
			set
			{
				bookName = value;
				OnPropertyChanged(nameof(BookName));
			}
		}

		private string authorName;
		public string AuthorName
		{
			get
			{
				return authorName;
			}
			set
			{
				authorName = value;
				OnPropertyChanged(nameof(AuthorName));
			}
		}


		public ICommand AddBookCommand { get; }
		public ICommand ViewBookCommand { get; }	
		

		public void showMessage()
		{
			MessageBox.Show("Book name is "+bookName+" and Autor is "+authorName);
		}
        public void showBooks()
        {
			WindowManger.Instance.CreateWindowInSperateThread();
        }
    }



}
