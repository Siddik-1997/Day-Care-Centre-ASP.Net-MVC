using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DaycareCenter.Migrations
{
    public partial class jj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NanyProfile",
                columns: table => new
                {
                    Nany_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nany_Name = table.Column<string>(nullable: false),
                    NAge = table.Column<string>(nullable: false),
                    NGender = table.Column<string>(nullable: false),
                    NReligion = table.Column<string>(nullable: false),
                    NPhone = table.Column<string>(nullable: false),
                    NAddress = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NanyProfile", x => x.Nany_Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Sl_No = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Staying_Hour = table.Column<float>(nullable: false),
                    Hour_Rate = table.Column<float>(nullable: false),
                    t_Payment = table.Column<float>(nullable: false),
                    datetime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Sl_No);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NanyProfile");

            migrationBuilder.DropTable(
                name: "Payment");
        }
    }
}
