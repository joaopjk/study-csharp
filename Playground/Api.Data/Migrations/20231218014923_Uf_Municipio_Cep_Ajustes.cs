using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class Uf_Municipio_Cep_Ajustes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Municipio_Uf_UfId",
                table: "Municipio");

            migrationBuilder.DropColumn(
                name: "EfId",
                table: "Municipio");

            migrationBuilder.AlterColumn<Guid>(
                name: "UfId",
                table: "Municipio",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 74, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5abca453-d035-4766-a81b-9f73d683a54b"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("b81f95e0-f226-4afd-9763-290001637ed4"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 49, 23, 75, DateTimeKind.Utc).AddTicks(188));

            migrationBuilder.AddForeignKey(
                name: "FK_Municipio_Uf_UfId",
                table: "Municipio",
                column: "UfId",
                principalTable: "Uf",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Municipio_Uf_UfId",
                table: "Municipio");

            migrationBuilder.AlterColumn<Guid>(
                name: "UfId",
                table: "Municipio",
                type: "char(36)",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "EfId",
                table: "Municipio",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5abca453-d035-4766-a81b-9f73d683a54b"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("b81f95e0-f226-4afd-9763-290001637ed4"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"),
                column: "CreateAt",
                value: new DateTime(2023, 12, 18, 1, 32, 6, 395, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.AddForeignKey(
                name: "FK_Municipio_Uf_UfId",
                table: "Municipio",
                column: "UfId",
                principalTable: "Uf",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
