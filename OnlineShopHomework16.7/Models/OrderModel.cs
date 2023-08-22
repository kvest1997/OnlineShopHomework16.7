using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace OnlineShopHomework16._7.Models
{
    public class OrderModel
    {
        public string Id { get; } = Guid.NewGuid().ToString();
        public ObservableCollection<ProductModel> ProductList { get; }

        public OrderModel(ObservableCollection<ProductModel> productList)
        {
            this.Id = Guid.NewGuid().ToString();
            ProductList = productList;

        }
    }
}
