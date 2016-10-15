using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using MVVM.Pages;
using MVVM.Service;
using Xamarin.Forms;

namespace MVVM.viewModel
{
    public class MenuItemViewModel
    {

        private NavigationService NavigationService { get; set; }
        public string Icon { get; set; }

        public string Title { get; set; }

        public String PageName { get; set; }


        public MenuItemViewModel()
        {
            NavigationService = new NavigationService();
        }

        public ICommand NavigateCommand
        {
            get
            {
                return new RelayCommand(Navigate);

            }
        }

        private void Navigate()
        {
            NavigationService.Navigate(PageName);
        }
    }
}
