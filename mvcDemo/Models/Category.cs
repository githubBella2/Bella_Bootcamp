using System.ComponentModel.DataAnnotations.Schema;

namespace mvcDemo.Models;

public class Category
{
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }

    [Column(TypeName = "TEXT")]
    public string Description { get; set; }
    public IEnumerable<Product> Products { get; set; }

    public Category()
    {
        Products = new List<Product>();
    }
}
