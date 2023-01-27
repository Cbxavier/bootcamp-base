using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Tarefas.Web.Models;

public class TarefaViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage ="Por favor informe o Titulo")]
    [MinLength(5, ErrorMessage ="Deve ter ao menos 5 caracteres")]

    [DisplayName("Título")]    
    public string? Titulo { get; set; }        
    
    [Required(ErrorMessage ="Por favor informe a Descrição")]
    [MinLength(5, ErrorMessage ="Deve ter ao menos 4 caracteres")]

    [DisplayName("Descrição")]
    public string? Descricao{get; set;}
    

    [DisplayName("Concluída")]
    public bool Concluida { get; set; }

}