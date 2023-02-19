using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DaycareCenter.Migrations
{
    public partial class dx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DutySchedule");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropColumn(
                name: "D_shiftFrom",
                table: "ChildProfile");

            migrationBuilder.DropColumn(
                name: "D_shiftTo",
                table: "ChildProfile");

            migrationBuilder.DropColumn(
                name: "End_datetime",
                table: "ChildProfile");

            migrationBuilder.DropColumn(
                name: "M_shiftFrom",
                table: "ChildProfile");

            migrationBuilder.DropColumn(
                name: "M_shiftTo",
                table: "ChildProfile");

            migrationBuilder.DropColumn(
                name: "No_shift",
                table: "ChildProfile");

            migrationBuilder.DropColumn(
                name: "Start_datetime",
                table: "ChildProfile");

            migrationBuilder.CreateTable(
                name: "NanySchedule",
                columns: table => new
                {
                    Schedule_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Shift_Id = table.Column<int>(nullable: false),
                    Nany_Id = table.Column<int>(nullable: false),
                    Child_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NanySchedule", x => x.Schedule_Id);
                });

            migrationBuilder.CreateTable(
                name: "Shift",
                columns: table => new
                {
                    Shift_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Start_datetime = table.Column<DateTime>(nullable: false),
                    End_datetime = table.Column<DateTime>(nullable: false),
                    shift_No = table.Column<string>(nullable: false),
                    shift_Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shift", x => x.Shift_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NanySchedule");

            migrationBuilder.DropTable(
                name: "Shift");

            migrationBuilder.AddColumn<DateTime>(
                name: "D_shiftFrom",
                table: "ChildProfile",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "D_shiftTo",
                table: "ChildProfile",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "End_datetime",
                table: "ChildProfile",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "M_shiftFrom",
                table: "ChildProfile",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "M_shiftTo",
                table: "ChildProfile",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "No_shift",
                table: "ChildProfile",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Start_datetime",
                table: "ChildProfile",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "DutySchedule",
                columns: table => new
                {
                    sl = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    D_shiftFrom = table.Column<DateTime>(nullable: false),
                    D_shiftTo = table.Column<DateTime>(nullable: false),
                    End_datetime = table.Column<DateTime>(nullable: false),
                    M_shiftFrom = table.Column<DateTime>(nullable: false),
                    M_shiftTo = table.Column<DateTime>(nullable: false),
                    Nany_id = table.Column<string>(nullable: false),
                    No_shift = table.Column<string>(nullable: false),
                    Start_datetime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DutySchedule", x => x.sl);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    LId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Pass = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.LId);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Sl_No = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Hour_Rate = table.Column<float>(nullable: false),
                    Staying_Hour = table.Column<float>(nullable: false),
                    datetime = table.Column<DateTime>(nullable: false),
                    t_Payment = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Sl_No);
                });
        }
    }
}
