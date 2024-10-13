using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServiceDataLayer.Migrations
{
    /// <inheritdoc />
    public partial class SomeChangesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId1",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "CarStatuses",
                keyColumn: "Id",
                keyValue: new Guid("74321073-8a2e-4e58-b7fb-2a60908c2e09"));

            migrationBuilder.DeleteData(
                table: "CarStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c1618794-64bf-4422-827a-f571daba4f08"));

            migrationBuilder.DeleteData(
                table: "CarStatuses",
                keyColumn: "Id",
                keyValue: new Guid("eb3b2f7b-1669-4188-80ca-0f1b8286f257"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "RoleId1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ServiceName",
                table: "ServiceTypes");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "ServiceTypes",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Name",
                table: "ServiceTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Roles",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Roles",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "StatusName",
                table: "CarStatuses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoleId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

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
                name: "Name",
                table: "ServiceTypes");

            migrationBuilder.AddColumn<int>(
                name: "RoleId1",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ServiceTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "ServiceName",
                table: "ServiceTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Roles",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "StatusName",
                table: "CarStatuses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Cars",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "CarStatuses",
                columns: new[] { "Id", "StatusName" },
                values: new object[,]
                {
                    { new Guid("74321073-8a2e-4e58-b7fb-2a60908c2e09"), "Pending" },
                    { new Guid("c1618794-64bf-4422-827a-f571daba4f08"), "Completed" },
                    { new Guid("eb3b2f7b-1669-4188-80ca-0f1b8286f257"), "InProgress" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "User" },
                    { 2, "Admin" },
                    { 3, "SuperAdmin" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "ServiceName", "ServicePrice" },
                values: new object[,]
                {
                    { 1, "Oil Change", 0m },
                    { 2, "Tire Rotation", 0m },
                    { 3, "Brake Inspection", 0m },
                    { 4, "Engine Diagnostic", 0m },
                    { 5, "Battery Replacement", 0m },
                    { 6, "Transmission Repair", 0m },
                    { 7, "Wheel Alignment", 0m },
                    { 8, "Air Conditioning Service", 0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId1",
                table: "Users",
                column: "RoleId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId1",
                table: "Users",
                column: "RoleId1",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
