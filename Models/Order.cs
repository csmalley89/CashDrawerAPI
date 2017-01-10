using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CashDrawer.Models
{
  public class Order
  {
    [Key]
    public int OrderId {get;set;}

    [Required]
    [DataType(DataType.DateTime)]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTimeOffset TimeStamp {get;set;}

    public ICollection<LineItem> LineItems;

    public double SubTotal {get;set;}

    public double? Tax {get;set;}

  }
}