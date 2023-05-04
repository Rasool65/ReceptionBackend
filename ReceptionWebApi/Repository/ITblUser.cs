using ReceptionWebApi.DataContext.Models;

namespace ReceptionWebApi.Repository
{
    public interface ITblUser
    {
        public IEnumerable<tblUser> GetTblUsers();
        public tblUser GetTblUser( int id);
        public void CreateUser(tblUser user);
        public void UpdateUser(int id, tblUser user);
        public void DeleteUser(int id);
    }
}
