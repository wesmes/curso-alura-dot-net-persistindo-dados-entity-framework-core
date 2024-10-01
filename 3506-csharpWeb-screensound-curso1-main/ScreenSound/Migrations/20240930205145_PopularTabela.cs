using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas", new string[] {"Nome", "Bio", "FotoPerfil"}, new object[] {"Ir. Kelly Patrícia", "Fundadora do Instituto Hesed de Vida Consagrada, em 1998, juntamente com a Irmã Jane Madeleine. O instituto tem espiritualidade carmelita, inspirada em São João da Cruz e Santa Teresa de Ávila.", "https://i.scdn.co/image/ab67616d0000b2732ae54f5c73543cedf199f6f5" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Frei Gilson", "É um sacerdote católico e cantor brasileiro. Frade carmelita, é conhecido por liderar o ministério Som do Monte, que busca levar mensagens religiosas através da música. Seu maior sucesso é a música Eu Te Levantarei.", "https://i.scdn.co/image/ab67616d0000b273db332adaf52632b4ad467803" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Pe. Marcelo Rossi", "É um sacerdote católico, cantor e escritor brasileiro, conhecido pelo trabalho de evangelização que realiza através dos meios de comunicação.", "https://i.scdn.co/image/ab67616d0000b2735d6826fb050c582b8d7b1a79" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Irmã Míria Therezinha Kolling", "Foi uma religiosa da Congregação das Irmãs do Imaculado Coração de Maria, cantora e compositora de música sacra.", "https://3.bp.blogspot.com/-D9M1Ffm5C5s/WpQsb2TXi2I/AAAAAAAAXco/UMRSC_B1XpMRedCvGWBFumrBDZ44NEvpwCLcBGAs/w1200-h630-p-k-no-nu/Banner_980x414_Ir_Miria_Kolling.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM ARTISTAS");
        }
    }
}
