using ReceptionWebApi.DataContext.Models;

namespace ReceptionWebApi.Repository
{
    public class InMemTblUserRep : ITblUser
    {

        private List<tblUser> _users;

        public  InMemTblUserRep() {
            //_users = new List<tblUser>();
            _users = new() { new tblUser { Id = 1, FirstName = "Rasool", LastName = "Aghajani" } };
        }
        public void CreateUser(tblUser user)
        {
           _users.Add(user);
        }

        public void DeleteUser(int id)
        {
            var User = _users.FindIndex(x => x.Id == id);
            if (User > -1)
            {
                _users.RemoveAt(User);
            }
        }

        public tblUser GetTblUser(int id)
        {
            var user = _users.Where(x=>x.Id == id).FirstOrDefault();
            return user ?? throw new Exception();
        }

        public IEnumerable<tblUser> GetTblUsers()
        {
            return _users; 
        }

        public void UpdateUser(int id, tblUser user)
        {
            var User = _users.FindIndex(X => X.Id == id);
            if (User > -1)
            {
                _users[User] = user;
            }
        }
    }
}
