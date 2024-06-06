using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace EntityFramework;
public class Category
{
    [Key] //membuat categoryid menjadi PK
    [Required, MaxLength(10)]
    public int CategoryID {get;set;}
    
    [Required, MaxLength(100)]
    public string CategoryName{get;set;}
    

    [Required, MaxLength(100)]
    public string Description {get;set;}

    public ICollection<Product> Products {get;set;}
}