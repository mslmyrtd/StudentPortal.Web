using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Web.Models;

public class AddStudentViewModel
{
    public Guid Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }=String.Empty;
    [Required]
    public string? Email { get; set; }=String.Empty;
    public int Phone { get; set; }
    public bool Subscribed { get; set; }
    [Required]
    public int Grade { get; set; }
    public string? ImagePath { get; set; }
}