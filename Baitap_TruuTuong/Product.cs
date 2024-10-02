using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_TruuTuong
{
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public Product(string Name , decimal Price , int Stock)
        {
            this.Name = Name;
            this.Price = Price;
            this.Stock = Stock;
        }
        public abstract void DisplayProductInfo();
        public abstract void ApplyDiscount( decimal percentage);
    }
    interface ISellable
    {
        void Sell(int quantity);
        bool IsInStock();
    }
    //MobilePhone
    class MobilePhone : Product, ISellable
    {
        public string Brand { get; set; }
        public MobilePhone(string Name, decimal Price, int Stock, string Brand) : base(Name, Price, Stock)
        {
            this.Brand = Brand;
        }
        public override void ApplyDiscount(decimal percentage)
        {
            Price -= Price * percentage / 100;
            Console.WriteLine($"{Name} gia moi sau khi giam {percentage}% : {Price}");
        }
        public override void DisplayProductInfo()
        {
            Console.WriteLine($"MobilePhone:{Name} Brand:{Brand}  Price:{Price}  Stock:{Stock} ");
        }

        public void Sell(int quantity)
        {
            if (Stock >= quantity)
            {
                Stock -= quantity;
                Console.WriteLine($"{quantity} san pham {Name} duoc ban. Ton kho con lai: {Stock}");
            }
            else
            {
                Console.WriteLine($"Khong du san pham {Name}.");
            }
        }

        public bool IsInStock()
        {
            return Stock > 0;
        }
    }
    //Laptop
    class Laptop : Product, ISellable
    {
        public string Memory { get; set; }
        public Laptop(string Name, decimal Price, int Stock, string Memory) : base(Name, Price, Stock)
        {
            this.Memory = Memory;
        }
        public override void ApplyDiscount(decimal percentage)
        {
            Price -= Price * percentage / 100;
            Console.WriteLine($"{Name} gia moi sau khi giam {percentage}% :{Price}");
        }
        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Laptop: {Name}  Memory:{Memory}  Price:{Price} Stock:{Stock}");
        }

        public void Sell(int quantity)
        {
            if (Stock >= quantity)
            {
                Stock -= quantity;
                Console.WriteLine($"{quantity} san pham {Name} duoc ban. Ton kho con lai: {Stock}");
            }
            else
            {
                Console.WriteLine($"Khong du san pham {Name}.");
            }
        }
        public bool IsInStock()
        {
            return Stock > 0;
        }
    }

    //Accessory: quản lý sản phẩm là phụ kiện.
    class Accessory : Product, ISellable
    {
        public string Type { get; set; }
        public Accessory(string Name, decimal Price, int Stock, string Type) : base(Name, Price, Stock)
        {
            this.Type = Type;
        }
        public override void ApplyDiscount(decimal percentage)
        {
            Price -= Price * percentage / 100;
            Console.WriteLine($"{Name} gia sau khi giam {percentage}% : {Price}");
        }
        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Accessory: {Name}  Type:{Type}  Price:{Price} Stock:{Stock}");
        }
        public void Sell(int quantity)
        {
            if (Stock >= quantity)
            {
                Stock -= quantity;
                Console.WriteLine($"{quantity} san pham {Name} duoc ban. Ton kho con lai: {Stock}");
            }
            else
            {
                Console.WriteLine($"Khong du san pham {Name}.");
            }
        }
        public bool IsInStock()
        {
            return Stock > 0;

        }
    }
}
