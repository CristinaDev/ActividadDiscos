using ActividadDiscos.DataAccessLayer;
using ActividadDiscos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActividadDiscos.BusinessAccessLayer
{
    public class ClientesBusiness
    {
        public Cliente Get(int Id)
        {
            Cliente cliente = new Cliente();

            using (DiscosDAL context = new DiscosDAL())
            {
                cliente = (Cliente) context.Clientes.Where(c => c.Id == Id);
            }

            return cliente;
        }

        public List<Cliente> Get()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (DiscosDAL context = new DiscosDAL())
            {
                clientes = context.Clientes.ToList();
            }

            return clientes;
        }

        public Cliente Insert(Cliente cli)
        {
            using (DiscosDAL context = new DiscosDAL())
            {
                context.Clientes.Add(cli);
                if (context.SaveChanges() == 0)
                {
                    cli = null;
                }
            }

            return cli;
        }

        public Cliente Remove(Cliente cli)
        {
            using (DiscosDAL context = new DiscosDAL())
            {
                context.Clientes.Remove(cli);
                if(context.SaveChanges() == 0)
                {
                    cli = null;
                }
            }

            return cli;
        }
    }
}