using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalEstacionamento.Modelo
{
    [Table("TipoVeiculo")]
    public class TipoVeiculoModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("Id")]
        public int Id { get; set; }

        [Required, Index(IsUnique = true)]
        [Column("TipoVeiculo"), MaxLength(30)]
        public string TipoVeiculo { get; set; }

        [Required]
        [Column("ValorHora")]
        public double ValorHora { get; set; }

        public virtual ICollection<VeiculoModel> Veiculos { get; set; }
    }
}
