namespace ReceptionWebApi.DataContext.Models
{
    public class Order : BaseModel
    {
        public int OrderId { get; set; }
        public bool VipStatus { get; set; }
        public Gift? Gift { get; set; }
        public Role? Role { get; set; }
        public Food? Food { get; set; }

        public virtual ICollection<FoodOrder>? FoodOrders { get; set; }
        public virtual ICollection<RoleOrder>? RoleOrders { get; set; }
        public virtual ICollection<GiftOrder>? GiftOrders { get; set; }
    }
}
