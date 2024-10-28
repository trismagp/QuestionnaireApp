using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateQuestionnairesTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaire_Users_AppUserId",
                table: "Questionnaire");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionnaireAdmins_Questionnaire_AdministeredQuestionnairesId",
                table: "QuestionnaireAdmins");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionnaireParticipants_Questionnaire_ParticipatedQuestionnairesId",
                table: "QuestionnaireParticipants");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionSection_Questionnaire_QuestionnaireId",
                table: "QuestionSection");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questionnaire",
                table: "Questionnaire");

            migrationBuilder.RenameTable(
                name: "Questionnaire",
                newName: "Questionnaires");

            migrationBuilder.RenameIndex(
                name: "IX_Questionnaire_AppUserId",
                table: "Questionnaires",
                newName: "IX_Questionnaires_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questionnaires",
                table: "Questionnaires",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionnaireAdmins_Questionnaires_AdministeredQuestionnairesId",
                table: "QuestionnaireAdmins",
                column: "AdministeredQuestionnairesId",
                principalTable: "Questionnaires",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionnaireParticipants_Questionnaires_ParticipatedQuestionnairesId",
                table: "QuestionnaireParticipants",
                column: "ParticipatedQuestionnairesId",
                principalTable: "Questionnaires",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaires_Users_AppUserId",
                table: "Questionnaires",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionSection_Questionnaires_QuestionnaireId",
                table: "QuestionSection",
                column: "QuestionnaireId",
                principalTable: "Questionnaires",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionnaireAdmins_Questionnaires_AdministeredQuestionnairesId",
                table: "QuestionnaireAdmins");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionnaireParticipants_Questionnaires_ParticipatedQuestionnairesId",
                table: "QuestionnaireParticipants");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_Users_AppUserId",
                table: "Questionnaires");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionSection_Questionnaires_QuestionnaireId",
                table: "QuestionSection");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questionnaires",
                table: "Questionnaires");

            migrationBuilder.RenameTable(
                name: "Questionnaires",
                newName: "Questionnaire");

            migrationBuilder.RenameIndex(
                name: "IX_Questionnaires_AppUserId",
                table: "Questionnaire",
                newName: "IX_Questionnaire_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questionnaire",
                table: "Questionnaire",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaire_Users_AppUserId",
                table: "Questionnaire",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionnaireAdmins_Questionnaire_AdministeredQuestionnairesId",
                table: "QuestionnaireAdmins",
                column: "AdministeredQuestionnairesId",
                principalTable: "Questionnaire",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionnaireParticipants_Questionnaire_ParticipatedQuestionnairesId",
                table: "QuestionnaireParticipants",
                column: "ParticipatedQuestionnairesId",
                principalTable: "Questionnaire",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionSection_Questionnaire_QuestionnaireId",
                table: "QuestionSection",
                column: "QuestionnaireId",
                principalTable: "Questionnaire",
                principalColumn: "Id");
        }
    }
}
