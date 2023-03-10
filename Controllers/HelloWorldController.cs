using Microsoft.AspNetCore.Mvc; 
using System.Text.Encodings.Web;

namespace BondGarfoApp.Controllers;

public class HelloWorldController : Controller
{
    //Index
    /*public string Index()
    {
        return "Essa é a ação Padrão";
    }*/
    public IActionResult Index()
    {
        return View();
    }

    //Welcome
    /*public string Welcome()
    {
        return "Essa é a ação Bem-Vindo";
    }*/
    public string Welcome(string nome, int ID=1)
    {
        return HtmlEncoder.Default.Encode(
            $"Ola {nome}, seu ID e {ID}"
        );
    }


}