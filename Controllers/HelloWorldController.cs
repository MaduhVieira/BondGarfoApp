using Microsoft.AspNetCore.Mvc; 
using System.Text.Encodings.Web;
using BondGarfoApp.Models;

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
    /*public string Welcome(string nome, int ID=1)
    {
        return HtmlEncoder.Default.Encode(
            $"Ola {nome}, seu ID e {ID}"
        );
    }*/

    public IActionResult Welcome (String nome, int ID= 1)
    {
        ViewData["Mensagem"] = "Ola " + nome;
        ViewData["ID"] = ID;

        return View();
    }

    public IActionResult Cadastro()
    {
        var strogonof = new Prato();
        strogonof.Id =  120;
        strogonof.nome = "strogg";
        strogonof.ingredientes ="baba de piolho irlandes";
        strogonof.categoria = "prato principal";
        strogonof.preco = 23.30;
        strogonof.validade =2000-01-23;
/*
        ViewData["nome"] = "Patrícia Mariane Marli Silva";
        ViewData["cpf"] = "153.651.221-43";
        ViewData["DataNasc"] = "06/03/1986";
        ViewData["email"] = "patriciamarianesilva@riquefroes.com";*/

        return View();
    }


}