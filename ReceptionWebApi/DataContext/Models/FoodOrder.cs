namespace ReceptionWebApi.DataContext.Models
{
    public class FoodOrder
    {
        public int FoodOrderId { get; set; }
        public int Qty { get; set; }
        public virtual Food? Food { get; set; }
        public virtual Order? Order { get; set; }
    }
}
