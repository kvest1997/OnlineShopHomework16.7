using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using OnlineShopHomework16._7.Models.Client;

namespace OnlineShopHomework16._7.Models
{
    public class OnlineShopModel
    {
        public IEnumerable<ClientModel> GetClient()
        {
            var client = new List<ClientModel>();

            var convert = new BrushConverter();
            client.Add(new ClientModel(new Person.NumberPhoneModel("9528925111"),"fsgdsf","sdfgsd","sdfgsdf",(Brush)convert.ConvertFromString("#102ad")));

            return client;
        }
    }
}
