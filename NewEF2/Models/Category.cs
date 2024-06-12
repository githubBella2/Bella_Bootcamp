namespace NewEF2.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// [Table("Categories")]
public class Category
{
    // [Key]
    public int CategoryID { get; set; }

    public string CategoryName { get; set; }
    

    // [Column("Description",TypeName ="TEXT")]
    public string Description { get; set; }



    // 1 kategori,banyak produk
    public IEnumerable<Product> Products { get; set; }
    public Category(){
        Products = new List<Product>();
    }
}
