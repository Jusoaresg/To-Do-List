using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace To_Do_List.Migrations
{
    /// <inheritdoc />
    public partial class addDescritionsToTasksModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Task",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "TimeTaskCreated" },
                values: new object[] { null, new DateTime(2023, 12, 26, 18, 28, 2, 762, DateTimeKind.Local).AddTicks(5151) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Task");

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeTaskCreated",
                value: new DateTime(2023, 12, 26, 15, 32, 12, 984, DateTimeKind.Local).AddTicks(7755));
        }
    }
}
