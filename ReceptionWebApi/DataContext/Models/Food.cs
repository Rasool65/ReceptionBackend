namespace ReceptionWebApi.DataContext.Models
{
    public class Food : BaseModel
    {
        public int FoodId { get; set; }
        public string? FoodName { get; set; }
        public string? ImageUrl { get; set; }
        //public virtual ICollection<FoodOrder>? FoodOrders { get; set; }
    }
}
