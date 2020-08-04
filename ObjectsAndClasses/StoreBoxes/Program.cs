using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Box> boxes = new List<Box>();
            while ((input=Console.ReadLine())!="end")
            {
                string[] data = input.Split();
                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);
                Box box = new Box();
                box.Item = new Item();
                box.Item.Name = itemName;
                box.Item.Price = itemPrice;
                box.SerialNumber = serialNumber;
                box.Quantity = itemQuantity;
                box.PriceBox = itemPrice * itemQuantity;
                boxes.Add(box);
            }

           
            List<Box> filteredBoxes =boxes.OrderBy(b=>b.PriceBox).ToList();
            filteredBoxes.Reverse();
            foreach (Box box in filteredBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox:f2}");
            }
        }
    }
    class Item
    {     
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceBox { get; set; }
        public Box()
        {
            Item = new Item();

        }

    }
}
           


