using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseRegistration.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Migration_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseRegistrations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CourseRegistrationOpen = table.Column<bool>(type: "boolean", nullable: false),
                    RegistrationStartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RegistrationEndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ExternalCourseId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseRegistrations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    ExternalAccountId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegistrationStates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RegistrationOpen = table.Column<bool>(type: "boolean", nullable: false),
                    VacantPositionCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationStates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlowParticipants",
                columns: table => new
                {
                    ParticipantId = table.Column<Guid>(type: "uuid", nullable: false),
                    StateId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowParticipants", x => new { x.StateId, x.ParticipantId });
                    table.ForeignKey(
                        name: "FK_FlowParticipants_Participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlowParticipants_RegistrationStates_StateId",
                        column: x => x.StateId,
                        principalTable: "RegistrationStates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlowStates",
                columns: table => new
                {
                    FlowId = table.Column<Guid>(type: "uuid", nullable: false),
                    StateId = table.Column<Guid>(type: "uuid", nullable: false),
                    RegistrationFlowId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowStates", x => new { x.StateId, x.FlowId });
                    table.ForeignKey(
                        name: "FK_FlowStates_CourseRegistrations_RegistrationFlowId",
                        column: x => x.RegistrationFlowId,
                        principalTable: "CourseRegistrations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlowStates_RegistrationStates_FlowId",
                        column: x => x.FlowId,
                        principalTable: "RegistrationStates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlowParticipants_ParticipantId",
                table: "FlowParticipants",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowStates_FlowId",
                table: "FlowStates",
                column: "FlowId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowStates_RegistrationFlowId",
                table: "FlowStates",
                column: "RegistrationFlowId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlowParticipants");

            migrationBuilder.DropTable(
                name: "FlowStates");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "CourseRegistrations");

            migrationBuilder.DropTable(
                name: "RegistrationStates");
        }
    }
}
