using venerdi_28_06.Models;

namespace venerdi_28_06.service
{
    public class Magazzino
    {
       
        public List<Prodotto> Prodotti { get; set; }

        public Magazzino()
        {
            Prodotti = new List<Prodotto>();
        }

    }
}

