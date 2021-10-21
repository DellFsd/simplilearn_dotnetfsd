
namespace Phase1Section6._4
{
    abstract class BookingType
    {
        public string Seat { get; set; }
        public abstract BookingType Clone();

    }

    class Booking : BookingType
    {
        public override BookingType Clone()
        {
            return this.MemberwiseClone() as BookingType;
        }
    }
}
