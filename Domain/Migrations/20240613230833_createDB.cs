using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class createDB : Migration
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
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_User_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
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
                    UserID1 = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sesion", x => x.SesionID);
                    table.ForeignKey(
                        name: "FK_Sesion_User_UserID1",
                        column: x => x.UserID1,
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
                    { 1, "Swift", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Jeanette_Swift66@hotmail.com", new DateTime(1960, 11, 23, 13, 41, 34, 139, DateTimeKind.Local).AddTicks(1292), "765783133", "Jeanette", "Jeanette Swift", "(743) 619-1593 x127", null },
                    { 2, "Anderson", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Perry_Anderson0@yahoo.com", new DateTime(1979, 12, 21, 22, 30, 38, 783, DateTimeKind.Local).AddTicks(6089), "752600257", "Perry", "Perry Anderson", "498-939-9413 x238", null },
                    { 3, "Thompson", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Judy26@hotmail.com", new DateTime(2003, 8, 11, 21, 42, 35, 234, DateTimeKind.Local).AddTicks(5407), "112926297", "Judy", "Judy Thompson", "231.269.4337", null },
                    { 4, "Howe", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Regina40@yahoo.com", new DateTime(1954, 6, 13, 20, 40, 20, 420, DateTimeKind.Local).AddTicks(5009), "927329890", "Regina", "Regina Howe", "379.580.4615", null },
                    { 5, "Lueilwitz", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Jim55@yahoo.com", new DateTime(1999, 9, 16, 17, 54, 12, 980, DateTimeKind.Local).AddTicks(9211), "427095147", "Jim", "Jim Lueilwitz", "974-308-8844 x11948", null },
                    { 6, "Kozey", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Darren73@yahoo.com", new DateTime(1992, 9, 15, 0, 1, 10, 22, DateTimeKind.Local).AddTicks(5975), "982053476", "Darren", "Darren Kozey", "(835) 447-4493", null },
                    { 7, "Langosh", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Sara_Langosh@hotmail.com", new DateTime(1962, 1, 6, 2, 49, 9, 819, DateTimeKind.Local).AddTicks(8646), "973983453", "Sara", "Sara Langosh", "(302) 815-2788", null },
                    { 8, "Russel", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Lucille.Russel37@hotmail.com", new DateTime(1975, 10, 21, 15, 39, 23, 784, DateTimeKind.Local).AddTicks(9330), "585482117", "Lucille", "Lucille Russel", "(638) 560-7582 x6336", null },
                    { 9, "Padberg", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Marcus.Padberg27@yahoo.com", new DateTime(1980, 12, 17, 16, 43, 35, 837, DateTimeKind.Local).AddTicks(8343), "758279721", "Marcus", "Marcus Padberg", "1-574-501-4725 x33815", null },
                    { 10, "Mayert", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Gloria11@hotmail.com", new DateTime(1990, 1, 31, 12, 43, 25, 350, DateTimeKind.Local).AddTicks(8147), "183381586", "Gloria", "Gloria Mayert", "676.654.2903", null },
                    { 11, "Koch", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Jennifer_Koch@gmail.com", new DateTime(1980, 7, 20, 0, 15, 53, 470, DateTimeKind.Local).AddTicks(2632), "386132990", "Jennifer", "Jennifer Koch", "562.310.4572 x523", null },
                    { 12, "Hermann", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Crystal48@hotmail.com", new DateTime(1975, 8, 9, 6, 22, 31, 546, DateTimeKind.Local).AddTicks(9927), "226574384", "Crystal", "Crystal Hermann", "297-419-9788", null },
                    { 13, "Torphy", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Nadine_Torphy80@gmail.com", new DateTime(1998, 1, 30, 7, 52, 34, 981, DateTimeKind.Local).AddTicks(4212), "548644449", "Nadine", "Nadine Torphy", "(737) 382-3710 x5896", null },
                    { 14, "Anderson", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Jimmy_Anderson28@hotmail.com", new DateTime(1988, 1, 15, 14, 34, 21, 378, DateTimeKind.Local).AddTicks(9209), "687005387", "Jimmy", "Jimmy Anderson", "273-510-0163 x02461", null },
                    { 15, "Brown", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Alberta26@hotmail.com", new DateTime(1996, 10, 7, 16, 40, 27, 281, DateTimeKind.Local).AddTicks(8050), "601588566", "Alberta", "Alberta Brown", "1-870-530-2766 x7880", null },
                    { 16, "Stamm", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Faith93@yahoo.com", new DateTime(1958, 4, 14, 21, 27, 27, 702, DateTimeKind.Local).AddTicks(1277), "435689563", "Faith", "Faith Stamm", "814-227-9811 x225", null },
                    { 17, "Carter", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Edwin.Carter91@yahoo.com", new DateTime(1985, 7, 16, 17, 15, 23, 53, DateTimeKind.Local).AddTicks(9419), "974018991", "Edwin", "Edwin Carter", "(837) 606-8630 x472", null },
                    { 18, "Wisozk", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Jonathon_Wisozk@hotmail.com", new DateTime(1978, 7, 6, 20, 6, 7, 516, DateTimeKind.Local).AddTicks(6087), "667908234", "Jonathon", "Jonathon Wisozk", "(411) 328-2805 x20133", null },
                    { 19, "Okuneva", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Wanda85@yahoo.com", new DateTime(2002, 5, 29, 12, 38, 42, 823, DateTimeKind.Local).AddTicks(8488), "531756175", "Wanda", "Wanda Okuneva", "1-733-401-5084 x2578", null },
                    { 20, "Heathcote", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Sherman66@hotmail.com", new DateTime(1976, 3, 6, 2, 9, 26, 384, DateTimeKind.Local).AddTicks(71), "657783292", "Sherman", "Sherman Heathcote", "(280) 569-9642 x831", null },
                    { 21, "Goyette", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Wm5@gmail.com", new DateTime(1976, 7, 5, 19, 21, 51, 81, DateTimeKind.Local).AddTicks(9862), "926018974", "Wm", "Wm Goyette", "697.774.2099", null },
                    { 22, "Bosco", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Mable.Bosco@gmail.com", new DateTime(1996, 2, 22, 3, 22, 16, 737, DateTimeKind.Local).AddTicks(4753), "850085921", "Mable", "Mable Bosco", "302-308-2340 x1320", null },
                    { 23, "Schowalter", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Carolyn.Schowalter8@hotmail.com", new DateTime(1988, 4, 10, 17, 34, 42, 381, DateTimeKind.Local).AddTicks(3833), "314831086", "Carolyn", "Carolyn Schowalter", "1-235-411-1497 x157", null },
                    { 24, "Cremin", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Elena.Cremin@yahoo.com", new DateTime(2003, 6, 26, 15, 23, 50, 836, DateTimeKind.Local).AddTicks(7396), "451064454", "Elena", "Elena Cremin", "936.806.6962 x604", null },
                    { 25, "Koch", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Misty_Koch@gmail.com", new DateTime(1981, 1, 22, 19, 43, 45, 477, DateTimeKind.Local).AddTicks(3624), "531981954", "Misty", "Misty Koch", "548.852.5750", null },
                    { 26, "Zulauf", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Alton.Zulauf@yahoo.com", new DateTime(1969, 2, 12, 19, 37, 50, 54, DateTimeKind.Local).AddTicks(1045), "282831160", "Alton", "Alton Zulauf", "1-864-516-9706 x179", null },
                    { 27, "O'Connell", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Jerome.OConnell67@yahoo.com", new DateTime(1970, 6, 12, 16, 27, 15, 164, DateTimeKind.Local).AddTicks(8637), "572550366", "Jerome", "Jerome O'Connell", "1-871-843-3092 x727", null },
                    { 28, "Herzog", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Sammy91@yahoo.com", new DateTime(1977, 7, 13, 6, 33, 49, 880, DateTimeKind.Local).AddTicks(4780), "905379465", "Sammy", "Sammy Herzog", "1-409-722-9370 x70174", null },
                    { 29, "Hilpert", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Lisa45@yahoo.com", new DateTime(1997, 12, 9, 7, 4, 49, 240, DateTimeKind.Local).AddTicks(1765), "487477533", "Lisa", "Lisa Hilpert", "(404) 298-0428", null },
                    { 30, "Erdman", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Katherine38@yahoo.com", new DateTime(1988, 12, 11, 10, 20, 51, 208, DateTimeKind.Local).AddTicks(2797), "794561692", "Katherine", "Katherine Erdman", "(610) 652-2095 x1049", null },
                    { 31, "Marvin", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Daniel_Marvin97@yahoo.com", new DateTime(1998, 8, 8, 12, 8, 50, 551, DateTimeKind.Local).AddTicks(9305), "492398463", "Daniel", "Daniel Marvin", "343.337.3734 x5872", null },
                    { 32, "Leannon", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Leonard13@yahoo.com", new DateTime(1963, 8, 7, 9, 33, 56, 341, DateTimeKind.Local).AddTicks(7901), "669583017", "Leonard", "Leonard Leannon", "(913) 546-2206 x1788", null },
                    { 33, "Reynolds", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Bobbie_Reynolds@hotmail.com", new DateTime(1992, 11, 9, 13, 53, 29, 134, DateTimeKind.Local).AddTicks(3815), "648032053", "Bobbie", "Bobbie Reynolds", "323.948.6801 x7536", null },
                    { 34, "Stamm", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Cory_Stamm23@yahoo.com", new DateTime(1962, 8, 30, 7, 43, 36, 500, DateTimeKind.Local).AddTicks(6858), "858036448", "Cory", "Cory Stamm", "(892) 513-8394 x101", null },
                    { 35, "Lehner", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Forrest_Lehner63@yahoo.com", new DateTime(1988, 8, 6, 14, 49, 56, 123, DateTimeKind.Local).AddTicks(4616), "121502699", "Forrest", "Forrest Lehner", "1-717-509-2090 x5943", null },
                    { 36, "Labadie", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Paul45@gmail.com", new DateTime(1993, 2, 7, 22, 1, 59, 481, DateTimeKind.Local).AddTicks(3575), "969728316", "Paul", "Paul Labadie", "1-515-294-2257", null },
                    { 37, "Terry", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Billie.Terry@yahoo.com", new DateTime(1997, 4, 17, 20, 50, 29, 520, DateTimeKind.Local).AddTicks(2895), "646627958", "Billie", "Billie Terry", "343-647-3206", null },
                    { 38, "Schmidt", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Tommy_Schmidt@yahoo.com", new DateTime(1992, 7, 16, 5, 57, 34, 456, DateTimeKind.Local).AddTicks(2780), "569315247", "Tommy", "Tommy Schmidt", "1-373-346-1050 x2404", null },
                    { 39, "Kuhn", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Darryl30@gmail.com", new DateTime(1956, 1, 8, 23, 40, 10, 922, DateTimeKind.Local).AddTicks(2800), "703053687", "Darryl", "Darryl Kuhn", "1-770-536-3352", null },
                    { 40, "Simonis", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Lloyd49@gmail.com", new DateTime(1977, 8, 27, 14, 43, 37, 946, DateTimeKind.Local).AddTicks(7911), "451219384", "Lloyd", "Lloyd Simonis", "1-296-841-6318", null },
                    { 41, "Mertz", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Patricia8@yahoo.com", new DateTime(1994, 9, 13, 0, 13, 19, 913, DateTimeKind.Local).AddTicks(5189), "337709526", "Patricia", "Patricia Mertz", "1-274-739-5380", null },
                    { 42, "Trantow", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Margarita.Trantow@hotmail.com", new DateTime(1956, 4, 9, 20, 59, 49, 606, DateTimeKind.Local).AddTicks(8923), "510333528", "Margarita", "Margarita Trantow", "417.426.2943", null },
                    { 43, "Crooks", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Madeline67@yahoo.com", new DateTime(1981, 2, 12, 7, 28, 1, 996, DateTimeKind.Local).AddTicks(5768), "117788233", "Madeline", "Madeline Crooks", "(373) 643-7692 x17063", null },
                    { 44, "Mertz", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Terrell59@yahoo.com", new DateTime(1976, 5, 25, 5, 12, 2, 237, DateTimeKind.Local).AddTicks(34), "320604369", "Terrell", "Terrell Mertz", "213-382-9362 x0007", null },
                    { 45, "Schimmel", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Isaac.Schimmel1@hotmail.com", new DateTime(1987, 5, 11, 6, 1, 6, 414, DateTimeKind.Local).AddTicks(2233), "850772483", "Isaac", "Isaac Schimmel", "(908) 494-6929 x948", null },
                    { 46, "Romaguera", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Vernon_Romaguera25@gmail.com", new DateTime(1983, 5, 10, 9, 30, 58, 56, DateTimeKind.Local).AddTicks(6948), "515241704", "Vernon", "Vernon Romaguera", "1-430-409-1457 x04139", null },
                    { 47, "Strosin", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Virginia.Strosin76@hotmail.com", new DateTime(1982, 10, 6, 18, 18, 42, 653, DateTimeKind.Local).AddTicks(8044), "866443395", "Virginia", "Virginia Strosin", "(525) 733-1446 x71261", null },
                    { 48, "Morissette", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Roman.Morissette26@yahoo.com", new DateTime(1980, 2, 8, 21, 12, 45, 595, DateTimeKind.Local).AddTicks(2081), "173056115", "Roman", "Roman Morissette", "1-694-725-1366 x7851", null },
                    { 49, "Halvorson", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Alyssa_Halvorson@hotmail.com", new DateTime(1990, 10, 29, 9, 33, 18, 236, DateTimeKind.Local).AddTicks(1257), "900275565", "Alyssa", "Alyssa Halvorson", "999-677-1171", null },
                    { 50, "Hoppe", new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Kara_Hoppe6@gmail.com", new DateTime(1990, 2, 1, 5, 57, 0, 622, DateTimeKind.Local).AddTicks(2368), "348532660", "Kara", "Kara Hoppe", "784-384-1236 x55666", null }
                });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "EstadoId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Activo", null },
                    { 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Inactivo", null },
                    { 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Devuelto", null },
                    { 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Prestamo", null },
                    { 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Error", null }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "MarcaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Microsoft", null },
                    { 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Sony", null },
                    { 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "EA", null },
                    { 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Ubisoft", null },
                    { 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Rovio", null },
                    { 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Activision", null },
                    { 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Nintendo", null },
                    { 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Rockstar", null },
                    { 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "CD Project Red", null },
                    { 10, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Annapurna Interactive", null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma",
                columns: new[] { "PlataformaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "PC", null },
                    { 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Xbox", null },
                    { 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Xbox 360", null },
                    { 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Xbox ONE", null },
                    { 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Xbox X", null },
                    { 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "PSP Vita", null },
                    { 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "PlayStation", null },
                    { 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "PlayStation 2", null },
                    { 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "PlayStation 3", null },
                    { 10, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "PlayStation 4", null },
                    { 11, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "PlayStation 5", null },
                    { 12, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Nintendo 64", null },
                    { 13, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Nintendo DS", null },
                    { 14, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Nintendo Switch", null },
                    { 15, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Android", null },
                    { 16, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "IOS", null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista",
                columns: new[] { "ProtagonistaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Mario Bross", null },
                    { 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Tommy Vercetti", null },
                    { 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Altaïr Ibn-La'Ahad", null },
                    { 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Natan Drake", null },
                    { 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Crash Bandicoot", null },
                    { 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Samus Aran", null },
                    { 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "John-117", null },
                    { 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Aiden Perce", null },
                    { 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Carl Jhonson", null },
                    { 10, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Red", null },
                    { 11, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Crazy Dave", null },
                    { 12, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Spyro", null },
                    { 13, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Marcus Fenix", null },
                    { 14, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Vass", null },
                    { 15, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Gordon Freeman", null },
                    { 16, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Joel", null },
                    { 17, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Jill Valentine", null },
                    { 18, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Zelda", null },
                    { 19, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Link", null },
                    { 20, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Glados", null },
                    { 21, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Meet Boy", null },
                    { 22, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Geralt de Rivia", null },
                    { 23, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Steve", null },
                    { 24, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Ellie", null },
                    { 25, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Faith", null },
                    { 26, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Bayonetta", null },
                    { 27, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Tracer", null },
                    { 28, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Pacman", null },
                    { 29, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Chris Redfield", null },
                    { 30, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Leon S. Kennedy", null },
                    { 31, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Agente 47", null },
                    { 32, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Haytham Kenway", null },
                    { 33, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Lara Croft", null },
                    { 34, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Ryu", null },
                    { 35, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Mega Man", null },
                    { 36, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", "Sonic", null }
                });

            migrationBuilder.InsertData(
                table: "Alquiler",
                columns: new[] { "AlquilerId", "ClienteId", "CreatedAt", "CreatedBy", "EstadoId", "Fecha_Devolucion", "Fecha_Reservacion", "UpdatedAt", "Valor_Total" },
                values: new object[,]
                {
                    { 1, 25, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15776.0 },
                    { 2, 16, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15212.0 },
                    { 3, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19031.0 },
                    { 4, 32, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19650.0 },
                    { 5, 47, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17190.0 },
                    { 6, 11, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16324.0 },
                    { 7, 32, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17320.0 },
                    { 8, 42, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18639.0 },
                    { 9, 44, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15744.0 },
                    { 10, 49, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15744.0 },
                    { 11, 18, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19135.0 },
                    { 12, 42, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17586.0 },
                    { 13, 36, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17535.0 },
                    { 14, 48, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18714.0 },
                    { 15, 14, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19075.0 },
                    { 16, 26, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16250.0 },
                    { 17, 28, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15294.0 },
                    { 18, 27, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18143.0 },
                    { 19, 18, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18777.0 },
                    { 20, 17, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18635.0 },
                    { 21, 45, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18089.0 },
                    { 22, 11, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19429.0 },
                    { 23, 18, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15501.0 },
                    { 24, 16, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16144.0 },
                    { 25, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18190.0 },
                    { 26, 47, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15930.0 },
                    { 27, 16, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16875.0 },
                    { 28, 35, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17519.0 },
                    { 29, 26, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15073.0 },
                    { 30, 25, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19177.0 },
                    { 31, 13, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17150.0 },
                    { 32, 48, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15183.0 },
                    { 33, 32, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17235.0 },
                    { 34, 30, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19858.0 },
                    { 35, 37, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18198.0 },
                    { 36, 30, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18201.0 },
                    { 37, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18275.0 },
                    { 38, 13, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15719.0 },
                    { 39, 32, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19204.0 },
                    { 40, 34, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19777.0 },
                    { 41, 43, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16142.0 },
                    { 42, 12, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18256.0 },
                    { 43, 36, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16816.0 },
                    { 44, 42, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17307.0 },
                    { 45, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16329.0 },
                    { 46, 21, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19692.0 },
                    { 47, 42, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16207.0 },
                    { 48, 48, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15529.0 },
                    { 49, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19943.0 },
                    { 50, 46, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18695.0 },
                    { 51, 18, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15604.0 },
                    { 52, 38, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15381.0 },
                    { 53, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18903.0 },
                    { 54, 30, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18833.0 },
                    { 55, 39, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18625.0 },
                    { 56, 23, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16682.0 },
                    { 57, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18923.0 },
                    { 58, 49, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15344.0 },
                    { 59, 21, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17716.0 },
                    { 60, 48, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17197.0 },
                    { 61, 43, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19923.0 },
                    { 62, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16780.0 },
                    { 63, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16599.0 },
                    { 64, 25, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17689.0 },
                    { 65, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17563.0 },
                    { 66, 43, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17434.0 },
                    { 67, 43, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19625.0 },
                    { 68, 21, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15053.0 },
                    { 69, 35, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17316.0 },
                    { 70, 49, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16901.0 },
                    { 71, 46, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18081.0 },
                    { 72, 44, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19986.0 },
                    { 73, 29, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15237.0 },
                    { 74, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19436.0 },
                    { 75, 17, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18354.0 },
                    { 76, 23, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18391.0 },
                    { 77, 45, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15770.0 },
                    { 78, 40, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17241.0 },
                    { 79, 14, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16602.0 },
                    { 80, 31, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17169.0 },
                    { 81, 12, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15692.0 },
                    { 82, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15858.0 },
                    { 83, 49, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19548.0 },
                    { 84, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18896.0 },
                    { 85, 23, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16878.0 },
                    { 86, 32, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17845.0 },
                    { 87, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19272.0 },
                    { 88, 31, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18209.0 },
                    { 89, 34, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16650.0 },
                    { 90, 35, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15002.0 },
                    { 91, 44, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17560.0 },
                    { 92, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18745.0 },
                    { 93, 13, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17614.0 },
                    { 94, 49, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15877.0 },
                    { 95, 48, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18909.0 },
                    { 96, 13, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18998.0 },
                    { 97, 21, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19106.0 },
                    { 98, 19, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15559.0 },
                    { 99, 39, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18143.0 },
                    { 100, 23, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18940.0 }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "DirectorId", "CreatedAt", "CreatedBy", "MarcaId", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 8, "Hideo Kojima", null },
                    { 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 8, "Will Wriths", null },
                    { 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 5, "Hidetaka Miyazaki", null },
                    { 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, "Tim Schafer", null },
                    { 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 5, "Ken Levine", null },
                    { 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 2, "Fumito Ueda", null },
                    { 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 6, "Yves Guillemot", null },
                    { 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 6, "Gabe Newell", null },
                    { 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 6, "Tom Howard", null },
                    { 10, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 8, "Yoko Taro", null },
                    { 11, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, "Shigeru Miyamoto", null },
                    { 12, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, "Amy Hennig", null },
                    { 13, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 8, "Michel Ancel", null },
                    { 14, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 8, "Goichi Suda", null },
                    { 15, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, "Warren Spector", null },
                    { 16, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 6, "John Romero", null },
                    { 17, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 6, "Yuji Horii", null },
                    { 18, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 1, "Yuji Naka", null },
                    { 19, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 2, "Sid Meier", null },
                    { 20, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, "John Carmack", null },
                    { 21, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 8, "Keiji Inafune", null },
                    { 22, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 5, "Hironobu Sakaguchi", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "AccessFailCount", "ClienteId", "CreatedAt", "CreatedBy", "IsActive", "IsAdmin", "IsPasswordChange", "PasswordHash", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1, (sbyte)0, 16, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", true, true, true, "81DC9BDB52D04DC223B621240E3DD8B7", null, "ADMIN" },
                    { 2, (sbyte)0, 34, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", true, false, false, "66628C8FB6D6399925E8B29A3CDC3E37", null, "DEV" }
                });

            migrationBuilder.InsertData(
                table: "Juego",
                columns: new[] { "JuegoId", "CreatedAt", "CreatedBy", "DirectorId", "Lanzamiento", "Nombre", "Precio", "Stock", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 16, new DateTime(2001, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassins Creed I", 182331.0, 6, null },
                    { 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 2, new DateTime(2017, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassins Creed Valhalla", 142180.0, 2, null },
                    { 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(1998, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA III", 145022.0, 4, null },
                    { 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 17, new DateTime(2004, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA Vice City", 225053.0, 11, null },
                    { 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2004, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA San Andreas", 164134.0, 12, null },
                    { 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 6, new DateTime(1999, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA IV", 270833.0, 7, null },
                    { 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, new DateTime(2003, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA V", 71854.0, 6, null },
                    { 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 2, new DateTime(1996, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 17", 94455.0, 3, null },
                    { 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 11, new DateTime(2014, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 18", 99138.0, 14, null },
                    { 10, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 14, new DateTime(2016, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 19", 146440.0, 14, null },
                    { 11, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 16, new DateTime(2005, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 20", 176413.0, 8, null },
                    { 12, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 20, new DateTime(2013, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 21", 312348.0, 7, null },
                    { 13, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 10, new DateTime(2007, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", 177888.0, 3, null },
                    { 14, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 13, new DateTime(2016, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gears Of War", 246707.0, 5, null },
                    { 15, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 13, new DateTime(2020, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watch_Dogs", 231507.0, 13, null },
                    { 16, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 19, new DateTime(2006, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watch_Dogs 2", 317653.0, 5, null },
                    { 17, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 14, new DateTime(2003, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher", 65607.0, 8, null },
                    { 18, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 20, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 2", 30309.0, 3, null },
                    { 19, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 8, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3", 278827.0, 10, null },
                    { 20, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 1, new DateTime(2013, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon", 245778.0, 12, null },
                    { 21, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2006, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires", 31827.0, 2, null },
                    { 22, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 17, new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires II", 219373.0, 14, null },
                    { 23, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 2, new DateTime(2018, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires III", 26697.0, 9, null },
                    { 24, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 12, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires IV", 105886.0, 2, null },
                    { 25, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 5, new DateTime(2014, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption II", 275661.0, 12, null },
                    { 26, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 14, new DateTime(2011, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "DOOM", 180532.0, 8, null },
                    { 27, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 14, new DateTime(2001, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pong", 110771.0, 11, null },
                    { 28, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 13, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims", 172264.0, 2, null },
                    { 29, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 2, new DateTime(2012, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims 2", 264547.0, 13, null },
                    { 30, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 18, new DateTime(2004, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halo", 187331.0, 9, null },
                    { 31, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 2, new DateTime(2011, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angry Birds", 160690.0, 11, null },
                    { 32, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, new DateTime(2002, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plants vs Zombies", 80248.0, 9, null },
                    { 33, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 17, new DateTime(2016, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battlefield 3", 72096.0, 14, null },
                    { 34, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 15, new DateTime(1999, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fligth Simulation", 290294.0, 14, null },
                    { 35, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 21, new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chivarly II", 184384.0, 4, null },
                    { 36, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 1, new DateTime(2010, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pureya", 304487.0, 12, null },
                    { 37, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 15, new DateTime(2019, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rust", 232564.0, 6, null },
                    { 38, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 14, new DateTime(2011, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mass Effect: Legendary Edition", 210127.0, 8, null },
                    { 39, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 18, new DateTime(2013, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", 95258.0, 8, null },
                    { 40, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2008, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us 2", 46755.0, 11, null },
                    { 41, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 8, new DateTime(2009, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwatch", 157339.0, 3, null },
                    { 42, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 16, new DateTime(2007, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "NBA 2K21", 42915.0, 14, null },
                    { 43, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 9, new DateTime(2005, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fortnite", 126959.0, 13, null },
                    { 44, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(1996, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Squadrons", 86745.0, 9, null },
                    { 45, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 9, new DateTime(2008, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil 8: Village", 204673.0, 3, null },
                    { 46, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 11, new DateTime(2000, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroes of the Storm", 139731.0, 14, null },
                    { 47, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 19, new DateTime(1999, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battefield 4", 242393.0, 9, null },
                    { 48, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, new DateTime(2008, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battlefield 2042", 308528.0, 7, null },
                    { 49, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, new DateTime(2017, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "florence", 82356.0, 4, null },
                    { 50, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 16, new DateTime(2015, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "portal", 261115.0, 12, null }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Det",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 1, 80, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 27, null, 0.0 },
                    { 2, 27, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 22, null, 0.0 },
                    { 3, 72, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 32, null, 0.0 },
                    { 4, 40, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 9, null, 0.0 },
                    { 5, 30, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, null, 0.0 },
                    { 6, 91, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, null, 0.0 },
                    { 7, 30, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 36, null, 0.0 },
                    { 8, 70, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 18, null, 0.0 },
                    { 9, 25, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 31, null, 0.0 },
                    { 10, 21, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 16, null, 0.0 },
                    { 11, 57, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 47, null, 0.0 },
                    { 12, 18, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 19, null, 0.0 },
                    { 13, 89, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 49, null, 0.0 },
                    { 14, 82, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 11, null, 0.0 },
                    { 15, 69, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 43, null, 0.0 },
                    { 16, 47, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 11, null, 0.0 },
                    { 17, 92, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 16, null, 0.0 },
                    { 18, 24, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 41, null, 0.0 },
                    { 19, 73, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 14, null, 0.0 },
                    { 20, 71, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 31, null, 0.0 },
                    { 21, 87, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 10, null, 0.0 },
                    { 22, 61, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 45, null, 0.0 },
                    { 23, 99, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 42, null, 0.0 },
                    { 24, 11, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 20, null, 0.0 },
                    { 25, 53, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 30, null, 0.0 },
                    { 26, 31, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 46, null, 0.0 },
                    { 27, 65, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 48, null, 0.0 },
                    { 28, 13, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 23, null, 0.0 },
                    { 29, 51, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, null, 0.0 },
                    { 30, 85, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 41, null, 0.0 },
                    { 31, 82, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 26, null, 0.0 },
                    { 32, 16, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 22, null, 0.0 },
                    { 33, 81, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 33, null, 0.0 },
                    { 34, 15, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 41, null, 0.0 },
                    { 35, 44, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 5, null, 0.0 },
                    { 36, 19, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 49, null, 0.0 },
                    { 37, 9, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 11, null, 0.0 },
                    { 38, 70, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 6, null, 0.0 },
                    { 39, 71, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 22, null, 0.0 },
                    { 40, 57, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 6, null, 0.0 },
                    { 41, 23, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 34, null, 0.0 },
                    { 42, 32, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, null, 0.0 },
                    { 43, 50, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 19, null, 0.0 },
                    { 44, 24, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 13, null, 0.0 },
                    { 45, 11, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 16, null, 0.0 },
                    { 46, 17, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 30, null, 0.0 },
                    { 47, 59, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 49, null, 0.0 },
                    { 48, 52, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 14, null, 0.0 },
                    { 49, 91, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 9, null, 0.0 },
                    { 50, 36, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 42, null, 0.0 },
                    { 51, 70, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 38, null, 0.0 },
                    { 52, 96, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, null, 0.0 },
                    { 53, 5, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 18, null, 0.0 },
                    { 54, 63, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 49, null, 0.0 },
                    { 55, 83, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 6, null, 0.0 },
                    { 56, 30, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 44, null, 0.0 },
                    { 57, 49, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 8, null, 0.0 },
                    { 58, 39, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 32, null, 0.0 },
                    { 59, 85, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, null, 0.0 },
                    { 60, 36, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 22, null, 0.0 },
                    { 61, 18, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 24, null, 0.0 },
                    { 62, 52, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 43, null, 0.0 },
                    { 63, 52, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 36, null, 0.0 },
                    { 64, 3, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 15, null, 0.0 },
                    { 65, 3, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 27, null, 0.0 },
                    { 66, 18, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 28, null, 0.0 },
                    { 67, 25, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 36, null, 0.0 },
                    { 68, 61, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 8, null, 0.0 },
                    { 69, 52, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 13, null, 0.0 },
                    { 70, 1, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 27, null, 0.0 },
                    { 71, 88, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 31, null, 0.0 },
                    { 72, 70, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 42, null, 0.0 },
                    { 73, 97, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 5, null, 0.0 },
                    { 74, 76, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 36, null, 0.0 },
                    { 75, 5, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, null, 0.0 },
                    { 76, 32, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 32, null, 0.0 },
                    { 77, 54, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 44, null, 0.0 },
                    { 78, 69, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 6, null, 0.0 },
                    { 79, 61, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 27, null, 0.0 },
                    { 80, 3, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 13, null, 0.0 },
                    { 81, 38, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 38, null, 0.0 },
                    { 82, 45, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 42, null, 0.0 },
                    { 83, 19, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 46, null, 0.0 },
                    { 84, 67, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 31, null, 0.0 },
                    { 85, 95, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 15, null, 0.0 },
                    { 86, 82, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 28, null, 0.0 },
                    { 87, 58, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 33, null, 0.0 },
                    { 88, 34, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 12, null, 0.0 },
                    { 89, 75, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 19, null, 0.0 },
                    { 90, 98, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 25, null, 0.0 },
                    { 91, 30, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 45, null, 0.0 },
                    { 92, 27, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 5, null, 0.0 },
                    { 93, 46, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 45, null, 0.0 },
                    { 94, 46, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 10, null, 0.0 },
                    { 95, 66, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 34, null, 0.0 },
                    { 96, 18, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 32, null, 0.0 },
                    { 97, 92, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 49, null, 0.0 },
                    { 98, 83, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 21, null, 0.0 },
                    { 99, 95, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 2, null, 0.0 },
                    { 100, 65, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 24, null, 0.0 },
                    { 101, 7, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 19, null, 0.0 },
                    { 102, 83, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 20, null, 0.0 },
                    { 103, 37, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 45, null, 0.0 },
                    { 104, 66, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 6, null, 0.0 },
                    { 105, 4, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 36, null, 0.0 },
                    { 106, 37, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 42, null, 0.0 },
                    { 107, 41, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 49, null, 0.0 },
                    { 108, 80, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 42, null, 0.0 },
                    { 109, 73, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 42, null, 0.0 },
                    { 110, 97, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 47, null, 0.0 },
                    { 111, 77, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 15, null, 0.0 },
                    { 112, 40, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 30, null, 0.0 },
                    { 113, 21, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 5, null, 0.0 },
                    { 114, 19, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 29, null, 0.0 },
                    { 115, 66, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 18, null, 0.0 },
                    { 116, 70, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 15, null, 0.0 },
                    { 117, 2, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 37, null, 0.0 },
                    { 118, 68, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, null, 0.0 },
                    { 119, 1, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 32, null, 0.0 },
                    { 120, 87, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 22, null, 0.0 },
                    { 121, 66, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 15, null, 0.0 },
                    { 122, 75, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 44, null, 0.0 },
                    { 123, 27, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 45, null, 0.0 },
                    { 124, 77, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 10, null, 0.0 },
                    { 125, 63, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 44, null, 0.0 },
                    { 126, 35, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 20, null, 0.0 },
                    { 127, 84, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 2, null, 0.0 },
                    { 128, 6, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 19, null, 0.0 },
                    { 129, 90, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 21, null, 0.0 },
                    { 130, 71, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 2, null, 0.0 },
                    { 131, 92, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 25, null, 0.0 },
                    { 132, 29, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 40, null, 0.0 },
                    { 133, 86, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 35, null, 0.0 },
                    { 134, 65, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 45, null, 0.0 },
                    { 135, 7, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 45, null, 0.0 },
                    { 136, 73, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 19, null, 0.0 },
                    { 137, 92, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 43, null, 0.0 },
                    { 138, 56, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 30, null, 0.0 },
                    { 139, 51, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 18, null, 0.0 },
                    { 140, 15, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 38, null, 0.0 },
                    { 141, 76, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 30, null, 0.0 },
                    { 142, 55, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 26, null, 0.0 },
                    { 143, 48, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 20, null, 0.0 },
                    { 144, 63, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 43, null, 0.0 },
                    { 145, 9, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 37, null, 0.0 },
                    { 146, 34, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 40, null, 0.0 },
                    { 147, 25, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 9, null, 0.0 },
                    { 148, 66, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 29, null, 0.0 },
                    { 149, 65, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 23, null, 0.0 },
                    { 150, 38, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 1, null, 0.0 },
                    { 151, 65, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 39, null, 0.0 },
                    { 152, 11, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, null, 0.0 },
                    { 153, 3, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 12, null, 0.0 },
                    { 154, 57, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 39, null, 0.0 },
                    { 155, 22, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 32, null, 0.0 },
                    { 156, 34, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 25, null, 0.0 },
                    { 157, 36, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 41, null, 0.0 },
                    { 158, 65, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 9, null, 0.0 },
                    { 159, 32, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 42, null, 0.0 },
                    { 160, 95, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 42, null, 0.0 },
                    { 161, 64, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 1, null, 0.0 },
                    { 162, 56, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 46, null, 0.0 },
                    { 163, 20, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 47, null, 0.0 },
                    { 164, 64, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 28, null, 0.0 },
                    { 165, 66, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 36, null, 0.0 },
                    { 166, 35, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 39, null, 0.0 },
                    { 167, 34, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 26, null, 0.0 },
                    { 168, 80, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 5, null, 0.0 },
                    { 169, 28, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 8, null, 0.0 },
                    { 170, 40, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 1, null, 0.0 },
                    { 171, 48, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 43, null, 0.0 },
                    { 172, 18, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 26, null, 0.0 },
                    { 173, 20, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 23, null, 0.0 },
                    { 174, 57, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 17, null, 0.0 },
                    { 175, 77, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 26, null, 0.0 },
                    { 176, 5, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 29, null, 0.0 },
                    { 177, 61, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 21, null, 0.0 },
                    { 178, 49, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 1, null, 0.0 },
                    { 179, 20, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 29, null, 0.0 },
                    { 180, 28, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 29, null, 0.0 },
                    { 181, 40, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 30, null, 0.0 },
                    { 182, 72, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 46, null, 0.0 },
                    { 183, 40, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 9, null, 0.0 },
                    { 184, 95, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 27, null, 0.0 },
                    { 185, 95, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 45, null, 0.0 },
                    { 186, 73, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 19, null, 0.0 },
                    { 187, 40, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 9, null, 0.0 },
                    { 188, 19, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 35, null, 0.0 },
                    { 189, 92, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 1, null, 0.0 },
                    { 190, 10, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 25, null, 0.0 },
                    { 191, 2, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 32, null, 0.0 },
                    { 192, 97, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 24, null, 0.0 },
                    { 193, 17, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 27, null, 0.0 },
                    { 194, 59, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 36, null, 0.0 },
                    { 195, 89, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 11, null, 0.0 },
                    { 196, 69, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 8, null, 0.0 },
                    { 197, 61, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 2, null, 0.0 },
                    { 198, 33, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 20, null, 0.0 },
                    { 199, 14, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 37, null, 0.0 },
                    { 200, 98, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 10, null, 0.0 },
                    { 201, 6, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 20, null, 0.0 },
                    { 202, 35, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 17, null, 0.0 },
                    { 203, 52, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 33, null, 0.0 },
                    { 204, 31, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 39, null, 0.0 },
                    { 205, 70, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 46, null, 0.0 },
                    { 206, 37, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 36, null, 0.0 },
                    { 207, 65, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 38, null, 0.0 },
                    { 208, 7, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 44, null, 0.0 },
                    { 209, 58, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 30, null, 0.0 },
                    { 210, 49, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 18, null, 0.0 },
                    { 211, 94, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, null, 0.0 },
                    { 212, 20, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 34, null, 0.0 },
                    { 213, 87, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 19, null, 0.0 },
                    { 214, 97, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 17, null, 0.0 },
                    { 215, 68, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 42, null, 0.0 },
                    { 216, 67, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 1, null, 0.0 },
                    { 217, 25, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 47, null, 0.0 },
                    { 218, 62, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 33, null, 0.0 },
                    { 219, 20, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 11, null, 0.0 },
                    { 220, 66, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 6, null, 0.0 },
                    { 221, 28, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 49, null, 0.0 },
                    { 222, 59, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 38, null, 0.0 },
                    { 223, 42, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 22, null, 0.0 },
                    { 224, 54, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 17, null, 0.0 },
                    { 225, 28, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 44, null, 0.0 },
                    { 226, 55, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 25, null, 0.0 },
                    { 227, 78, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 45, null, 0.0 },
                    { 228, 64, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 28, null, 0.0 },
                    { 229, 72, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 24, null, 0.0 },
                    { 230, 17, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 2, null, 0.0 },
                    { 231, 40, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 16, null, 0.0 },
                    { 232, 99, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 12, null, 0.0 },
                    { 233, 29, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 27, null, 0.0 },
                    { 234, 76, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 48, null, 0.0 },
                    { 235, 12, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, null, 0.0 },
                    { 236, 11, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 49, null, 0.0 },
                    { 237, 94, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 19, null, 0.0 },
                    { 238, 68, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 2, null, 0.0 },
                    { 239, 6, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 18, null, 0.0 },
                    { 240, 76, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 15, null, 0.0 },
                    { 241, 61, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 18, null, 0.0 },
                    { 242, 53, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 20, null, 0.0 },
                    { 243, 90, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 13, null, 0.0 },
                    { 244, 84, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 40, null, 0.0 },
                    { 245, 70, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 41, null, 0.0 },
                    { 246, 89, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 17, null, 0.0 },
                    { 247, 10, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 49, null, 0.0 },
                    { 248, 75, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 23, null, 0.0 },
                    { 249, 97, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 15, null, 0.0 },
                    { 250, 47, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 34, null, 0.0 },
                    { 251, 44, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 29, null, 0.0 },
                    { 252, 67, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 40, null, 0.0 },
                    { 253, 70, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 22, null, 0.0 },
                    { 254, 82, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 27, null, 0.0 },
                    { 255, 74, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, null, 0.0 },
                    { 256, 36, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 25, null, 0.0 },
                    { 257, 35, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 29, null, 0.0 },
                    { 258, 88, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 18, null, 0.0 },
                    { 259, 76, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 10, null, 0.0 },
                    { 260, 93, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 15, null, 0.0 },
                    { 261, 20, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 34, null, 0.0 },
                    { 262, 9, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 39, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Det",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 263, 60, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 5, null, 0.0 },
                    { 264, 37, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 37, null, 0.0 },
                    { 265, 26, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 22, null, 0.0 },
                    { 266, 84, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 46, null, 0.0 },
                    { 267, 54, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 14, null, 0.0 },
                    { 268, 98, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, null, 0.0 },
                    { 269, 19, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, null, 0.0 },
                    { 270, 51, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 33, null, 0.0 },
                    { 271, 85, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 11, null, 0.0 },
                    { 272, 36, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 25, null, 0.0 },
                    { 273, 47, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 35, null, 0.0 },
                    { 274, 3, 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, null, 0.0 },
                    { 275, 97, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 21, null, 0.0 },
                    { 276, 21, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 33, null, 0.0 },
                    { 277, 32, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 6, null, 0.0 },
                    { 278, 56, 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 48, null, 0.0 },
                    { 279, 78, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 25, null, 0.0 },
                    { 280, 64, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 10, null, 0.0 },
                    { 281, 49, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 29, null, 0.0 },
                    { 282, 82, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 11, null, 0.0 },
                    { 283, 16, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 45, null, 0.0 },
                    { 284, 69, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 34, null, 0.0 },
                    { 285, 59, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 42, null, 0.0 },
                    { 286, 68, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 42, null, 0.0 },
                    { 287, 88, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 45, null, 0.0 },
                    { 288, 13, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 45, null, 0.0 },
                    { 289, 51, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 25, null, 0.0 },
                    { 290, 82, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 20, null, 0.0 },
                    { 291, 8, 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 14, null, 0.0 },
                    { 292, 92, 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 32, null, 0.0 },
                    { 293, 13, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 45, null, 0.0 },
                    { 294, 20, 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 40, null, 0.0 },
                    { 295, 37, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 16, null, 0.0 },
                    { 296, 99, 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 49, null, 0.0 },
                    { 297, 60, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 39, null, 0.0 },
                    { 298, 82, 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 19, null, 0.0 },
                    { 299, 49, 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 39, null, 0.0 },
                    { 300, 85, 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 21, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "PlataformaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 10, 8, null },
                    { 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 43, 5, null },
                    { 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 26, 10, null },
                    { 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, 9, null },
                    { 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 18, 11, null },
                    { 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 13, 4, null },
                    { 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 30, 7, null },
                    { 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 24, 13, null },
                    { 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 17, 6, null },
                    { 10, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 11, 1, null },
                    { 11, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 12, 14, null },
                    { 12, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 49, 7, null },
                    { 13, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 34, 13, null },
                    { 14, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 37, 3, null },
                    { 15, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 22, 11, null },
                    { 16, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, 15, null },
                    { 17, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 2, 5, null },
                    { 18, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 2, 1, null },
                    { 19, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 37, 6, null },
                    { 20, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 40, 10, null },
                    { 21, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, 11, null },
                    { 22, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 49, 14, null },
                    { 23, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 43, 10, null },
                    { 24, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 41, 5, null },
                    { 25, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 40, 10, null },
                    { 26, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 21, 4, null },
                    { 27, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 33, 13, null },
                    { 28, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 12, 9, null },
                    { 29, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 43, 14, null },
                    { 30, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 38, 12, null },
                    { 31, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 44, 5, null },
                    { 32, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 9, 8, null },
                    { 33, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 49, 1, null },
                    { 34, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, 6, null },
                    { 35, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 1, 13, null },
                    { 36, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 45, 3, null },
                    { 37, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 10, 5, null },
                    { 38, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 30, 6, null },
                    { 39, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 46, 2, null },
                    { 40, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 46, 14, null },
                    { 41, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 13, 4, null },
                    { 42, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 12, 11, null },
                    { 43, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 32, 7, null },
                    { 44, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 13, 12, null },
                    { 45, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 35, 3, null },
                    { 46, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 30, 15, null },
                    { 47, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 23, 8, null },
                    { 48, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 15, 15, null },
                    { 49, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 27, 1, null },
                    { 50, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 42, 6, null },
                    { 51, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 13, 8, null },
                    { 52, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, 13, null },
                    { 53, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, 5, null },
                    { 54, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 23, 1, null },
                    { 55, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 13, 1, null },
                    { 56, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 20, 14, null },
                    { 57, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 43, 9, null },
                    { 58, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 30, 15, null },
                    { 59, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 18, 4, null },
                    { 60, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 37, 15, null },
                    { 61, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 1, 10, null },
                    { 62, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 12, 8, null },
                    { 63, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 33, 5, null },
                    { 64, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 48, 6, null },
                    { 65, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 9, 7, null },
                    { 66, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 22, 15, null },
                    { 67, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, 1, null },
                    { 68, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 20, 15, null },
                    { 69, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 26, 13, null },
                    { 70, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 24, 14, null },
                    { 71, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 9, 10, null },
                    { 72, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 25, 4, null },
                    { 73, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 30, 12, null },
                    { 74, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 24, 2, null },
                    { 75, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 6, 10, null },
                    { 76, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 33, 2, null },
                    { 77, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 47, 8, null },
                    { 78, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 12, 14, null },
                    { 79, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 2, 4, null },
                    { 80, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 38, 11, null },
                    { 81, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 11, 15, null },
                    { 82, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 45, 11, null },
                    { 83, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 12, 1, null },
                    { 84, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 48, 14, null },
                    { 85, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 9, 2, null },
                    { 86, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 37, 14, null },
                    { 87, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 35, 7, null },
                    { 88, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 19, 6, null },
                    { 89, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 1, 9, null },
                    { 90, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 22, 3, null },
                    { 91, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 11, 7, null },
                    { 92, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 24, 1, null },
                    { 93, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 12, 5, null },
                    { 94, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 9, 6, null },
                    { 95, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 14, 9, null },
                    { 96, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 6, 12, null },
                    { 97, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 16, 2, null },
                    { 98, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 37, 6, null },
                    { 99, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 11, 13, null },
                    { 100, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 11, 9, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 42, 21, null },
                    { 2, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 43, 9, null },
                    { 3, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 44, 28, null },
                    { 4, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 40, 21, null },
                    { 5, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 13, 8, null },
                    { 6, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 45, 23, null },
                    { 7, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 36, 2, null },
                    { 8, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 29, 4, null },
                    { 9, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 37, 29, null },
                    { 10, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 40, 6, null },
                    { 11, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 41, 21, null },
                    { 12, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 35, 6, null },
                    { 13, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 36, 30, null },
                    { 14, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 48, 28, null },
                    { 15, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 28, 6, null },
                    { 16, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 17, 30, null },
                    { 17, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 8, 19, null },
                    { 18, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 5, 21, null },
                    { 19, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 18, 26, null },
                    { 20, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 21, 35, null },
                    { 21, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 16, 21, null },
                    { 22, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 10, 11, null },
                    { 23, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 24, 19, null },
                    { 24, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 41, 23, null },
                    { 25, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 18, 16, null },
                    { 26, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 32, 8, null },
                    { 27, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 27, 22, null },
                    { 28, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 11, 10, null },
                    { 29, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 5, 5, null },
                    { 30, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, 2, null },
                    { 31, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 40, 32, null },
                    { 32, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 38, 13, null },
                    { 33, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 42, 29, null },
                    { 34, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 33, 17, null },
                    { 35, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 34, 31, null },
                    { 36, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 13, 3, null },
                    { 37, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, 3, null },
                    { 38, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 28, 20, null },
                    { 39, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 15, 6, null },
                    { 40, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 26, 23, null },
                    { 41, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 28, 9, null },
                    { 42, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 39, 12, null },
                    { 43, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 22, 18, null },
                    { 44, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 31, 25, null },
                    { 45, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, 23, null },
                    { 46, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 31, 27, null },
                    { 47, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 26, 22, null },
                    { 48, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 24, 9, null },
                    { 49, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 44, 4, null },
                    { 50, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 33, 14, null },
                    { 51, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 32, 7, null },
                    { 52, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 10, 25, null },
                    { 53, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 42, 17, null },
                    { 54, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 2, 15, null },
                    { 55, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 2, 33, null },
                    { 56, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, 27, null },
                    { 57, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 47, 8, null },
                    { 58, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 18, 24, null },
                    { 59, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 49, 22, null },
                    { 60, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 43, 16, null },
                    { 61, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 41, 21, null },
                    { 62, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 8, 5, null },
                    { 63, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 13, 1, null },
                    { 64, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 5, 1, null },
                    { 65, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 45, 31, null },
                    { 66, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 39, 5, null },
                    { 67, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 36, 12, null },
                    { 68, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 21, 6, null },
                    { 69, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, 10, null },
                    { 70, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 13, 21, null },
                    { 71, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 45, 3, null },
                    { 72, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 16, 15, null },
                    { 73, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, 25, null },
                    { 74, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 5, 26, null },
                    { 75, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, 4, null },
                    { 76, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 25, 6, null },
                    { 77, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 38, 9, null },
                    { 78, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 11, 5, null },
                    { 79, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 15, 4, null },
                    { 80, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 14, 35, null },
                    { 81, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 4, 34, null },
                    { 82, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 15, 1, null },
                    { 83, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 27, 7, null },
                    { 84, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 12, 3, null },
                    { 85, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 37, 24, null },
                    { 86, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 30, 17, null },
                    { 87, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 26, 12, null },
                    { 88, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 30, 5, null },
                    { 89, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 41, 16, null },
                    { 90, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 15, 13, null },
                    { 91, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, 35, null },
                    { 92, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 36, 30, null },
                    { 93, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 11, 31, null },
                    { 94, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 45, 3, null },
                    { 95, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 16, 30, null },
                    { 96, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 37, 26, null },
                    { 97, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 6, 12, null },
                    { 98, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 29, 23, null },
                    { 99, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 31, 22, null },
                    { 100, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 20, 25, null },
                    { 101, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 20, 18, null },
                    { 102, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 48, 3, null },
                    { 103, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 43, 23, null },
                    { 104, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 41, 19, null },
                    { 105, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 25, 32, null },
                    { 106, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 14, 27, null },
                    { 107, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, 15, null },
                    { 108, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 43, 8, null },
                    { 109, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 30, 32, null },
                    { 110, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 10, 33, null },
                    { 111, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 43, 11, null },
                    { 112, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 26, 9, null },
                    { 113, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 39, 11, null },
                    { 114, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 12, 22, null },
                    { 115, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 23, 31, null },
                    { 116, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, 34, null },
                    { 117, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 16, 25, null },
                    { 118, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 8, 7, null },
                    { 119, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 16, 8, null },
                    { 120, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 34, 8, null },
                    { 121, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 38, 18, null },
                    { 122, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 31, 30, null },
                    { 123, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 39, 33, null },
                    { 124, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 47, 19, null },
                    { 125, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 16, 23, null },
                    { 126, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 43, 14, null },
                    { 127, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 15, 8, null },
                    { 128, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 11, 27, null },
                    { 129, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 43, 15, null },
                    { 130, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 34, 18, null },
                    { 131, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 47, 8, null },
                    { 132, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 27, 24, null },
                    { 133, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 6, 16, null },
                    { 134, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 48, 14, null },
                    { 135, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 30, 6, null },
                    { 136, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 13, 34, null },
                    { 137, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, 13, null },
                    { 138, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 28, 5, null },
                    { 139, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 17, 31, null },
                    { 140, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 26, 2, null },
                    { 141, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 21, 6, null },
                    { 142, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 17, 10, null },
                    { 143, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 1, 3, null },
                    { 144, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 40, 14, null },
                    { 145, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 42, 21, null },
                    { 146, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 40, 1, null },
                    { 147, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 12, 13, null },
                    { 148, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 43, 14, null },
                    { 149, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 41, 7, null },
                    { 150, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, 28, null },
                    { 151, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 46, 19, null },
                    { 152, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 47, 8, null },
                    { 153, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 11, 32, null },
                    { 154, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 46, 7, null },
                    { 155, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 45, 27, null },
                    { 156, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 37, 12, null },
                    { 157, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 12, 27, null },
                    { 158, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 28, 24, null },
                    { 159, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 49, 11, null },
                    { 160, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 30, 32, null },
                    { 161, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 48, 21, null },
                    { 162, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 17, 29, null },
                    { 163, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 43, 12, null },
                    { 164, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 9, 3, null },
                    { 165, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 17, 23, null },
                    { 166, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 12, 31, null },
                    { 167, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 49, 13, null },
                    { 168, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 27, 22, null },
                    { 169, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 29, 33, null },
                    { 170, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 7, 27, null },
                    { 171, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 20, 15, null },
                    { 172, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 12, 32, null },
                    { 173, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 26, 1, null },
                    { 174, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 49, 21, null },
                    { 175, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 3, 12, null },
                    { 176, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 40, 2, null },
                    { 177, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 17, 7, null },
                    { 178, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 23, 27, null },
                    { 179, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 37, 13, null },
                    { 180, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 19, 7, null },
                    { 181, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 29, 4, null },
                    { 182, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 41, 11, null },
                    { 183, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 39, 6, null },
                    { 184, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 46, 33, null },
                    { 185, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 24, 22, null },
                    { 186, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 43, 1, null },
                    { 187, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 19, 29, null },
                    { 188, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 19, 16, null },
                    { 189, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 14, 12, null },
                    { 190, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 25, 15, null },
                    { 191, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 8, 20, null },
                    { 192, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 14, 15, null },
                    { 193, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 48, 2, null },
                    { 194, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 19, 16, null },
                    { 195, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 25, 5, null },
                    { 196, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 35, 35, null },
                    { 197, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 24, 26, null },
                    { 198, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 21, 21, null },
                    { 199, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 20, 23, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[] { 200, new DateTime(2024, 6, 13, 18, 8, 31, 630, DateTimeKind.Utc).AddTicks(3220), "Wilmilcard", 17, 28, null });

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
                name: "IX_Sesion_UserID1",
                table: "Sesion",
                column: "UserID1");

            migrationBuilder.CreateIndex(
                name: "IX_User_ClienteId",
                table: "User",
                column: "ClienteId");
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
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Director");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Marca");
        }
    }
}
