using System;
using System.Collections.Generic;

namespace WebForm.Data
{
    public class CartData
    {
        public DateTime PurchaseDate { get; set; }
        public string CustomerId { get; set; }
        public string GoodsId { get; set; }
        public string CategoryId { get; set; }

        public List<CartData> GetCartData()
        {
            return new List<CartData>
            {
                new CartData{PurchaseDate = DateTime.Today, CustomerId = "XXXXX", CategoryId = "C002", GoodsId = "G003"},
                new CartData{PurchaseDate = DateTime.Today, CustomerId = "XXXXX", CategoryId = "C001", GoodsId = "G001"}
            };
        }
    }

    public class Goods
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CategoryId { get; set; }
        public decimal Price { get; set; }

        public List<Goods> GetGoodsAll()
        {
            return new List<Goods> {
                new Goods{Id = "G001", Name = "みかん", CategoryId = "C001", Price = 200},
                new Goods{Id = "G002", Name = "バナナ", CategoryId = "C001", Price = 100},
                new Goods{Id = "G003", Name = "トマト", CategoryId = "C002", Price = 200},
                new Goods{Id = "G004", Name = "キュウリ", CategoryId = "C002", Price = 180},
                new Goods{Id = "G005", Name = "りんご", CategoryId = "C001", Price = 100}
            };
        }
    }

    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Category> GetCategory()
        {
            return new List<Category> {
                new Category{Id = "C001", Name = "果物"},
                new Category{Id = "C002", Name = "野菜"}
            };
        }
    }
}