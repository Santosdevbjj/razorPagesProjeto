public class CreateModel : PageModel
{
    private readonly IContatoRepository _repo;

    public CreateModel(IContatoRepository repo)
    {
        _repo = repo;
    }

    [BindProperty]
    public Contato Contato { get; set; }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();

        await _repo.AddAsync(Contato);
        return RedirectToPage("Index");
    }
}
