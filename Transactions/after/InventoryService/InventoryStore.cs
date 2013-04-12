using System;
using System.Collections.Generic;
using System.Text;
using IDesign.System.Collections.Transactional;

namespace DM.PetShop.Inventory
{
    static class InventoryStore
    {
        static TransactionalDictionary<string, AnimalDetails> _inventory;

        static InventoryStore()
        {
            _inventory = new TransactionalDictionary<string, AnimalDetails>();

            _inventory.Add("Elephant", new AnimalDetails(3, 200));
            _inventory.Add("Mouse", new AnimalDetails(100, 50));
        }

        public static Dictionary<string, AnimalDetails> GetInventory()
        {
            Dictionary<string, AnimalDetails> inventory = new Dictionary<string, AnimalDetails>();

            foreach (KeyValuePair<string, AnimalDetails> entry in _inventory)
            {
                inventory.Add(entry.Key, entry.Value);
            }

            return inventory;
        }

        public static void UpdateInventory(string animal, int amount)
        {
            AnimalDetails animalDetail = _inventory[animal];

            if ((animalDetail.InStock - amount) >= 0)
            {
                animalDetail.InStock -= amount;
            }
            else
            {
                throw new InventoryException();
            }
        }
    }


    [global::System.Serializable]
    public class InventoryException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public InventoryException() { }
        public InventoryException(string message) : base(message) { }
        public InventoryException(string message, Exception inner) : base(message, inner) { }
        protected InventoryException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
