using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BondGarfoApp.Models;

public class Categoria
{
    public int Id{get;set;}
    public string Nome{get;set;}
    public string Descricao{get;set;}
}