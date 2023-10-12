using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StripePaymentData.Migrations
{
    /// <inheritdoc />
    public partial class Update__Relationship_Payment_Process_Table_And_Order_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_ProductId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PaymentProcess_Id",
                table: "Orders");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentProcess_OrderId",
                table: "PaymentProcess",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentProcess_Orders_OrderId",
                table: "PaymentProcess",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentProcess_Orders_OrderId",
                table: "PaymentProcess");

            migrationBuilder.DropIndex(
                name: "IX_PaymentProcess_OrderId",
                table: "PaymentProcess");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_ProductId",
                table: "OrderItems",
                column: "ProductId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PaymentProcess_Id",
                table: "Orders",
                column: "Id",
                principalTable: "PaymentProcess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
