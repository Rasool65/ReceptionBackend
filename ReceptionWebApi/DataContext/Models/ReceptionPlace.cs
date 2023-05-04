using System.ComponentModel.DataAnnotations.Schema;

namespace ReceptionWebApi.DataContext.Models
{
    public class ReceptionPlace
    {
        public int ReceptionPlaceId { get; set; }
        public string? ReceptionPlaceName { get; set; }
        public string? Activity { get; set; }
        public int RoomNo { get; set; }
        public string? AreaName { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order? Order { get; set; }
    }
}
