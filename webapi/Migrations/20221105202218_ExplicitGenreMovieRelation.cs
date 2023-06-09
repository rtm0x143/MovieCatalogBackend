﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieCatalogBackend.Migrations
{
    public partial class ExplicitGenreMovieRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreMovie_Genre_GenresId",
                table: "GenreMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreMovie_Movie_MoviesId",
                table: "GenreMovie");

            migrationBuilder.RenameColumn(
                name: "MoviesId",
                table: "GenreMovie",
                newName: "GenreId");

            migrationBuilder.RenameColumn(
                name: "GenresId",
                table: "GenreMovie",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_GenreMovie_MoviesId",
                table: "GenreMovie",
                newName: "IX_GenreMovie_GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_GenreMovie_Genre_GenreId",
                table: "GenreMovie",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreMovie_Movie_MovieId",
                table: "GenreMovie",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreMovie_Genre_GenreId",
                table: "GenreMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreMovie_Movie_MovieId",
                table: "GenreMovie");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "GenreMovie",
                newName: "MoviesId");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "GenreMovie",
                newName: "GenresId");

            migrationBuilder.RenameIndex(
                name: "IX_GenreMovie_GenreId",
                table: "GenreMovie",
                newName: "IX_GenreMovie_MoviesId");

            migrationBuilder.AddForeignKey(
                name: "FK_GenreMovie_Genre_GenresId",
                table: "GenreMovie",
                column: "GenresId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreMovie_Movie_MoviesId",
                table: "GenreMovie",
                column: "MoviesId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
