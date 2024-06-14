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
                    { 1, "Balistreri", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Naomi24@hotmail.com", new DateTime(1965, 1, 10, 20, 17, 35, 424, DateTimeKind.Local).AddTicks(849), "670554986", "Naomi", "Naomi Balistreri", "1-425-500-0463", null },
                    { 2, "Mann", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Rufus46@hotmail.com", new DateTime(1986, 7, 6, 18, 4, 0, 357, DateTimeKind.Local).AddTicks(4926), "114330999", "Rufus", "Rufus Mann", "664-254-0698 x89485", null },
                    { 3, "Ebert", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Javier78@hotmail.com", new DateTime(1963, 11, 11, 5, 54, 56, 742, DateTimeKind.Local).AddTicks(6342), "577106716", "Javier", "Javier Ebert", "394-743-1310 x5144", null },
                    { 4, "Robel", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Pamela23@yahoo.com", new DateTime(1960, 5, 10, 1, 37, 26, 448, DateTimeKind.Local).AddTicks(5847), "360497291", "Pamela", "Pamela Robel", "710-605-8239 x02046", null },
                    { 5, "Moore", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Gloria_Moore@hotmail.com", new DateTime(1995, 10, 27, 10, 31, 53, 384, DateTimeKind.Local).AddTicks(2333), "560069598", "Gloria", "Gloria Moore", "250-203-6431 x3937", null },
                    { 6, "Lockman", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Bryant.Lockman@hotmail.com", new DateTime(1975, 1, 28, 19, 46, 59, 309, DateTimeKind.Local).AddTicks(3201), "547340795", "Bryant", "Bryant Lockman", "1-259-333-1519 x12452", null },
                    { 7, "Nolan", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Nellie.Nolan38@hotmail.com", new DateTime(1983, 4, 28, 13, 21, 24, 467, DateTimeKind.Local).AddTicks(728), "937420422", "Nellie", "Nellie Nolan", "(694) 611-9174 x4813", null },
                    { 8, "Schowalter", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Kristie.Schowalter10@hotmail.com", new DateTime(1976, 12, 11, 1, 25, 37, 580, DateTimeKind.Local).AddTicks(9251), "108194831", "Kristie", "Kristie Schowalter", "951.732.7251 x120", null },
                    { 9, "Cronin", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Larry.Cronin65@hotmail.com", new DateTime(1990, 10, 25, 12, 45, 58, 625, DateTimeKind.Local).AddTicks(2451), "904280875", "Larry", "Larry Cronin", "(793) 417-9879", null },
                    { 10, "Zulauf", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Jerald.Zulauf52@gmail.com", new DateTime(2002, 3, 16, 1, 59, 49, 953, DateTimeKind.Local).AddTicks(4163), "399244418", "Jerald", "Jerald Zulauf", "(747) 487-0529 x7764", null },
                    { 11, "Stehr", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Margie_Stehr@hotmail.com", new DateTime(1954, 10, 19, 20, 52, 5, 972, DateTimeKind.Local).AddTicks(6413), "514428568", "Margie", "Margie Stehr", "1-330-915-5509", null },
                    { 12, "Stark", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Mercedes.Stark42@gmail.com", new DateTime(1990, 7, 15, 18, 55, 20, 92, DateTimeKind.Local).AddTicks(2549), "168487689", "Mercedes", "Mercedes Stark", "690-783-3781 x139", null },
                    { 13, "Schoen", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Elisa_Schoen27@gmail.com", new DateTime(1987, 12, 20, 19, 28, 22, 97, DateTimeKind.Local).AddTicks(1409), "304998326", "Elisa", "Elisa Schoen", "(261) 796-1685", null },
                    { 14, "Marvin", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Elizabeth.Marvin8@gmail.com", new DateTime(1956, 11, 1, 6, 44, 46, 526, DateTimeKind.Local).AddTicks(9551), "807718260", "Elizabeth", "Elizabeth Marvin", "(501) 431-6249 x394", null },
                    { 15, "Watsica", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Angel_Watsica@yahoo.com", new DateTime(1975, 8, 20, 7, 8, 0, 192, DateTimeKind.Local).AddTicks(7822), "703773578", "Angel", "Angel Watsica", "1-605-562-8577", null },
                    { 16, "Windler", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Rufus_Windler85@gmail.com", new DateTime(1958, 4, 20, 18, 20, 41, 763, DateTimeKind.Local).AddTicks(9107), "599356278", "Rufus", "Rufus Windler", "689-875-0230", null },
                    { 17, "Auer", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Miguel_Auer@hotmail.com", new DateTime(1962, 7, 10, 10, 54, 6, 213, DateTimeKind.Local).AddTicks(5798), "713319598", "Miguel", "Miguel Auer", "1-409-868-0729", null },
                    { 18, "Spencer", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Darren_Spencer73@yahoo.com", new DateTime(1997, 1, 4, 9, 16, 31, 506, DateTimeKind.Local).AddTicks(9372), "201676897", "Darren", "Darren Spencer", "428-733-2037 x236", null },
                    { 19, "Jast", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Leon_Jast53@yahoo.com", new DateTime(2002, 12, 15, 14, 10, 21, 529, DateTimeKind.Local).AddTicks(8174), "142259960", "Leon", "Leon Jast", "(414) 584-6529 x95212", null },
                    { 20, "Hand", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Adrian_Hand43@hotmail.com", new DateTime(1960, 7, 27, 21, 39, 13, 411, DateTimeKind.Local).AddTicks(4868), "813122524", "Adrian", "Adrian Hand", "(874) 271-9161 x6103", null },
                    { 21, "Schmeler", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Wilbur.Schmeler@hotmail.com", new DateTime(1975, 9, 24, 17, 22, 3, 922, DateTimeKind.Local).AddTicks(9592), "974590827", "Wilbur", "Wilbur Schmeler", "555-277-9936 x12683", null },
                    { 22, "West", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Bobbie_West6@gmail.com", new DateTime(1996, 3, 5, 7, 9, 27, 955, DateTimeKind.Local).AddTicks(8423), "393349063", "Bobbie", "Bobbie West", "1-899-493-8021", null },
                    { 23, "Langosh", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Jeanette57@hotmail.com", new DateTime(1957, 10, 31, 9, 20, 0, 23, DateTimeKind.Local).AddTicks(8236), "541696563", "Jeanette", "Jeanette Langosh", "541.492.6045 x18361", null },
                    { 24, "Davis", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Tom87@gmail.com", new DateTime(1983, 9, 11, 14, 34, 28, 150, DateTimeKind.Local).AddTicks(4613), "108026200", "Tom", "Tom Davis", "(690) 634-9450", null },
                    { 25, "McLaughlin", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Sally50@hotmail.com", new DateTime(1989, 8, 21, 0, 25, 31, 993, DateTimeKind.Local).AddTicks(6909), "497635923", "Sally", "Sally McLaughlin", "856.423.3750 x3071", null },
                    { 26, "Medhurst", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Sonya.Medhurst@gmail.com", new DateTime(1986, 12, 13, 14, 4, 14, 217, DateTimeKind.Local).AddTicks(6112), "148988499", "Sonya", "Sonya Medhurst", "374-418-3010 x2759", null },
                    { 27, "Leannon", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Clinton.Leannon25@gmail.com", new DateTime(1989, 7, 22, 12, 4, 28, 274, DateTimeKind.Local).AddTicks(3529), "846181921", "Clinton", "Clinton Leannon", "474.490.8384 x2011", null },
                    { 28, "Block", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Ruby_Block24@gmail.com", new DateTime(1993, 7, 1, 4, 0, 27, 406, DateTimeKind.Local).AddTicks(6017), "240484460", "Ruby", "Ruby Block", "(428) 343-5365", null },
                    { 29, "O'Connell", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Andy42@gmail.com", new DateTime(2000, 1, 3, 5, 35, 34, 165, DateTimeKind.Local).AddTicks(7051), "292742675", "Andy", "Andy O'Connell", "482.967.5891 x60155", null },
                    { 30, "Simonis", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Edward.Simonis3@yahoo.com", new DateTime(1990, 2, 17, 3, 55, 15, 712, DateTimeKind.Local).AddTicks(9710), "417659237", "Edward", "Edward Simonis", "692.275.6665 x5684", null },
                    { 31, "Bode", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Jeannie.Bode@gmail.com", new DateTime(1959, 4, 10, 8, 38, 51, 658, DateTimeKind.Local).AddTicks(9512), "702351405", "Jeannie", "Jeannie Bode", "702-233-9375", null },
                    { 32, "Lockman", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Maureen.Lockman@yahoo.com", new DateTime(1998, 6, 18, 5, 34, 23, 350, DateTimeKind.Local).AddTicks(739), "838912084", "Maureen", "Maureen Lockman", "451-530-3592", null },
                    { 33, "Bogan", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Stacey72@yahoo.com", new DateTime(1979, 12, 18, 22, 8, 0, 276, DateTimeKind.Local).AddTicks(6229), "987803161", "Stacey", "Stacey Bogan", "518-716-1686 x368", null },
                    { 34, "Hilll", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Andrea_Hilll@gmail.com", new DateTime(1998, 6, 5, 1, 44, 51, 829, DateTimeKind.Local).AddTicks(5096), "320375566", "Andrea", "Andrea Hilll", "(704) 678-6261", null },
                    { 35, "Weimann", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Carolyn_Weimann@yahoo.com", new DateTime(1990, 2, 12, 23, 33, 19, 161, DateTimeKind.Local).AddTicks(891), "845257533", "Carolyn", "Carolyn Weimann", "300.685.8257", null },
                    { 36, "Kessler", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Marianne_Kessler77@yahoo.com", new DateTime(1980, 1, 13, 18, 39, 45, 151, DateTimeKind.Local).AddTicks(2618), "726692284", "Marianne", "Marianne Kessler", "(982) 518-4088 x337", null },
                    { 37, "Rippin", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Jeanette.Rippin@gmail.com", new DateTime(1990, 7, 25, 1, 54, 8, 135, DateTimeKind.Local).AddTicks(2075), "507423220", "Jeanette", "Jeanette Rippin", "(920) 644-1378 x7468", null },
                    { 38, "Weissnat", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Valerie.Weissnat46@gmail.com", new DateTime(1981, 1, 30, 16, 56, 43, 438, DateTimeKind.Local).AddTicks(9626), "757480766", "Valerie", "Valerie Weissnat", "(990) 219-0513", null },
                    { 39, "Wisozk", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Irma.Wisozk47@yahoo.com", new DateTime(1967, 8, 7, 14, 9, 13, 895, DateTimeKind.Local).AddTicks(2734), "320042323", "Irma", "Irma Wisozk", "(206) 333-2332 x5960", null },
                    { 40, "Flatley", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Alicia_Flatley@yahoo.com", new DateTime(1983, 11, 17, 21, 23, 56, 506, DateTimeKind.Local).AddTicks(8372), "466936118", "Alicia", "Alicia Flatley", "1-322-384-8125", null },
                    { 41, "Ebert", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Danny57@gmail.com", new DateTime(1956, 2, 8, 22, 1, 41, 418, DateTimeKind.Local).AddTicks(4244), "250284948", "Danny", "Danny Ebert", "(314) 947-3001 x93275", null },
                    { 42, "Pollich", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Franklin.Pollich92@gmail.com", new DateTime(1983, 12, 12, 20, 39, 17, 926, DateTimeKind.Local).AddTicks(6852), "421322956", "Franklin", "Franklin Pollich", "200-283-0788 x2281", null },
                    { 43, "Rau", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Barry.Rau12@yahoo.com", new DateTime(1965, 7, 14, 22, 4, 46, 942, DateTimeKind.Local).AddTicks(4470), "218662623", "Barry", "Barry Rau", "613-717-5436 x3756", null },
                    { 44, "Hermann", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Sheri_Hermann@gmail.com", new DateTime(1965, 8, 25, 14, 46, 7, 535, DateTimeKind.Local).AddTicks(5788), "537923408", "Sheri", "Sheri Hermann", "328-339-3534 x1564", null },
                    { 45, "Stamm", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Gilbert.Stamm52@hotmail.com", new DateTime(1998, 4, 24, 4, 19, 58, 530, DateTimeKind.Local).AddTicks(4407), "338778286", "Gilbert", "Gilbert Stamm", "(660) 541-8854 x0859", null },
                    { 46, "Lowe", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Myron.Lowe69@gmail.com", new DateTime(1974, 7, 4, 16, 21, 27, 706, DateTimeKind.Local).AddTicks(6532), "684862232", "Myron", "Myron Lowe", "553.247.8921 x5695", null },
                    { 47, "Brekke", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Stanley68@hotmail.com", new DateTime(2000, 10, 16, 2, 47, 3, 885, DateTimeKind.Local).AddTicks(4125), "100387167", "Stanley", "Stanley Brekke", "(340) 250-6888", null },
                    { 48, "Nienow", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Florence6@gmail.com", new DateTime(1977, 8, 4, 9, 30, 5, 273, DateTimeKind.Local).AddTicks(4269), "392076243", "Florence", "Florence Nienow", "648.943.8336", null },
                    { 49, "Luettgen", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Marlon8@yahoo.com", new DateTime(1993, 10, 12, 14, 54, 33, 857, DateTimeKind.Local).AddTicks(4876), "941863801", "Marlon", "Marlon Luettgen", "1-517-639-7194", null },
                    { 50, "Stiedemann", new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Brandy.Stiedemann@gmail.com", new DateTime(1984, 11, 5, 17, 17, 12, 735, DateTimeKind.Local).AddTicks(9597), "918504476", "Brandy", "Brandy Stiedemann", "1-305-516-8023 x196", null }
                });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "EstadoId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Activo", null },
                    { 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Inactivo", null },
                    { 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Devuelto", null },
                    { 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Prestamo", null },
                    { 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Error", null }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "MarcaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Microsoft", null },
                    { 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Sony", null },
                    { 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "EA", null },
                    { 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Ubisoft", null },
                    { 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Rovio", null },
                    { 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Activision", null },
                    { 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Nintendo", null },
                    { 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Rockstar", null },
                    { 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "CD Project Red", null },
                    { 10, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Annapurna Interactive", null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma",
                columns: new[] { "PlataformaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "PC", null },
                    { 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Xbox", null },
                    { 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Xbox 360", null },
                    { 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Xbox ONE", null },
                    { 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Xbox X", null },
                    { 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "PSP Vita", null },
                    { 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "PlayStation", null },
                    { 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "PlayStation 2", null },
                    { 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "PlayStation 3", null },
                    { 10, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "PlayStation 4", null },
                    { 11, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "PlayStation 5", null },
                    { 12, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Nintendo 64", null },
                    { 13, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Nintendo DS", null },
                    { 14, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Nintendo Switch", null },
                    { 15, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Android", null },
                    { 16, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "IOS", null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista",
                columns: new[] { "ProtagonistaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Mario Bross", null },
                    { 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Tommy Vercetti", null },
                    { 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Altaïr Ibn-La'Ahad", null },
                    { 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Natan Drake", null },
                    { 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Crash Bandicoot", null },
                    { 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Samus Aran", null },
                    { 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "John-117", null },
                    { 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Aiden Perce", null },
                    { 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Carl Jhonson", null },
                    { 10, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Red", null },
                    { 11, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Crazy Dave", null },
                    { 12, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Spyro", null },
                    { 13, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Marcus Fenix", null },
                    { 14, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Vass", null },
                    { 15, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Gordon Freeman", null },
                    { 16, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Joel", null },
                    { 17, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Jill Valentine", null },
                    { 18, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Zelda", null },
                    { 19, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Link", null },
                    { 20, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Glados", null },
                    { 21, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Meet Boy", null },
                    { 22, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Geralt de Rivia", null },
                    { 23, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Steve", null },
                    { 24, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Ellie", null },
                    { 25, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Faith", null },
                    { 26, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Bayonetta", null },
                    { 27, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Tracer", null },
                    { 28, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Pacman", null },
                    { 29, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Chris Redfield", null },
                    { 30, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Leon S. Kennedy", null },
                    { 31, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Agente 47", null },
                    { 32, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Haytham Kenway", null },
                    { 33, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Lara Croft", null },
                    { 34, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Ryu", null },
                    { 35, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Mega Man", null },
                    { 36, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", "Sonic", null }
                });

            migrationBuilder.InsertData(
                table: "Alquiler",
                columns: new[] { "AlquilerId", "ClienteId", "CreatedAt", "CreatedBy", "EstadoId", "Fecha_Devolucion", "Fecha_Reservacion", "UpdatedAt", "Valor_Total" },
                values: new object[,]
                {
                    { 1, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19517.0 },
                    { 2, 44, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16054.0 },
                    { 3, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18603.0 },
                    { 4, 25, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16443.0 },
                    { 5, 15, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18920.0 },
                    { 6, 44, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19938.0 },
                    { 7, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15786.0 },
                    { 8, 30, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18877.0 },
                    { 9, 13, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18651.0 },
                    { 10, 40, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15131.0 },
                    { 11, 13, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19975.0 },
                    { 12, 13, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16808.0 },
                    { 13, 15, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16574.0 },
                    { 14, 41, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15707.0 },
                    { 15, 17, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17990.0 },
                    { 16, 41, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15645.0 },
                    { 17, 17, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18940.0 },
                    { 18, 25, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15515.0 },
                    { 19, 46, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19241.0 },
                    { 20, 42, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17060.0 },
                    { 21, 30, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16477.0 },
                    { 22, 48, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18866.0 },
                    { 23, 28, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16228.0 },
                    { 24, 44, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19420.0 },
                    { 25, 40, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15283.0 },
                    { 26, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19984.0 },
                    { 27, 34, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19665.0 },
                    { 28, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17590.0 },
                    { 29, 21, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18365.0 },
                    { 30, 30, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19909.0 },
                    { 31, 37, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16849.0 },
                    { 32, 40, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17247.0 },
                    { 33, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16792.0 },
                    { 34, 43, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16086.0 },
                    { 35, 38, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18330.0 },
                    { 36, 40, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18583.0 },
                    { 37, 17, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16492.0 },
                    { 38, 32, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16918.0 },
                    { 39, 22, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19473.0 },
                    { 40, 15, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15673.0 },
                    { 41, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19049.0 },
                    { 42, 27, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17527.0 },
                    { 43, 19, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16883.0 },
                    { 44, 12, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19737.0 },
                    { 45, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15624.0 },
                    { 46, 44, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19642.0 },
                    { 47, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17448.0 },
                    { 48, 48, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16776.0 },
                    { 49, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15422.0 },
                    { 50, 25, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19800.0 },
                    { 51, 26, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18191.0 },
                    { 52, 38, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16232.0 },
                    { 53, 37, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19532.0 },
                    { 54, 37, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15719.0 },
                    { 55, 36, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18572.0 },
                    { 56, 24, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19854.0 },
                    { 57, 26, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15103.0 },
                    { 58, 44, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18105.0 },
                    { 59, 23, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19204.0 },
                    { 60, 22, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16233.0 },
                    { 61, 12, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17818.0 },
                    { 62, 36, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15065.0 },
                    { 63, 26, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15735.0 },
                    { 64, 39, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15940.0 },
                    { 65, 39, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18669.0 },
                    { 66, 22, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15301.0 },
                    { 67, 39, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19684.0 },
                    { 68, 35, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18378.0 },
                    { 69, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16345.0 },
                    { 70, 44, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18116.0 },
                    { 71, 42, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17581.0 },
                    { 72, 44, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16584.0 },
                    { 73, 15, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16344.0 },
                    { 74, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16681.0 },
                    { 75, 28, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15499.0 },
                    { 76, 34, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17984.0 },
                    { 77, 13, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18429.0 },
                    { 78, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17507.0 },
                    { 79, 31, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19785.0 },
                    { 80, 19, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16719.0 },
                    { 81, 49, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19700.0 },
                    { 82, 27, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17615.0 },
                    { 83, 45, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19897.0 },
                    { 84, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16313.0 },
                    { 85, 46, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16864.0 },
                    { 86, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19462.0 },
                    { 87, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18735.0 },
                    { 88, 26, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19373.0 },
                    { 89, 44, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15610.0 },
                    { 90, 33, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19403.0 },
                    { 91, 29, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16805.0 },
                    { 92, 34, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18534.0 },
                    { 93, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15847.0 },
                    { 94, 14, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19565.0 },
                    { 95, 28, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19525.0 },
                    { 96, 15, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17321.0 },
                    { 97, 47, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19275.0 },
                    { 98, 13, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18144.0 },
                    { 99, 20, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18021.0 },
                    { 100, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19123.0 }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "DirectorId", "CreatedAt", "CreatedBy", "MarcaId", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 6, "Hideo Kojima", null },
                    { 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 8, "Will Wriths", null },
                    { 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, "Hidetaka Miyazaki", null },
                    { 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, "Tim Schafer", null },
                    { 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, "Ken Levine", null },
                    { 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 2, "Fumito Ueda", null },
                    { 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, "Yves Guillemot", null },
                    { 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, "Gabe Newell", null },
                    { 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 5, "Tom Howard", null },
                    { 10, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, "Yoko Taro", null },
                    { 11, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 5, "Shigeru Miyamoto", null },
                    { 12, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 5, "Amy Hennig", null },
                    { 13, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, "Michel Ancel", null },
                    { 14, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 2, "Goichi Suda", null },
                    { 15, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 5, "Warren Spector", null },
                    { 16, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 2, "John Romero", null },
                    { 17, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 8, "Yuji Horii", null },
                    { 18, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 5, "Yuji Naka", null },
                    { 19, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 6, "Sid Meier", null },
                    { 20, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, "John Carmack", null },
                    { 21, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, "Keiji Inafune", null },
                    { 22, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, "Hironobu Sakaguchi", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "AccessFailCount", "ClienteId", "CreatedAt", "CreatedBy", "IsActive", "IsAdmin", "IsPasswordChange", "PasswordHash", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1, (sbyte)0, 16, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", true, true, true, "81DC9BDB52D04DC223B621240E3DD8B7", null, "ADMIN" },
                    { 2, (sbyte)0, 33, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", true, false, false, "66628C8FB6D6399925E8B29A3CDC3E37", null, "DEV" }
                });

            migrationBuilder.InsertData(
                table: "Juego",
                columns: new[] { "JuegoId", "CreatedAt", "CreatedBy", "DirectorId", "Lanzamiento", "Nombre", "Precio", "Stock", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 14, new DateTime(2001, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassins Creed I", 37237.0, 4, null },
                    { 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassins Creed Valhalla", 246468.0, 13, null },
                    { 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 12, new DateTime(2000, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA III", 274845.0, 4, null },
                    { 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 21, new DateTime(2010, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA Vice City", 51096.0, 10, null },
                    { 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 21, new DateTime(2003, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA San Andreas", 130715.0, 4, null },
                    { 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 14, new DateTime(2006, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA IV", 68886.0, 9, null },
                    { 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, new DateTime(1996, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA V", 286270.0, 3, null },
                    { 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 21, new DateTime(2013, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 17", 101678.0, 9, null },
                    { 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 17, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 18", 181669.0, 2, null },
                    { 10, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 20, new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 19", 295106.0, 3, null },
                    { 11, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 21, new DateTime(2012, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 20", 262904.0, 3, null },
                    { 12, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 14, new DateTime(2016, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 21", 227723.0, 7, null },
                    { 13, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 9, new DateTime(2001, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", 205709.0, 7, null },
                    { 14, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 8, new DateTime(1997, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gears Of War", 41260.0, 7, null },
                    { 15, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 2, new DateTime(1999, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watch_Dogs", 105189.0, 13, null },
                    { 16, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, new DateTime(2018, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watch_Dogs 2", 220057.0, 14, null },
                    { 17, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 9, new DateTime(2003, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher", 152199.0, 14, null },
                    { 18, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 2", 256781.0, 14, null },
                    { 19, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 8, new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3", 167806.0, 3, null },
                    { 20, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 5, new DateTime(2014, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon", 193878.0, 12, null },
                    { 21, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2005, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires", 246660.0, 2, null },
                    { 22, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 16, new DateTime(2007, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires II", 158724.0, 11, null },
                    { 23, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, new DateTime(2014, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires III", 257343.0, 8, null },
                    { 24, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 19, new DateTime(2001, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires IV", 147580.0, 6, null },
                    { 25, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, new DateTime(2020, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption II", 310671.0, 12, null },
                    { 26, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 16, new DateTime(2019, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "DOOM", 205637.0, 5, null },
                    { 27, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 8, new DateTime(2008, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pong", 90969.0, 12, null },
                    { 28, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 18, new DateTime(2007, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims", 285435.0, 7, null },
                    { 29, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 21, new DateTime(2018, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims 2", 44678.0, 8, null },
                    { 30, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, new DateTime(2005, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halo", 182284.0, 3, null },
                    { 31, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 20, new DateTime(2015, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angry Birds", 92910.0, 6, null },
                    { 32, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 13, new DateTime(2000, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plants vs Zombies", 167112.0, 7, null },
                    { 33, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, new DateTime(1995, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battlefield 3", 164630.0, 6, null },
                    { 34, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2007, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fligth Simulation", 90398.0, 2, null },
                    { 35, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 13, new DateTime(2016, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chivarly II", 260072.0, 2, null },
                    { 36, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pureya", 124825.0, 3, null },
                    { 37, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 12, new DateTime(2008, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rust", 180015.0, 3, null },
                    { 38, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, new DateTime(2018, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mass Effect: Legendary Edition", 62188.0, 14, null },
                    { 39, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, new DateTime(2008, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", 194560.0, 6, null },
                    { 40, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 9, new DateTime(2012, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us 2", 141548.0, 2, null },
                    { 41, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 20, new DateTime(2017, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwatch", 45204.0, 12, null },
                    { 42, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 8, new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "NBA 2K21", 118226.0, 9, null },
                    { 43, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 2, new DateTime(2000, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fortnite", 38254.0, 9, null },
                    { 44, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 12, new DateTime(2018, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Squadrons", 289606.0, 10, null },
                    { 45, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 8, new DateTime(2003, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil 8: Village", 131816.0, 12, null },
                    { 46, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 8, new DateTime(2003, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroes of the Storm", 158014.0, 5, null },
                    { 47, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 8, new DateTime(2019, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battefield 4", 105183.0, 7, null },
                    { 48, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 8, new DateTime(2022, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battlefield 2042", 323079.0, 2, null },
                    { 49, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 18, new DateTime(1999, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "florence", 140474.0, 5, null },
                    { 50, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, new DateTime(1996, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "portal", 26068.0, 7, null }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Det",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 1, 35, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 37, null, 0.0 },
                    { 2, 55, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 46, null, 0.0 },
                    { 3, 81, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 41, null, 0.0 },
                    { 4, 37, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 22, null, 0.0 },
                    { 5, 77, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 42, null, 0.0 },
                    { 6, 66, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 27, null, 0.0 },
                    { 7, 30, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 48, null, 0.0 },
                    { 8, 27, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 46, null, 0.0 },
                    { 9, 66, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 12, null, 0.0 },
                    { 10, 9, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 45, null, 0.0 },
                    { 11, 72, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 34, null, 0.0 },
                    { 12, 8, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 9, null, 0.0 },
                    { 13, 67, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 34, null, 0.0 },
                    { 14, 46, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 20, null, 0.0 },
                    { 15, 34, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 38, null, 0.0 },
                    { 16, 5, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, null, 0.0 },
                    { 17, 69, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 8, null, 0.0 },
                    { 18, 91, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 43, null, 0.0 },
                    { 19, 49, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 36, null, 0.0 },
                    { 20, 63, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 47, null, 0.0 },
                    { 21, 16, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 45, null, 0.0 },
                    { 22, 40, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 38, null, 0.0 },
                    { 23, 34, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, null, 0.0 },
                    { 24, 72, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 12, null, 0.0 },
                    { 25, 10, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 49, null, 0.0 },
                    { 26, 37, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, null, 0.0 },
                    { 27, 90, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 49, null, 0.0 },
                    { 28, 15, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 41, null, 0.0 },
                    { 29, 75, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 13, null, 0.0 },
                    { 30, 35, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 44, null, 0.0 },
                    { 31, 22, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 30, null, 0.0 },
                    { 32, 19, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, null, 0.0 },
                    { 33, 35, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 6, null, 0.0 },
                    { 34, 10, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 15, null, 0.0 },
                    { 35, 47, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 47, null, 0.0 },
                    { 36, 87, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 44, null, 0.0 },
                    { 37, 79, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, null, 0.0 },
                    { 38, 61, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, null, 0.0 },
                    { 39, 47, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 44, null, 0.0 },
                    { 40, 69, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 6, null, 0.0 },
                    { 41, 51, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 12, null, 0.0 },
                    { 42, 41, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, null, 0.0 },
                    { 43, 89, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 19, null, 0.0 },
                    { 44, 11, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, null, 0.0 },
                    { 45, 65, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 37, null, 0.0 },
                    { 46, 39, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 24, null, 0.0 },
                    { 47, 18, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 2, null, 0.0 },
                    { 48, 66, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 39, null, 0.0 },
                    { 49, 55, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, null, 0.0 },
                    { 50, 77, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 25, null, 0.0 },
                    { 51, 67, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 16, null, 0.0 },
                    { 52, 10, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 37, null, 0.0 },
                    { 53, 47, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 38, null, 0.0 },
                    { 54, 11, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, null, 0.0 },
                    { 55, 37, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 45, null, 0.0 },
                    { 56, 83, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 8, null, 0.0 },
                    { 57, 86, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 8, null, 0.0 },
                    { 58, 73, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 28, null, 0.0 },
                    { 59, 7, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 32, null, 0.0 },
                    { 60, 8, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 38, null, 0.0 },
                    { 61, 57, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, null, 0.0 },
                    { 62, 35, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 47, null, 0.0 },
                    { 63, 57, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 19, null, 0.0 },
                    { 64, 70, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 13, null, 0.0 },
                    { 65, 35, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, null, 0.0 },
                    { 66, 28, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 27, null, 0.0 },
                    { 67, 24, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 12, null, 0.0 },
                    { 68, 45, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 26, null, 0.0 },
                    { 69, 39, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 10, null, 0.0 },
                    { 70, 4, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 32, null, 0.0 },
                    { 71, 88, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, null, 0.0 },
                    { 72, 87, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, null, 0.0 },
                    { 73, 90, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 19, null, 0.0 },
                    { 74, 84, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 30, null, 0.0 },
                    { 75, 59, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, null, 0.0 },
                    { 76, 43, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 34, null, 0.0 },
                    { 77, 7, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 18, null, 0.0 },
                    { 78, 17, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 10, null, 0.0 },
                    { 79, 79, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 19, null, 0.0 },
                    { 80, 58, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 9, null, 0.0 },
                    { 81, 50, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 40, null, 0.0 },
                    { 82, 48, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 44, null, 0.0 },
                    { 83, 48, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 15, null, 0.0 },
                    { 84, 40, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 46, null, 0.0 },
                    { 85, 24, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 21, null, 0.0 },
                    { 86, 62, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 41, null, 0.0 },
                    { 87, 39, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 35, null, 0.0 },
                    { 88, 82, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 2, null, 0.0 },
                    { 89, 45, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 6, null, 0.0 },
                    { 90, 86, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 27, null, 0.0 },
                    { 91, 68, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 28, null, 0.0 },
                    { 92, 17, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 45, null, 0.0 },
                    { 93, 87, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 23, null, 0.0 },
                    { 94, 44, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 19, null, 0.0 },
                    { 95, 76, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 16, null, 0.0 },
                    { 96, 85, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 41, null, 0.0 },
                    { 97, 84, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 10, null, 0.0 },
                    { 98, 70, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 12, null, 0.0 },
                    { 99, 94, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 2, null, 0.0 },
                    { 100, 34, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 42, null, 0.0 },
                    { 101, 91, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, null, 0.0 },
                    { 102, 16, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 41, null, 0.0 },
                    { 103, 72, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 19, null, 0.0 },
                    { 104, 30, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 21, null, 0.0 },
                    { 105, 72, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, null, 0.0 },
                    { 106, 13, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 30, null, 0.0 },
                    { 107, 93, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 22, null, 0.0 },
                    { 108, 27, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 25, null, 0.0 },
                    { 109, 71, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, null, 0.0 },
                    { 110, 86, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 13, null, 0.0 },
                    { 111, 54, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 29, null, 0.0 },
                    { 112, 96, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 48, null, 0.0 },
                    { 113, 2, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 13, null, 0.0 },
                    { 114, 13, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 8, null, 0.0 },
                    { 115, 11, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 2, null, 0.0 },
                    { 116, 90, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 44, null, 0.0 },
                    { 117, 15, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 33, null, 0.0 },
                    { 118, 66, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 9, null, 0.0 },
                    { 119, 81, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 31, null, 0.0 },
                    { 120, 65, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 43, null, 0.0 },
                    { 121, 2, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 6, null, 0.0 },
                    { 122, 41, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, null, 0.0 },
                    { 123, 71, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 5, null, 0.0 },
                    { 124, 68, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 5, null, 0.0 },
                    { 125, 73, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 45, null, 0.0 },
                    { 126, 16, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, null, 0.0 },
                    { 127, 99, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 19, null, 0.0 },
                    { 128, 79, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, null, 0.0 },
                    { 129, 61, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 42, null, 0.0 },
                    { 130, 98, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, null, 0.0 },
                    { 131, 81, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 41, null, 0.0 },
                    { 132, 57, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 31, null, 0.0 },
                    { 133, 88, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 23, null, 0.0 },
                    { 134, 96, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 34, null, 0.0 },
                    { 135, 1, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 41, null, 0.0 },
                    { 136, 76, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 36, null, 0.0 },
                    { 137, 80, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, null, 0.0 },
                    { 138, 1, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 48, null, 0.0 },
                    { 139, 11, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 46, null, 0.0 },
                    { 140, 22, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 16, null, 0.0 },
                    { 141, 30, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 30, null, 0.0 },
                    { 142, 77, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 6, null, 0.0 },
                    { 143, 14, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 8, null, 0.0 },
                    { 144, 2, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 32, null, 0.0 },
                    { 145, 55, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 16, null, 0.0 },
                    { 146, 91, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 35, null, 0.0 },
                    { 147, 46, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 10, null, 0.0 },
                    { 148, 98, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 2, null, 0.0 },
                    { 149, 77, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, null, 0.0 },
                    { 150, 51, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 14, null, 0.0 },
                    { 151, 97, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 6, null, 0.0 },
                    { 152, 3, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 32, null, 0.0 },
                    { 153, 44, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 5, null, 0.0 },
                    { 154, 32, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 33, null, 0.0 },
                    { 155, 73, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 6, null, 0.0 },
                    { 156, 98, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 47, null, 0.0 },
                    { 157, 49, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 37, null, 0.0 },
                    { 158, 84, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 40, null, 0.0 },
                    { 159, 96, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, null, 0.0 },
                    { 160, 66, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 5, null, 0.0 },
                    { 161, 86, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 29, null, 0.0 },
                    { 162, 95, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 12, null, 0.0 },
                    { 163, 75, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 8, null, 0.0 },
                    { 164, 70, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 21, null, 0.0 },
                    { 165, 88, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 26, null, 0.0 },
                    { 166, 5, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 47, null, 0.0 },
                    { 167, 53, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, null, 0.0 },
                    { 168, 70, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 49, null, 0.0 },
                    { 169, 87, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 23, null, 0.0 },
                    { 170, 93, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 38, null, 0.0 },
                    { 171, 22, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, null, 0.0 },
                    { 172, 15, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 14, null, 0.0 },
                    { 173, 36, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 35, null, 0.0 },
                    { 174, 36, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, null, 0.0 },
                    { 175, 74, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 42, null, 0.0 },
                    { 176, 20, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 40, null, 0.0 },
                    { 177, 99, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 40, null, 0.0 },
                    { 178, 76, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 19, null, 0.0 },
                    { 179, 96, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 34, null, 0.0 },
                    { 180, 65, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 49, null, 0.0 },
                    { 181, 7, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 45, null, 0.0 },
                    { 182, 37, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 42, null, 0.0 },
                    { 183, 17, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, null, 0.0 },
                    { 184, 76, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 41, null, 0.0 },
                    { 185, 56, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 37, null, 0.0 },
                    { 186, 8, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, null, 0.0 },
                    { 187, 91, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 15, null, 0.0 },
                    { 188, 40, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 21, null, 0.0 },
                    { 189, 26, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 23, null, 0.0 },
                    { 190, 25, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 6, null, 0.0 },
                    { 191, 27, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 29, null, 0.0 },
                    { 192, 8, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 33, null, 0.0 },
                    { 193, 51, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 46, null, 0.0 },
                    { 194, 64, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 9, null, 0.0 },
                    { 195, 92, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 44, null, 0.0 },
                    { 196, 8, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 15, null, 0.0 },
                    { 197, 77, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 43, null, 0.0 },
                    { 198, 56, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 8, null, 0.0 },
                    { 199, 70, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 23, null, 0.0 },
                    { 200, 54, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 43, null, 0.0 },
                    { 201, 37, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 26, null, 0.0 },
                    { 202, 99, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 16, null, 0.0 },
                    { 203, 46, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 27, null, 0.0 },
                    { 204, 25, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 26, null, 0.0 },
                    { 205, 6, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 18, null, 0.0 },
                    { 206, 65, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 25, null, 0.0 },
                    { 207, 13, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 29, null, 0.0 },
                    { 208, 75, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 39, null, 0.0 },
                    { 209, 9, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, null, 0.0 },
                    { 210, 83, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 17, null, 0.0 },
                    { 211, 72, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 38, null, 0.0 },
                    { 212, 77, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 33, null, 0.0 },
                    { 213, 29, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 32, null, 0.0 },
                    { 214, 48, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 19, null, 0.0 },
                    { 215, 63, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, null, 0.0 },
                    { 216, 6, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, null, 0.0 },
                    { 217, 37, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 30, null, 0.0 },
                    { 218, 56, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 22, null, 0.0 },
                    { 219, 28, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, null, 0.0 },
                    { 220, 45, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 45, null, 0.0 },
                    { 221, 65, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 20, null, 0.0 },
                    { 222, 79, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 44, null, 0.0 },
                    { 223, 25, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 15, null, 0.0 },
                    { 224, 46, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 13, null, 0.0 },
                    { 225, 98, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, null, 0.0 },
                    { 226, 72, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 24, null, 0.0 },
                    { 227, 37, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 34, null, 0.0 },
                    { 228, 78, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 37, null, 0.0 },
                    { 229, 11, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 18, null, 0.0 },
                    { 230, 20, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 17, null, 0.0 },
                    { 231, 38, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 30, null, 0.0 },
                    { 232, 80, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, null, 0.0 },
                    { 233, 80, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 49, null, 0.0 },
                    { 234, 60, 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 48, null, 0.0 },
                    { 235, 80, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 25, null, 0.0 },
                    { 236, 73, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 30, null, 0.0 },
                    { 237, 65, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 39, null, 0.0 },
                    { 238, 90, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 34, null, 0.0 },
                    { 239, 37, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 32, null, 0.0 },
                    { 240, 60, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 30, null, 0.0 },
                    { 241, 94, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 6, null, 0.0 },
                    { 242, 4, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 23, null, 0.0 },
                    { 243, 89, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, null, 0.0 },
                    { 244, 48, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 16, null, 0.0 },
                    { 245, 7, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 42, null, 0.0 },
                    { 246, 38, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 37, null, 0.0 },
                    { 247, 60, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 26, null, 0.0 },
                    { 248, 63, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, null, 0.0 },
                    { 249, 41, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, null, 0.0 },
                    { 250, 64, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, null, 0.0 },
                    { 251, 57, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 29, null, 0.0 },
                    { 252, 96, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 5, null, 0.0 },
                    { 253, 88, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 26, null, 0.0 },
                    { 254, 45, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 30, null, 0.0 },
                    { 255, 29, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, null, 0.0 },
                    { 256, 36, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 42, null, 0.0 },
                    { 257, 66, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 22, null, 0.0 },
                    { 258, 47, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 15, null, 0.0 },
                    { 259, 51, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 21, null, 0.0 },
                    { 260, 64, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 38, null, 0.0 },
                    { 261, 58, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 12, null, 0.0 },
                    { 262, 59, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Det",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 263, 50, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 28, null, 0.0 },
                    { 264, 63, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 10, null, 0.0 },
                    { 265, 81, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 16, null, 0.0 },
                    { 266, 76, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 40, null, 0.0 },
                    { 267, 73, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 6, null, 0.0 },
                    { 268, 92, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 43, null, 0.0 },
                    { 269, 68, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 10, null, 0.0 },
                    { 270, 28, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 16, null, 0.0 },
                    { 271, 65, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, null, 0.0 },
                    { 272, 30, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 37, null, 0.0 },
                    { 273, 32, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 15, null, 0.0 },
                    { 274, 43, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, null, 0.0 },
                    { 275, 39, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 25, null, 0.0 },
                    { 276, 53, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 42, null, 0.0 },
                    { 277, 16, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 6, null, 0.0 },
                    { 278, 10, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 20, null, 0.0 },
                    { 279, 22, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 27, null, 0.0 },
                    { 280, 70, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 12, null, 0.0 },
                    { 281, 73, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 19, null, 0.0 },
                    { 282, 72, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 47, null, 0.0 },
                    { 283, 10, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 26, null, 0.0 },
                    { 284, 73, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 41, null, 0.0 },
                    { 285, 2, 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 45, null, 0.0 },
                    { 286, 40, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 22, null, 0.0 },
                    { 287, 18, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 20, null, 0.0 },
                    { 288, 67, 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, null, 0.0 },
                    { 289, 79, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 20, null, 0.0 },
                    { 290, 71, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, null, 0.0 },
                    { 291, 88, 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 17, null, 0.0 },
                    { 292, 7, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, null, 0.0 },
                    { 293, 90, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 46, null, 0.0 },
                    { 294, 50, 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 41, null, 0.0 },
                    { 295, 92, 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, null, 0.0 },
                    { 296, 20, 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 39, null, 0.0 },
                    { 297, 24, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 39, null, 0.0 },
                    { 298, 43, 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 24, null, 0.0 },
                    { 299, 67, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 20, null, 0.0 },
                    { 300, 75, 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 34, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "PlataformaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 20, 11, null },
                    { 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 13, 13, null },
                    { 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, 4, null },
                    { 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 45, 13, null },
                    { 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 16, 13, null },
                    { 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 34, 3, null },
                    { 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 16, 2, null },
                    { 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, 9, null },
                    { 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 33, 5, null },
                    { 10, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, 8, null },
                    { 11, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 28, 5, null },
                    { 12, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 9, 8, null },
                    { 13, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 12, 8, null },
                    { 14, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 20, 13, null },
                    { 15, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 32, 2, null },
                    { 16, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 35, 7, null },
                    { 17, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, 8, null },
                    { 18, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 43, 12, null },
                    { 19, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 34, 13, null },
                    { 20, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 27, 11, null },
                    { 21, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 32, 4, null },
                    { 22, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 44, 1, null },
                    { 23, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 43, 8, null },
                    { 24, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 40, 8, null },
                    { 25, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 23, 7, null },
                    { 26, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 10, 9, null },
                    { 27, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 44, 10, null },
                    { 28, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 33, 6, null },
                    { 29, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 10, 14, null },
                    { 30, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 42, 4, null },
                    { 31, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 35, 8, null },
                    { 32, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 23, 8, null },
                    { 33, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, 10, null },
                    { 34, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 32, 7, null },
                    { 35, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 10, 4, null },
                    { 36, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 43, 8, null },
                    { 37, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 23, 3, null },
                    { 38, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 34, 14, null },
                    { 39, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 25, 10, null },
                    { 40, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 34, 12, null },
                    { 41, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 48, 11, null },
                    { 42, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 25, 7, null },
                    { 43, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 31, 14, null },
                    { 44, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, 9, null },
                    { 45, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, 14, null },
                    { 46, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 12, 9, null },
                    { 47, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, 3, null },
                    { 48, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 20, 14, null },
                    { 49, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 17, 12, null },
                    { 50, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 49, 4, null },
                    { 51, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 34, 6, null },
                    { 52, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, 11, null },
                    { 53, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 37, 8, null },
                    { 54, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 10, 11, null },
                    { 55, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 17, 12, null },
                    { 56, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 37, 12, null },
                    { 57, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, 12, null },
                    { 58, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 12, 4, null },
                    { 59, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 38, 7, null },
                    { 60, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 5, 9, null },
                    { 61, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 19, 1, null },
                    { 62, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, 8, null },
                    { 63, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 46, 4, null },
                    { 64, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 16, 7, null },
                    { 65, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 38, 13, null },
                    { 66, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, 10, null },
                    { 67, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 31, 10, null },
                    { 68, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 43, 2, null },
                    { 69, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, 8, null },
                    { 70, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 43, 8, null },
                    { 71, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 12, 14, null },
                    { 72, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 33, 10, null },
                    { 73, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, 13, null },
                    { 74, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 15, 7, null },
                    { 75, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, 3, null },
                    { 76, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, 2, null },
                    { 77, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 37, 12, null },
                    { 78, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 30, 4, null },
                    { 79, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 37, 12, null },
                    { 80, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, 9, null },
                    { 81, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 39, 1, null },
                    { 82, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 36, 10, null },
                    { 83, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 43, 12, null },
                    { 84, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 8, 11, null },
                    { 85, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 39, 14, null },
                    { 86, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 47, 11, null },
                    { 87, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 23, 15, null },
                    { 88, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 43, 14, null },
                    { 89, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 15, 7, null },
                    { 90, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 6, 8, null },
                    { 91, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 21, 4, null },
                    { 92, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 25, 3, null },
                    { 93, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 6, 9, null },
                    { 94, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 46, 8, null },
                    { 95, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, 6, null },
                    { 96, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 16, 14, null },
                    { 97, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 10, 10, null },
                    { 98, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 33, 7, null },
                    { 99, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 26, 5, null },
                    { 100, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 21, 9, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 39, 30, null },
                    { 2, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 5, 25, null },
                    { 3, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, 12, null },
                    { 4, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 42, 15, null },
                    { 5, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 28, 33, null },
                    { 6, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 30, 34, null },
                    { 7, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 29, 27, null },
                    { 8, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 37, 3, null },
                    { 9, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 18, 23, null },
                    { 10, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 30, 29, null },
                    { 11, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 27, 8, null },
                    { 12, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 47, 10, null },
                    { 13, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 32, 31, null },
                    { 14, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 16, 28, null },
                    { 15, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 23, 31, null },
                    { 16, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 43, 8, null },
                    { 17, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 48, 19, null },
                    { 18, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 40, 5, null },
                    { 19, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, 16, null },
                    { 20, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 49, 34, null },
                    { 21, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 24, 13, null },
                    { 22, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 45, 16, null },
                    { 23, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 28, 4, null },
                    { 24, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 9, 35, null },
                    { 25, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 29, 8, null },
                    { 26, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 2, 2, null },
                    { 27, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 16, 35, null },
                    { 28, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 36, 29, null },
                    { 29, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 25, 19, null },
                    { 30, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 4, 15, null },
                    { 31, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 39, 6, null },
                    { 32, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 24, 25, null },
                    { 33, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 45, 11, null },
                    { 34, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 21, 6, null },
                    { 35, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 8, 28, null },
                    { 36, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 6, 13, null },
                    { 37, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 42, 3, null },
                    { 38, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 31, 6, null },
                    { 39, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 34, 23, null },
                    { 40, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 19, 34, null },
                    { 41, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 17, 23, null },
                    { 42, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 35, 27, null },
                    { 43, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, 35, null },
                    { 44, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 2, 20, null },
                    { 45, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 49, 16, null },
                    { 46, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 10, 7, null },
                    { 47, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 47, 1, null },
                    { 48, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 22, 9, null },
                    { 49, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 33, 16, null },
                    { 50, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 10, 33, null },
                    { 51, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 31, 8, null },
                    { 52, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 23, 9, null },
                    { 53, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 42, 8, null },
                    { 54, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 15, 12, null },
                    { 55, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 44, 2, null },
                    { 56, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 5, 32, null },
                    { 57, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 18, 16, null },
                    { 58, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 13, 34, null },
                    { 59, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 16, 7, null },
                    { 60, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 31, 29, null },
                    { 61, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 48, 19, null },
                    { 62, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 6, 8, null },
                    { 63, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, 17, null },
                    { 64, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 14, 28, null },
                    { 65, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 5, 17, null },
                    { 66, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 36, 30, null },
                    { 67, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 33, 32, null },
                    { 68, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 45, 34, null },
                    { 69, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, 16, null },
                    { 70, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, 10, null },
                    { 71, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 17, 22, null },
                    { 72, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 42, 32, null },
                    { 73, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 33, 29, null },
                    { 74, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 19, 22, null },
                    { 75, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 34, 13, null },
                    { 76, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 10, 3, null },
                    { 77, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 15, 23, null },
                    { 78, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 21, 12, null },
                    { 79, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 23, 15, null },
                    { 80, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 32, 19, null },
                    { 81, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 21, 33, null },
                    { 82, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 26, 13, null },
                    { 83, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 26, 4, null },
                    { 84, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 21, 15, null },
                    { 85, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 36, 17, null },
                    { 86, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, 33, null },
                    { 87, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 47, 16, null },
                    { 88, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 23, 22, null },
                    { 89, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 13, 31, null },
                    { 90, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 47, 29, null },
                    { 91, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, 16, null },
                    { 92, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 33, 2, null },
                    { 93, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 13, 8, null },
                    { 94, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, 22, null },
                    { 95, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 46, 13, null },
                    { 96, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 36, 26, null },
                    { 97, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 43, 1, null },
                    { 98, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 19, 9, null },
                    { 99, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 28, 14, null },
                    { 100, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 10, 27, null },
                    { 101, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 42, 15, null },
                    { 102, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 38, 23, null },
                    { 103, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 9, 17, null },
                    { 104, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 5, 33, null },
                    { 105, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 17, 21, null },
                    { 106, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 28, 4, null },
                    { 107, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 9, 9, null },
                    { 108, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 17, 18, null },
                    { 109, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 16, 14, null },
                    { 110, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 44, 11, null },
                    { 111, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 40, 5, null },
                    { 112, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 17, 35, null },
                    { 113, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, 13, null },
                    { 114, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 10, 2, null },
                    { 115, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 31, 35, null },
                    { 116, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 34, 25, null },
                    { 117, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, 14, null },
                    { 118, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 26, 21, null },
                    { 119, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 32, 5, null },
                    { 120, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 24, 21, null },
                    { 121, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 12, 34, null },
                    { 122, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 37, 34, null },
                    { 123, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 44, 11, null },
                    { 124, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 17, 7, null },
                    { 125, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 24, 7, null },
                    { 126, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 21, 18, null },
                    { 127, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 22, 14, null },
                    { 128, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 24, 30, null },
                    { 129, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 24, 23, null },
                    { 130, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 9, 27, null },
                    { 131, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 19, 34, null },
                    { 132, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 23, 31, null },
                    { 133, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 28, 18, null },
                    { 134, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 35, 32, null },
                    { 135, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, 26, null },
                    { 136, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 6, 4, null },
                    { 137, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, 9, null },
                    { 138, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 5, 25, null },
                    { 139, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 11, 3, null },
                    { 140, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 9, 22, null },
                    { 141, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 36, 24, null },
                    { 142, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 33, 32, null },
                    { 143, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 36, 18, null },
                    { 144, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 45, 10, null },
                    { 145, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 26, 22, null },
                    { 146, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 22, 9, null },
                    { 147, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 28, 28, null },
                    { 148, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 48, 1, null },
                    { 149, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 48, 4, null },
                    { 150, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 20, 18, null },
                    { 151, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 26, 14, null },
                    { 152, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, 15, null },
                    { 153, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 39, 29, null },
                    { 154, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 17, 13, null },
                    { 155, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 3, 27, null },
                    { 156, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 22, 5, null },
                    { 157, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 1, 26, null },
                    { 158, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 25, 13, null },
                    { 159, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 25, 23, null },
                    { 160, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 12, 27, null },
                    { 161, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 2, 32, null },
                    { 162, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 43, 12, null },
                    { 163, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 34, 15, null },
                    { 164, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 36, 23, null },
                    { 165, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 38, 35, null },
                    { 166, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 29, 35, null },
                    { 167, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 39, 27, null },
                    { 168, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 44, 32, null },
                    { 169, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 42, 15, null },
                    { 170, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 27, 30, null },
                    { 171, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 19, 23, null },
                    { 172, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 24, 3, null },
                    { 173, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 26, 19, null },
                    { 174, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 21, 9, null },
                    { 175, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 5, 34, null },
                    { 176, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 5, 33, null },
                    { 177, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, 14, null },
                    { 178, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 25, 32, null },
                    { 179, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 7, 10, null },
                    { 180, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 2, 24, null },
                    { 181, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 23, 17, null },
                    { 182, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 34, 32, null },
                    { 183, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 5, 11, null },
                    { 184, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 32, 31, null },
                    { 185, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 13, 34, null },
                    { 186, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 30, 22, null },
                    { 187, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 12, 14, null },
                    { 188, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 47, 29, null },
                    { 189, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 12, 17, null },
                    { 190, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 46, 4, null },
                    { 191, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 10, 33, null },
                    { 192, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 20, 10, null },
                    { 193, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 38, 14, null },
                    { 194, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 13, 14, null },
                    { 195, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 44, 12, null },
                    { 196, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 16, 23, null },
                    { 197, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 9, 16, null },
                    { 198, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 34, 33, null },
                    { 199, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 26, 24, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[] { 200, new DateTime(2024, 6, 14, 7, 30, 43, 844, DateTimeKind.Utc).AddTicks(2942), "Wilmilcard", 38, 11, null });

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
