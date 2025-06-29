using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class Seedingdatafordifficultiesandregions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9163de00-a8e3-4b2f-af26-dd536b1d59cb"), "Medium" },
                    { new Guid("dce0b3ae-f57d-4cce-9425-fde015e2c7b5"), "Easy" },
                    { new Guid("f8ed408d-2969-4aba-a93f-fb4cf17b19db"), "Hard" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("276a7602-ceb8-4700-997a-0f9a7b14ae24"), "WGN", "Wellington", "https://images.app.goo.gl/HAk8CB4PWHJRCzkT8" },
                    { new Guid("36809860-36b9-426b-b6ee-16f7bab876c9"), "BOP", "Bay Of Plenty", "https://images.app.goo.gl/qGgEnHCn1fnjriic6" },
                    { new Guid("6647e810-48d2-497d-b241-dba58edcf80c"), "AKL", "Northland", "https://images.app.goo.gl/WhFEsqvb9fcf543J8" },
                    { new Guid("6ca36f10-d705-4ace-b903-8cdb01532f70"), "NSN", "Nelson", "https://images.app.goo.gl/JvLtU9r7EjnRgZ5CA" },
                    { new Guid("f8ed408d-2969-4aba-a93f-fb4cf17b19db"), "AKL", "Auckland", "https://images.app.goo.gl/a68tjnGNah5b9bdVA" },
                    { new Guid("ff4e4220-d272-423d-8527-5c583211ba4a"), "STL", "Southland", "https://images.app.goo.gl/ZR3tV6Spoi8YZK9Y6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("9163de00-a8e3-4b2f-af26-dd536b1d59cb"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("dce0b3ae-f57d-4cce-9425-fde015e2c7b5"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("f8ed408d-2969-4aba-a93f-fb4cf17b19db"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("276a7602-ceb8-4700-997a-0f9a7b14ae24"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("36809860-36b9-426b-b6ee-16f7bab876c9"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("6647e810-48d2-497d-b241-dba58edcf80c"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("6ca36f10-d705-4ace-b903-8cdb01532f70"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f8ed408d-2969-4aba-a93f-fb4cf17b19db"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("ff4e4220-d272-423d-8527-5c583211ba4a"));
        }
    }
}
