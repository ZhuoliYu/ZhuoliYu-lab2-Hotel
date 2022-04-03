using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab1_DataAnnotations_Hotel.Migrations
{
    public partial class initialllise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Client",
                type: "varchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Client",
                type: "varchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Credit",
                columns: table => new
                {
                    CreditNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsValid = table.Column<bool>(type: "bit", nullable: false),
                    HolderName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credit", x => x.CreditNumber);
                    table.ForeignKey(
                        name: "FK_Credit_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });


            migrationBuilder.CreateTable(
                name: "CurrentlyBooking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentClientId = table.Column<int>(type: "int", nullable: false),
                    CurrentRoomNumber = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentlyBooking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrentlyBooking_Client_CurrentClientId",
                        column: x => x.CurrentClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentlyBooking_Room_CurrentRoomNumber",
                        column: x => x.CurrentRoomNumber,
                        principalTable: "Room",
                        principalColumn: "RoomNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreviouslyBooking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PreviousClientId = table.Column<int>(type: "int", nullable: false),
                    PreviousRoomNumber = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreviouslyBooking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreviouslyBooking_Client_PreviousClientId",
                        column: x => x.PreviousClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreviouslyBooking_Room_PreviousRoomNumber",
                        column: x => x.PreviousRoomNumber,
                        principalTable: "Room",
                        principalColumn: "RoomNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Credit_ClientId",
                table: "Credit",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentlyBooking_CurrentClientId",
                table: "CurrentlyBooking",
                column: "CurrentClientId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentlyBooking_CurrentRoomNumber",
                table: "CurrentlyBooking",
                column: "CurrentRoomNumber");

            migrationBuilder.CreateIndex(
                name: "IX_PreviouslyBooking_PreviousClientId",
                table: "PreviouslyBooking",
                column: "PreviousClientId");

            migrationBuilder.CreateIndex(
                name: "IX_PreviouslyBooking_PreviousRoomNumber",
                table: "PreviouslyBooking",
                column: "PreviousRoomNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Credit");

            migrationBuilder.DropTable(
                name: "CurrentlyBooking");

            migrationBuilder.DropTable(
                name: "PreviouslyBooking");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Client",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldMaxLength: 25,
                oldNullable: true);
        }
    }
}
