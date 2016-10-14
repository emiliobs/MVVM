using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.viewModel
{
    public class OrderViewModel
    {
        public String  Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime  DeliveryDate { get; set; }
        public String DeliveryInformation { get; set; }
        public string Client { get; set; }
    }
}
