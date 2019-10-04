using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalEstacionamento.Modelo
{
    [Table("RegistroEntradaSaida")]
    public class RegistroEntradaSaidaModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("Id")]
        public int Id { get; set; }
        [Required]
        [Column("HoraEntrada")]
        public DateTime Entrada { get; set; }
        [Column("HoraSaida")]
        public DateTime? Saida { get; set; }
        [Column("Desconto")]
        public double? Desconto { get; set; }
        [Required]
        public int VeiculoId { get; set; }
        public virtual VeiculoModel Veiculo { get; set; }
        [Required]
        public int UsuarioId { get; set; }
        public virtual UsuarioModel Usuario { get; set; }
    }
}
