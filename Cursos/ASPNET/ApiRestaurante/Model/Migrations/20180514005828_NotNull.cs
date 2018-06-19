using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Model.Migrations
{
    public partial class NotNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuRestaurantes_Menus_MenuId",
                table: "MenuRestaurantes");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuRestaurantes_Restaurantes_RestauranteId",
                table: "MenuRestaurantes");

            migrationBuilder.AlterColumn<Guid>(
                name: "RestauranteId",
                table: "MenuRestaurantes",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MenuId",
                table: "MenuRestaurantes",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuRestaurantes_Menus_MenuId",
                table: "MenuRestaurantes",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuRestaurantes_Restaurantes_RestauranteId",
                table: "MenuRestaurantes",
                column: "RestauranteId",
                principalTable: "Restaurantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuRestaurantes_Menus_MenuId",
                table: "MenuRestaurantes");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuRestaurantes_Restaurantes_RestauranteId",
                table: "MenuRestaurantes");

            migrationBuilder.AlterColumn<Guid>(
                name: "RestauranteId",
                table: "MenuRestaurantes",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "MenuId",
                table: "MenuRestaurantes",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_MenuRestaurantes_Menus_MenuId",
                table: "MenuRestaurantes",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuRestaurantes_Restaurantes_RestauranteId",
                table: "MenuRestaurantes",
                column: "RestauranteId",
                principalTable: "Restaurantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
