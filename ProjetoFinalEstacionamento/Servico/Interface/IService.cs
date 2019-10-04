using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalEstacionamento.Servico.Interface
{
    public interface IService<T>
    {
        IEnumerable<T> Listar(T usuario);

        T Selecionar(T usuario, int id);

        void Incluir(T item);

        void Deletar(T item);

        void Atualiza(T item);
    }
}
