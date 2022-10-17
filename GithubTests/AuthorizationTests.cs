using Microsoft.Extensions.Options;

namespace GithubTests;

public class AuthorizationTests : BaseSeleniumTests
{
  private readonly GithubOptions _githubOptions;

  public AuthorizationTests(IOptions<GithubOptions> options)
  {
    _githubOptions = options.Value;
  }

  [Fact]
  public void Authorization() 
  {
    Driver
      .Navigate()
      .GoToUrl(_githubOptions.Gist.BaseUrl);
    Wait
      .Until(d => d.FindElement(By.LinkText("Sign in")))
      .Click();
    Wait
      .Until(d => d.FindElement(By.Id("login_field")))
      .SendKeys(_githubOptions.Login);
    Driver
      .FindElement(By.Id("password"))
      .SendKeys(_githubOptions.Password);
    Driver
      .FindElement(By.Name("commit"))
      .Click();
  }
}