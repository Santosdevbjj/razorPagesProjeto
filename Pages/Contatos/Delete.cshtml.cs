public class DeleteModel : PageModel
{
    private readonly IContatoRepository _repo;

    public DeleteModel(IContatoRepository repo)
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

    public async Task<IActionResult> OnPostAsync(int id)
    {
        await _repo.DeleteAsync(id);
        return RedirectToPage("Index");
    }
}
