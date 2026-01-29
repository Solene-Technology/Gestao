using Gestao.Models;
using Gestao.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao.Services
{
    public class UserService
    {
        public class UsuarioService
        {
            private UsuarioRepository _usuarioRepository;

            public UsuarioService()
            {
                _usuarioRepository = new UsuarioRepository();
            }

            // Login
            public Usuario Login(string username, string senha)
            {
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(senha))
                {
                    throw new ArgumentException("Usuário e senha são obrigatórios.");
                }

                var usuario = _usuarioRepository.Login(username, senha);

                if (usuario == null)
                    throw new Exception("Usuário ou senha inválidos.");

                return usuario;
            }

            // Criar usuário
            public bool CriarUsuario(string nome, string username, string senha, string perfil)
            {
                if (string.IsNullOrWhiteSpace(nome) ||
                    string.IsNullOrWhiteSpace(username) ||
                    string.IsNullOrWhiteSpace(senha) ||
                    string.IsNullOrWhiteSpace(perfil))
                {
                    throw new ArgumentException("Todos os campos são obrigatórios.");
                }

                // Você pode adicionar aqui outras validações, tipo se o username já existe
                var usuariosExistentes = _usuarioRepository.ListarUsuarios();
                if (usuariosExistentes.Any(u => u.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)))
                {
                    throw new Exception("Usuário já existe.");
                }

                return _usuarioRepository.CriarUsuario(nome, username, senha, perfil);
            }

            // Listar usuários
            public List<Usuario> ListarUsuarios()
            {
                return _usuarioRepository.ListarUsuarios();
            }
        }
    }
}
