using ReceptionWebApi.DataContext;
using ReceptionWebApi.DataContext.Models;

namespace ReceptionWebApi.Repository.CRUD
{
    public class FoodRepo :IFood
    {
        private List<Food> _food;

        public FoodRepo()
        {
            _food = new List<Food>();
            
            //_food = new() { new tblUser { Id = 1, FirstName = "Rasool", LastName = "Aghajani" } };
        }

        public void CreateFood(Food food)
        {
            throw new NotImplementedException();
        }

        public void DeleteFood(int id)
        {
            throw new NotImplementedException();
        }

        public Food GetFood(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Food> GetFoods()
        {
            throw new NotImplementedException();
        }

        public void UpdateFood(int id, Food food)
        {
            throw new NotImplementedException();
        }
        //public void CreateUser(tblUser user)
        //{
        //    _users.Add(user);
        //}

        //public void DeleteUser(int id)
        //{
        //    var User = _users.FindIndex(x => x.Id == id);
        //    if (User > -1)
        //    {
        //        _users.RemoveAt(User);
        //    }
        //}

        //public tblUser GetTblUser(int id)
        //{
        //    var user = _users.Where(x => x.Id == id).FirstOrDefault();
        //    return user ?? throw new Exception();
        //}

        //public IEnumerable<tblUser> GetTblUsers()
        //{
        //    return _users;
        //}

        //public void UpdateUser(int id, tblUser user)
        //{
        //    var User = _users.FindIndex(X => X.Id == id);
        //    if (User > -1)
        //    {
        //        _users[User] = user;
        //    }
        //}
    }
}
