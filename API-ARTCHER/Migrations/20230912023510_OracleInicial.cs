using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_ARTCHER.Migrations
{
    /// <inheritdoc />
    public partial class OracleInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    UserName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TIMESTAMP(7) WITH TIME ZONE", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filiais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NomeDaFilial = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Contato = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Endereco = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Numero = table.Column<int>(type: "NUMBER(10)", maxLength: 30, nullable: false),
                    Bairro = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Descricao = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    Foto = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Data = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_Cad_Usu",
                columns: table => new
                {
                    Id_Usr = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Cpf = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Cad_Usu", x => x.Id_Usr);
                });

            migrationBuilder.CreateTable(
                name: "T_Prod_Parc",
                columns: table => new
                {
                    Id_Prd = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Valor = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Descricao = table.Column<string>(type: "NVARCHAR2(60)", maxLength: 60, nullable: false),
                    Foto = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Adicionais = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Nome_Produto = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Prod_Parc", x => x.Id_Prd);
                });

            migrationBuilder.CreateTable(
                name: "T_Rede_Soc",
                columns: table => new
                {
                    Id_Feed = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Curtida = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Foto_Postagem = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Comentario = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Rede_Soc", x => x.Id_Feed);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Senha = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Usuario = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Data = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    RoleId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ClaimValue = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    UserId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ClaimValue = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    UserId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    RoleId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Value = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_PST",
                columns: table => new
                {
                    Id_Pst = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Avaliacao = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Indicacao = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Data = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    t_cad_usu_id_usr = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_PST", x => x.Id_Pst);
                    table.ForeignKey(
                        name: "FK_T_PST_T_Cad_Usu_t_cad_usu_id_usr",
                        column: x => x.t_cad_usu_id_usr,
                        principalTable: "T_Cad_Usu",
                        principalColumn: "Id_Usr",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_Card_Parc",
                columns: table => new
                {
                    Id_Card = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Data = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Cardapio = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Valores = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Descricao_Extra = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    T_PROD_PARC_id_prd = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ProdutoParceiroId_Prd = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Card_Parc", x => x.Id_Card);
                    table.ForeignKey(
                        name: "FK_T_Card_Parc_T_Prod_Parc_ProdutoParceiroId_Prd",
                        column: x => x.ProdutoParceiroId_Prd,
                        principalTable: "T_Prod_Parc",
                        principalColumn: "Id_Prd");
                    table.ForeignKey(
                        name: "FK_T_Card_Parc_T_Prod_Parc_T_PROD_PARC_id_prd",
                        column: x => x.T_PROD_PARC_id_prd,
                        principalTable: "T_Prod_Parc",
                        principalColumn: "Id_Prd",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_Cad_Parc",
                columns: table => new
                {
                    Id_Parc = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Cnpj = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Tipo_Especialidade = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Servicos = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Valor_Medio = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Descricao = table.Column<string>(type: "NVARCHAR2(500)", maxLength: 500, nullable: false),
                    t_card_parc_id_card = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    t_card_parc_T_PROD_PARC_id_prd = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ProdutoParceiroId_Prd = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Cad_Parc", x => x.Id_Parc);
                    table.ForeignKey(
                        name: "FK_T_Cad_Parc_T_Card_Parc_t_card_parc_id_card",
                        column: x => x.t_card_parc_id_card,
                        principalTable: "T_Card_Parc",
                        principalColumn: "Id_Card",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Cad_Parc_T_Prod_Parc_ProdutoParceiroId_Prd",
                        column: x => x.ProdutoParceiroId_Prd,
                        principalTable: "T_Prod_Parc",
                        principalColumn: "Id_Prd");
                    table.ForeignKey(
                        name: "FK_T_Cad_Parc_T_Prod_Parc_t_card_parc_T_PROD_PARC_id_prd",
                        column: x => x.t_card_parc_T_PROD_PARC_id_prd,
                        principalTable: "T_Prod_Parc",
                        principalColumn: "Id_Prd",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_End",
                columns: table => new
                {
                    Id_End = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    logradouro = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Uf = table.Column<string>(type: "NVARCHAR2(2)", maxLength: 2, nullable: false),
                    Cep = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Numero = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Foto = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LoginId_Log = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    UsuarioConvidadoId_ind = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_End", x => x.Id_End);
                });

            migrationBuilder.CreateTable(
                name: "T_Login",
                columns: table => new
                {
                    Id_Log = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Email = table.Column<string>(type: "NVARCHAR2(40)", maxLength: 40, nullable: false),
                    Senha = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Nome = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Telefone = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Foto = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    t_cad_parc_id_parc = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    t_end_id_end = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    t_rede_soc_id_feed = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    t_cad_usu_id_usr = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CadUsuarioId_Usr = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    RedeSocialId_Feed = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Login", x => x.Id_Log);
                    table.UniqueConstraint("AK_T_Login_t_end_id_end", x => x.t_end_id_end);
                    table.ForeignKey(
                        name: "FK_T_Login_T_Cad_Parc_t_cad_parc_id_parc",
                        column: x => x.t_cad_parc_id_parc,
                        principalTable: "T_Cad_Parc",
                        principalColumn: "Id_Parc");
                    table.ForeignKey(
                        name: "FK_T_Login_T_Cad_Parc_t_cad_usu_id_usr",
                        column: x => x.t_cad_usu_id_usr,
                        principalTable: "T_Cad_Parc",
                        principalColumn: "Id_Parc");
                    table.ForeignKey(
                        name: "FK_T_Login_T_Cad_Usu_CadUsuarioId_Usr",
                        column: x => x.CadUsuarioId_Usr,
                        principalTable: "T_Cad_Usu",
                        principalColumn: "Id_Usr");
                    table.ForeignKey(
                        name: "FK_T_Login_T_Cad_Usu_t_cad_usu_id_usr",
                        column: x => x.t_cad_usu_id_usr,
                        principalTable: "T_Cad_Usu",
                        principalColumn: "Id_Usr");
                    table.ForeignKey(
                        name: "FK_T_Login_T_End_t_end_id_end",
                        column: x => x.t_end_id_end,
                        principalTable: "T_End",
                        principalColumn: "Id_End",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Login_T_Rede_Soc_RedeSocialId_Feed",
                        column: x => x.RedeSocialId_Feed,
                        principalTable: "T_Rede_Soc",
                        principalColumn: "Id_Feed");
                    table.ForeignKey(
                        name: "FK_T_Login_T_Rede_Soc_t_rede_soc_id_feed",
                        column: x => x.t_rede_soc_id_feed,
                        principalTable: "T_Rede_Soc",
                        principalColumn: "Id_Feed",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_USU_CONV",
                columns: table => new
                {
                    Id_ind = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Data = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Observacoes = table.Column<string>(type: "NVARCHAR2(80)", maxLength: 80, nullable: false),
                    Qt_Pessoas = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    t_cad_usu_id_usr = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    t_end_id_end = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CadUsuarioId_Usr = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USU_CONV", x => x.Id_ind);
                    table.UniqueConstraint("AK_T_USU_CONV_t_end_id_end", x => x.t_end_id_end);
                    table.ForeignKey(
                        name: "FK_T_USU_CONV_T_Cad_Usu_CadUsuarioId_Usr",
                        column: x => x.CadUsuarioId_Usr,
                        principalTable: "T_Cad_Usu",
                        principalColumn: "Id_Usr");
                    table.ForeignKey(
                        name: "FK_T_USU_CONV_T_Cad_Usu_t_cad_usu_id_usr",
                        column: x => x.t_cad_usu_id_usr,
                        principalTable: "T_Cad_Usu",
                        principalColumn: "Id_Usr",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_USU_CONV_T_End_t_end_id_end",
                        column: x => x.t_end_id_end,
                        principalTable: "T_End",
                        principalColumn: "Id_End",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "\"NormalizedName\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "\"NormalizedUserName\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cad_Parc_ProdutoParceiroId_Prd",
                table: "T_Cad_Parc",
                column: "ProdutoParceiroId_Prd",
                unique: true,
                filter: "\"ProdutoParceiroId_Prd\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cad_Parc_t_card_parc_id_card",
                table: "T_Cad_Parc",
                column: "t_card_parc_id_card",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_Cad_Parc_t_card_parc_T_PROD_PARC_id_prd",
                table: "T_Cad_Parc",
                column: "t_card_parc_T_PROD_PARC_id_prd",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_Card_Parc_ProdutoParceiroId_Prd",
                table: "T_Card_Parc",
                column: "ProdutoParceiroId_Prd",
                unique: true,
                filter: "\"ProdutoParceiroId_Prd\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_T_Card_Parc_T_PROD_PARC_id_prd",
                table: "T_Card_Parc",
                column: "T_PROD_PARC_id_prd",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_End_LoginId_Log",
                table: "T_End",
                column: "LoginId_Log");

            migrationBuilder.CreateIndex(
                name: "IX_T_End_UsuarioConvidadoId_ind",
                table: "T_End",
                column: "UsuarioConvidadoId_ind");

            migrationBuilder.CreateIndex(
                name: "IX_T_Login_CadUsuarioId_Usr",
                table: "T_Login",
                column: "CadUsuarioId_Usr",
                unique: true,
                filter: "\"CadUsuarioId_Usr\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_T_Login_RedeSocialId_Feed",
                table: "T_Login",
                column: "RedeSocialId_Feed",
                unique: true,
                filter: "\"RedeSocialId_Feed\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_T_Login_t_cad_parc_id_parc",
                table: "T_Login",
                column: "t_cad_parc_id_parc",
                unique: true,
                filter: "\"t_cad_parc_id_parc\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_T_Login_t_cad_usu_id_usr",
                table: "T_Login",
                column: "t_cad_usu_id_usr",
                unique: true,
                filter: "\"t_cad_usu_id_usr\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_T_Login_t_rede_soc_id_feed",
                table: "T_Login",
                column: "t_rede_soc_id_feed",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_PST_t_cad_usu_id_usr",
                table: "T_PST",
                column: "t_cad_usu_id_usr");

            migrationBuilder.CreateIndex(
                name: "IX_T_USU_CONV_CadUsuarioId_Usr",
                table: "T_USU_CONV",
                column: "CadUsuarioId_Usr",
                unique: true,
                filter: "\"CadUsuarioId_Usr\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_T_USU_CONV_t_cad_usu_id_usr",
                table: "T_USU_CONV",
                column: "t_cad_usu_id_usr",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_T_End_T_Login_LoginId_Log",
                table: "T_End",
                column: "LoginId_Log",
                principalTable: "T_Login",
                principalColumn: "Id_Log",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_End_T_USU_CONV_UsuarioConvidadoId_ind",
                table: "T_End",
                column: "UsuarioConvidadoId_ind",
                principalTable: "T_USU_CONV",
                principalColumn: "Id_ind",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Cad_Parc_T_Card_Parc_t_card_parc_id_card",
                table: "T_Cad_Parc");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Cad_Parc_T_Prod_Parc_ProdutoParceiroId_Prd",
                table: "T_Cad_Parc");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Cad_Parc_T_Prod_Parc_t_card_parc_T_PROD_PARC_id_prd",
                table: "T_Cad_Parc");

            migrationBuilder.DropForeignKey(
                name: "FK_T_End_T_Login_LoginId_Log",
                table: "T_End");

            migrationBuilder.DropForeignKey(
                name: "FK_T_End_T_USU_CONV_UsuarioConvidadoId_ind",
                table: "T_End");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Filiais");

            migrationBuilder.DropTable(
                name: "T_PST");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "T_Card_Parc");

            migrationBuilder.DropTable(
                name: "T_Prod_Parc");

            migrationBuilder.DropTable(
                name: "T_Login");

            migrationBuilder.DropTable(
                name: "T_Cad_Parc");

            migrationBuilder.DropTable(
                name: "T_Rede_Soc");

            migrationBuilder.DropTable(
                name: "T_USU_CONV");

            migrationBuilder.DropTable(
                name: "T_Cad_Usu");

            migrationBuilder.DropTable(
                name: "T_End");
        }
    }
}
