﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaNet.Models;
using LojaNet.DAL;

namespace LojaNet.BLL
{

    //Bussiness Logic Layer

    public class ClienteBLL : IClienteDados 
    {
        public void Alterar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Excluir(string Id)
        {
            if (string.IsNullOrEmpty(Cliente.Nome))
            {
                throw new ApplicationException("O nome deve ser informado");
            }
            if(string.IsNullOrEmpty(cliente.Id)) 
            {
                cliente.Id = Guid.NewGuid().ToString();
            }

            var dal = new ClienteDAL();
            dal.Incluir(cliente);



        }

        public void Incluir(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorId(string id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ObterTodos()
        {
            throw new NotImplementedException();
        }

    }
}
