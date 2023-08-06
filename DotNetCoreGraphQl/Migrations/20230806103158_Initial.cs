using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotNetCoreGraphQl.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Superheroes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superheroes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instructor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SuperheroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Superheroes_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Superpowers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SuperPower = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperheroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superpowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Superpowers_Superheroes_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("27e0f5ce-4e45-4854-84ff-2d0e42dfcf60"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", "1.70", "Black Widow" },
                    { new Guid("5ed0d038-3525-4c7a-b243-fa7c5f5a2aa9"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", "1.93", "Batman" },
                    { new Guid("77f12ed9-2087-4b87-bfcf-b87d91b34c12"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", "1.70", "Luke Skywalker" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("25287ab9-8f4b-4b96-8afa-3707188c9514"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("77f12ed9-2087-4b87-bfcf-b87d91b34c12"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("29140fdd-b0c6-4d37-b1dd-9847fd945fe3"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("77f12ed9-2087-4b87-bfcf-b87d91b34c12"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("3c311722-f99e-42f1-a87b-db835ea1fb39"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5ed0d038-3525-4c7a-b243-fa7c5f5a2aa9"), "Batman Begins" },
                    { new Guid("5dcaa83a-e4c9-4d7b-a9ac-2f871af552ec"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("77f12ed9-2087-4b87-bfcf-b87d91b34c12"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("8842e0bf-4763-4004-82ca-d0f0d9de532d"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5ed0d038-3525-4c7a-b243-fa7c5f5a2aa9"), "The Dark Knight Rises" },
                    { new Guid("caa82aa4-ff20-4485-843d-29432ac91268"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("27e0f5ce-4e45-4854-84ff-2d0e42dfcf60"), "Black Widow" },
                    { new Guid("cd7c3f63-98a2-427e-9e5f-fb3fa12f4c96"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5ed0d038-3525-4c7a-b243-fa7c5f5a2aa9"), "The Dark Knight" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("02c409c0-6e5f-4975-91ef-150cfedc90dd"), "Sublime fighting skills.", "Fighting", new Guid("5ed0d038-3525-4c7a-b243-fa7c5f5a2aa9") },
                    { new Guid("0389393e-cbf7-4ed3-864f-c71af2a6b6b2"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("77f12ed9-2087-4b87-bfcf-b87d91b34c12") },
                    { new Guid("23dae16f-80ed-465e-be38-c74adeb7a5af"), "He got a lot of money", "Wealth.", new Guid("5ed0d038-3525-4c7a-b243-fa7c5f5a2aa9") },
                    { new Guid("275f1bba-32b4-4723-a5d1-d06af0bbbb07"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("27e0f5ce-4e45-4854-84ff-2d0e42dfcf60") },
                    { new Guid("4630307b-96a5-4a83-8d0d-c5cfa74b4afc"), "He's always a step ahead.", "Intellect.", new Guid("5ed0d038-3525-4c7a-b243-fa7c5f5a2aa9") },
                    { new Guid("c5668721-727a-42b3-ae4a-0fdf4bbf43e9"), "She's good at spying at people.", "Espionage", new Guid("27e0f5ce-4e45-4854-84ff-2d0e42dfcf60") },
                    { new Guid("fd0664c4-a3c4-4d2c-9111-11e0d4dcbf86"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("27e0f5ce-4e45-4854-84ff-2d0e42dfcf60") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_SuperheroId",
                table: "Movies",
                column: "SuperheroId");

            migrationBuilder.CreateIndex(
                name: "IX_Superpowers_SuperheroId",
                table: "Superpowers",
                column: "SuperheroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Superpowers");

            migrationBuilder.DropTable(
                name: "Superheroes");
        }
    }
}
