using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("Persons")]
public class Person
{
    [Key]
    public string? PersonId { get; set;}
    public string? Fullname { get; set;}
    public string? Address { get; set; }
    public string? Email { get; set; }
}
}