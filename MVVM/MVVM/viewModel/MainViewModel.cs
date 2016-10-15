using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using MVVM.Pages;

namespace MVVM.viewModel
{
    public class MainViewModel
    {

        #region Properties
        public ObservableCollection<OrderViewModel> Orders { get; set; }
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();

            LoadMenu();
            LoadFakeData();
        }
        #endregion

        #region Methods
        private void LoadFakeData()
        {
            Orders = new ObservableCollection<OrderViewModel>();

            for (int i = 0; i < 10; i++)
            {
                Orders.Add(new OrderViewModel
                {
                    Title = "Emilio Barrera",
                    DeliveryDate = DateTime.Today,
                    Description = "Hola emilio barrera sepulveda el hijo del pueblo de los mierdas del mundo...."

                });
            }
        }

        private void LoadMenu()
        {
            Menu.Add(new MenuItemViewModel
            {

                Icon = "ic_action_action_orders.png",
                PageName = "MainPage",
                Title = "Pedidos"
            });

            Menu.Add(new MenuItemViewModel
            {

                Icon = "ic_action_customer.png",
                PageName = "ClientsPage",
                Title = "Clientes"
            });

            Menu.Add(new MenuItemViewModel
            {

                Icon = "ic_action_alarm.png",
                PageName = "AlarmsPage",
                Title = "Alarms"
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_settings.png",
                PageName = "SettingsPage",
                Title = "AJustes"

            });
        }
        #endregion

        #region Commands
        public ICommand GoToCommand
        {
            get
            {
                return new RelayCommand<string>(GoTo);
            }
        }

        private void GoTo(string pageName)
        {
            switch (pageName)
            {
                case "NewOrderPage":
                    App.Navigation.PushAsync(new NewOrderPage());
                    break;

                default:
                    break;
            }
        }

        #endregion

    }
}
