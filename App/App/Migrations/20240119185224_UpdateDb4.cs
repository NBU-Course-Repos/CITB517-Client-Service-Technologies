using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Migrations
{
    public partial class UpdateDb4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_CommentatorEmailAddress",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Medias_Users_OwnerEmailAddress",
                table: "Medias");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CommentatorEmailAddress",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CommentatorEmailAddress",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "OwnerEmailAddress",
                table: "Medias",
                newName: "OwnerEmail");

            migrationBuilder.RenameIndex(
                name: "IX_Medias_OwnerEmailAddress",
                table: "Medias",
                newName: "IX_Medias_OwnerEmail");

            migrationBuilder.AlterColumn<string>(
                name: "CommentatorEmail",
                table: "Comments",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CommentatorEmail",
                table: "Comments",
                column: "CommentatorEmail");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_CommentatorEmail",
                table: "Comments",
                column: "CommentatorEmail",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_Users_OwnerEmail",
                table: "Medias",
                column: "OwnerEmail",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_CommentatorEmail",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Medias_Users_OwnerEmail",
                table: "Medias");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CommentatorEmail",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "EmailAddress");

            migrationBuilder.RenameColumn(
                name: "OwnerEmail",
                table: "Medias",
                newName: "OwnerEmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_Medias_OwnerEmail",
                table: "Medias",
                newName: "IX_Medias_OwnerEmailAddress");

            migrationBuilder.AlterColumn<string>(
                name: "CommentatorEmail",
                table: "Comments",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CommentatorEmailAddress",
                table: "Comments",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CommentatorEmailAddress",
                table: "Comments",
                column: "CommentatorEmailAddress");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_CommentatorEmailAddress",
                table: "Comments",
                column: "CommentatorEmailAddress",
                principalTable: "Users",
                principalColumn: "EmailAddress",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_Users_OwnerEmailAddress",
                table: "Medias",
                column: "OwnerEmailAddress",
                principalTable: "Users",
                principalColumn: "EmailAddress",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
