using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OblakotekaTask.Domain.Entities;

namespace OblakotekaTask.Infrastructure.Configurations
{
    public class EventLogConfiguration : IEntityTypeConfiguration<EventLog>
    {
        public void Configure(EntityTypeBuilder<EventLog> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__EventLog__3214EC272E31F89D");

            builder.ToTable("EventLog");

            builder.HasIndex(e => e.EventDate, "IX_EventLog_EventDate");

            builder.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            builder.Property(e => e.EventDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
        }
    }
}
