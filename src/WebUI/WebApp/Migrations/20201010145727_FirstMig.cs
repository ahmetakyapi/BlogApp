using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class FirstMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dbPostComment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    postId = table.Column<int>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    published = table.Column<bool>(nullable: false),
                    publishedAt = table.Column<DateTime>(nullable: false),
                    content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbPostComment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbBiography",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    imagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbBiography", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbMenus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMenus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbPost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    authorID = table.Column<int>(nullable: false),
                    caption = table.Column<string>(nullable: true),
                    metaTitle = table.Column<string>(nullable: true),
                    summary = table.Column<string>(nullable: true),
                    published = table.Column<bool>(nullable: false),
                    publishedAt = table.Column<DateTime>(nullable: false),
                    content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbPost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbPostMeta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    postId = table.Column<int>(nullable: false),
                    key = table.Column<string>(nullable: true),
                    content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPostMeta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbPostTag",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    tagId = table.Column<int>(nullable: false),
                    postId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPostTag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbTag",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    metaTitle = table.Column<string>(nullable: true),
                    slug = table.Column<string>(nullable: true),
                    content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbTag", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "dbPostComment");

            migrationBuilder.DropTable(
                name: "TbBiography");

            migrationBuilder.DropTable(
                name: "tbMenus");

            migrationBuilder.DropTable(
                name: "TbPost");

            migrationBuilder.DropTable(
                name: "tbPostMeta");

            migrationBuilder.DropTable(
                name: "tbPostTag");

            migrationBuilder.DropTable(
                name: "tbTag");
        }
    }
}
