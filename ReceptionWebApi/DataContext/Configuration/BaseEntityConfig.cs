using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ReceptionWebApi.DataContext.Models.BaseEntity;

namespace ReceptionWebApi.DataContext.Configuration
{
    public class BaseEntityConfig<T, TIdentifire> : IEntityTypeConfiguration<T>
    where T : TBaseEntity<TIdentifire>
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).UseIdentityColumn();
            builder.ToTable($"{typeof(T).Name}s");
            Config(builder);
        }

        public virtual void Config(EntityTypeBuilder<T> builder)
        {

        }
    }
}
