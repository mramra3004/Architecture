using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Architecture.Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                "User");

            migrationBuilder.CreateTable(
                "Users",
                schema: "User",
                columns: table => new
                {
                    Id = table.Column<long>()
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Surname = table.Column<string>(maxLength: 200, nullable: true),
                    Email = table.Column<string>(maxLength: 300, nullable: true),
                    Login = table.Column<string>(maxLength: 100, nullable: true),
                    Password = table.Column<string>(maxLength: 500, nullable: true),
                    Salt = table.Column<string>(maxLength: 500, nullable: true),
                    Roles = table.Column<int>(nullable: true),
                    Status = table.Column<int>()
                },
                constraints: table => { table.PrimaryKey("PK_Users", x => x.Id); });

            migrationBuilder.CreateTable(
                "UsersLogs",
                schema: "User",
                columns: table => new
                {
                    Id = table.Column<long>()
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(),
                    LogType = table.Column<int>(),
                    DateTime = table.Column<DateTime>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersLogs", x => x.Id);
                    table.ForeignKey(
                        "FK_UsersLogs_Users_UserId",
                        x => x.UserId,
                        principalSchema: "User",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "Users",
                columns: new[] { "Id", "Status", "Email", "Name", "Surname", "Login", "Password", "Roles", "Salt" },
                values: new object[]
                {
                    1L, 1, "administrator@administrator.com", "Administrator", "Administrator", "admin",
                    "O34uMN1Vho2IYcSM7nlXEqn57RZ8VEUsJwH++sFr0i3MSHJVx8J3PQGjhLR3s5i4l0XWUnCnymQ/EbRmzvLy8uMWREZu7vZI+BqebjAl5upYKMMQvlEcBeyLcRRTTBpYpv80m/YCZQmpig4XFVfIViLLZY/Kr5gBN5dkQf25rK8=",
                    3, "79005744-e69a-4b09-996b-08fe0b70cbb9"
                });

            migrationBuilder.CreateIndex(
                "IX_Users_Email",
                schema: "User",
                table: "Users",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                "IX_Users_Login",
                schema: "User",
                table: "Users",
                column: "Login",
                unique: true,
                filter: "[Login] IS NOT NULL");

            migrationBuilder.CreateIndex(
                "IX_UsersLogs_UserId",
                schema: "User",
                table: "UsersLogs",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "UsersLogs",
                "User");

            migrationBuilder.DropTable(
                "Users",
                "User");
        }
    }
}
