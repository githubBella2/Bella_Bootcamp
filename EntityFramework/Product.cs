using System.ComponentModel.DataAnnotations;

namespace EntityFramework;

public class Product
{
    [Key]
    [Required, MaxLength(10)]
    public int ProductID { get; set; }

    [Required, MaxLength(100)]
    public string ProductName { get; set; }

    [Required]
    public int CategoryID { get; set; }//menyimpan categori idnya


    [Required]
    public int Stock { get; set; }

    [Required]
    public int Price { get; set; }
    
    public Category Category { get; set; } //jembatan atau sambungan untuk ke tabel lain

}