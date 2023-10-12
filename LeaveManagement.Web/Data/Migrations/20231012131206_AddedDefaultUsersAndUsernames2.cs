using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndUsernames2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12e68a19-bfbc-1f35-b557-179648cd3afd",
                column: "ConcurrencyStamp",
                value: "8070a790-a75a-4956-bbe9-b80d4530af03");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98e76a54-bfbc-1f35-b557-179648cd3afd",
                column: "ConcurrencyStamp",
                value: "772cb140-b271-4c69-b44f-031da0d49bdd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12993093-51b5-4508-be0a-13745aa58210",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19c9d86e-21af-46f1-9f1b-33be146919e5", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEMPRwWUeIX8EFIsSeZoByAwKVCAksNgEv/r51qIIytolyrl9jZHw/aChj0sTylHf+g==", "e826294c-0ef0-459c-9ca4-1ef64f0592d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34e68a19-bfbc-4f53-b557-179648cd3afd",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1ce0369-e74b-4d89-92be-c55b58d3c939", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFjsx08OlO2dyT/EaH9TZL5mElqNGejo+0z6yAWCMEH7z/KJYsPQLzJa17RspTfPMg==", "fc60c89f-1b96-48af-87bf-50065f05c47f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "520f7468-9ba6-46dd-a0b0-b2e23d1bfb00", null, "AQAAAAEAACcQAAAAENp5cBS5xOtr+JPnBYXhwrnGX13R0LMG3SPofxoqG/YvuozCli99OvVGeRLMKMqHMg==", "971a2ffb-a1ac-4030-86dd-3b96835f0b3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34e68a19-bfbc-4f53-b557-179648cd3afd",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "921db011-d4f2-4857-af5d-b975a16cbefb", null, "AQAAAAEAACcQAAAAEIHWrUGEkTMTZViXmGHke0GpY0BFZtNCVD+VnEJgxKuRdlt0m2em0WpR8+HfvDf9MA==", "fe2a1ca5-6128-4519-9700-e50761f75686" });
        }
    }
}
