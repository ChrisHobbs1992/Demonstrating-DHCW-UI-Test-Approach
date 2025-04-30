using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowProjectTest.Pages.DHCW.Shared_Components;
using SpecFlowProjectTest.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectTest.Pages.DHCW
{
    internal class DHCW_NewsPage : DHCWUpperRibbon
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        private readonly Browser _browser;
        public DHCW_NewsPage(Browser browser) : base(browser)
        {
            _browser = browser;
            _driver = browser.DriverInstance();
            _wait = browser.DriverWaitInstance();
        }
        #region Locators

        By NewsPageHeading = By.XPath("//h1[contains(text(), 'News and stories')]");

        #endregion

        #region Actions

        // e.g. internal void SelectNewsStory(int numberInlist){}

        #endregion

        #region Assertions and Checks

        internal void NewsPageHeadingIsPresent()
        {
            WaitForElementToDisplay(NewsPageHeading).Should().BeTrue();
        }

        #endregion
    
    }
}
