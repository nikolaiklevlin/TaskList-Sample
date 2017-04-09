using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Contracts_Module_Sample.Migrations
{
    public partial class CreateAppsSchema2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isComleted",
                table: "Task",
                newName: "IsComleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsComleted",
                table: "Task",
                newName: "isComleted");
        }
    }
}
