using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using BondGarfoApp.Models;

namespace BondGarfoApp.Controllers;

public class HelloWorldController : Controller
{
    // Index
    public IActionResult Index()
    {
        return View();
    }

    // Welcome
    /*public string Welcome()
    {
        return "Essa é a ação Bem-Vindo";
    }*/
    /*public string Welcome(string nome, int ID=1)
    {
        return HtmlEncoder.Default.Encode(
            $"Ola {nome}, seu ID e {ID}"
        );
    }*/

    public IActionResult Welcome(string nome, int ID =1)
    {
        ViewData["Mensagem"] = "Ola "+nome;
        ViewData["ID"] = ID;

        return View();
    }

    public IActionResult Cadastro()
    {
        
        var strogonof = new Prato();

        strogonof.Id = 101;
        strogonof.nome = "Strogonoff de Carne";
        strogonof.ingredientes = "Filet Mignon com champignon, com arroz e batata palha";
        strogonof.categoria = "Prato Principal";
        //strogonof.preco = 19.90;
        //strogonof.validade = "2023-03-17";
        /*ViewData["Nome"] = "Regina Andrea Eduarda Cavalcanti";
        ViewData["cpf"] = "106.950.242-13";
        ViewData["dtnasc"] = "03/02/1964";
        ViewData["email"] = "regina.andrea.cavalcanti@cordeiromaquinas.com.br";
        */
        return View();
    }




}

