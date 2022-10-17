namespace GithubTests;

public sealed class GithubOptions
{
    public GithubGistOptions Gist { get; set; } = default!;
    public string Login { get; set; } = default!;
    public string Password { get; set; } = default!;
}

public sealed class GithubGistOptions
{
    public string BaseUrl { get; set; } = default!;
}