using OnlineShopHomework16._7.Models;
using OnlineShopHomework16._7.Models.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopHomework16._7.Tools
{
    public class EventManager
    {
        public static Func<ClientModel> GetClients;
        public static ClientModel OnGetClients()
        {
            return GetClients?.Invoke();
        }

        public static Func<OrderModel> GetOrders;
        public static OrderModel OnGetOrders()
        {
            return GetOrders?.Invoke();
        }
    }
}
