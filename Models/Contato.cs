namespace AgendaContatos.Models;

public class Contato
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Nome { get; set; }

    [Required]
    [StringLength(11)]
    public string Telefone { get; set; }

    [Required]
    [EmailAddress]
    [StringLength(100)]
    public string Email { get; set; }

    [DataType(DataType.Date)]
    public DateTime DataNascimento { get; set; }

    [StringLength(255)]
    public string Foto { get; set; }
}
