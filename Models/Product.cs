using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CashDrawer.Models
{
  public class Product
  {
    [Key]
    public int ProductId {get;set;}

    [Required]
    [StringLength(255)]
    public string Name { get; set; }

    [Required]
    public double Price { get; set; }
    public ICollection<LineItem> LineItems;

    [Required]
    public double Cost { get; set; }

    [Required]
    public int Quantity { get; set; }

    [Required]
    public bool IsTaxable { get; set; }

    public double TaxRate { get; set; }

    }
}