using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DaycareCenter.Migrations
{
    public partial class k : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChildProfile",
                columns: table => new
                {
                    Child_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Child_Name = table.Column<string>(nullable: false),
                    Age = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    Religion = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
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
                    table.PrimaryKey("PK_ChildProfile", x => x.Child_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChildProfile");
        }
    }
}
