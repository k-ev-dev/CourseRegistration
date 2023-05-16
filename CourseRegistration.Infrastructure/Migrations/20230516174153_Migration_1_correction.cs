using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseRegistration.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Migration_1_correction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlowStates_CourseRegistrations_RegistrationFlowId",
                table: "FlowStates");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowStates_RegistrationStates_FlowId",
                table: "FlowStates");

            migrationBuilder.DropIndex(
                name: "IX_FlowStates_RegistrationFlowId",
                table: "FlowStates");

            migrationBuilder.DropColumn(
                name: "RegistrationFlowId",
                table: "FlowStates");

            migrationBuilder.AddForeignKey(
                name: "FK_FlowStates_CourseRegistrations_FlowId",
                table: "FlowStates",
                column: "FlowId",
                principalTable: "CourseRegistrations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlowStates_RegistrationStates_StateId",
                table: "FlowStates",
                column: "StateId",
                principalTable: "RegistrationStates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlowStates_CourseRegistrations_FlowId",
                table: "FlowStates");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowStates_RegistrationStates_StateId",
                table: "FlowStates");

            migrationBuilder.AddColumn<Guid>(
                name: "RegistrationFlowId",
                table: "FlowStates",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_FlowStates_RegistrationFlowId",
                table: "FlowStates",
                column: "RegistrationFlowId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlowStates_CourseRegistrations_RegistrationFlowId",
                table: "FlowStates",
                column: "RegistrationFlowId",
                principalTable: "CourseRegistrations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlowStates_RegistrationStates_FlowId",
                table: "FlowStates",
                column: "FlowId",
                principalTable: "RegistrationStates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
