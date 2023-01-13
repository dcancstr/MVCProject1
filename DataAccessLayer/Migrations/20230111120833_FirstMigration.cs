    using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AboutDetails1 = table.Column<string>(type: "text", nullable: false),
                    AboutDetails2 = table.Column<string>(type: "text", nullable: false),
                    AboutImgae1 = table.Column<string>(type: "text", nullable: false),
                    AboutImgae2 = table.Column<string>(type: "text", nullable: false),
                    AboutMapLocation = table.Column<string>(type: "text", nullable: false),
                    AboutStatus = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BlogTitle = table.Column<string>(type: "text", nullable: false),
                    BlogContent = table.Column<string>(type: "text", nullable: false),
                    BlogThumbnailImage = table.Column<string>(type: "text", nullable: false),
                    BlogImage = table.Column<string>(type: "text", nullable: false),
                    BlogCreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BlogStatus = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
