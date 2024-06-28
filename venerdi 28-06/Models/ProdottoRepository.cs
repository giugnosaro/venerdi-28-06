namespace venerdi_28_06.Models
{
    public static class ProdottoRepository
    {
        private static List<Prodotto> prodotti = new List<Prodotto>
        {
            new Prodotto
            {
                Id = 1,
                Nome = "Scarpe Duso Giornaliere",
                Prezzo = 79.99m,
                Descrizione = "Scarpe da tennis confortevoli e resistenti.",
                ImmagineCopertina = "/IMG/scarpe.jpg",
                ImmagineAggiuntiva1 = "/IMG/scarpe.jpg",
                ImmagineAggiuntiva2 = "/IMG/scarpe.jpg"
            },

            new Prodotto
            {
                Id = 2,
                Nome = "Scarpa Elegante Donna",
                Prezzo = 19.99m,
                Descrizione = "Scarpe alla moda.",
                ImmagineCopertina = "/IMG/donna.jpg",
                ImmagineAggiuntiva1 = "/IMG/donna.jpg",
                ImmagineAggiuntiva2 = "/IMG/donna.jpg"
            },

            new Prodotto
            {
                Id = 3,
                Nome = "Scarpe Sportive Uomo",
                Prezzo = 29.99m,
                Descrizione = "Scarpe da corsa.",
                ImmagineCopertina = "/IMG/sportive.jpg",
                ImmagineAggiuntiva1 = "/IMG/sportive.jpg",
                ImmagineAggiuntiva2 = "/IMG/sportive.jpg"
            },

            new Prodotto
            {
                Id = 4,
                Nome = "Scarpe da Trekking",
                Prezzo = 49.99m,
                Descrizione = "Scarpe da trekking per le tue avventure.",
                ImmagineCopertina = "/IMG/trekking.jpg",
                ImmagineAggiuntiva1 = "/IMG/trekking.jpg",
                ImmagineAggiuntiva2 = "/IMG/trekking.jpg"

            },
            new Prodotto
            {
                Id = 5,
                Nome = "Scarpe da Calcio",
                Prezzo = 59.99m,
                Descrizione = "Scarpe da calcio per i tuoi allenamenti.",
                ImmagineCopertina = "/IMG/calcio.jpg",
                ImmagineAggiuntiva1 = "/IMG/calcio.jpg",
                ImmagineAggiuntiva2 = "/IMG/calcio.jpg"
            },
            new Prodotto
            {
                Id = 6,
                Nome = "Scarpe da Ginnastica",
                Prezzo = 39.99m,
                Descrizione = "Scarpe da ginnastica per il tuo benessere.",
                ImmagineCopertina = "/IMG/ginnastica.jpg",
                ImmagineAggiuntiva1 = "/IMG/ginnastica.jpg",
                ImmagineAggiuntiva2 = "/IMG/ginnastica.jpg"
            }

            // Aggiungi altri prodotti qui
        };
        public static List<Prodotto> GetProdotti() => prodotti;

        public static Prodotto GetProdottoById(int id) => prodotti.FirstOrDefault(p => p.Id == id);

    }
}
