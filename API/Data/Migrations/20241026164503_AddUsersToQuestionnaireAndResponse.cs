using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUsersToQuestionnaireAndResponse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestionnaireAdmins",
                columns: table => new
                {
                    AdministeredQuestionnairesId = table.Column<int>(type: "INTEGER", nullable: false),
                    AdminsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionnaireAdmins", x => new { x.AdministeredQuestionnairesId, x.AdminsId });
                    table.ForeignKey(
                        name: "FK_QuestionnaireAdmins_Questionnaire_AdministeredQuestionnairesId",
                        column: x => x.AdministeredQuestionnairesId,
                        principalTable: "Questionnaire",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionnaireAdmins_Users_AdminsId",
                        column: x => x.AdminsId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionnaireParticipants",
                columns: table => new
                {
                    ParticipantListId = table.Column<int>(type: "INTEGER", nullable: false),
                    ParticipatedQuestionnairesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionnaireParticipants", x => new { x.ParticipantListId, x.ParticipatedQuestionnairesId });
                    table.ForeignKey(
                        name: "FK_QuestionnaireParticipants_Questionnaire_ParticipatedQuestionnairesId",
                        column: x => x.ParticipatedQuestionnairesId,
                        principalTable: "Questionnaire",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionnaireParticipants_Users_ParticipantListId",
                        column: x => x.ParticipantListId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionnaireAdmins_AdminsId",
                table: "QuestionnaireAdmins",
                column: "AdminsId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionnaireParticipants_ParticipatedQuestionnairesId",
                table: "QuestionnaireParticipants",
                column: "ParticipatedQuestionnairesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionnaireAdmins");

            migrationBuilder.DropTable(
                name: "QuestionnaireParticipants");
        }
    }
}
