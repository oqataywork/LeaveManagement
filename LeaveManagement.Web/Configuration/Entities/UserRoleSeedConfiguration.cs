using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "12e68a19-bfbc-1f35-b557-179648cd3afd",
                    UserId = "12993093-51b5-4508-be0a-13745aa58210"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "98e76a54-bfbc-1f35-b557-179648cd3afd",
                    UserId = "34e68a19-bfbc-4f53-b557-179648cd3afd"
                }

                );
            
        }
    }
}