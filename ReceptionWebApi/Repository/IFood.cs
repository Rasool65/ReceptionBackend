using ReceptionWebApi.DataContext.Models;

namespace ReceptionWebApi.Repository
{
    public interface IFood
    {
        public IEnumerable<Food> GetFoods();
        public Food GetFood(int id);
        public void CreateFood(Food food); 
        public void UpdateFood(int id, Food food);
        public void DeleteFood(int id);
    }
 
}
