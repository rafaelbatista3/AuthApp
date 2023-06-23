using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthApp.Migrations
{
    /// <inheritdoc />
    public partial class Orçamento_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Orçamentos_OrcamentoId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Orçamentos_OrcamentoId",
                table: "Servicos");

            migrationBuilder.DropIndex(
                name: "IX_Servicos_OrcamentoId",
                table: "Servicos");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_OrcamentoId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "OrcamentoId",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "OrcamentoId",
                table: "Clientes");

            migrationBuilder.CreateIndex(
                name: "IX_Orçamentos_ClientesId",
                table: "Orçamentos",
                column: "ClientesId");

            migrationBuilder.CreateIndex(
                name: "IX_Orçamentos_ServicosId",
                table: "Orçamentos",
                column: "ServicosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orçamentos_Clientes_ClientesId",
                table: "Orçamentos",
                column: "ClientesId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orçamentos_Servicos_ServicosId",
                table: "Orçamentos",
                column: "ServicosId",
                principalTable: "Servicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orçamentos_Clientes_ClientesId",
                table: "Orçamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Orçamentos_Servicos_ServicosId",
                table: "Orçamentos");

            migrationBuilder.DropIndex(
                name: "IX_Orçamentos_ClientesId",
                table: "Orçamentos");

            migrationBuilder.DropIndex(
                name: "IX_Orçamentos_ServicosId",
                table: "Orçamentos");

            migrationBuilder.AddColumn<int>(
                name: "OrcamentoId",
                table: "Servicos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrcamentoId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_OrcamentoId",
                table: "Servicos",
                column: "OrcamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_OrcamentoId",
                table: "Clientes",
                column: "OrcamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Orçamentos_OrcamentoId",
                table: "Clientes",
                column: "OrcamentoId",
                principalTable: "Orçamentos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Orçamentos_OrcamentoId",
                table: "Servicos",
                column: "OrcamentoId",
                principalTable: "Orçamentos",
                principalColumn: "Id");
        }
    }
}
