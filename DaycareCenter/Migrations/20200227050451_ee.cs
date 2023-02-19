using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DaycareCenter.Migrations
{
    public partial class ee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DutySchedule",
                columns: table => new
                {
                    sl = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nany_id = table.Column<string>(nullable: false),
                    Start_datetime = table.Column<DateTime>(nullable: false),
                    End_datetime = table.Column<DateTime>(nullable: false),
                    No_shift = table.Column<string>(nullable: false),
                    D_shiftFrom = table.Column<DateTime>(nullable: false),
                    D_shiftTo = table.Column<DateTime>(nullable: false),
                    M_shiftFrom = table.Column<DateTime>(nullable: false),
                    M_shiftTo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DutySchedule", x => x.sl);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DutySchedule");
        }
    }
}
