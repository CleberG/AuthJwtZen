using AuthJwtZen.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthJwtZen.Contratcts
{
	/// <summary>
	/// Contrato para o serviço que gera tokens de autenticação.
	/// </summary>
	internal interface ITokenService
	{
		/// <summary>
		/// Gera um token JWT para um usuário específico.
		/// </summary>
		/// <param name="user">O usuário para o qual o token será gerado.</param>
		/// <returns>Uma string representando o token JWT.</returns>
		string GenerateToken(UserBase user);
	}
}
