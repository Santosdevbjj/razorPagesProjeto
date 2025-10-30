public class IndexModel : PageModel
{
    private readonly IContatoRepository _repo;

    public IndexModel(IContatoRepository repo)
    {
        _repo = repo;
    }

    public List<Contato> Contatos { get; set; } = new();

    public async Task OnGetAsync()
    {
        Contatos = await _repo.GetAllAsync();
    }
}
