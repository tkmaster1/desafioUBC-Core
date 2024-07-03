﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBC.Core.Domain.Models;
using UBC.Core.Domain.Models.Result;
using UBC.Core.Service.DTO.Identity;

namespace UBC.Core.Service.Facades.Interfaces.Identity
{
    public interface ILoginRegisterUserFacade : IDisposable
    {
        /// <summary>
        /// Método que realiza o Login do usuário na aplicação
        /// </summary>
        /// <param name="userRequestDto"></param>
        /// <returns></returns>
        Task<LoginUserResult> Login(LoginUserRequestDTO userRequestDto);

        /// <summary>
        /// Método que gera o Token para a aplicação
        /// </summary>
        /// <param name="email"></param>
        /// <param name="authorizationSettings"></param>
        /// <returns></returns>
        Task<LoginUserResponseDTO> GerarJwt(string email, AuthorizationSettings authorizationSettings);

        /// <summary>
        /// Método que realiza o Cadastro do usuário na aplicação
        /// </summary>
        /// <param name="userIdentityEntity"></param>
        /// <returns></returns>
        Task<IdentityResult> RegisterUserIdentity(RegisterUserRequestDTO registerUserRequestDTO);
    }
}
