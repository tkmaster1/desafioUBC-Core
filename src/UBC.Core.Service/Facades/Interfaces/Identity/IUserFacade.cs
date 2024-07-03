﻿using UBC.Core.Service.DTO.Identity;

namespace UBC.Core.Service.Facades.Interfaces.Identity
{
    public interface IUserFacade : IDisposable
    {
        /// <summary>
        /// Método que retorna os dados do usuário através da pesquisa por Código
        /// </summary>
        /// <param name="codeUser"></param>
        /// <returns></returns>
        Task<UserDTO> GetUserByCode(string codeUser);
    }
}