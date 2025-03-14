using Bibliotekarz.Client.Model;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace Bibliotekarz.Client.Pages;

public partial class Home
{
    [Inject]
    public HttpClient client { get; set; }

    public List<Book> BookList { get; set; } = [];

    protected override async Task OnInitializedAsync()
    {
        try
        {
            BookList = (await client?.GetFromJsonAsync<List<Book>>("/Books")) ?? [];
            StateHasChanged();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine(ex);
        }
        await base.OnInitializedAsync();
    }


}
