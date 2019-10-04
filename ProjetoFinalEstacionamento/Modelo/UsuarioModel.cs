using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalEstacionamento.Modelo
{
    [Table("Usuario")] // Nome da tabela que será gerada no BD
    public class UsuarioModel
    {
        //Define que essa coluna não pode ser nula
        [Required]
        //Definido como primary key, Identity e o nome da coluna
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("Id")]
        public int Id { get; set; }

        [Required]
        //Nome da coluna que será criada no BD
        [Column("Nome"), MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [Column("Senha"), MaxLength(30)]
        public string Senha { get; set; }

        [MaxLength(30)]
        public virtual ICollection<RegistroEntradaSaidaModel> Registros { get; set; }
    }
}
