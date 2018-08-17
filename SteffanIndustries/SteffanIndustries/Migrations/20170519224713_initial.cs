using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SteffanIndustries.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estimate",
                columns: table => new
                {
                    EstimateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Contact = table.Column<string>(nullable: true),
                    ContactPhone = table.Column<string>(nullable: true),
                    EstimateDate = table.Column<DateTime>(nullable: false),
                    JobName = table.Column<string>(nullable: true),
                    Scope = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estimate", x => x.EstimateID);
                });

            migrationBuilder.CreateTable(
                name: "Quote",
                columns: table => new
                {
                    QuoteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    ContactEmail = table.Column<string>(nullable: true),
                    ContactPhone = table.Column<string>(nullable: true),
                    JobCost = table.Column<decimal>(nullable: true),
                    JobName = table.Column<string>(nullable: true),
                    JobScope = table.Column<string>(nullable: true),
                    QuoteDate = table.Column<DateTime>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quote", x => x.QuoteID);
                });

            migrationBuilder.CreateTable(
                name: "EstimateDetail",
                columns: table => new
                {
                    EstimateDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EstimateID = table.Column<int>(nullable: false),
                    EstimateSection = table.Column<string>(nullable: true),
                    Markup = table.Column<decimal>(nullable: true),
                    NumberOfDays = table.Column<decimal>(nullable: false),
                    NumberOfHours = table.Column<decimal>(nullable: false),
                    NumberOfWorkers = table.Column<decimal>(nullable: false),
                    Rate = table.Column<decimal>(nullable: false),
                    TotalAmount = table.Column<decimal>(nullable: true),
                    UOM = table.Column<string>(nullable: true),
                    UOMQuantity = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstimateDetail", x => x.EstimateDetailID);
                    table.ForeignKey(
                        name: "FK_EstimateDetail_Estimate_EstimateID",
                        column: x => x.EstimateID,
                        principalTable: "Estimate",
                        principalColumn: "EstimateID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuoteNote",
                columns: table => new
                {
                    QuoteNoteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Note = table.Column<string>(nullable: true),
                    NoteNumber = table.Column<int>(nullable: false),
                    QuoteID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuoteNote", x => x.QuoteNoteID);
                    table.ForeignKey(
                        name: "FK_QuoteNote_Quote_QuoteID",
                        column: x => x.QuoteID,
                        principalTable: "Quote",
                        principalColumn: "QuoteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstimateDetail_EstimateID",
                table: "EstimateDetail",
                column: "EstimateID");

            migrationBuilder.CreateIndex(
                name: "IX_QuoteNote_QuoteID",
                table: "QuoteNote",
                column: "QuoteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstimateDetail");

            migrationBuilder.DropTable(
                name: "QuoteNote");

            migrationBuilder.DropTable(
                name: "Estimate");

            migrationBuilder.DropTable(
                name: "Quote");
        }
    }
}
