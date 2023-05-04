using ReceptionWebApi.DataContext.Models;

namespace ReceptionWebApi.Repository
{
    public interface IRole
    {
        public IEnumerable<Role> GetRoles();
        public Role GetRole(int id);
        public void CreateRole(Role role);
        public void UpdateRole(int id, Role role);
        public void DeleteRole(int id);
    }
}
