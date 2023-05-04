namespace ReceptionWebApi.DataContext.Models.BaseEntity
{
    public abstract class TBaseEntity<T>
    {
        public T? Id { get; set; }
    }
}
