using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SmartFood.Api.Models;

public class Recipe
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    [StringLength(50)]
    public String Name { get; set; }

    [Required]
    public int PreparationTime { get; set; }

    [Required]
    public int Servings { get; set; }

    [Required]
    [StringLength(300)]
    public String Ingredients { get; set; }

    [Required]
    [StringLength(300)]
    public String Description { get; set; }

    [Required]
    [JsonIgnore]
    public Guid CategoryId { get; set; }
    public Category? Category { get; set; }

    public String Photo { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}