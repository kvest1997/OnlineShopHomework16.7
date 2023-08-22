using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace OnlineShopHomework16._7.Models.Person
{
    public class NumberPhoneModel
    {
        private string phone = "";
        public string Phone
        {
            get => phone;
            set => phone = value;
        }

        public NumberPhoneModel(string phoneNumber)
        {
            SetNumber(phoneNumber);
        }

        private void SetNumber(string phoneNumber)
        {
            if (!IsCheckNumberPhone(phoneNumber))
            {
                throw new ArgumentException($"Строка \"{nameof(phoneNumber)}\" не является номером телефона");
            } 
            Phone = phoneNumber;
        }

        public static bool IsCheckNumberPhone(string phoneNumber)
        {
            var result = Regex.Match(phoneNumber, @"\d{9}$").Success;
            return result;
        }
    }
}
