namespace ReceptionWebApi.DataContext.Models
{
    public class RoleOrder
    {
        public int RoleOrderId { get; set; }
        public int Qty { get; set; }
        public virtual Role? Role { get; set; }
        public virtual Order? Order { get; set; }

    }
}
