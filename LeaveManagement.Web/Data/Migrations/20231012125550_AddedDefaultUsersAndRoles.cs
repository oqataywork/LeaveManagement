using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atashes");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12e68a19-bfbc-1f35-b557-179648cd3afd", "22dd06d4-8fd2-4564-b396-fce85c59e170", "Administrator", "ADMINISTRATOR" },
                    { "98e76a54-bfbc-1f35-b557-179648cd3afd", "bf9d1595-a9f6-4189-816f-eebcabd2e7ca", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "12993093-51b5-4508-be0a-13745aa58210", 0, "40b37e5d-48a0-4c75-aa1b-998620c2a203", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEOk2jDv8M5rGssFPdSNOv0WbKxsch9owvuoqeVlXNZD5AS9NKkoykuuLttbFxvpX2g==", null, false, "8e111822-f7c7-407d-afb0-1b3028057765", null, false, null },
                    { "34e68a19-bfbc-4f53-b557-179648cd3afd", 0, "8bd55971-13bf-4632-988c-93eeee13153b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEKFdegAEwT4WPeiHRSfgNIIqD7TO1vHh2LF3fO8fohPYcGWnbv7uTkwjpWTUvtAkcg==", null, false, "1a88efb8-a702-4772-abc6-f0e32e740aa5", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "12e68a19-bfbc-1f35-b557-179648cd3afd", "12993093-51b5-4508-be0a-13745aa58210" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "98e76a54-bfbc-1f35-b557-179648cd3afd", "34e68a19-bfbc-4f53-b557-179648cd3afd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "12e68a19-bfbc-1f35-b557-179648cd3afd", "12993093-51b5-4508-be0a-13745aa58210" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "98e76a54-bfbc-1f35-b557-179648cd3afd", "34e68a19-bfbc-4f53-b557-179648cd3afd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12e68a19-bfbc-1f35-b557-179648cd3afd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98e76a54-bfbc-1f35-b557-179648cd3afd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12993093-51b5-4508-be0a-13745aa58210");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34e68a19-bfbc-4f53-b557-179648cd3afd");

            migrationBuilder.CreateTable(
                name: "Atashes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Haircut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Money = table.Column<int>(type: "int", nullable: false),
                    Years = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atashes", x => x.Id);
                });
        }
    }
}
