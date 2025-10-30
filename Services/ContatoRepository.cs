namespace AgendaContatos.Services;

public class ContatoRepository : IContatoRepository
{
    private readonly AppDbContext _context;

    public ContatoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Contato>> GetAllAsync() =>
        await _context.Contatos.ToListAsync();

    public async Task<Contato?> GetByIdAsync(int id) =>
        await _context.Contatos.FindAsync(id);

    public async Task AddAsync(Contato contato)
    {
        _context.Contatos.Add(contato);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Contato contato)
    {
        _context.Contatos.Update(contato);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var contato = await GetByIdAsync(id);
        if (contato != null)
        {
            _context.Contatos.Remove(contato);
            await _context.SaveChangesAsync();
        }
    }
}
