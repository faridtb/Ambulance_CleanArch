using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CallResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CallResults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diagnosis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diagnos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalWorkers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalWorkers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Protocol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    InsertUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalWorkerId = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    DiagnosId = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registrations_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registrations_Diagnosis_DiagnosId",
                        column: x => x.DiagnosId,
                        principalTable: "Diagnosis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registrations_MedicalWorkers_MedicalWorkerId",
                        column: x => x.MedicalWorkerId,
                        principalTable: "MedicalWorkers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistrationInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHospitalization = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationId = table.Column<int>(type: "int", nullable: false),
                    CallResultId = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistrationInfos_CallResults_CallResultId",
                        column: x => x.CallResultId,
                        principalTable: "CallResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegistrationInfos_Registrations_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registrations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CallResults",
                columns: new[] { "Id", "InsertDate", "Result" },
                values: new object[,]
                {
                    { 1, new DateTime(2008, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "result-1" },
                    { 2, new DateTime(2008, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "result-2" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "InsertDate", "LicensePlate" },
                values: new object[,]
                {
                    { 1, "Mercedes", new DateTime(2008, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "10-MM-100" },
                    { 2, "Ford", new DateTime(2008, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "10-FF-100" }
                });

            migrationBuilder.InsertData(
                table: "Diagnosis",
                columns: new[] { "Id", "Diagnos", "InsertDate" },
                values: new object[,]
                {
                    { 1, "Infarkt", new DateTime(2008, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Kelle-beyin travmasi", new DateTime(2008, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "MedicalWorkers",
                columns: new[] { "Id", "Fullname", "InsertDate" },
                values: new object[,]
                {
                    { 1, "Elekber Teymurov", new DateTime(2008, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Mirqasim Abbasov", new DateTime(2008, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "InsertDate", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2008, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin" },
                    { 2, new DateTime(2008, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "user" }
                });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "Birth", "CarId", "DiagnosId", "InsertDate", "InsertUser", "IsActive", "MedicalWorkerId", "Name", "Pin", "Protocol", "Surname", "UpdateDate", "UpdateUser" },
                values: new object[] { 1, new DateTime(2008, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2008, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", 1, 1, "Ramil", "12345678", "123456789102", "Sheydayev", null, "user" });

            migrationBuilder.InsertData(
                table: "RegistrationInfos",
                columns: new[] { "Id", "CallResultId", "InsertDate", "IsHospitalization", "RegistrationId", "photo" },
                values: new object[] { 1, 1, new DateTime(2008, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, "adasdad/asdadsasd/asdasdasd" });

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationInfos_CallResultId",
                table: "RegistrationInfos",
                column: "CallResultId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationInfos_RegistrationId",
                table: "RegistrationInfos",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_CarId",
                table: "Registrations",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_DiagnosId",
                table: "Registrations",
                column: "DiagnosId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_MedicalWorkerId",
                table: "Registrations",
                column: "MedicalWorkerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistrationInfos");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CallResults");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Diagnosis");

            migrationBuilder.DropTable(
                name: "MedicalWorkers");
        }
    }
}
