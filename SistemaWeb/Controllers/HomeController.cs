using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SistemaWeb.Db;
using SistemaWeb.Models; // Adicione esta linha para usar Peca

namespace SistemaWeb.Controllers;

public class HomeController : Controller
{
    private readonly DbAccess _dbAccess;
    public HomeController(DbAccess dbAccess)
    {
        _dbAccess = dbAccess;
    }

    public IActionResult Index()
    {

        try
        {
            var pecas = _dbAccess.ListarPecas();
            return View(pecas);
        }
        catch (Exception e)
        {
            TempData["MensagemErro"] = "Ocorreu um erro ao listar as peças: " + e.Message; 
            return View(new List<Peca>()); 
        }
    }
}
