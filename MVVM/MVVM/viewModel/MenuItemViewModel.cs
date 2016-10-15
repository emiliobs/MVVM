using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using MVVM.Pages;

namespace MVVM.viewModel
{
    public class MenuItemViewModel
    {
        public string Icon { get; set; }

        public string Title { get; set; }

        public String PageName { get; set; }

        public ICommand NavigateCommand
        {
            get
            {
                return new RelayCommand(Navigate);

            }
        }

        private void Navigate()
        {
            App.Master.IsPresented = false;

            switch (PageName)
            {
                case "AlarmsPage":
                    App.Navigation.PushAsync(new AlarmsPage());
                    break;
                case "ClientsPage":
                    App.Navigation.PushAsync(new ClientsPage());
                    break;
                case "SettingsPage":
                    App.Navigation.PushAsync(new SettingsPage());
                    break;
                case "MainPage":
                    App.Navigation.PopToRootAsync();
                    break;
                default:
                    break;
            }
        }
    }
}
