using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalEstacionamento.Modelo
{
    [Table("Veiculo")]
    public class VeiculoModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("Id")]
        public int Id { get; set; }

        [Column("Placa"), MaxLength(100), Required]
        public string Placa { get; set; }

        [Column("Marca"), MaxLength(100)]
        public string Marca { get; set; }

        [Column("Modelo"), MaxLength(100), Required]
        public string Modelo { get; set; }

        [Column("Cor"), MaxLength(20), Required]
        public string Cor { get; set; }
        
        public int TipoVeiculoId { get; set; }
        public virtual TipoVeiculoModel TipoVeiculo { get; set; }
        public virtual ICollection<RegistroEntradaSaidaModel> RegistroEntradaSaidas { get; set; }   
        public virtual ICollection<ClienteVeiculoModel> ClienteVeiculos { get; set; }
    }
}
