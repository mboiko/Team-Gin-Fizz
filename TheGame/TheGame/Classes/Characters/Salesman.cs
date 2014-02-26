namespace TheGame.Classes.Characters
{
    using System.Collections.Generic;
    using System.Linq;

    using TheGame.Classes.Items;

    class Salesman : Character
    {
        private IList<Item> merchandise;

        public Salesman(string initialName, IList<Item> initialMechandise)
            :base(initialName)
        {

        }

        public Item GetItemForSell(string itemName)
        {
            var item = merchandise.Where(x => x.Name == itemName);

            return (Item)item;
        }
    }
}
