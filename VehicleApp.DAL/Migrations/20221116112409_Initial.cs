using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Busses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Busses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wheels = table.Column<int>(type: "int", nullable: false),
                    Headlights = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Boats",
                columns: new[] { "Id", "Brand", "Color", "CreationDate", "DeleteDate", "Model", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Duffy Boats", "White", new DateTime(2022, 11, 16, 14, 24, 9, 542, DateTimeKind.Local).AddTicks(2878), null, "SUN CRUISER 22", 1, null },
                    { 2, "Duffy Boats", "Blue", new DateTime(2022, 11, 16, 14, 24, 9, 542, DateTimeKind.Local).AddTicks(2881), null, "SUN CRUISER 22", 1, null },
                    { 3, "Duffy Boats", "Black", new DateTime(2022, 11, 16, 14, 24, 9, 542, DateTimeKind.Local).AddTicks(2884), null, "SUN CRUISER 22", 1, null },
                    { 4, "Duffy Boats", "Red", new DateTime(2022, 11, 16, 14, 24, 9, 542, DateTimeKind.Local).AddTicks(2886), null, "BAY ISLAND 22", 1, null },
                    { 5, "Duffy Boats", "White", new DateTime(2022, 11, 16, 14, 24, 9, 542, DateTimeKind.Local).AddTicks(2888), null, "BAY ISLAND 22", 1, null },
                    { 6, "Duffy Boats", "Blue", new DateTime(2022, 11, 16, 14, 24, 9, 542, DateTimeKind.Local).AddTicks(2890), null, "BAY ISLAND 22", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Busses",
                columns: new[] { "Id", "Brand", "Color", "CreationDate", "DeleteDate", "Model", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Karsan", "Red", new DateTime(2022, 11, 16, 14, 24, 9, 542, DateTimeKind.Local).AddTicks(2866), null, "e-ATAK", 1, null },
                    { 2, "Karsan", "Blue", new DateTime(2022, 11, 16, 14, 24, 9, 542, DateTimeKind.Local).AddTicks(2869), null, "e-ATAK", 1, null },
                    { 3, "Karsan", "White", new DateTime(2022, 11, 16, 14, 24, 9, 542, DateTimeKind.Local).AddTicks(2871), null, "e-ATAK", 1, null },
                    { 4, "Karsan", "Black", new DateTime(2022, 11, 16, 14, 24, 9, 542, DateTimeKind.Local).AddTicks(2872), null, "e-ATA 10", 1, null },
                    { 5, "Karsan", "White", new DateTime(2022, 11, 16, 14, 24, 9, 542, DateTimeKind.Local).AddTicks(2874), null, "e-ATA 10", 1, null },
                    { 6, "Karsan", "Blue", new DateTime(2022, 11, 16, 14, 24, 9, 542, DateTimeKind.Local).AddTicks(2876), null, "e-ATA 10", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Color", "CreationDate", "DeleteDate", "Headlights", "Model", "Status", "UpdateDate", "Wheels" },
                values: new object[,]
                {
                    { 1, "Tesla", "Red", new DateTime(2022, 11, 16, 14, 24, 9, 542, DateTimeKind.Local).AddTicks(2834), null, false, "S", 1, null, 4 },
                    { 2, "Tesla", "Black", new DateTime(2022, 11, 16, 14, 24, 9, 542, DateTimeKind.Local).AddTicks(2852), null, false, "S", 1, null, 4 },
                    { 3, "Tesla", "Blue", new DateTime(2022, 11, 16, 14, 24, 9, 542, DateTimeKind.Local).AddTicks(2855), null, false, "S", 1, null, 4 },
                    { 4, "Togg", "Red", new DateTime(2022, 11, 16, 14, 24, 9, 542, DateTimeKind.Local).AddTicks(2856), null, false, "C-SUV", 1, null, 4 },
                    { 5, "Togg", "White", new DateTime(2022, 11, 16, 14, 24, 9, 542, DateTimeKind.Local).AddTicks(2858), null, false, "C-SUV", 1, null, 4 },
                    { 6, "Togg", "Blue", new DateTime(2022, 11, 16, 14, 24, 9, 542, DateTimeKind.Local).AddTicks(2861), null, false, "C-SUV", 1, null, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boats");

            migrationBuilder.DropTable(
                name: "Busses");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
