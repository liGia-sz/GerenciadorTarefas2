using System.ComponentModel.DataAnnotations;
namespace GerenciadorTarefas2.Models;
    public class Tarefas
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres.")]
        [MaxLength(100, ErrorMessage = "Máximo de 100 caracteres.") ]
        public string Nome { get; set; }= string.Empty;
        
        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        [MinLength(5, ErrorMessage = "Mínimo de 5 caracteres.")]
        [MaxLength(200, ErrorMessage = "Máximo de 200 caracteres.") ]
        public string Descricao { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Data de Conclusão")]
        public DateTime? DataConclusao { get; set; }

        public int TipoId { get; set; }
        public Tipo? Tipo { get; set; }

    public bool Concluida { get; set; } = false;
    }