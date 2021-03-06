using System;

namespace Source.Models
{
    public abstract class Item
    {
        public int ProductId { get; }
        public decimal UnitPrice { get; }
        public int Quantity { get; protected set; }
        public decimal TotalPrice => Quantity * UnitPrice;

        protected Item(int productId, int quantity, decimal unitPrice)
        {
            //TODO: Add validation.              
            ProductId = productId;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }


        public virtual void IncreaseQuantity()
        {
            Quantity++;
        }

        public virtual void DecreaseQuantity()
        {
            if(Quantity == 0)
            {
                return;
            }
            Quantity--;
        }
    }
}