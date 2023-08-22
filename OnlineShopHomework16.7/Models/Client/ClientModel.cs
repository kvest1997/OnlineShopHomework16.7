using OnlineShopHomework16._7.Models.Base;
using OnlineShopHomework16._7.Models.Person;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Media;

namespace OnlineShopHomework16._7.Models.Client
{
    public class ClientModel : PersonModel
    {
        public string Id { get; } = Guid.NewGuid().ToString();
        public NumberPhoneModel NumberPhone { get; set; }
        public ObservableCollection<OrderModel> OrderList { get; set; }

        private Brush bgColor;
        public Brush BgColor
        {
            get { return bgColor; }
            set
            {
                if (bgColor != value)
                {
                    bgColor = value;
                }
            }
        }


        public ClientModel(NumberPhoneModel numberPhone,
            string firstname,
            string surname,
            string lastname,
            Brush bgColor)
            : base(firstname, surname, lastname)
        {
            Id = Guid.NewGuid().ToString();
            BgColor = bgColor;
            NumberPhone = numberPhone;
        }
        public void AddOrderToList(ObservableCollection<ProductModel> product)
        {
            OrderList.Add(new OrderModel(product));
        }
    }
}
