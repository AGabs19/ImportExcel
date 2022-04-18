using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImportExcel.Migrations
{
    public partial class ImportExcel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autorizacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObservacaoFuncionario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdGerente1 = table.Column<int>(type: "int", nullable: false),
                    ObservacaoGerente1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusGerente1 = table.Column<bool>(type: "bit", nullable: false),
                    IdGerente2 = table.Column<int>(type: "int", nullable: false),
                    ObservacaoGerente2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusGerente2 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autorizacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Longadouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    CEP = table.Column<int>(type: "int", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Historico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuantidadeDeDias = table.Column<int>(type: "int", nullable: false),
                    Venda = table.Column<bool>(type: "bit", nullable: false),
                    UltimoPeriodo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PeriodoAquisitivo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataDaContratacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimoPeriodo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodoAquisitivo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ferias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutorizacaoId1 = table.Column<int>(type: "int", nullable: true),
                    AutorizacaoId = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdiantamentoDecimoTerceiro = table.Column<bool>(type: "bit", nullable: false),
                    HistoricoId1 = table.Column<int>(type: "int", nullable: true),
                    HistoricoId = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AutorizacaoGerente1 = table.Column<bool>(type: "bit", nullable: false),
                    AutorizacaoGerente2 = table.Column<bool>(type: "bit", nullable: false),
                    PeriodoAquisitivoId1 = table.Column<int>(type: "int", nullable: true),
                    PeriodoAquisitivoId = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ferias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ferias_Autorizacao_AutorizacaoId1",
                        column: x => x.AutorizacaoId1,
                        principalTable: "Autorizacao",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ferias_Historico_HistoricoId1",
                        column: x => x.HistoricoId1,
                        principalTable: "Historico",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ferias_PeriodoAquisitivo_PeriodoAquisitivoId1",
                        column: x => x.PeriodoAquisitivoId1,
                        principalTable: "PeriodoAquisitivo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sobrenome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<int>(type: "int", nullable: false),
                    TelefoneId = table.Column<int>(type: "int", nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcionario_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Funcionario_Telefone_TelefoneId",
                        column: x => x.TelefoneId,
                        principalTable: "Telefone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contrato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salario = table.Column<double>(type: "float", nullable: false),
                    CargoId = table.Column<int>(type: "int", nullable: false),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contrato_Cargo_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contrato_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_CargoId",
                table: "Contrato",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_FuncionarioId",
                table: "Contrato",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_AutorizacaoId1",
                table: "Ferias",
                column: "AutorizacaoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_HistoricoId1",
                table: "Ferias",
                column: "HistoricoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_PeriodoAquisitivoId1",
                table: "Ferias",
                column: "PeriodoAquisitivoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_EnderecoId",
                table: "Funcionario",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_TelefoneId",
                table: "Funcionario",
                column: "TelefoneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contrato");

            migrationBuilder.DropTable(
                name: "Ferias");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Autorizacao");

            migrationBuilder.DropTable(
                name: "Historico");

            migrationBuilder.DropTable(
                name: "PeriodoAquisitivo");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Telefone");
        }
    }
}
