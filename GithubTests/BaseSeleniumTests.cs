namespace GithubTests;

public abstract class BaseSeleniumTests : IDisposable
{
    protected BaseSeleniumTests()
    {
        Driver = new ChromeDriver();
        Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
    }

    protected IWebDriver Driver { get; }
    protected WebDriverWait Wait { get; }
    
    public void Dispose()
    {
        Driver.Quit();
        GC.SuppressFinalize(this);
    }
}