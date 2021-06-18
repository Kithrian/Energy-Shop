using System;
namespace Energy_Shop.Models
{
    public class Energydrinks
    {
        public Energydrinks()
        {
        }

        public int Id { get; set; }


        public int Bez { get; set; }

        public Marke Marke { get; set; }

        public Geschmack Geschmack { get; set; }

        public int Preis { get; set; }

        public int Anzahl { get; set; }
    }
}
