using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestTaskApp.Migrations
{
    public partial class newDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserContacts_userContactId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "userContactId",
                table: "Users",
                newName: "UserContactId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_userContactId",
                table: "Users",
                newName: "IX_Users_UserContactId");

            migrationBuilder.AlterColumn<int>(
                name: "UserContactId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserContacts_UserContactId",
                table: "Users",
                column: "UserContactId",
                principalTable: "UserContacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserContacts_UserContactId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserContactId",
                table: "Users",
                newName: "userContactId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UserContactId",
                table: "Users",
                newName: "IX_Users_userContactId");

            migrationBuilder.AlterColumn<int>(
                name: "userContactId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserContacts_userContactId",
                table: "Users",
                column: "userContactId",
                principalTable: "UserContacts",
                principalColumn: "Id");
        }
    }
}
