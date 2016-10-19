using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace MVVM.Service
{
    public class ApiService
    {
        public async Task<List<Orders>> GetAllOrders()
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://zulu-software.com");
                var url = "/service/api/Orders";
                var response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    return new List<Orders>();
                }

                var result = await response.Content.ReadAsStringAsync();


                var orders = JsonConvert.DeserializeObject<List<Orders>>(result);
                return orders;


            }
            catch
            {
                return new List<Orders>();

            }
        }

        public async Task<Orders> CreateOrder(Orders order)
        {
            try
            {
                var content = JsonConvert.SerializeObject(order);
                var body = new StringContent(content, Encoding.UTF8, "application/json");
                var client = new HttpClient();
                client.BaseAddress= new Uri("http://zulu-software.com");
                var uri = "/service/api/Orders";
                var response = await client.PostAsync(uri, body);

                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }

                var result = await response.Content.ReadAsStringAsync();
                var newOrder = JsonConvert.DeserializeObject<Orders>(result);

                return newOrder;
            }
            catch
            {

                return null;
            }
        }

    }


}
