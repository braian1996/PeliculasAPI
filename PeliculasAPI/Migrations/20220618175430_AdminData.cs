using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeliculasAPI.Migrations
{
    public partial class AdminData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            
                UPDATE [AspNetRoles] SET [ConcurrencyStamp] = N'161d3acc-ba0b-4868-9434-f0cbfaead1b4'
                WHERE [Id] = N'9aae0b6d-d50c-4d0a-9b90-2a6873e3845d';
                SELECT @@ROWCOUNT;

                GO

                UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'5ea4ed6b-f685-43c0-8a1b-bae8367ba7ed', [PasswordHash] = N'AQAAAAEAACcQAAAAEDM8JJSMjS2eZOShdn/hOwmtiBm0b54vRRH/tB7Rm/eCusshBNqumbwORKEW2ZgdyQ==', [SecurityStamp] = N'24bdd617-f66e-4e4c-8e02-c4f8a71f59ff'
                WHERE [Id] = N'5673b8cf-12de-44f6-92ad-fae4a77932ad';
                SELECT @@ROWCOUNT;

                GO
            ");

            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "9aae0b6d-d50c-4d0a-9b90-2a6873e3845d");

            //migrationBuilder.DeleteData(
            //    table: "AspNetUserClaims",
            //    keyColumn: "Id",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "5673b8cf-12de-44f6-92ad-fae4a77932ad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9aae0b6d-d50c-4d0a-9b90-2a6873e3845d",
                column: "ConcurrencyStamp",
                value: "f38192b8-10be-4d52-a00e-dec5ec5cd6c0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5673b8cf-12de-44f6-92ad-fae4a77932ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eba7e18b-bb23-46eb-89d9-af3741afbc2d", "AQAAAAEAACcQAAAAEMGZpWxW1cj9S1QlXF6yaiLGvI94AiYcSlOg7vhPO0qXSZl7mZRZBsRvgW2TACx/Zw==", "7bbba15d-67b7-430c-b484-55290b205c06" });


            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 1, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Admin", "5673b8cf-12de-44f6-92ad-fae4a77932ad" });

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[] { "9aae0b6d-d50c-4d0a-9b90-2a6873e3845d", "f38192b8-10be-4d52-a00e-dec5ec5cd6c0", "Admin", "Admin" });

            //migrationBuilder.InsertData(
            //    table: "AspNetUsers",
            //    columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
            //    values: new object[] { "5673b8cf-12de-44f6-92ad-fae4a77932ad", 0, "eba7e18b-bb23-46eb-89d9-af3741afbc2d", "wengerbraian@gmail.com", false, false, null, "wengerbraian@gmail.com", "wengerbraian@gmail.com", "AQAAAAEAACcQAAAAEMGZpWxW1cj9S1QlXF6yaiLGvI94AiYcSlOg7vhPO0qXSZl7mZRZBsRvgW2TACx/Zw==", null, false, "7bbba15d-67b7-430c-b484-55290b205c06", false, "wengerbraian@gmail.com" });

            //migrationBuilder.InsertData(
            //    table: "AspNetUserClaims",
            //    columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
            //    values: new object[] { 1, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Admin", "5673b8cf-12de-44f6-92ad-fae4a77932ad" });
        }
    }
}
