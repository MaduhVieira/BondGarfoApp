using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BondGarfoApp.Models;

public class Bebidas
{
    public int Id {get; set;}
    public string nome {get; set;}
    public string ingredientes {get; set;}
    public string categoria {get; set;}
    [Display(Name="Preço")]
    public decimal preco {get; set;}
    
}