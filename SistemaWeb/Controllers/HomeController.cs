using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(); // Retorna a view padrão (Index.cshtml) na pasta Views/Home
    }

    public IActionResult About()
    {
        return View(); // Retorna a view About.cshtml na pasta Views/Home
    }

    public IActionResult Contact()
    {
        return View(); // Retorna a view Contact.cshtml na pasta Views/Home
    }
}