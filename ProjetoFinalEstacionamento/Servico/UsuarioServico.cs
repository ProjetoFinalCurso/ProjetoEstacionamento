using ProjetoFinalEstacionamento.Contexto;
using ProjetoFinalEstacionamento.Modelo;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProjetoFinalEstacionamento.Servico
{
    public static class UsuarioServico
    {
        public static IEnumerable<UsuarioModel> Listar(this UsuarioModel usuario)
        {
            using (var contexto = new BaseContexto())
            {
                return contexto.Set<UsuarioModel>();
            }
        }

        public static IQueryable<UsuarioModel> Listar(this UsuarioModel usuario, params string[] includes)
        {            
            using (var contexto = new BaseContexto())
            {
                var query = contexto.Set<UsuarioModel>().AsQueryable();
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
                return query.AsNoTracking();
            }
        }

        public static UsuarioModel Selecionar(this UsuarioModel usuario, int id)
        {
            using (var contexto = new BaseContexto())
            {
                return contexto.Set<UsuarioModel>().Find(id);
            }
        }

        public static void Incluir(this UsuarioModel item)
        {
            using (var contexto = new BaseContexto())
            {
                contexto.Set<UsuarioModel>().Add(item);
                contexto.SaveChanges();
            }
        }

        public static void Deletar(this UsuarioModel item)
        {
            using (var contexto = new BaseContexto())
            {
                contexto.Set<UsuarioModel>().Remove(item);
                contexto.SaveChanges();
            }
        }

        public static void Atualiza(this UsuarioModel item)
        {
            using (var contexto = new BaseContexto())
            {
                contexto.Entry(item).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}
