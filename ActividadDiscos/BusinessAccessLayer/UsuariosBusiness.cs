using ActividadDiscos.DataAccessLayer;
using ActividadDiscos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace ActividadDiscos.BusinessAccessLayer
{
    public class UsuariosBusiness
    {
        public Usuario Insert(Usuario u)
        {
            using (DiscosDAL dal = new DiscosDAL())
            {
                dal.Usuarios.Add(u);

                if(dal.SaveChanges() == 0)
                {
                    u = null;
                }
                else
                {
                    UsuarioGrupo ug = new UsuarioGrupo();

                    ug.IdUsuario = dal.Usuarios.OrderByDescending(us => us.IdUsuario)
                                                .Select(us => us.IdUsuario)
                                                .Take(1).Single();
                    ug.IdGrupo = 2;

                    dal.UsuariosGrupos.Add(ug);
                    
                    if(dal.SaveChanges() == 0)
                    {
                        u = null;
                    }
                }
            }

            return u;
        }

        public Usuario IsAuthenticated(Usuario u)
        {
            Usuario authUser = null;

            using (DiscosDAL dal = new DiscosDAL())
            {
                string password = u.Password;

                authUser = dal.Usuarios.Include(usu => usu.UsuariosGrupos.Select(g => g.Grupo))
                            .FirstOrDefault(usu => usu.Login == u.Login && usu.Password == password);
            }

            return authUser;
        }
    }
}