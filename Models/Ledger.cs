using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CashDrawer.Models
{
  public class Ledger
  {
    [Key]
    public int LedgerId {get;set;}

    [Required]
    [DataType(DataType.Date)]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime TimeStamp {get;set;}

    [Required]
    public decimal OpenDrawerBalance{ get; set; }

    public decimal ClosedDrawerBalance { get; set; }

    }
}