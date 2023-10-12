using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "12e68a19-bfbc-1f35-b557-179648cd3afd",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                }, new IdentityRole
                {
                    Id = "98e76a54-bfbc-1f35-b557-179648cd3afd",
                    Name = "User",
                    NormalizedName = "USER",
                }
                );
        }
    }
}