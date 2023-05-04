namespace ReceptionWebApi.DataContext.Models
{
    public class Gift : BaseModel
    {
        public int GiftId { get; set; }
        public string? GiftName { get; set; }
        public string? ImageUrl { get; set; }
        public virtual ICollection<GiftOrder>? GiftOrders { get; set; }
    }
}
