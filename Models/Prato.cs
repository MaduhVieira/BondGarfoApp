using System;
using System.ComponentModel.DataAnnotations;

namespace BondGarfoApp.Models;

public class Prato
{
    public int Id{get; set;}
    public string nome{get;set;}
    public string ingredientes{get; set;}
    public string categoria{get; set;}
    public decimal preco{get; set;}
    [DataType(DataType.Date)]
    public DateTime validade{get;set;}


}