using System.ComponentModel.DataAnnotations;
namespace BookStore.Models;

public class Status {

    // Properties
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Please enter a reading status.")]
    public required string ReadingStatus { get; set; }

    // List of Books
    public List<Book>? Books { get; set; }
}