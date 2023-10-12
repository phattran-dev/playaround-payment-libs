using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StripePaymentData.Migrations
{
    /// <inheritdoc />
    public partial class Update_Payment_Process_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentProcess_Users_CreatedById",
                table: "PaymentProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentProcess_Users_UpdatedById",
                table: "PaymentProcess");

            migrationBuilder.DropIndex(
                name: "IX_PaymentProcess_CreatedById",
                table: "PaymentProcess");

            migrationBuilder.DropIndex(
                name: "IX_PaymentProcess_UpdatedById",
                table: "PaymentProcess");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "PaymentProcess");

            migrationBuilder.DropColumn(
                name: "CreatedDateUtc",
                table: "PaymentProcess");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PaymentProcess");

            migrationBuilder.DropColumn(
                name: "UpdateDateUtc",
                table: "PaymentProcess");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "PaymentProcess");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "PaymentProcess",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "PaymentProcess",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PaymentProcess",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateUtc",
                table: "PaymentProcess",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "PaymentProcess",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_PaymentProcess_CreatedById",
                table: "PaymentProcess",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentProcess_UpdatedById",
                table: "PaymentProcess",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentProcess_Users_CreatedById",
                table: "PaymentProcess",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentProcess_Users_UpdatedById",
                table: "PaymentProcess",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
