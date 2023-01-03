using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestTaskApp.Migrations
{
    public partial class emailUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "userContactId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_userContactId",
                table: "Users",
                column: "userContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserContacts_userContactId",
                table: "Users",
                column: "userContactId",
                principalTable: "UserContacts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserContacts_userContactId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_userContactId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "userContactId",
                table: "Users");
        }
    }
}
