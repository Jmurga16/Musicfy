using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.EFCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Artist", "ImageURL", "Name", "Status", "Year" },
                values: new object[] { 1, "Bad Bunny", "https://i1.sndcdn.com/artworks-lJMUnZEnRcJBpzvx-DftmXA-t500x500.jpg", "El Ultimo Tour del Mundo", true, 2020 });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Artist", "ImageURL", "Name", "Status", "Year" },
                values: new object[] { 2, "Morat", "https://master.com.ar/wp-content/uploads/0157657001625861386.jpg", "¿A Donde Vamos?", true, 2021 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
