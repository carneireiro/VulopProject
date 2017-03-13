using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VulopNetCore.Data.Migrations
{
    public partial class FixServicesTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Services",
                table: "Blogs",
                column: "ID");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "Services");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Services",
                table: "Services");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogs",
                table: "Services",
                column: "ID");

            migrationBuilder.RenameTable(
                name: "Services",
                newName: "Blogs");
        }
    }
}
