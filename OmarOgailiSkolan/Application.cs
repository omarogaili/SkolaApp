using System.ComponentModel.DataAnnotations;

namespace OmarOgailiSkolan
{
    public class Application
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime Dateofbirth { get; set; }
        [Required, EmailAddress]
        public string? Email { get; set; }
        [Range(10,70)]
        public int Age { get; set; }
    }
}
