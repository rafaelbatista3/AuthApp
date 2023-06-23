using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthApp.Migrations
{
    /// <inheritdoc />
    public partial class TesteiCollection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orçamentos_Servicos_ServicosId",
                table: "Orçamentos");

            migrationBuilder.DropIndex(
                name: "IX_Orçamentos_ServicosId",
                table: "Orçamentos");

            migrationBuilder.AddColumn<int>(
                name: "OrcamentoId",
                table: "Servicos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_OrcamentoId",
                table: "Servicos",
                column: "OrcamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Orçamentos_OrcamentoId",
                table: "Servicos",
                column: "OrcamentoId",
                principalTable: "Orçamentos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Orçamentos_OrcamentoId",
                table: "Servicos");

            migrationBuilder.DropIndex(
                name: "IX_Servicos_OrcamentoId",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "OrcamentoId",
                table: "Servicos");

            migrationBuilder.CreateIndex(
                name: "IX_Orçamentos_ServicosId",
                table: "Orçamentos",
                column: "ServicosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orçamentos_Servicos_ServicosId",
                table: "Orçamentos",
                column: "ServicosId",
                principalTable: "Servicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
