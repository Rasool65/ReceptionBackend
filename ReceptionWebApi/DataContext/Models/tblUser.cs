using System.ComponentModel.DataAnnotations;

namespace ReceptionWebApi.DataContext.Models
{
    public class tblUser
    {
        [Required]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
