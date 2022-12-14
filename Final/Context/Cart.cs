using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Context
{
    public class CartItem
    {
        public product shopping_product { get; set; }
        public int shopping_quantity { get; set; }
    }

    public class Cart
    {
        List<CartItem> items = new List<CartItem>();
        public IEnumerable<CartItem> Items
        {
            get { return items; }
        }
        public void Add(product _product, int _quantity = 1)
        {
            var item = items.FirstOrDefault(s => s.shopping_product.pd_id == _product.pd_id);
            if (item == null)
            {
                items.Add(new CartItem
                {
                    shopping_product = _product,
                    shopping_quantity = _quantity
                }) ;
            }
            else
            {
                item.shopping_quantity += _quantity;
            }
        }
        public void Update_Quantity(int id, int qty)
        {
            var  item = items.Find(s => s.shopping_product.pd_id == id);
            if (item != null)
            {
                item.shopping_quantity = qty;
            }
        }
        public double Total_Price()
        {
            var total = items.Sum(s => s.shopping_product.pd_price * s.shopping_quantity);
            return (double)total;
        }
        public void Remove(int id)
        {
            items.RemoveAll(s => s.shopping_product.pd_id == id);
        }
        public int TotalItem()
        {
            return items.Sum(s => s.shopping_quantity);
        }

        public void ClearAll()
        {
            items.Clear();
        }
    }
}