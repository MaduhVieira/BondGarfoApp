using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BondGarfoApp.Models;

public class Categoria
{
    public int Id{get;set;}
    public string Nome{get;set;}
    [Display(Name="Descrição")]
    public string Descricao{get;set;}

    //Relacionamento com Pratos
    public virtual List<Prato> Pratos {get;set;}
}