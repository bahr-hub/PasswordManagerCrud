using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PasswordManagerCrud.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    UserPk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('0001-01-01T00:00:00.0000000')"),
                    CreationTimeStamp = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "(CONVERT([bigint],(0)))"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "('0001-01-01T00:00:00.0000000')"),
                    UpdateDateStamp = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "(CONVERT([bigint],(0)))"),
                    DeleteBy = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "('0001-01-01T00:00:00.0000000')"),
                    DeleteDateStamp = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "(CONVERT([bigint],(0)))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.UserPk);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserInfo");
        }
    }
}
