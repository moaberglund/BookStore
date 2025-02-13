using System.ComponentModel.DataAnnotations;
namespace BookStore.Models;

public class Book
{

    // Properties
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter a book title.")]
    [MinLength(1)]
    [MaxLength(50)]
    public required string Title { get; set; }

    [Required(ErrorMessage = "Plese enter the name of the author.")]
    [MinLength(3)]
    [MaxLength(50)]
    public required string Author { get; set; }

    public string? Description { get; set; }

    [Required(ErrorMessage = "Please enter how many pages the book has.")]
    [Range(1, 10000)]
    public required int Pages { get; set; }

    [Required(ErrorMessage = "Please enter which year the book was published.")]
    [Range(1, 2025)]
    public required int Year { get; set; }

   [Range(1, 5)]
    public int? Rating { get; set; }

    // Relationship
    public int? StatusId { get; set; }
    public Status? Status { get; set; }

}