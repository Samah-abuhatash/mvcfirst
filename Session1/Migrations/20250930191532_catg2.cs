using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session1.Migrations
{
    /// <inheritdoc />
    public partial class catg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categorys");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys");

            migrationBuilder.RenameTable(
                name: "Categorys",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");
        }
    }
}
