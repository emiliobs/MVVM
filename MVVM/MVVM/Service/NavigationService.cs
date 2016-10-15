using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Pages;

namespace MVVM.Service
{
   public class NavigationService
    {
        public async void Navigate(string pageName)
        {
            App.Master.IsPresented = false;

            switch (pageName)
            {
                case "AlarmsPage":
                 await   App.Navigation.PushAsync(new AlarmsPage());
                    break;
                case "ClientsPage":
                  await  App.Navigation.PushAsync(new ClientsPage());
                    break;
                case "SettingsPage":
                 await   App.Navigation.PushAsync(new SettingsPage());
                    break;
                case "NewOrderPage":
                  await  App.Navigation.PushAsync(new NewOrderPage());
                    break;
                case "MainPage":
                 await   App.Navigation.PopToRootAsync();
                    break;
                default:
                    break;
            }
        }
    }
}
