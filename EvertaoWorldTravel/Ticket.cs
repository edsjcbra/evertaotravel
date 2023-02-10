namespace EvertaoWorldTravel
{
    internal class Ticket
    {
        public Ticket(string origin, string destination, float price, DateTime travelDate)
        {
            Origin = origin;
            Destination = destination;
            Price = price;
            TravelDate = travelDate;
        }
        public int Id { get; set; }
        public string Origin { get; private set; }
        public string Destination { get; private set; }
        public float Price { get; private set; }
        public DateTime TravelDate { get; private set; }

        public override string ToString()
        {
            return $"Num - Origem - Destino - Preco - Data\n {Id}      {Origin}       {Destination}     {Price}   {TravelDate}";
        }
    }
}
