using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Navigation;

namespace OnlineShopHomework16._7.Models
{
    public class ProductModel
    {
        public string Id { get; } = Guid.NewGuid().ToString();

        private string email = "";
        public string Email
        {
            get => email;
            set
            {
                if (this.email != value)
                    this.email = value;
            }
        }

        private string codeProduct = "";
        public string CodeProduct
        {
            get => codeProduct;
            set
            {
                if (this.codeProduct != value)
                    this.codeProduct = value;
            }
        }

        private string nameProduct = "";
        public string NameProduct
        {
            get => nameProduct;
            set
            {
                if (this.nameProduct != value)
                    nameProduct = value;
            }
        }

        public ProductModel(string email, string codeProduct, string nameProduct)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Email = this.email;
            this.CodeProduct = this.codeProduct;
            this.NameProduct = this.nameProduct;
        }
    }
}
