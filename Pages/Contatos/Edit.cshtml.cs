public class EditModel : PageModel
{
    private readonly IContatoRepository _repo;

    public EditModel(IContatoRepository repo)
    {
        _repo = repo;
    }

    [BindProperty]
    public Contato Contato { get; set; }

    public async Task<IActionResult> OnGetAsync(int id)
    {
        var contato = await _repo.GetByIdAsync(id);
        if (contato == null) return NotFound();

        Contato = contato;
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();

        await _repo.UpdateAsync(Contato);
        return RedirectToPage("Index");
    }
}
