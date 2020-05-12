using System;
using System.Collections.Generic;

namespace T1907M.Assignment3
{
    public class Program
    {
        public static void Main(string[] args)
        {    
            Product p1 = new Product(1,"sp1",5000,5,"image1","sanpham1",new List<string>());
            p1.addGallery();
            Cart cart = new Cart(1,"thang",0,new List<Product>(), "HN","VN");
            cart.AddProduct(p1);
            Console.WriteLine("So tien thanh toan"+cart.FinalTotal());
        }   
    }
}