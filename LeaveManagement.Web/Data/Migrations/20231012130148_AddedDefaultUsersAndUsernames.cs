using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12e68a19-bfbc-1f35-b557-179648cd3afd",
                column: "ConcurrencyStamp",
                value: "93500d36-8613-4942-83cd-9cbe14077ad2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98e76a54-bfbc-1f35-b557-179648cd3afd",
                column: "ConcurrencyStamp",
                value: "8de501fc-6322-4dc8-9260-8c4c7d1d2ec6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12993093-51b5-4508-be0a-13745aa58210",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "520f7468-9ba6-46dd-a0b0-b2e23d1bfb00", true, "AQAAAAEAACcQAAAAENp5cBS5xOtr+JPnBYXhwrnGX13R0LMG3SPofxoqG/YvuozCli99OvVGeRLMKMqHMg==", "971a2ffb-a1ac-4030-86dd-3b96835f0b3b", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34e68a19-bfbc-4f53-b557-179648cd3afd",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "921db011-d4f2-4857-af5d-b975a16cbefb", true, "AQAAAAEAACcQAAAAEIHWrUGEkTMTZViXmGHke0GpY0BFZtNCVD+VnEJgxKuRdlt0m2em0WpR8+HfvDf9MA==", "fe2a1ca5-6128-4519-9700-e50761f75686", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12e68a19-bfbc-1f35-b557-179648cd3afd",
                column: "ConcurrencyStamp",
                value: "22dd06d4-8fd2-4564-b396-fce85c59e170");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98e76a54-bfbc-1f35-b557-179648cd3afd",
                column: "ConcurrencyStamp",
                value: "bf9d1595-a9f6-4189-816f-eebcabd2e7ca");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12993093-51b5-4508-be0a-13745aa58210",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "40b37e5d-48a0-4c75-aa1b-998620c2a203", false, "AQAAAAEAACcQAAAAEOk2jDv8M5rGssFPdSNOv0WbKxsch9owvuoqeVlXNZD5AS9NKkoykuuLttbFxvpX2g==", "8e111822-f7c7-407d-afb0-1b3028057765", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34e68a19-bfbc-4f53-b557-179648cd3afd",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8bd55971-13bf-4632-988c-93eeee13153b", false, "AQAAAAEAACcQAAAAEKFdegAEwT4WPeiHRSfgNIIqD7TO1vHh2LF3fO8fohPYcGWnbv7uTkwjpWTUvtAkcg==", "1a88efb8-a702-4772-abc6-f0e32e740aa5", null });
        }
    }
}
