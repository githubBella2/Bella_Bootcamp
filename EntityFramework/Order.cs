using System.ComponentModel.DataAnnotations;

namespace EntityFramework;

public class Order
{
    [Key]
    [Required]
    public int OrderID{get;set;}


    [Required]
    public int ProductID{get;set;}

    [Required]
    public int TotalOrder{get;set;}
    
    [Required]
    public int TotalPrice{get;set;}

    public Category Category { get; set; } //jembatan atau sambungan untuk ke tabel lain
    public Product Products { get; set; } //jembatan atau sambungan untuk ke tabel lain





}
