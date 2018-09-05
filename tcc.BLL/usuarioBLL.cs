﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using tcc.DAL;
using tcc.DTO;

namespace tcc.BLL
{
    public class UsuarioBLL
    {
        public int novoUsuarioBLL(Usuario novoUser)
        {
            try
            {
                return new UsuarioDAL().novoUsuarioDAL(novoUser);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int autenticaUsuario(String email, String senha)
        {
            try
            {
                //verifica se usuario existe, antes de autenticar senha
                int existeUsuario = new UsuarioDAL().existeUsuario(email);

                // se encontrar usuario, verifica a resposta de retorno
                if (existeUsuario == 1)
                {
                    return new UsuarioDAL().autenticaUsuario(email, senha);
                }

                //se nao encontrar usuario, retorna 0
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Usuario carregaUsuario(String email)
        {
            try
            {
                return new UsuarioDAL().carregaUsuario(email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
