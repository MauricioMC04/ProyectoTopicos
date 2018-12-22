using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTopicos.LogicaNegocio.Logica.Repositorio
{
    public class Parametro
    {
        //    Model.TopicosSelectosEntities _miContexto = new Model.TopicosSelectosEntities();

        //    public Model.Usuarios GetParametro(string idParametro)
        //    {
        //        foreach (var line in _miContexto.Usuarios)
        //        {
        //            Console.Out.WriteLine("%s - %s - %s", line.nombre, line.perfil, line.pwd);
        //        }

        //        var query = _miContexto.Usuarios.Where(a => a.Perfiles.perfil.Equals(idParametro);

        //        return query.FirstOrDefault();

        //    }

        //    public bool AddParametro(string nombre)
        //    {
        //        _miContexto.Database.ExecuteSqlCommand("insert into Usuarios values (@codigo, @nombre)", new SqlParameter("@codigo", (GetMaxUsuario() + 1).ToString()), new SqlParameter("@nombre", nombre), new SqlParameter("@correo", correo), new SqlParameter("@perfil", perfil));
        //        return true;
        //    }

        //    internal Parametro GetUsuarioPorCodigo(string codigo)
        //    {
        //        return _miContexto.Usuarios.Where(a => a.codigoUsuario.Equals(codigo)).FirstOrDefault();
        //    }

        //    public int GetMaxUsuario()
        //    {
        //        var resultado = _miContexto.Usuarios.Max(a => a.codigoUsuario);
        //        return Convert.ToInt32(resultado);
        //    }

        //    public bool ReasignarPerfilDeUsuario(string codigoUsuario, string codigoPerfil)
        //    {
        //        var usuario = GetUsuarioPorCodigo(codigoUsuario);
        //        var perfil = _miContexto.Perfiles.Where(a => a.codigoPerfil.Equals(codigoPerfil)).FirstOrDefault();

        //        usuario.Perfiles = perfil;
        //        return _miContexto.SaveChanges() > 0;
        //    }

        //    public List<Usuarios> GetAll()
        //    {
        //        return _miContexto.Usuarios.ToList();
        //    }
        //}
    }
}