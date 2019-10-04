using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalEstacionamento.Modelo
{
    [Table("Cliente")]
    public class ClienteModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("Id")]
        public int Id { get; set; }
        [Column("Nome"), MaxLength(100), Required]
        public string Nome { get; set; }
        [Column("DataNascimento"), Required]
        public DateTime? DataNascimento { get; set; }
        [Column("RG"), MaxLength(20), Required]
        public string RG { get; set; }
        [Column("CPF"), MaxLength(14), Required]
        public string CPF { get; set; }
        [Column("Celular"), MaxLength(20)]
        public string Celular { get; set; }        
        public virtual ICollection<ClienteVeiculoModel> ClienteVeiculos { get; set; }
    }
}
