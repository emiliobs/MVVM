using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public String DeliveryInformation { get; set; }
        public string Client { get; set; }

        public string Phone { get; set; }
        public bool IsDelivered { get; set; }
    }
}
