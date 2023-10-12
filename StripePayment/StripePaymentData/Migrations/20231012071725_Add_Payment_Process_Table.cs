using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StripePaymentData.Migrations
{
    /// <inheritdoc />
    public partial class Add_Payment_Process_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentProcess",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SessionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentProcess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentProcess_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentProcess_Users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentProcess_CreatedById",
                table: "PaymentProcess",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentProcess_UpdatedById",
                table: "PaymentProcess",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PaymentProcess_Id",
                table: "Orders",
                column: "Id",
                principalTable: "PaymentProcess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PaymentProcess_Id",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "PaymentProcess");
        }
    }
}
