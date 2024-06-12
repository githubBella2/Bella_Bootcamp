using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Model;

public class Category
{

    public int CategoryID { get; set; }
    public string CategoryName { get; set; }

    [Column(TypeName = "TEXT")]
    public string Description { get; set; }
    public IEnumerable<Product> Products { get; set; }
}
