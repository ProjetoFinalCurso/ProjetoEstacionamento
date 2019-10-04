using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalEstacionamento.Modelo
{
    [Table("ClienteVeiculo")]
    public class ClienteVeiculoModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("Id")]
        public int Id { get; set; }

        [Required]
        public int ClienteId { get; set; }
        public virtual ClienteModel Cliente { get; set; }

        [Required]
        public int VeiculoId { get; set; }
        public virtual VeiculoModel Veiculo { get; set; }
    }
}
