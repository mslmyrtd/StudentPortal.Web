namespace StudentPortal.Web.Models.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }=String.Empty;
        public string? Email { get; set; }=String.Empty;
        public int Phone { get; set; }
        public bool Subscribed { get; set; }
        public int Grade { get; set; }
         public string? ImagePath { get; set; }
    }
}