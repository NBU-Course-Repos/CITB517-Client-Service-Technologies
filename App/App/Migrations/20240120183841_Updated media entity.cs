using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Migrations
{
    public partial class Updatedmediaentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medias_Users_OwnerEmail",
                table: "Medias");

            migrationBuilder.RenameColumn(
                name: "OwnerEmail",
                table: "Medias",
                newName: "UploaderEmail");

            migrationBuilder.RenameIndex(
                name: "IX_Medias_OwnerEmail",
                table: "Medias",
                newName: "IX_Medias_UploaderEmail");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Timestamp",
                table: "Medias",
                type: "datetime(6)",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AddColumn<string>(
                name: "FileExtension",
                table: "Medias",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "MediaId",
                table: "Comments",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MediaId",
                table: "Comments",
                column: "MediaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Medias_MediaId",
                table: "Comments",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_Users_UploaderEmail",
                table: "Medias",
                column: "UploaderEmail",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Medias_MediaId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Medias_Users_UploaderEmail",
                table: "Medias");

            migrationBuilder.DropIndex(
                name: "IX_Comments_MediaId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "FileExtension",
                table: "Medias");

            migrationBuilder.DropColumn(
                name: "MediaId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "UploaderEmail",
                table: "Medias",
                newName: "OwnerEmail");

            migrationBuilder.RenameIndex(
                name: "IX_Medias_UploaderEmail",
                table: "Medias",
                newName: "IX_Medias_OwnerEmail");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Timestamp",
                table: "Medias",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldRowVersion: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_Users_OwnerEmail",
                table: "Medias",
                column: "OwnerEmail",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
