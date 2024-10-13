using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServiceDataLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddedControllers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Roles_RoleId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_RoleId",
                table: "Cars");

            migrationBuilder.DeleteData(
                table: "CarStatuses",
                keyColumn: "Id",
                keyValue: new Guid("54063478-b0f8-40c2-8a94-8964b26f0292"));

            migrationBuilder.DeleteData(
                table: "CarStatuses",
                keyColumn: "Id",
                keyValue: new Guid("99d7790c-34ee-472b-beea-4a364b77fa7b"));

            migrationBuilder.DeleteData(
                table: "CarStatuses",
                keyColumn: "Id",
                keyValue: new Guid("b7c0609f-c5f6-422b-a493-d61456d57cab"));

            migrationBuilder.DeleteData(
                table: "CarStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ce6f0c96-e0ca-4be8-9e40-9a37faaba044"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("575f0f68-d1ed-458f-ba0c-36aa9a3b4e15"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c66d7158-1ef8-41ac-b552-e44992208c87"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dd89b50e-8d1c-43f7-90c6-c50d397714f5"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("04a9da98-89a7-4dfc-996a-6b80e9698f9d"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("0a4bc55c-fd9c-4989-a4a2-f9b0d615c6d9"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("2324d67e-0855-45f0-b46e-30982b47e40d"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("49022463-7571-44d1-a527-09c719fc8447"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("7e7f2190-6223-4f28-b560-cca3254535fd"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("a83470d3-82b0-42f9-afed-aca2dfc9045a"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("df59427d-e3d1-44fa-9890-1ae653483994"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("e603d3cb-c539-4eec-976b-cc733c874993"));

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Cars");

            migrationBuilder.InsertData(
                table: "CarStatuses",
                columns: new[] { "Id", "StatusName" },
                values: new object[,]
                {
                    { new Guid("94f0559f-d923-4873-809f-59b373dd4ddc"), 3 },
                    { new Guid("9f3a5565-6309-43dd-9da1-71c11114ce00"), 2 },
                    { new Guid("ef788967-e426-46ef-b5e8-f3aea49f50a4"), 0 },
                    { new Guid("fc8b6cec-db3c-4ee2-94fc-9ed17ea441c4"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4560f276-e2bd-4783-b7c4-bdbb86800dce"), 2 },
                    { new Guid("4cb29782-9531-4a4b-97e0-77737f043c01"), 1 },
                    { new Guid("ec9b6652-1ff5-4d1b-81c2-6ca3a61ea39d"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "Name", "ServicePrice" },
                values: new object[,]
                {
                    { new Guid("34dc2cb3-037d-4231-b962-dcfad91e9169"), 5, 0m },
                    { new Guid("387bf946-d1ce-4fde-892c-c9497df904bb"), 7, 0m },
                    { new Guid("3a2044ac-bd57-4101-87bb-3b0433839662"), 3, 0m },
                    { new Guid("3b0a4c42-e6c9-47bf-90be-d05e8df17a39"), 4, 0m },
                    { new Guid("6d3e850b-e320-46f5-b166-99c01f5e0584"), 3, 0m },
                    { new Guid("8b398794-9d2b-492f-ac1b-bb28b3374c82"), 1, 0m },
                    { new Guid("9b7b2104-f8c5-4dd7-9b1e-5614ecc0fb43"), 2, 0m },
                    { new Guid("b7795d96-8bf0-473e-abaa-ab58280ecac1"), 0, 0m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarStatuses",
                keyColumn: "Id",
                keyValue: new Guid("94f0559f-d923-4873-809f-59b373dd4ddc"));

            migrationBuilder.DeleteData(
                table: "CarStatuses",
                keyColumn: "Id",
                keyValue: new Guid("9f3a5565-6309-43dd-9da1-71c11114ce00"));

            migrationBuilder.DeleteData(
                table: "CarStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ef788967-e426-46ef-b5e8-f3aea49f50a4"));

            migrationBuilder.DeleteData(
                table: "CarStatuses",
                keyColumn: "Id",
                keyValue: new Guid("fc8b6cec-db3c-4ee2-94fc-9ed17ea441c4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4560f276-e2bd-4783-b7c4-bdbb86800dce"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4cb29782-9531-4a4b-97e0-77737f043c01"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ec9b6652-1ff5-4d1b-81c2-6ca3a61ea39d"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("34dc2cb3-037d-4231-b962-dcfad91e9169"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("387bf946-d1ce-4fde-892c-c9497df904bb"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("3a2044ac-bd57-4101-87bb-3b0433839662"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("3b0a4c42-e6c9-47bf-90be-d05e8df17a39"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("6d3e850b-e320-46f5-b166-99c01f5e0584"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("8b398794-9d2b-492f-ac1b-bb28b3374c82"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("9b7b2104-f8c5-4dd7-9b1e-5614ecc0fb43"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("b7795d96-8bf0-473e-abaa-ab58280ecac1"));

            migrationBuilder.AddColumn<Guid>(
                name: "RoleId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "CarStatuses",
                columns: new[] { "Id", "StatusName" },
                values: new object[,]
                {
                    { new Guid("54063478-b0f8-40c2-8a94-8964b26f0292"), 1 },
                    { new Guid("99d7790c-34ee-472b-beea-4a364b77fa7b"), 0 },
                    { new Guid("b7c0609f-c5f6-422b-a493-d61456d57cab"), 2 },
                    { new Guid("ce6f0c96-e0ca-4be8-9e40-9a37faaba044"), 3 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("575f0f68-d1ed-458f-ba0c-36aa9a3b4e15"), 1 },
                    { new Guid("c66d7158-1ef8-41ac-b552-e44992208c87"), 0 },
                    { new Guid("dd89b50e-8d1c-43f7-90c6-c50d397714f5"), 2 }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "Name", "ServicePrice" },
                values: new object[,]
                {
                    { new Guid("04a9da98-89a7-4dfc-996a-6b80e9698f9d"), 7, 0m },
                    { new Guid("0a4bc55c-fd9c-4989-a4a2-f9b0d615c6d9"), 3, 0m },
                    { new Guid("2324d67e-0855-45f0-b46e-30982b47e40d"), 2, 0m },
                    { new Guid("49022463-7571-44d1-a527-09c719fc8447"), 5, 0m },
                    { new Guid("7e7f2190-6223-4f28-b560-cca3254535fd"), 4, 0m },
                    { new Guid("a83470d3-82b0-42f9-afed-aca2dfc9045a"), 0, 0m },
                    { new Guid("df59427d-e3d1-44fa-9890-1ae653483994"), 1, 0m },
                    { new Guid("e603d3cb-c539-4eec-976b-cc733c874993"), 3, 0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_RoleId",
                table: "Cars",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Roles_RoleId",
                table: "Cars",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
