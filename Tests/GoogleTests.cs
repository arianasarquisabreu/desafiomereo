using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using FluentAssertions;

public class GoogleTests
{
    [Fact]
    public void ValidarTituloDaPaginaDoGoogle()
    {
        using var driver = new ChromeDriver();

        driver.Navigate().GoToUrl("https://www.google.com");
        string titulo = driver.Title;

        titulo.Should().Be("Google");var  //comparacao

        driver.Quit(); //fecha o navegador
    }
}
