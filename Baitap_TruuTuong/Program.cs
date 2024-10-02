using System;
using Baitap_TruuTuong;
public class Program
{
    public static void Main(string[] args)
    {
        MobilePhone phone = new MobilePhone("Samsung S23 Utrl", 14m, 5, "SamSung");
        Laptop laptop = new Laptop("lenovo", 13.5m, 10, "Intel i5");
        Accessory accessory = new Accessory("AirPods", 1m, 12, "Wireless Earbuds");
        phone.DisplayProductInfo();
        laptop.DisplayProductInfo();
        accessory.DisplayProductInfo();

        Console.WriteLine();

       
        phone.Sell(2);
        Console.WriteLine($"con {phone.Name} trong kho {phone.IsInStock()}");

        laptop.Sell(12);  
        Console.WriteLine($"con {laptop.Name} trong kho: {laptop.IsInStock()}");

        accessory.Sell(5);
        Console.WriteLine($"con {accessory.Name} trong kho {accessory.IsInStock()}");

        Console.WriteLine();
        phone.ApplyDiscount(10);
        laptop.ApplyDiscount(15);
    }
}