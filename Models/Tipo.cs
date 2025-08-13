using System.ComponentModel.DataAnnotations;
namespace GerenciadorTarefas2.Models;

public class Tipo
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres.")]
    [MaxLength(100, ErrorMessage = "Máximo de 100 caracteres.")]
    public string Nome { get; set; } = null!;

    [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
    [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres.")]
    [MaxLength(200, ErrorMessage = "Máximo de 200 caracteres.")]
    public string Descricao { get; set; } = null!;
    public ICollection<Tarefas> Tarefas { get; set; }= new List<Tarefas>();
}