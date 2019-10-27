using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEANet
{
    class Purchase
    {
        public bool InternetConnection { get; set; }
        public int Price { get; set; }
        public string[] CellPhone { get; set; }
        public int PhoneLines { get; set; }

        public Purchase()
        {
        }

        public void IncludeExcludeInternetConnection(bool input)
        {
            if (input) Price += 200;
            else Price -= 200;
        }

        public void IncrementPhoneLineNumber()
        {
            if (PhoneLines < 8)
            { 
            PhoneLines++;
            Price += 150;
            }
        }

        public void DecrementPhoneLineNumber()
        {
            if (PhoneLines > 0)
            {
                PhoneLines--;
                Price -= 150;
            }
        }

        public void SelectCellPhone(string modelName)
        {
            if (modelName == "Huawei 99") Price += 900;
            if (modelName == "Sony Xperia 99") Price += 900;
            if (modelName == "Samsung Galaxy 99") Price += 1000;
            if (modelName == "iPhone 99") Price += 6000;
            if (modelName == "Motorola G99") Price += 800;

        }

        public void UnselectCellPhone(string modelName)
        {
            if (modelName == "Huawei 99") Price -= 900;
            if (modelName == "Sony Xperia 99") Price -= 900;
            if (modelName == "Samsung Galaxy 99") Price -= 1000;
            if (modelName == "iPhone 99") Price -= 6000;
            if (modelName == "Motorola G99") Price -= 800;
        }

        public string Buy()
        {
            return "You have bought items for a total of " + Price + " DKK";
        }

        public void Reset()
        {
            PhoneLines = 0;
            Price = 0;
        }
    }
}