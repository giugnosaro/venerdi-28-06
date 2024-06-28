using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using venerdi_28_06.Models;

namespace venerdi_28_06.Controllers
{
    public class ProdottiController : Controller
    {
        private readonly ILogger<ProdottiController> _logger;

        public ProdottiController(ILogger<ProdottiController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var prodotti = ProdottoRepository.GetProdotti();
            if (prodotti == null || !prodotti.Any())
            {
                _logger.LogError("Nessun prodotto disponibile.");
                return View("Error"); // Assicurati di avere una vista di errore
            }
            return View(prodotti);
        }

        public IActionResult Dettagli(int id)
        {
            var prodotto = ProdottoRepository.GetProdottoById(id);
            if (prodotto == null)
            {
                _logger.LogError($"Prodotto con ID {id} non trovato.");
                return NotFound();
            }
            return View(prodotto);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
