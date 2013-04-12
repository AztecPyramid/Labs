using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace DM.PetShop.Inventory
{
    [DataContract(Name="Order", Namespace=Constants.DATA_NAMESPACE)]
    public class Order
    {
        [DataMember(Name="Quantity")]
        public int Quantity;

        [DataMember(Name = "ProductName")]
        public string ProductName;
    }
    
    [DataContract(Name = "Inventory", Namespace = Constants.DATA_NAMESPACE)]
    public class InventoryDetails
    {
        [DataMember(Name = "Items")]
        public Dictionary<string, AnimalDetails> Items;
    }

    [Serializable]
    [DataContract(Name = "AnimalDetails", Namespace = Constants.DATA_NAMESPACE)]
    public class AnimalDetails
    {
        [DataMember(Name = "InStock")]
        public int InStock;

        [DataMember(Name = "Price")]
        public int Price;

        public AnimalDetails()
        {}

        public AnimalDetails(int inStock, int price)
        {
            InStock = inStock;
            Price = price;
        }
    }
}
