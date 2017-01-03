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
    [DataType(DataType.Date)]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime TimeStamp {get;set;}

    public ICollection<LineItem> LineItems;

    public int SubTotal {get;set;}

    public int? Tax {get;set;}

  }
}