namespace StudentPortal.Web.Models;

public class AddStudentViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }=String.Empty;
    public string? Email { get; set; }=String.Empty;
    public int Phone { get; set; }
    public bool Subscribed { get; set; }
}