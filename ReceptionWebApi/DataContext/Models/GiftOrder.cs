namespace ReceptionWebApi.DataContext.Models
{
    public class GiftOrder
    {
        public int GiftOrderId { get; set; }
        public int Qty { get; set; }
        public virtual Gift? Gift { get; set; }
        public virtual Order? Order { get; set; }
    }
}
