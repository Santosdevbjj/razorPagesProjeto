namespace AgendaContatos.Services;

public interface IContatoRepository
{
    Task<List<Contato>> GetAllAsync();
    Task<Contato?> GetByIdAsync(int id);
    Task AddAsync(Contato contato);
    Task UpdateAsync(Contato contato);
    Task DeleteAsync(int id);
}
