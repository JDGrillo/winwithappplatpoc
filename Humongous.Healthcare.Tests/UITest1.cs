// Generated by Selenium IDE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Xunit;
using OpenQA.Selenium.Edge;

public class SuiteTests : IDisposable
{
    public IWebDriver driver { get; private set; }
    public IDictionary<String, Object> vars { get; private set; }
    public IJavaScriptExecutor js { get; private set; }
    public SuiteTests()
    {
        var edgeOptions = new EdgeOptions();
        edgeOptions.AddArguments("headless");
        driver = new EdgeDriver(edgeOptions);
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<String, Object>();
    }
    public void Dispose()
    {
        driver.Quit();
    }
    //[Fact]
    //public void Namejd()
    //{
    //    driver.Navigate().GoToUrl("https://workshopappjd.azurewebsites.net/");
    //    driver.Manage().Window.Size = new System.Drawing.Size(1000, 600);
    //    driver.FindElement(By.Id("name")).Click();
    //    driver.FindElement(By.Id("name")).SendKeys("JD");
    //    driver.FindElement(By.CssSelector(".btn")).Click();
    //}

    [Fact]
    public void Humongous()
    {
        driver.Navigate().GoToUrl("https://testing-accelerator-appsvc-jdg20230308.azurewebsites.net/");
        driver.Manage().Window.Size = new System.Drawing.Size(1000, 600);
        driver.FindElement(By.LinkText("Home")).Click();
        driver.FindElement(By.LinkText("Health Checks")).Click();
        driver.FindElement(By.Id("tabelLabel")).Click();
        Assert.Equal(driver.FindElement(By.Id("tabelLabel")).Text, "Health Checks");
    }
}