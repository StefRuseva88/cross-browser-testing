using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;


namespace SelenoidTests
{
    [TestFixture("chrome", "128.0")]
    [TestFixture("firefox", "125.0")]

    public class SelenoidTests
    {
        private IWebDriver driver;

        private string browserType;
        private string version;

        public SelenoidTests(string browserType, string version)
        {
            this.browserType = browserType;
            this.version = version;
        }

        [SetUp]
        public void SetUp()
        {
            var options = GetOptions(this.browserType, this.version);

            this.driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);

            this.driver.Url = "https://en.wikipedia.org/";

            this.driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        private DriverOptions GetOptions(string browserType, string version)
        {
            if (browserType == "chrome")
            {
                var options = new ChromeOptions();
                options.BrowserVersion = version;

                options.AddAdditionalOption("selenoid:options", new Dictionary<string, object>
                {
                    ["name"] = "Chrome browser tests...",
                    ["sessionTimeout"] = "15m",
                    ["labels"] = new Dictionary<string, object>
                    {
                        ["manual"] = "false"
                    },
                    ["enableVideo"] = false,
                    ["enableVNC"] = true
                });

                return options;
            }
            else
            {
                var options = new FirefoxOptions();
                options.BrowserVersion = version;

                options.AddAdditionalOption("selenoid:options", new Dictionary<string, object>
                {
                    ["name"] = "FireFox browser tests...",
                    ["sessionTimeout"] = "15m",
                    ["labels"] = new Dictionary<string, object>
                    {
                        ["manual"] = "false"
                    },
                    ["enableVideo"] = false,
                    ["enableVNC"] = true
                });
                return options;
            }
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

        [Test]
        public void SearchQalityAssuranceTest()
        {
            var searchString = "Quality assurance";
            var searchField = driver.FindElement(By.Id("searchInput"));
            searchField.Clear();
            searchField.SendKeys(searchString);

            driver.FindElement(By.XPath("//button[text()='Search']")).Click();

            var searchResult = driver.FindElement(By.XPath("//h1[@id='firstHeading']/span")).Text;

            Assert.That(searchResult, Is.EqualTo(searchString));
        }

        [Test]
        public void WikipediaLogoTest()
        {
            var wikiLogo = driver.FindElement(By.XPath("//a[@class='mw-logo']"));
            wikiLogo.Click();

            var welcomeMessage = driver.FindElement(By.XPath("//h1[@id='Welcome_to_Wikipedia']")).Text;
            string expectedWelcomeMessage = "Welcome to Wikipedia"; 
            Assert.That(welcomeMessage, Is.EqualTo(expectedWelcomeMessage));
        }

    }
}