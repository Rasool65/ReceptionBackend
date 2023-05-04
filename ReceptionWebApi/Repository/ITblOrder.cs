using ReceptionWebApi.DataContext.Models;

namespace ReceptionWebApi.Repository
{
    public interface ITblOrder
    {
        public IEnumerable<tblOrder> GetTblOrders();
        public tblOrder GetTblOrder();
        public void CreateOrder(tblOrder order);
        public void UpdateOrder(int id, tblOrder order);
        public void DeleteOrder(int id);

    }
}
