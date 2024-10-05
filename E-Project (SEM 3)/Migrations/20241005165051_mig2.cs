using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Project__SEM_3_.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_StationeryItems_ItemId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Users_UserId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_SuperiorId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SuperiorId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StationeryItems",
                table: "StationeryItems");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SuperiorId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ApprovedAt",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "CancelledAt",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "WithdrawnAt",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "SystemLogin",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "ItemName",
                table: "StationeryItems",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "StationeryItems",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Requests",
                newName: "StationeryItemId");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Requests",
                newName: "RequestorId");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_UserId",
                table: "Requests",
                newName: "IX_Requests_StationeryItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_ItemId",
                table: "Requests",
                newName: "IX_Requests_RequestorId");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "StationeryItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "StationeryItemId",
                table: "StationeryItems",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "QuantityRequested",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StationeryItems",
                table: "StationeryItems",
                column: "StationeryItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_StationeryItems_StationeryItemId",
                table: "Requests",
                column: "StationeryItemId",
                principalTable: "StationeryItems",
                principalColumn: "StationeryItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Users_RequestorId",
                table: "Requests",
                column: "RequestorId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_StationeryItems_StationeryItemId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Users_RequestorId",
                table: "Requests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StationeryItems",
                table: "StationeryItems");

            migrationBuilder.DropColumn(
                name: "StationeryItemId",
                table: "StationeryItems");

            migrationBuilder.DropColumn(
                name: "QuantityRequested",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "SystemLogin");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "StationeryItems",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "StationeryItems",
                newName: "ItemName");

            migrationBuilder.RenameColumn(
                name: "StationeryItemId",
                table: "Requests",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "RequestorId",
                table: "Requests",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_StationeryItemId",
                table: "Requests",
                newName: "IX_Requests_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_RequestorId",
                table: "Requests",
                newName: "IX_Requests_ItemId");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SuperiorId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "StationeryItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Requests",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovedAt",
                table: "Requests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CancelledAt",
                table: "Requests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "WithdrawnAt",
                table: "Requests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StationeryItems",
                table: "StationeryItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SuperiorId",
                table: "Users",
                column: "SuperiorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_StationeryItems_ItemId",
                table: "Requests",
                column: "ItemId",
                principalTable: "StationeryItems",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Users_UserId",
                table: "Requests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_SuperiorId",
                table: "Users",
                column: "SuperiorId",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
