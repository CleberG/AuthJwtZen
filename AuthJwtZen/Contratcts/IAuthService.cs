using AuthJwtZen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthJwtZen.Contratcts
{
	/// <summary>
	/// Contrato principal para as operações de registro e login de usuários.
	/// </summary>
	public interface IAuthService
	{
		/// <summary>
		/// Registra um novo usuário no sistema.
		/// </summary>
		/// <param name="request">Dados para registro do novo usuário.</param>
		/// <returns>Um AuthResponse contendo o resultado da operação.</returns>
		Task<AuthResponse> RegisterAsync(RegisterRequest request);

		/// <summary>
		/// Autentica um usuário e retorna um token JWT se for bem-sucedido.
		/// </summary>
		/// <param name="request">Credenciais de login do usuário.</param>
		/// <returns>Um AuthResponse contendo o token e o resultado da operação.</returns>
		Task<AuthResponse> LoginAsync(LoginRequest request);
	}
}
