public class DetailsModel : PageModel
{
    private readonly IContatoRepository _repo;

    public DetailsModel(IContatoRepository repo)
    {
        _repo = repo;
    }

    public Contato Contato { get; set; }

    public async Task<IActionResult> OnGetAsync(int id)
    {
        Contato = await _repo.GetByIdAsync(id);
        if (Contato == null) return NotFound();

        return Page();
    }
}
