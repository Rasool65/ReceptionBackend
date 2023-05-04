using System.ComponentModel.DataAnnotations.Schema;

namespace ReceptionWebApi.DataContext.Models.BaseEntity
{
    public abstract class BaseEntity : TBaseEntity<int>
    {
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public DateTime? CreateDate { get; set; } = DateTime.Now;
        public DateTime? LastUpdate { get; set; } = DateTime.Now;

    }
}
