using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace To_Do_List.Migrations
{
    /// <inheritdoc />
    public partial class deleteSomeAtributesFromModelTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeLimitTime",
                table: "Task");

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeTaskCreated",
                value: new DateTime(2023, 12, 26, 18, 45, 55, 445, DateTimeKind.Local).AddTicks(3675));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TimeLimitTime",
                table: "Task",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeLimitTime", "TimeTaskCreated" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 26, 18, 28, 2, 762, DateTimeKind.Local).AddTicks(5151) });
        }
    }
}
