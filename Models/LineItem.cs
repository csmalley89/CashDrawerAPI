using System.ComponentModel.DataAnnotations;


namespace CashDrawer.Models
{
  public class LineItem
  {
    [Key]
    public int LineItemId {get;set;}
    
    [Required]
    public int OrderId { get; set; }

    [Required]
    public int Quantity { get; set; }

    [Required]
    public int ProductId { get; set; }

  }
}