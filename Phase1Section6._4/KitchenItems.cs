
namespace Phase1Section6._4
{
    abstract class KitchenItem
    {
        public abstract string Print();
    }

    class Spoon : KitchenItem
    {
        public override string Print() { return "Spoon"; }
    }
    class Pan : KitchenItem
    {
        public override string Print() { return "Pan"; }
    }
    class Kettle : KitchenItem
    {
        public override string Print() { return "Kettle"; }
    }
    class Glass : KitchenItem
    {
        public override string Print() { return "Glass"; }
    }
}
