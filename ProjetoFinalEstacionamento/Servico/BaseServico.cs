using Microsoft.Win32.SafeHandles;
using ProjetoFinalEstacionamento.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace ProjetoFinalEstacionamento.Servico
{
    public class BaseServico<T> where T : class
    {
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public virtual IList<T> Listar()
        {
            using (var contexto = new BaseContexto())
            {
                return contexto.Set<T>().ToList();
            }   
        }
        public virtual IList<T> Listar<TProperty>(params Expression<Func<T, TProperty>>[] includes)
        {
            using (var contexto = new BaseContexto())
            {
                var select = contexto.Set<T>().AsQueryable();
                foreach (var include in includes)
                {
                    select = select.Include(include);
                }
                return select.AsNoTracking().ToList();
            }
        }

        public virtual T Selecionar(int id)
        {
            using (var contexto = new BaseContexto())
            {
                return contexto.Set<T>().Find(id);
            }
        }

        public virtual void Incluir(T item)
        {
            using (var contexto = new BaseContexto())
            {
                contexto.Set<T>().Add(item);
                contexto.SaveChanges();
            }
        }

        public virtual void Deletar(T item)
        {
            using (var contexto = new BaseContexto())
            {
                contexto.Entry<T>(item).State = EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

        public virtual void Atualiza(T item)
        {
            using (var contexto = new BaseContexto())
            {
                contexto.Entry(item).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }
    }
}
