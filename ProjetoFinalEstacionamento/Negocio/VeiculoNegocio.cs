using ProjetoFinalEstacionamento.Contexto;
using ProjetoFinalEstacionamento.Modelo;
using ProjetoFinalEstacionamento.Servico;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalEstacionamento.Negocio
{
    public class VeiculoNegocio : BaseServico<VeiculoModel>
    {
        public override IList<VeiculoModel> Listar()
        {
            using (var contexto = new BaseContexto())
            {
                return contexto.Set<VeiculoModel>().Include("TipoVeiculo").ToList();                
            }
            
            //return base.Listar(includes);
        }
    }
}
