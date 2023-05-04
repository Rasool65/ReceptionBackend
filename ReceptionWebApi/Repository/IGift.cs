using ReceptionWebApi.DataContext.Models;

namespace ReceptionWebApi.Repository
{
    public interface IGift
    {
        public IEnumerable<Gift> GetGifts();
        public Gift GetGift(int id);
        public void CreateGift(Gift gift);
        public void UpdateGift(int id, Gift gift);
        public void DeleteGift(int id);
    }
}
