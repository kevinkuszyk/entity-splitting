using System.Data.Entity.ModelConfiguration;
using Data.Entities;

namespace Data.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Map(map =>
            {
                map.Properties(p => new { p.Key, p.Id, p.Username });

                map.ToTable("TM_USER");

                map.Property(p => p.Key).HasColumnName("USR_USER_KEY");
                map.Property(p => p.Id).HasColumnName("USR_ID");
                map.Property(p => p.Username).HasColumnName("USR_USER_NAME");
            });

            Map(map =>
            {
                map.Properties(p => new { p.Forename, p.Surname });

                map.ToTable("TM_USER_DETAIL");

                map.Property(p => p.Id).HasColumnName("UDT_USR_ID");
                map.Property(p => p.Forename).HasColumnName("UDT_FORENAME");
                map.Property(p => p.Surname).HasColumnName("UDT_SURNAME");
            });

            Map(map =>
            {
                map.Properties(p => new { p.IsApproved });

                map.ToTable("TM_MEMBERSHIP_USERS");

                map.Property(p => p.Key).HasColumnName("USR_ID");
                map.Property(p => p.IsApproved).HasColumnName("USR_ISAPPROVED");
            });

            HasKey(user => user.Id);
        }
    }
}
