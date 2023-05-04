namespace ReceptionWebApi.DataContext.Models
{
    public class Role : BaseModel
    {
        public int RoleId { get; set; }
        public string? RoleName { get; set; }
        public bool Gender { get; set; }
        public string? ImageUrl { get; set; }
        public virtual ICollection<RoleOrder>? RoleOrders { get; set; }

    }
}
