using Catel;
using Gestao.Data;
using Gestao.Models;
using Gestao.Services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao.Repositories
{
    public class UsuarioRepository
    {
        
        [Obsolete]
        public Usuario Login(string username, string senha)
        {
            using (var conn = DbConnection.GetConnection())
            {
                string hash = HashService.GerarHash(senha);

                string sql = @"SELECT Id, Nome, Perfil 
                       FROM usuarios
                       WHERE Username = @username
                       AND SenhaHash = @senha
                       AND Ativo = 1";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@senha", hash);

                    conn.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new Usuario
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                Nome = dr["Nome"].ToString(),
                                Perfil = dr["Perfil"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (var conn = DbConnection.GetConnection())
            {
                string sql = @"SELECT Id, Nome, Username, Perfil, Ativo
                       FROM usuarios";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    conn.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            usuarios.Add(new Usuario
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                Nome = dr["Nome"].ToString(),
                                UserName = dr["Username"].ToString(),
                                Perfil = dr["Perfil"].ToString(),
                                Ativo = Convert.ToBoolean(dr["Ativo"])
                            });
                        }
                    }
                }
            }

            return usuarios;
        }
    }
}
