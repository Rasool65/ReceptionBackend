using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ReceptionWebApi.DataContext.Models
{
    public class tblOrder
    {
        [Required]
        public int Id { get; set; }
        public string? ReciptionVIP { get; set; }
        public List<string>? Gifts { get; set; }
        public string? Food { get; set; }

        internal ActionResult<IEnumerable<tblOrder>> ToList()
        {
            throw new NotImplementedException();
        }
    }
}
