using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthApp.Migrations
{
    /// <inheritdoc />
    public partial class Orçamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Servicos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Servicos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrcamentoId",
                table: "Servicos",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrcamentoId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Orçamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientesId = table.Column<int>(type: "int", nullable: false),
                    ServicosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orçamentos", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Orçamentos_OrcamentoId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Orçamentos_OrcamentoId",
                table: "Servicos");

            migrationBuilder.DropTable(
                name: "Orçamentos");

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

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Servicos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Servicos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
