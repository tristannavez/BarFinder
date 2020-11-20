using Microsoft.EntityFrameworkCore.Migrations;

namespace POIN.Server.Migrations
{
    public partial class Updatebar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f72e758-f855-4cf7-b755-c9d6b76af343");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adbfa698-6122-4455-8c24-0bb17c28d82a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f789f81b-1443-4b08-afdb-e24dab03c320");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f2d684e4-0e89-4da0-a98e-7c7556f6180b", "29b74b5c-ec61-41e3-9338-638103342f76", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a258bd38-290a-416c-8fba-422398cc7d32", "f1cdcc04-fc88-4d04-b77f-e83e1dfe4597", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fda6e03f-df8a-4b73-b923-84302b2559a0", "cd6f20b8-f599-41f8-b28e-8b927971ab0b", "Sam", "Sam" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a258bd38-290a-416c-8fba-422398cc7d32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2d684e4-0e89-4da0-a98e-7c7556f6180b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fda6e03f-df8a-4b73-b923-84302b2559a0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1f72e758-f855-4cf7-b755-c9d6b76af343", "9772d6a0-eb5f-4b41-b455-6d8352bfb5b0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "adbfa698-6122-4455-8c24-0bb17c28d82a", "9d72f3a1-2fb3-4b51-9bb6-5d67ad97b2d1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f789f81b-1443-4b08-afdb-e24dab03c320", "d4e256bb-e919-47ca-8b21-419753c1b117", "Sam", "Sam" });
        }
    }
}
