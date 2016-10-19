using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using MVVM.Models;
using MVVM.Service;

namespace MVVM.viewModel
{



    public class OrderViewModel
    {
        #region Attributes

        private ApiService apiService;
        private DialogService dialogService;

        #endregion

        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public String DeliveryInformation { get; set; }
        public string Client { get; set; }

        public string Phone { get; set; }
        public bool IsDelivered { get; set; }
        #endregion

        #region Commands

        #region Constructor

        public OrderViewModel()
        {
            this.apiService = new ApiService();
            this.dialogService = new DialogService();
            this.DeliveryDate = DateTime.Today;
        }
        #endregion

        public ICommand SaveCommand
        {
            get
            {

                return  new RelayCommand(Save);
            }
        }

        private async void Save()
        {
            if (string.IsNullOrEmpty(Title))
            {
                await dialogService.ShowMesssage("Error", "Debes Ingresar un Titulo.");
            }

            var order = new Orders
            {

                Id = Id,
                Client = Client,
                CreationDate = DateTime.Today,
                DeliveryDate = DeliveryDate,
                DeliveryInformation = DeliveryInformation,
                Description =  Description,
                IsDelivered = false,
                Phone = Phone,
                Title = Title
            };

            await apiService.CreateOrder(order);
            await dialogService.ShowMesssage("Información","El servicio ha sido Creado.");
        }

        #endregion
    }
}
