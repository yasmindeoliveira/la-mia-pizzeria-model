using LaMiaPizzeriaModel.Models;
using LaMiaPizzeriaModel.Utils;
using Microsoft.AspNetCore.Mvc;

namespace LaMiaPizzeriaModel.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza>pizzas= PizzaData.GetPizzas();

            return View("Index", pizzas);
        }

        
    }
}
