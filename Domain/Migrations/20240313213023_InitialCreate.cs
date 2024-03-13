using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreCompleto = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nit = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nacimiento = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.EstadoId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    MarcaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.MarcaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Plataforma",
                columns: table => new
                {
                    PlataformaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plataforma", x => x.PlataformaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Protagonista",
                columns: table => new
                {
                    ProtagonistaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protagonista", x => x.ProtagonistaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PasswordHash = table.Column<string>(type: "varchar(600)", maxLength: 600, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccessFailCount = table.Column<sbyte>(type: "tinyint", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsPasswordChange = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Alquiler",
                columns: table => new
                {
                    AlquilerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    Fecha_Reservacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Fecha_Devolucion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Valor_Total = table.Column<double>(type: "double", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alquiler", x => x.AlquilerId);
                    table.ForeignKey(
                        name: "FK_Alquiler_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alquiler_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "EstadoId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Director",
                columns: table => new
                {
                    DirectorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MarcaId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => x.DirectorId);
                    table.ForeignKey(
                        name: "FK_Director_Marca_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marca",
                        principalColumn: "MarcaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LogLogin",
                columns: table => new
                {
                    LogLoginID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogLogin", x => x.LogLoginID);
                    table.ForeignKey(
                        name: "FK_LogLogin_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sesion",
                columns: table => new
                {
                    SesionID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Expiration_Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sesion", x => x.SesionID);
                    table.ForeignKey(
                        name: "FK_Sesion_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Juego",
                columns: table => new
                {
                    JuegoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Precio = table.Column<double>(type: "double", nullable: false),
                    Lanzamiento = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DirectorId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juego", x => x.JuegoId);
                    table.ForeignKey(
                        name: "FK_Juego_Director_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Director",
                        principalColumn: "DirectorId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Alquiler_Det",
                columns: table => new
                {
                    AlquilerDetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    AlquilerId = table.Column<int>(type: "int", nullable: false),
                    JuegoId = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<double>(type: "double", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alquiler_Det", x => x.AlquilerDetId);
                    table.ForeignKey(
                        name: "FK_Alquiler_Det_Alquiler_AlquilerId",
                        column: x => x.AlquilerId,
                        principalTable: "Alquiler",
                        principalColumn: "AlquilerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alquiler_Det_Juego_JuegoId",
                        column: x => x.JuegoId,
                        principalTable: "Juego",
                        principalColumn: "JuegoId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Plataforma_Juego",
                columns: table => new
                {
                    PlataformaJuegoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    JuegoId = table.Column<int>(type: "int", nullable: false),
                    PlataformaId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plataforma_Juego", x => x.PlataformaJuegoId);
                    table.ForeignKey(
                        name: "FK_Plataforma_Juego_Juego_JuegoId",
                        column: x => x.JuegoId,
                        principalTable: "Juego",
                        principalColumn: "JuegoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plataforma_Juego_Plataforma_PlataformaId",
                        column: x => x.PlataformaId,
                        principalTable: "Plataforma",
                        principalColumn: "PlataformaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Protagonista_Juego",
                columns: table => new
                {
                    ProtagonistaJuegoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    JuegoId = table.Column<int>(type: "int", nullable: false),
                    ProtagonistaId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protagonista_Juego", x => x.ProtagonistaJuegoId);
                    table.ForeignKey(
                        name: "FK_Protagonista_Juego_Juego_JuegoId",
                        column: x => x.JuegoId,
                        principalTable: "Juego",
                        principalColumn: "JuegoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Protagonista_Juego_Protagonista_ProtagonistaId",
                        column: x => x.ProtagonistaId,
                        principalTable: "Protagonista",
                        principalColumn: "ProtagonistaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "ClienteId", "Apellido", "CreatedAt", "CreatedBy", "Email", "Nacimiento", "Nit", "Nombre", "NombreCompleto", "Telefono", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Ziemann", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Sheila.Ziemann@yahoo.com", new DateTime(2000, 12, 17, 3, 32, 25, 105, DateTimeKind.Local).AddTicks(6987), "280531834", "Sheila", "Sheila Ziemann", "1-859-636-8654", null },
                    { 2, "Champlin", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Santiago.Champlin@yahoo.com", new DateTime(1961, 7, 8, 23, 15, 5, 872, DateTimeKind.Local).AddTicks(6229), "390572286", "Santiago", "Santiago Champlin", "767-752-5097", null },
                    { 3, "Predovic", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Moses_Predovic47@hotmail.com", new DateTime(1990, 3, 3, 1, 34, 55, 335, DateTimeKind.Local).AddTicks(2118), "845515488", "Moses", "Moses Predovic", "1-443-323-4806 x81599", null },
                    { 4, "Osinski", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Joy.Osinski70@hotmail.com", new DateTime(1974, 7, 10, 18, 13, 50, 448, DateTimeKind.Local).AddTicks(1898), "606319070", "Joy", "Joy Osinski", "997-732-0258 x23113", null },
                    { 5, "Ullrich", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Javier.Ullrich25@yahoo.com", new DateTime(1964, 12, 28, 12, 32, 48, 783, DateTimeKind.Local).AddTicks(7823), "962757690", "Javier", "Javier Ullrich", "992.785.5474 x30826", null },
                    { 6, "Runte", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Ramona.Runte@yahoo.com", new DateTime(1974, 2, 1, 6, 4, 2, 565, DateTimeKind.Local).AddTicks(6659), "810732406", "Ramona", "Ramona Runte", "(455) 540-9414 x9711", null },
                    { 7, "Carter", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Santos_Carter@yahoo.com", new DateTime(1955, 10, 7, 16, 26, 51, 642, DateTimeKind.Local).AddTicks(7170), "176901003", "Santos", "Santos Carter", "(802) 975-8488", null },
                    { 8, "Mann", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Pat_Mann@gmail.com", new DateTime(1993, 1, 27, 3, 23, 20, 157, DateTimeKind.Local).AddTicks(6665), "256857668", "Pat", "Pat Mann", "730-208-6136 x873", null },
                    { 9, "Mann", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Sadie_Mann@yahoo.com", new DateTime(1975, 10, 30, 16, 7, 54, 71, DateTimeKind.Local).AddTicks(7170), "686804442", "Sadie", "Sadie Mann", "1-976-305-0967 x17832", null },
                    { 10, "Bosco", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Ron_Bosco@yahoo.com", new DateTime(1988, 3, 10, 5, 46, 8, 405, DateTimeKind.Local).AddTicks(3264), "750090249", "Ron", "Ron Bosco", "279-246-7591 x67848", null },
                    { 11, "Bosco", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Kelly_Bosco@gmail.com", new DateTime(1979, 6, 12, 3, 24, 56, 88, DateTimeKind.Local).AddTicks(4347), "363261320", "Kelly", "Kelly Bosco", "873.807.9613 x803", null },
                    { 12, "Dach", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Edgar.Dach@hotmail.com", new DateTime(1972, 8, 5, 0, 23, 43, 383, DateTimeKind.Local).AddTicks(9268), "272631715", "Edgar", "Edgar Dach", "843.992.4246", null },
                    { 13, "Jakubowski", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Judy.Jakubowski@gmail.com", new DateTime(1968, 2, 2, 10, 46, 29, 367, DateTimeKind.Local).AddTicks(5223), "996566547", "Judy", "Judy Jakubowski", "(779) 354-3518", null },
                    { 14, "Cartwright", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Mona77@gmail.com", new DateTime(1982, 5, 22, 22, 6, 45, 373, DateTimeKind.Local).AddTicks(9385), "641413719", "Mona", "Mona Cartwright", "773-264-8814 x039", null },
                    { 15, "Halvorson", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Bethany_Halvorson@yahoo.com", new DateTime(1961, 7, 27, 13, 39, 4, 942, DateTimeKind.Local).AddTicks(9032), "995601827", "Bethany", "Bethany Halvorson", "1-725-671-5612 x303", null },
                    { 16, "Lueilwitz", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Jordan.Lueilwitz69@yahoo.com", new DateTime(1971, 2, 1, 10, 55, 45, 452, DateTimeKind.Local).AddTicks(8334), "251305096", "Jordan", "Jordan Lueilwitz", "522.781.7418 x370", null },
                    { 17, "Johns", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Todd49@yahoo.com", new DateTime(1957, 4, 18, 11, 56, 40, 806, DateTimeKind.Local).AddTicks(6682), "310154046", "Todd", "Todd Johns", "338-223-6642 x114", null },
                    { 18, "Quigley", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Todd.Quigley@gmail.com", new DateTime(1969, 4, 4, 7, 57, 25, 399, DateTimeKind.Local).AddTicks(9444), "214776632", "Todd", "Todd Quigley", "342-947-2736", null },
                    { 19, "Romaguera", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Lori79@hotmail.com", new DateTime(1982, 11, 5, 12, 43, 33, 928, DateTimeKind.Local).AddTicks(6706), "493042795", "Lori", "Lori Romaguera", "1-649-796-7958 x29245", null },
                    { 20, "Hettinger", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Regina_Hettinger18@hotmail.com", new DateTime(1997, 9, 26, 4, 42, 0, 361, DateTimeKind.Local).AddTicks(3578), "483615497", "Regina", "Regina Hettinger", "1-617-222-4169 x59820", null },
                    { 21, "Hoeger", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "James_Hoeger@yahoo.com", new DateTime(1960, 5, 31, 18, 45, 49, 808, DateTimeKind.Local).AddTicks(4576), "956870652", "James", "James Hoeger", "949-496-0820", null },
                    { 22, "Hilll", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Edith_Hilll51@gmail.com", new DateTime(1980, 6, 20, 14, 36, 10, 844, DateTimeKind.Local).AddTicks(4435), "719653717", "Edith", "Edith Hilll", "793.223.6202", null },
                    { 23, "Upton", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Harry.Upton@yahoo.com", new DateTime(1977, 10, 12, 4, 15, 42, 123, DateTimeKind.Local).AddTicks(6259), "160564082", "Harry", "Harry Upton", "1-670-554-1971 x964", null },
                    { 24, "Leffler", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Blake.Leffler@hotmail.com", new DateTime(2000, 12, 17, 4, 25, 56, 596, DateTimeKind.Local).AddTicks(31), "297148790", "Blake", "Blake Leffler", "1-294-869-8737 x4942", null },
                    { 25, "Collins", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Rosalie17@hotmail.com", new DateTime(1967, 11, 6, 5, 28, 0, 741, DateTimeKind.Local).AddTicks(9606), "396292546", "Rosalie", "Rosalie Collins", "474-742-7086 x3855", null },
                    { 26, "Jenkins", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Inez_Jenkins37@gmail.com", new DateTime(1986, 1, 27, 19, 15, 41, 510, DateTimeKind.Local).AddTicks(5073), "823846531", "Inez", "Inez Jenkins", "239-426-8529", null },
                    { 27, "Pacocha", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Abel.Pacocha68@gmail.com", new DateTime(1992, 9, 21, 4, 58, 42, 179, DateTimeKind.Local).AddTicks(481), "221569498", "Abel", "Abel Pacocha", "(280) 790-8247", null },
                    { 28, "Koss", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Jenna.Koss31@hotmail.com", new DateTime(1981, 3, 22, 3, 15, 12, 295, DateTimeKind.Local).AddTicks(4073), "131055596", "Jenna", "Jenna Koss", "1-779-880-1731 x449", null },
                    { 29, "Baumbach", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Adam_Baumbach60@hotmail.com", new DateTime(1966, 9, 8, 21, 26, 16, 741, DateTimeKind.Local).AddTicks(5674), "611374201", "Adam", "Adam Baumbach", "1-200-417-6421 x35120", null },
                    { 30, "Kling", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Deborah30@hotmail.com", new DateTime(1986, 7, 20, 0, 22, 1, 222, DateTimeKind.Local).AddTicks(1807), "977676744", "Deborah", "Deborah Kling", "481-785-0918 x34624", null },
                    { 31, "Cormier", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Steve4@hotmail.com", new DateTime(1972, 3, 5, 7, 2, 19, 771, DateTimeKind.Local).AddTicks(9149), "741135360", "Steve", "Steve Cormier", "(242) 949-7420 x706", null },
                    { 32, "Mitchell", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Sylvia16@hotmail.com", new DateTime(1959, 5, 12, 6, 5, 9, 373, DateTimeKind.Local).AddTicks(3660), "526470708", "Sylvia", "Sylvia Mitchell", "811-771-3653 x786", null },
                    { 33, "Reichert", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Theodore88@gmail.com", new DateTime(1963, 5, 24, 19, 9, 20, 788, DateTimeKind.Local).AddTicks(1989), "573883547", "Theodore", "Theodore Reichert", "1-889-420-1556 x714", null },
                    { 34, "Rogahn", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Luis67@gmail.com", new DateTime(1982, 4, 20, 22, 5, 0, 906, DateTimeKind.Local).AddTicks(4221), "885917818", "Luis", "Luis Rogahn", "1-597-620-2966 x137", null },
                    { 35, "Schowalter", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Regina_Schowalter12@hotmail.com", new DateTime(1984, 7, 18, 15, 16, 49, 201, DateTimeKind.Local).AddTicks(7933), "650735950", "Regina", "Regina Schowalter", "(593) 284-1892 x17204", null },
                    { 36, "Kuhlman", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Bennie93@yahoo.com", new DateTime(1956, 9, 6, 4, 9, 3, 151, DateTimeKind.Local).AddTicks(8799), "193606333", "Bennie", "Bennie Kuhlman", "(986) 928-3033 x984", null },
                    { 37, "Mueller", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Ellen72@yahoo.com", new DateTime(1977, 8, 22, 16, 11, 45, 673, DateTimeKind.Local).AddTicks(7643), "801492474", "Ellen", "Ellen Mueller", "837.976.8838 x2777", null },
                    { 38, "Lubowitz", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Dianne.Lubowitz@hotmail.com", new DateTime(1985, 3, 24, 0, 29, 43, 970, DateTimeKind.Local).AddTicks(830), "130593884", "Dianne", "Dianne Lubowitz", "850-947-2893 x86037", null },
                    { 39, "Nicolas", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Alexander_Nicolas@yahoo.com", new DateTime(1974, 9, 30, 8, 11, 23, 222, DateTimeKind.Local).AddTicks(7172), "888567381", "Alexander", "Alexander Nicolas", "1-769-547-2657", null },
                    { 40, "Kassulke", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Patrick64@gmail.com", new DateTime(1970, 10, 18, 16, 14, 43, 767, DateTimeKind.Local).AddTicks(2689), "952768713", "Patrick", "Patrick Kassulke", "363-748-8052 x5785", null },
                    { 41, "Wiegand", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Bob74@yahoo.com", new DateTime(1991, 5, 30, 18, 39, 55, 573, DateTimeKind.Local).AddTicks(4083), "141849062", "Bob", "Bob Wiegand", "309.624.3982", null },
                    { 42, "Hermann", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Holly_Hermann@yahoo.com", new DateTime(1999, 2, 25, 20, 4, 32, 35, DateTimeKind.Local).AddTicks(2981), "817500122", "Holly", "Holly Hermann", "977-529-3852 x9818", null },
                    { 43, "Nitzsche", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Erma_Nitzsche@hotmail.com", new DateTime(1971, 11, 30, 10, 56, 22, 428, DateTimeKind.Local).AddTicks(7642), "543959868", "Erma", "Erma Nitzsche", "(523) 332-9534 x2400", null },
                    { 44, "Zemlak", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Wilbur_Zemlak@yahoo.com", new DateTime(2003, 10, 21, 5, 59, 6, 291, DateTimeKind.Local).AddTicks(98), "297758516", "Wilbur", "Wilbur Zemlak", "588-705-1556 x3297", null },
                    { 45, "Mann", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Margie74@yahoo.com", new DateTime(1993, 4, 20, 14, 16, 23, 300, DateTimeKind.Local).AddTicks(385), "747411368", "Margie", "Margie Mann", "878.328.6330", null },
                    { 46, "Harris", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Marco_Harris44@hotmail.com", new DateTime(1977, 5, 3, 13, 42, 34, 791, DateTimeKind.Local).AddTicks(3403), "277997392", "Marco", "Marco Harris", "695-315-8901", null },
                    { 47, "Murphy", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Lillie38@gmail.com", new DateTime(1981, 9, 28, 13, 16, 51, 481, DateTimeKind.Local).AddTicks(1648), "848729905", "Lillie", "Lillie Murphy", "(630) 354-5818", null },
                    { 48, "Boyle", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Shelly.Boyle@gmail.com", new DateTime(2002, 3, 17, 11, 15, 25, 889, DateTimeKind.Local).AddTicks(8196), "792610595", "Shelly", "Shelly Boyle", "925.201.7980", null },
                    { 49, "Kulas", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Antonio4@gmail.com", new DateTime(1971, 12, 13, 11, 21, 19, 611, DateTimeKind.Local).AddTicks(2502), "525126918", "Antonio", "Antonio Kulas", "(731) 405-2373 x1573", null },
                    { 50, "Ledner", new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Jeffery22@hotmail.com", new DateTime(1983, 7, 15, 20, 44, 18, 424, DateTimeKind.Local).AddTicks(2093), "764445123", "Jeffery", "Jeffery Ledner", "(982) 952-9074 x4204", null }
                });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "EstadoId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Activo", null },
                    { 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Inactivo", null },
                    { 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Devuelto", null },
                    { 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Prestamo", null },
                    { 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Error", null }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "MarcaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Microsoft", null },
                    { 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Sony", null },
                    { 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "EA", null },
                    { 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Ubisoft", null },
                    { 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Rovio", null },
                    { 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Activision", null },
                    { 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Nintendo", null },
                    { 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Rockstar", null },
                    { 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "CD Project Red", null },
                    { 10, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Annapurna Interactive", null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma",
                columns: new[] { "PlataformaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "PC", null },
                    { 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Xbox", null },
                    { 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Xbox 360", null },
                    { 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Xbox ONE", null },
                    { 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Xbox X", null },
                    { 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "PSP Vita", null },
                    { 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "PlayStation", null },
                    { 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "PlayStation 2", null },
                    { 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "PlayStation 3", null },
                    { 10, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "PlayStation 4", null },
                    { 11, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "PlayStation 5", null },
                    { 12, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Nintendo 64", null },
                    { 13, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Nintendo DS", null },
                    { 14, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Nintendo Switch", null },
                    { 15, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Android", null },
                    { 16, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "IOS", null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista",
                columns: new[] { "ProtagonistaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Mario Bross", null },
                    { 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Tommy Vercetti", null },
                    { 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Altaïr Ibn-La'Ahad", null },
                    { 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Natan Drake", null },
                    { 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Crash Bandicoot", null },
                    { 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Samus Aran", null },
                    { 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "John-117", null },
                    { 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Aiden Perce", null },
                    { 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Carl Jhonson", null },
                    { 10, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Red", null },
                    { 11, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Crazy Dave", null },
                    { 12, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Spyro", null },
                    { 13, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Marcus Fenix", null },
                    { 14, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Vass", null },
                    { 15, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Gordon Freeman", null },
                    { 16, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Joel", null },
                    { 17, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Jill Valentine", null },
                    { 18, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Zelda", null },
                    { 19, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Link", null },
                    { 20, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Glados", null },
                    { 21, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Meet Boy", null },
                    { 22, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Geralt de Rivia", null },
                    { 23, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Steve", null },
                    { 24, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Ellie", null },
                    { 25, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Faith", null },
                    { 26, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Bayonetta", null },
                    { 27, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Tracer", null },
                    { 28, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Pacman", null },
                    { 29, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Chris Redfield", null },
                    { 30, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Leon S. Kennedy", null },
                    { 31, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Agente 47", null },
                    { 32, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Haytham Kenway", null },
                    { 33, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Lara Croft", null },
                    { 34, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Ryu", null },
                    { 35, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Mega Man", null },
                    { 36, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", "Sonic", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "AccessFailCount", "CreatedAt", "CreatedBy", "IsActive", "IsAdmin", "IsPasswordChange", "PasswordHash", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1, (sbyte)0, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", true, true, true, "81DC9BDB52D04DC223B621240E3DD8B7", null, "ADMIN" },
                    { 2, (sbyte)0, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", true, false, false, "81DC9BDB52D04DC223B621240E3DD8B7", null, "DEV" }
                });

            migrationBuilder.InsertData(
                table: "Alquiler",
                columns: new[] { "AlquilerId", "ClienteId", "CreatedAt", "CreatedBy", "EstadoId", "Fecha_Devolucion", "Fecha_Reservacion", "UpdatedAt", "Valor_Total" },
                values: new object[,]
                {
                    { 1, 40, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19260.0 },
                    { 2, 30, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16028.0 },
                    { 3, 49, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17852.0 },
                    { 4, 38, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19424.0 },
                    { 5, 17, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15504.0 },
                    { 6, 36, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17057.0 },
                    { 7, 32, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19548.0 },
                    { 8, 45, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19530.0 },
                    { 9, 49, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19421.0 },
                    { 10, 43, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18410.0 },
                    { 11, 46, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19337.0 },
                    { 12, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17619.0 },
                    { 13, 17, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17761.0 },
                    { 14, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19958.0 },
                    { 15, 28, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18519.0 },
                    { 16, 33, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17278.0 },
                    { 17, 32, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17575.0 },
                    { 18, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15565.0 },
                    { 19, 36, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19357.0 },
                    { 20, 35, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15453.0 },
                    { 21, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16016.0 },
                    { 22, 32, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17761.0 },
                    { 23, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19457.0 },
                    { 24, 20, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19427.0 },
                    { 25, 13, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18956.0 },
                    { 26, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18011.0 },
                    { 27, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16893.0 },
                    { 28, 11, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16191.0 },
                    { 29, 14, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16227.0 },
                    { 30, 14, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17284.0 },
                    { 31, 11, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17153.0 },
                    { 32, 29, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18517.0 },
                    { 33, 14, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17431.0 },
                    { 34, 46, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18643.0 },
                    { 35, 25, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16812.0 },
                    { 36, 20, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17872.0 },
                    { 37, 49, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19645.0 },
                    { 38, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17901.0 },
                    { 39, 39, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16462.0 },
                    { 40, 31, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16096.0 },
                    { 41, 37, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17435.0 },
                    { 42, 22, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18726.0 },
                    { 43, 41, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19241.0 },
                    { 44, 25, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19856.0 },
                    { 45, 16, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16028.0 },
                    { 46, 48, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17443.0 },
                    { 47, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19018.0 },
                    { 48, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18887.0 },
                    { 49, 21, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19124.0 },
                    { 50, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16740.0 },
                    { 51, 28, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15908.0 },
                    { 52, 10, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17169.0 },
                    { 53, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18432.0 },
                    { 54, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17036.0 },
                    { 55, 21, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19223.0 },
                    { 56, 25, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16640.0 },
                    { 57, 20, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15719.0 },
                    { 58, 48, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15766.0 },
                    { 59, 37, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16435.0 },
                    { 60, 14, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16615.0 },
                    { 61, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19231.0 },
                    { 62, 48, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18026.0 },
                    { 63, 24, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18119.0 },
                    { 64, 26, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18248.0 },
                    { 65, 20, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15259.0 },
                    { 66, 21, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17452.0 },
                    { 67, 12, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18570.0 },
                    { 68, 45, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18079.0 },
                    { 69, 20, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17995.0 },
                    { 70, 41, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17872.0 },
                    { 71, 17, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17221.0 },
                    { 72, 18, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19305.0 },
                    { 73, 46, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19277.0 },
                    { 74, 45, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18848.0 },
                    { 75, 11, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16381.0 },
                    { 76, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16504.0 },
                    { 77, 47, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16684.0 },
                    { 78, 13, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18634.0 },
                    { 79, 44, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15495.0 },
                    { 80, 23, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15103.0 },
                    { 81, 40, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19456.0 },
                    { 82, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17402.0 },
                    { 83, 49, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15125.0 },
                    { 84, 27, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17467.0 },
                    { 85, 23, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19163.0 },
                    { 86, 27, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19805.0 },
                    { 87, 27, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19183.0 },
                    { 88, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15556.0 },
                    { 89, 26, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15629.0 },
                    { 90, 28, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15238.0 },
                    { 91, 28, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17150.0 },
                    { 92, 45, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15628.0 },
                    { 93, 39, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15240.0 },
                    { 94, 16, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17912.0 },
                    { 95, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18121.0 },
                    { 96, 29, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16830.0 },
                    { 97, 12, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17509.0 },
                    { 98, 15, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16128.0 },
                    { 99, 42, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15422.0 },
                    { 100, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16916.0 }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "DirectorId", "CreatedAt", "CreatedBy", "MarcaId", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, "Hideo Kojima", null },
                    { 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 5, "Will Wriths", null },
                    { 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, "Hidetaka Miyazaki", null },
                    { 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, "Tim Schafer", null },
                    { 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, "Ken Levine", null },
                    { 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, "Fumito Ueda", null },
                    { 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 7, "Yves Guillemot", null },
                    { 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 7, "Gabe Newell", null },
                    { 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 1, "Tom Howard", null },
                    { 10, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 1, "Yoko Taro", null },
                    { 11, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 1, "Shigeru Miyamoto", null },
                    { 12, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, "Amy Hennig", null },
                    { 13, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 5, "Michel Ancel", null },
                    { 14, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 1, "Goichi Suda", null },
                    { 15, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 7, "Warren Spector", null },
                    { 16, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, "John Romero", null },
                    { 17, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, "Yuji Horii", null },
                    { 18, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 1, "Yuji Naka", null },
                    { 19, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, "Sid Meier", null },
                    { 20, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 1, "John Carmack", null },
                    { 21, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 7, "Keiji Inafune", null },
                    { 22, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, "Hironobu Sakaguchi", null }
                });

            migrationBuilder.InsertData(
                table: "Juego",
                columns: new[] { "JuegoId", "CreatedAt", "CreatedBy", "DirectorId", "Lanzamiento", "Nombre", "Precio", "Stock", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 14, new DateTime(2001, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassins Creed I", 147724.0, 5, null },
                    { 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, new DateTime(2017, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassins Creed Valhalla", 101459.0, 10, null },
                    { 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 9, new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA III", 112413.0, 6, null },
                    { 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 7, new DateTime(2006, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA Vice City", 239875.0, 13, null },
                    { 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 20, new DateTime(1995, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA San Andreas", 252052.0, 10, null },
                    { 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 14, new DateTime(2014, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA IV", 61265.0, 12, null },
                    { 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA V", 314170.0, 8, null },
                    { 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 15, new DateTime(2004, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 17", 274830.0, 7, null },
                    { 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 18", 55171.0, 11, null },
                    { 10, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 20, new DateTime(2001, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 19", 263304.0, 12, null },
                    { 11, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 18, new DateTime(1998, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 20", 95767.0, 13, null },
                    { 12, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2002, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 21", 141007.0, 8, null },
                    { 13, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 21, new DateTime(1997, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", 77252.0, 4, null },
                    { 14, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 15, new DateTime(2001, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gears Of War", 183853.0, 11, null },
                    { 15, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 21, new DateTime(2014, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watch_Dogs", 63414.0, 7, null },
                    { 16, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 17, new DateTime(2014, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watch_Dogs 2", 222239.0, 11, null },
                    { 17, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, new DateTime(2012, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher", 199586.0, 9, null },
                    { 18, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 13, new DateTime(2001, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 2", 224952.0, 3, null },
                    { 19, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, new DateTime(2010, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3", 146745.0, 2, null },
                    { 20, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 7, new DateTime(2009, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon", 211763.0, 14, null },
                    { 21, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 12, new DateTime(2002, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires", 136563.0, 10, null },
                    { 22, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 13, new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires II", 232904.0, 13, null },
                    { 23, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 20, new DateTime(2019, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires III", 206310.0, 9, null },
                    { 24, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 5, new DateTime(2010, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires IV", 197745.0, 6, null },
                    { 25, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 18, new DateTime(2015, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption II", 200542.0, 10, null },
                    { 26, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, new DateTime(2012, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "DOOM", 195849.0, 7, null },
                    { 27, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2011, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pong", 154721.0, 9, null },
                    { 28, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 12, new DateTime(2005, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims", 241103.0, 2, null },
                    { 29, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, new DateTime(2001, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims 2", 280080.0, 11, null },
                    { 30, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2018, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halo", 274447.0, 2, null },
                    { 31, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 8, new DateTime(1996, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angry Birds", 289287.0, 10, null },
                    { 32, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 13, new DateTime(2012, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plants vs Zombies", 237628.0, 6, null },
                    { 33, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, new DateTime(1995, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battlefield 3", 61030.0, 2, null },
                    { 34, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 17, new DateTime(1997, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fligth Simulation", 83880.0, 3, null },
                    { 35, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 8, new DateTime(1998, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chivarly II", 107542.0, 4, null },
                    { 36, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 17, new DateTime(2022, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pureya", 124456.0, 8, null },
                    { 37, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, new DateTime(2018, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rust", 213800.0, 10, null },
                    { 38, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 20, new DateTime(2000, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mass Effect: Legendary Edition", 28001.0, 9, null },
                    { 39, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, new DateTime(2007, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", 92396.0, 7, null },
                    { 40, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us 2", 308485.0, 7, null },
                    { 41, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 20, new DateTime(2011, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwatch", 171343.0, 3, null },
                    { 42, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, new DateTime(2003, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "NBA 2K21", 192001.0, 8, null },
                    { 43, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 18, new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fortnite", 295144.0, 8, null },
                    { 44, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 5, new DateTime(2003, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Squadrons", 159143.0, 7, null },
                    { 45, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, new DateTime(2003, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil 8: Village", 227756.0, 4, null },
                    { 46, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, new DateTime(2020, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroes of the Storm", 100718.0, 4, null },
                    { 47, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 9, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battefield 4", 158595.0, 10, null },
                    { 48, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, new DateTime(2015, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battlefield 2042", 172050.0, 8, null },
                    { 49, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, new DateTime(2008, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "florence", 322560.0, 2, null },
                    { 50, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 17, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "portal", 172184.0, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Det",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 1, 40, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 11, null, 0.0 },
                    { 2, 49, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 31, null, 0.0 },
                    { 3, 99, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 23, null, 0.0 },
                    { 4, 33, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 28, null, 0.0 },
                    { 5, 18, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, null, 0.0 },
                    { 6, 91, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 43, null, 0.0 },
                    { 7, 16, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 29, null, 0.0 },
                    { 8, 98, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, null, 0.0 },
                    { 9, 55, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 8, null, 0.0 },
                    { 10, 89, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 26, null, 0.0 },
                    { 11, 76, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 8, null, 0.0 },
                    { 12, 29, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 34, null, 0.0 },
                    { 13, 33, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 29, null, 0.0 },
                    { 14, 18, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 24, null, 0.0 },
                    { 15, 69, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 21, null, 0.0 },
                    { 16, 49, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 49, null, 0.0 },
                    { 17, 55, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 41, null, 0.0 },
                    { 18, 48, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 38, null, 0.0 },
                    { 19, 94, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 28, null, 0.0 },
                    { 20, 50, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 27, null, 0.0 },
                    { 21, 88, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, null, 0.0 },
                    { 22, 73, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 38, null, 0.0 },
                    { 23, 23, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 21, null, 0.0 },
                    { 24, 84, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 29, null, 0.0 },
                    { 25, 67, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 18, null, 0.0 },
                    { 26, 69, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 43, null, 0.0 },
                    { 27, 97, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 39, null, 0.0 },
                    { 28, 62, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 37, null, 0.0 },
                    { 29, 63, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, null, 0.0 },
                    { 30, 21, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 18, null, 0.0 },
                    { 31, 55, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 24, null, 0.0 },
                    { 32, 73, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, null, 0.0 },
                    { 33, 71, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 11, null, 0.0 },
                    { 34, 86, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 34, null, 0.0 },
                    { 35, 17, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 20, null, 0.0 },
                    { 36, 32, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 46, null, 0.0 },
                    { 37, 34, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 29, null, 0.0 },
                    { 38, 61, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 33, null, 0.0 },
                    { 39, 84, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 43, null, 0.0 },
                    { 40, 90, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 37, null, 0.0 },
                    { 41, 54, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 30, null, 0.0 },
                    { 42, 19, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 32, null, 0.0 },
                    { 43, 36, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 29, null, 0.0 },
                    { 44, 63, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 48, null, 0.0 },
                    { 45, 75, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 24, null, 0.0 },
                    { 46, 15, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 12, null, 0.0 },
                    { 47, 53, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 39, null, 0.0 },
                    { 48, 99, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 44, null, 0.0 },
                    { 49, 55, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, null, 0.0 },
                    { 50, 77, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 5, null, 0.0 },
                    { 51, 16, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 23, null, 0.0 },
                    { 52, 17, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 15, null, 0.0 },
                    { 53, 17, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, null, 0.0 },
                    { 54, 49, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 37, null, 0.0 },
                    { 55, 99, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 42, null, 0.0 },
                    { 56, 18, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, null, 0.0 },
                    { 57, 62, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, null, 0.0 },
                    { 58, 85, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 40, null, 0.0 },
                    { 59, 7, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 47, null, 0.0 },
                    { 60, 60, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 38, null, 0.0 },
                    { 61, 19, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 31, null, 0.0 },
                    { 62, 29, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 25, null, 0.0 },
                    { 63, 53, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 24, null, 0.0 },
                    { 64, 72, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 48, null, 0.0 },
                    { 65, 94, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 32, null, 0.0 },
                    { 66, 26, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, null, 0.0 },
                    { 67, 92, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, null, 0.0 },
                    { 68, 67, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 31, null, 0.0 },
                    { 69, 5, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, null, 0.0 },
                    { 70, 88, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 26, null, 0.0 },
                    { 71, 10, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 36, null, 0.0 },
                    { 72, 77, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 31, null, 0.0 },
                    { 73, 57, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 7, null, 0.0 },
                    { 74, 41, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, null, 0.0 },
                    { 75, 43, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 1, null, 0.0 },
                    { 76, 64, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 21, null, 0.0 },
                    { 77, 85, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 27, null, 0.0 },
                    { 78, 28, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 35, null, 0.0 },
                    { 79, 4, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 34, null, 0.0 },
                    { 80, 34, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 25, null, 0.0 },
                    { 81, 45, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 5, null, 0.0 },
                    { 82, 83, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 14, null, 0.0 },
                    { 83, 72, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 37, null, 0.0 },
                    { 84, 49, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 47, null, 0.0 },
                    { 85, 94, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 1, null, 0.0 },
                    { 86, 94, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 39, null, 0.0 },
                    { 87, 46, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 18, null, 0.0 },
                    { 88, 89, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, null, 0.0 },
                    { 89, 17, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 15, null, 0.0 },
                    { 90, 17, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 36, null, 0.0 },
                    { 91, 99, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 43, null, 0.0 },
                    { 92, 61, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 40, null, 0.0 },
                    { 93, 3, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 20, null, 0.0 },
                    { 94, 56, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 22, null, 0.0 },
                    { 95, 44, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, null, 0.0 },
                    { 96, 96, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 47, null, 0.0 },
                    { 97, 10, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, null, 0.0 },
                    { 98, 77, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 40, null, 0.0 },
                    { 99, 61, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 35, null, 0.0 },
                    { 100, 22, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 38, null, 0.0 },
                    { 101, 23, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 9, null, 0.0 },
                    { 102, 17, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, null, 0.0 },
                    { 103, 19, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 49, null, 0.0 },
                    { 104, 31, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 36, null, 0.0 },
                    { 105, 38, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 31, null, 0.0 },
                    { 106, 71, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 47, null, 0.0 },
                    { 107, 79, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 20, null, 0.0 },
                    { 108, 28, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 33, null, 0.0 },
                    { 109, 74, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 18, null, 0.0 },
                    { 110, 17, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 45, null, 0.0 },
                    { 111, 7, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 29, null, 0.0 },
                    { 112, 54, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 5, null, 0.0 },
                    { 113, 4, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 29, null, 0.0 },
                    { 114, 40, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 47, null, 0.0 },
                    { 115, 46, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 14, null, 0.0 },
                    { 116, 35, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 41, null, 0.0 },
                    { 117, 12, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 8, null, 0.0 },
                    { 118, 70, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 32, null, 0.0 },
                    { 119, 83, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 24, null, 0.0 },
                    { 120, 87, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, null, 0.0 },
                    { 121, 8, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 20, null, 0.0 },
                    { 122, 11, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, null, 0.0 },
                    { 123, 92, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 44, null, 0.0 },
                    { 124, 27, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 27, null, 0.0 },
                    { 125, 6, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 40, null, 0.0 },
                    { 126, 30, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, null, 0.0 },
                    { 127, 52, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, null, 0.0 },
                    { 128, 15, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 22, null, 0.0 },
                    { 129, 15, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 12, null, 0.0 },
                    { 130, 57, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 49, null, 0.0 },
                    { 131, 62, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 33, null, 0.0 },
                    { 132, 54, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, null, 0.0 },
                    { 133, 96, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 13, null, 0.0 },
                    { 134, 69, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, null, 0.0 },
                    { 135, 72, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 40, null, 0.0 },
                    { 136, 47, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, null, 0.0 },
                    { 137, 5, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 36, null, 0.0 },
                    { 138, 32, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 23, null, 0.0 },
                    { 139, 32, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 21, null, 0.0 },
                    { 140, 14, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 21, null, 0.0 },
                    { 141, 68, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, null, 0.0 },
                    { 142, 20, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 1, null, 0.0 },
                    { 143, 94, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 40, null, 0.0 },
                    { 144, 94, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 34, null, 0.0 },
                    { 145, 79, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, null, 0.0 },
                    { 146, 58, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 43, null, 0.0 },
                    { 147, 62, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 47, null, 0.0 },
                    { 148, 97, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, null, 0.0 },
                    { 149, 78, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 27, null, 0.0 },
                    { 150, 13, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 36, null, 0.0 },
                    { 151, 68, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 20, null, 0.0 },
                    { 152, 35, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 12, null, 0.0 },
                    { 153, 23, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 45, null, 0.0 },
                    { 154, 33, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 1, null, 0.0 },
                    { 155, 75, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 43, null, 0.0 },
                    { 156, 58, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 49, null, 0.0 },
                    { 157, 70, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 49, null, 0.0 },
                    { 158, 32, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 33, null, 0.0 },
                    { 159, 54, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 28, null, 0.0 },
                    { 160, 67, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, null, 0.0 },
                    { 161, 33, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 48, null, 0.0 },
                    { 162, 86, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 34, null, 0.0 },
                    { 163, 74, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 40, null, 0.0 },
                    { 164, 47, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 24, null, 0.0 },
                    { 165, 35, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 33, null, 0.0 },
                    { 166, 34, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 24, null, 0.0 },
                    { 167, 79, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 37, null, 0.0 },
                    { 168, 55, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 48, null, 0.0 },
                    { 169, 12, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 27, null, 0.0 },
                    { 170, 71, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 45, null, 0.0 },
                    { 171, 59, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 37, null, 0.0 },
                    { 172, 61, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 44, null, 0.0 },
                    { 173, 90, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 21, null, 0.0 },
                    { 174, 27, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 24, null, 0.0 },
                    { 175, 26, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 28, null, 0.0 },
                    { 176, 14, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, null, 0.0 },
                    { 177, 80, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 27, null, 0.0 },
                    { 178, 89, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 40, null, 0.0 },
                    { 179, 92, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, null, 0.0 },
                    { 180, 10, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 23, null, 0.0 },
                    { 181, 28, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 9, null, 0.0 },
                    { 182, 57, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 27, null, 0.0 },
                    { 183, 4, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 9, null, 0.0 },
                    { 184, 53, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, null, 0.0 },
                    { 185, 5, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 27, null, 0.0 },
                    { 186, 61, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 26, null, 0.0 },
                    { 187, 69, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 22, null, 0.0 },
                    { 188, 54, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 38, null, 0.0 },
                    { 189, 71, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 15, null, 0.0 },
                    { 190, 7, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 35, null, 0.0 },
                    { 191, 47, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, null, 0.0 },
                    { 192, 20, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 47, null, 0.0 },
                    { 193, 6, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, null, 0.0 },
                    { 194, 64, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 22, null, 0.0 },
                    { 195, 61, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 48, null, 0.0 },
                    { 196, 89, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 18, null, 0.0 },
                    { 197, 84, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 43, null, 0.0 },
                    { 198, 44, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 45, null, 0.0 },
                    { 199, 30, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 18, null, 0.0 },
                    { 200, 15, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 28, null, 0.0 },
                    { 201, 69, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, null, 0.0 },
                    { 202, 37, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 17, null, 0.0 },
                    { 203, 92, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 39, null, 0.0 },
                    { 204, 20, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 24, null, 0.0 },
                    { 205, 37, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 49, null, 0.0 },
                    { 206, 29, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, null, 0.0 },
                    { 207, 63, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 44, null, 0.0 },
                    { 208, 76, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 28, null, 0.0 },
                    { 209, 7, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 18, null, 0.0 },
                    { 210, 5, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, null, 0.0 },
                    { 211, 26, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 33, null, 0.0 },
                    { 212, 56, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, null, 0.0 },
                    { 213, 25, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, null, 0.0 },
                    { 214, 75, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 11, null, 0.0 },
                    { 215, 38, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 20, null, 0.0 },
                    { 216, 93, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 48, null, 0.0 },
                    { 217, 19, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 13, null, 0.0 },
                    { 218, 69, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 37, null, 0.0 },
                    { 219, 96, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 9, null, 0.0 },
                    { 220, 38, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 9, null, 0.0 },
                    { 221, 49, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 13, null, 0.0 },
                    { 222, 12, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 47, null, 0.0 },
                    { 223, 39, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, null, 0.0 },
                    { 224, 66, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 39, null, 0.0 },
                    { 225, 12, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 20, null, 0.0 },
                    { 226, 60, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, null, 0.0 },
                    { 227, 44, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 24, null, 0.0 },
                    { 228, 34, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 36, null, 0.0 },
                    { 229, 8, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 12, null, 0.0 },
                    { 230, 91, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 43, null, 0.0 },
                    { 231, 71, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 7, null, 0.0 },
                    { 232, 70, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 21, null, 0.0 },
                    { 233, 64, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 13, null, 0.0 },
                    { 234, 58, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 26, null, 0.0 },
                    { 235, 24, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 28, null, 0.0 },
                    { 236, 29, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 42, null, 0.0 },
                    { 237, 21, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, null, 0.0 },
                    { 238, 1, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 25, null, 0.0 },
                    { 239, 95, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 24, null, 0.0 },
                    { 240, 50, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 15, null, 0.0 },
                    { 241, 23, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 30, null, 0.0 },
                    { 242, 39, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 23, null, 0.0 },
                    { 243, 35, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 28, null, 0.0 },
                    { 244, 3, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 32, null, 0.0 },
                    { 245, 88, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 37, null, 0.0 },
                    { 246, 73, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 9, null, 0.0 },
                    { 247, 3, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 11, null, 0.0 },
                    { 248, 4, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, null, 0.0 },
                    { 249, 35, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 22, null, 0.0 },
                    { 250, 31, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 18, null, 0.0 },
                    { 251, 23, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 41, null, 0.0 },
                    { 252, 1, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, null, 0.0 },
                    { 253, 78, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 42, null, 0.0 },
                    { 254, 11, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 27, null, 0.0 },
                    { 255, 67, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 36, null, 0.0 },
                    { 256, 21, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, null, 0.0 },
                    { 257, 62, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 29, null, 0.0 },
                    { 258, 90, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, null, 0.0 },
                    { 259, 54, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 36, null, 0.0 },
                    { 260, 4, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 37, null, 0.0 },
                    { 261, 5, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 30, null, 0.0 },
                    { 262, 83, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Det",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 263, 4, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 8, null, 0.0 },
                    { 264, 56, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 9, null, 0.0 },
                    { 265, 40, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 22, null, 0.0 },
                    { 266, 54, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, null, 0.0 },
                    { 267, 21, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 31, null, 0.0 },
                    { 268, 69, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 12, null, 0.0 },
                    { 269, 65, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 25, null, 0.0 },
                    { 270, 87, 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 40, null, 0.0 },
                    { 271, 13, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 45, null, 0.0 },
                    { 272, 35, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 35, null, 0.0 },
                    { 273, 99, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 46, null, 0.0 },
                    { 274, 12, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 23, null, 0.0 },
                    { 275, 29, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, null, 0.0 },
                    { 276, 57, 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 26, null, 0.0 },
                    { 277, 58, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 11, null, 0.0 },
                    { 278, 37, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 32, null, 0.0 },
                    { 279, 42, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 45, null, 0.0 },
                    { 280, 88, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 22, null, 0.0 },
                    { 281, 69, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, null, 0.0 },
                    { 282, 29, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 22, null, 0.0 },
                    { 283, 59, 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 29, null, 0.0 },
                    { 284, 3, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 1, null, 0.0 },
                    { 285, 21, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 47, null, 0.0 },
                    { 286, 45, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, null, 0.0 },
                    { 287, 4, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 29, null, 0.0 },
                    { 288, 36, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 28, null, 0.0 },
                    { 289, 50, 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 47, null, 0.0 },
                    { 290, 15, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 38, null, 0.0 },
                    { 291, 61, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 40, null, 0.0 },
                    { 292, 20, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 49, null, 0.0 },
                    { 293, 89, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 31, null, 0.0 },
                    { 294, 89, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 15, null, 0.0 },
                    { 295, 40, 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 31, null, 0.0 },
                    { 296, 89, 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, null, 0.0 },
                    { 297, 27, 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 24, null, 0.0 },
                    { 298, 28, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, null, 0.0 },
                    { 299, 10, 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 44, null, 0.0 },
                    { 300, 95, 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 48, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "PlataformaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 44, 14, null },
                    { 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, 9, null },
                    { 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 11, 6, null },
                    { 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 32, 3, null },
                    { 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, 12, null },
                    { 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 42, 12, null },
                    { 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 11, 2, null },
                    { 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 21, 12, null },
                    { 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 43, 5, null },
                    { 10, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 21, 9, null },
                    { 11, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, 14, null },
                    { 12, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 37, 7, null },
                    { 13, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 40, 2, null },
                    { 14, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 31, 7, null },
                    { 15, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 32, 8, null },
                    { 16, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 22, 12, null },
                    { 17, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 22, 3, null },
                    { 18, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, 6, null },
                    { 19, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 39, 5, null },
                    { 20, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 37, 9, null },
                    { 21, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 37, 4, null },
                    { 22, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, 11, null },
                    { 23, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 31, 15, null },
                    { 24, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, 8, null },
                    { 25, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 21, 14, null },
                    { 26, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, 8, null },
                    { 27, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 5, 13, null },
                    { 28, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 28, 9, null },
                    { 29, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 25, 7, null },
                    { 30, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, 8, null },
                    { 31, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 21, 11, null },
                    { 32, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 11, 10, null },
                    { 33, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 33, 13, null },
                    { 34, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 47, 5, null },
                    { 35, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 48, 9, null },
                    { 36, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 18, 5, null },
                    { 37, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 34, 1, null },
                    { 38, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, 1, null },
                    { 39, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, 3, null },
                    { 40, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 43, 5, null },
                    { 41, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, 9, null },
                    { 42, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 8, 15, null },
                    { 43, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, 2, null },
                    { 44, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 42, 15, null },
                    { 45, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, 3, null },
                    { 46, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 30, 15, null },
                    { 47, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 24, 15, null },
                    { 48, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 45, 7, null },
                    { 49, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, 11, null },
                    { 50, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 24, 7, null },
                    { 51, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 30, 3, null },
                    { 52, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 49, 11, null },
                    { 53, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 36, 15, null },
                    { 54, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 47, 1, null },
                    { 55, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 17, 8, null },
                    { 56, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 33, 6, null },
                    { 57, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 25, 14, null },
                    { 58, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 26, 10, null },
                    { 59, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 22, 6, null },
                    { 60, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 34, 12, null },
                    { 61, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, 2, null },
                    { 62, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, 1, null },
                    { 63, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 11, 6, null },
                    { 64, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 1, 6, null },
                    { 65, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 35, 9, null },
                    { 66, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 20, 11, null },
                    { 67, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 30, 12, null },
                    { 68, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, 4, null },
                    { 69, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 37, 4, null },
                    { 70, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 31, 6, null },
                    { 71, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 48, 13, null },
                    { 72, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 21, 2, null },
                    { 73, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 18, 8, null },
                    { 74, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 14, 2, null },
                    { 75, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 27, 12, null },
                    { 76, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, 12, null },
                    { 77, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, 4, null },
                    { 78, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 7, 4, null },
                    { 79, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 24, 6, null },
                    { 80, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 33, 9, null },
                    { 81, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 38, 6, null },
                    { 82, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 13, 13, null },
                    { 83, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 34, 7, null },
                    { 84, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, 5, null },
                    { 85, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, 13, null },
                    { 86, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 28, 13, null },
                    { 87, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, 4, null },
                    { 88, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 5, 4, null },
                    { 89, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 41, 1, null },
                    { 90, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, 3, null },
                    { 91, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 36, 3, null },
                    { 92, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 37, 2, null },
                    { 93, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 40, 3, null },
                    { 94, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 30, 12, null },
                    { 95, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 39, 13, null },
                    { 96, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 32, 8, null },
                    { 97, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, 14, null },
                    { 98, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 44, 1, null },
                    { 99, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 28, 14, null },
                    { 100, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, 6, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 44, 3, null },
                    { 2, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 42, 33, null },
                    { 3, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 24, 4, null },
                    { 4, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 35, 8, null },
                    { 5, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, 11, null },
                    { 6, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 31, 17, null },
                    { 7, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 35, 12, null },
                    { 8, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 13, 9, null },
                    { 9, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 29, 17, null },
                    { 10, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 21, 8, null },
                    { 11, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 12, 33, null },
                    { 12, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 48, 9, null },
                    { 13, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, 17, null },
                    { 14, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 35, 4, null },
                    { 15, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, 6, null },
                    { 16, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 1, 23, null },
                    { 17, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 25, 10, null },
                    { 18, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 40, 34, null },
                    { 19, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 37, 33, null },
                    { 20, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 21, 6, null },
                    { 21, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 11, 15, null },
                    { 22, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 46, 17, null },
                    { 23, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 48, 26, null },
                    { 24, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, 4, null },
                    { 25, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 36, 20, null },
                    { 26, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 38, 9, null },
                    { 27, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 7, 22, null },
                    { 28, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 8, 5, null },
                    { 29, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 12, 20, null },
                    { 30, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 41, 9, null },
                    { 31, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 24, 30, null },
                    { 32, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 21, 7, null },
                    { 33, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, 19, null },
                    { 34, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 14, 13, null },
                    { 35, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 23, 11, null },
                    { 36, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, 4, null },
                    { 37, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 11, 28, null },
                    { 38, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, 5, null },
                    { 39, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, 32, null },
                    { 40, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 32, 31, null },
                    { 41, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, 3, null },
                    { 42, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 9, 5, null },
                    { 43, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 21, 24, null },
                    { 44, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 12, 29, null },
                    { 45, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 13, 35, null },
                    { 46, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 1, 16, null },
                    { 47, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, 14, null },
                    { 48, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 15, 24, null },
                    { 49, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 13, 15, null },
                    { 50, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 26, 1, null },
                    { 51, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 9, 26, null },
                    { 52, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 31, 2, null },
                    { 53, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 49, 4, null },
                    { 54, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 7, 35, null },
                    { 55, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, 35, null },
                    { 56, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, 1, null },
                    { 57, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 46, 29, null },
                    { 58, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 37, 30, null },
                    { 59, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, 32, null },
                    { 60, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 18, 10, null },
                    { 61, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 46, 34, null },
                    { 62, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, 27, null },
                    { 63, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 49, 32, null },
                    { 64, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 27, 16, null },
                    { 65, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 14, 3, null },
                    { 66, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 30, 28, null },
                    { 67, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, 28, null },
                    { 68, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, 21, null },
                    { 69, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 8, 8, null },
                    { 70, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 29, 24, null },
                    { 71, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, 17, null },
                    { 72, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 38, 3, null },
                    { 73, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 22, 32, null },
                    { 74, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 23, 8, null },
                    { 75, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 27, 25, null },
                    { 76, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 31, 20, null },
                    { 77, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 30, 28, null },
                    { 78, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, 33, null },
                    { 79, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, 35, null },
                    { 80, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 7, 10, null },
                    { 81, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, 14, null },
                    { 82, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 37, 35, null },
                    { 83, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 47, 29, null },
                    { 84, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 33, 2, null },
                    { 85, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 41, 31, null },
                    { 86, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, 30, null },
                    { 87, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 44, 35, null },
                    { 88, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 26, 30, null },
                    { 89, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 38, 11, null },
                    { 90, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, 34, null },
                    { 91, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 28, 21, null },
                    { 92, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 9, 26, null },
                    { 93, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 14, 9, null },
                    { 94, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 35, 7, null },
                    { 95, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, 2, null },
                    { 96, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 21, 11, null },
                    { 97, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 20, 23, null },
                    { 98, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, 25, null },
                    { 99, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 30, 7, null },
                    { 100, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 8, 2, null },
                    { 101, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 9, 33, null },
                    { 102, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 35, 10, null },
                    { 103, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 1, 18, null },
                    { 104, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 5, 28, null },
                    { 105, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 38, 17, null },
                    { 106, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 11, 27, null },
                    { 107, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 23, 18, null },
                    { 108, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 18, 12, null },
                    { 109, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 26, 5, null },
                    { 110, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 25, 23, null },
                    { 111, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 46, 7, null },
                    { 112, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 27, 21, null },
                    { 113, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, 23, null },
                    { 114, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 9, 24, null },
                    { 115, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, 27, null },
                    { 116, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 31, 17, null },
                    { 117, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 18, 7, null },
                    { 118, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, 27, null },
                    { 119, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 38, 7, null },
                    { 120, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, 17, null },
                    { 121, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 42, 1, null },
                    { 122, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, 27, null },
                    { 123, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 47, 15, null },
                    { 124, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 29, 29, null },
                    { 125, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 47, 24, null },
                    { 126, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 11, 31, null },
                    { 127, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, 10, null },
                    { 128, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 33, 19, null },
                    { 129, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, 34, null },
                    { 130, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 23, 32, null },
                    { 131, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, 26, null },
                    { 132, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 43, 7, null },
                    { 133, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, 17, null },
                    { 134, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 33, 26, null },
                    { 135, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, 32, null },
                    { 136, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 41, 12, null },
                    { 137, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 31, 35, null },
                    { 138, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 40, 5, null },
                    { 139, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, 11, null },
                    { 140, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 15, 25, null },
                    { 141, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, 29, null },
                    { 142, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 15, 18, null },
                    { 143, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 8, 34, null },
                    { 144, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 47, 27, null },
                    { 145, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, 28, null },
                    { 146, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, 29, null },
                    { 147, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 10, 35, null },
                    { 148, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 1, 3, null },
                    { 149, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, 11, null },
                    { 150, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 34, 6, null },
                    { 151, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, 18, null },
                    { 152, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 11, 12, null },
                    { 153, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 6, 31, null },
                    { 154, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 36, 23, null },
                    { 155, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, 24, null },
                    { 156, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 13, 1, null },
                    { 157, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 46, 13, null },
                    { 158, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 34, 22, null },
                    { 159, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 21, 20, null },
                    { 160, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 8, 24, null },
                    { 161, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 37, 6, null },
                    { 162, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 42, 6, null },
                    { 163, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, 15, null },
                    { 164, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 8, 24, null },
                    { 165, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 12, 35, null },
                    { 166, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 45, 13, null },
                    { 167, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 1, 32, null },
                    { 168, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 14, 16, null },
                    { 169, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 12, 23, null },
                    { 170, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, 21, null },
                    { 171, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 16, 34, null },
                    { 172, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 22, 16, null },
                    { 173, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, 22, null },
                    { 174, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 40, 24, null },
                    { 175, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 1, 16, null },
                    { 176, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 24, 8, null },
                    { 177, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 33, 29, null },
                    { 178, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 25, 1, null },
                    { 179, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, 8, null },
                    { 180, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 49, 33, null },
                    { 181, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 39, 14, null },
                    { 182, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 30, 23, null },
                    { 183, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 47, 34, null },
                    { 184, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 9, 4, null },
                    { 185, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 42, 35, null },
                    { 186, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 33, 27, null },
                    { 187, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 5, 24, null },
                    { 188, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 12, 28, null },
                    { 189, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 46, 7, null },
                    { 190, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, 29, null },
                    { 191, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 2, 10, null },
                    { 192, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 19, 7, null },
                    { 193, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 15, 1, null },
                    { 194, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 15, 28, null },
                    { 195, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 45, 20, null },
                    { 196, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 3, 5, null },
                    { 197, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 4, 5, null },
                    { 198, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 36, 22, null },
                    { 199, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 46, 19, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[] { 200, new DateTime(2024, 3, 13, 16, 30, 21, 498, DateTimeKind.Utc).AddTicks(6255), "Wilmilcard", 38, 20, null });

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_ClienteId",
                table: "Alquiler",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_EstadoId",
                table: "Alquiler",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_Det_AlquilerId",
                table: "Alquiler_Det",
                column: "AlquilerId");

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_Det_JuegoId",
                table: "Alquiler_Det",
                column: "JuegoId");

            migrationBuilder.CreateIndex(
                name: "IX_Director_MarcaId",
                table: "Director",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Juego_DirectorId",
                table: "Juego",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_LogLogin_UserID",
                table: "LogLogin",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Plataforma_Juego_JuegoId",
                table: "Plataforma_Juego",
                column: "JuegoId");

            migrationBuilder.CreateIndex(
                name: "IX_Plataforma_Juego_PlataformaId",
                table: "Plataforma_Juego",
                column: "PlataformaId");

            migrationBuilder.CreateIndex(
                name: "IX_Protagonista_Juego_JuegoId",
                table: "Protagonista_Juego",
                column: "JuegoId");

            migrationBuilder.CreateIndex(
                name: "IX_Protagonista_Juego_ProtagonistaId",
                table: "Protagonista_Juego",
                column: "ProtagonistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Sesion_UserID",
                table: "Sesion",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alquiler_Det");

            migrationBuilder.DropTable(
                name: "LogLogin");

            migrationBuilder.DropTable(
                name: "Plataforma_Juego");

            migrationBuilder.DropTable(
                name: "Protagonista_Juego");

            migrationBuilder.DropTable(
                name: "Sesion");

            migrationBuilder.DropTable(
                name: "Alquiler");

            migrationBuilder.DropTable(
                name: "Plataforma");

            migrationBuilder.DropTable(
                name: "Juego");

            migrationBuilder.DropTable(
                name: "Protagonista");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Director");

            migrationBuilder.DropTable(
                name: "Marca");
        }
    }
}
