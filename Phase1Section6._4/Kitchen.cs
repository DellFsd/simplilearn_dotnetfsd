using System.Collections.Generic;


namespace Phase1Section6._4
{
    abstract class Kitchen
    {
        public List<KitchenItem> Items { get; protected set; } = new List<KitchenItem>();

        KitchenItem this[int i]
        {
            get { return Items[i]; }
        }

        public abstract void CreateItems();
    }

    class MyKitchen : Kitchen
    {
        public override void CreateItems()
        {
            Items.Add(new Spoon());
            Items.Add(new Pan());
            Items.Add(new Glass());
        }
    }

    class KatiesKitchen : Kitchen
    {
        public override void CreateItems()
        {
            Items.Add(new Spoon());
            Items.Add(new Kettle());
            Items.Add(new Glass());
        }
    }
}
