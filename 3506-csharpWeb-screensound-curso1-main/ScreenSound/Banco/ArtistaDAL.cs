using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal class ArtistaDAL
    {
        public IEnumerable<Artista> Listar()
        {
            using var context = new ScreenSoundContext();
            return context.Artistas.ToList();
        }

        //public void Adicionar(Artista artista)
        //{
        //    // Adição do "using" para determinar que a implementação da conexão
        //    // será encerrada após execução do escopo de onde ela foi implementada
        //    using var connection = new ScreenSoundContext().ObterConexao();
        //    connection.Open();

        //    string sql = "INSERT INTO Artistas (Nome, FotoPerfil, Bio) VALUES (@nome, @perfilPadrao, @bio)";

        //    SqlCommand command = new SqlCommand(sql, connection);

        //    command.Parameters.AddWithValue("@nome", artista.Nome);
        //    command.Parameters.AddWithValue("@perfilPadrao", artista.FotoPerfil);
        //    command.Parameters.AddWithValue("@bio", artista.Bio);

        //    int retorno = command.ExecuteNonQuery();
        //    Console.WriteLine($"Linhas afetadas: {retorno}");

        //}

        //public void Deletar(Artista artista)
        //{
        //    using var connection = new ScreenSoundContext().ObterConexao();
        //    connection.Open();

        //    string sql = $"DELETE FROM Artistas WHERE Id = @id";
        //    SqlCommand command = new SqlCommand(sql, connection);

        //    command.Parameters.AddWithValue("@id", artista.Id);

        //    int retorno = command.ExecuteNonQuery();

        //    Console.WriteLine($"Linhas afetadas: {retorno}");

        //}

    }
}
