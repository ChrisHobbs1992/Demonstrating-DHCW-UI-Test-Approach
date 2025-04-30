using SpecFlowProjectTest.Constants;
using SpecFlowProjectTest.Pages.DHCW;
using SpecFlowProjectTest.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectTest.StepDefinitions
{
    [Binding]
    internal class TabNavigationStepDefinitions
    {

        private readonly ScenarioContext _context;
        private readonly Browser _browser;
        private DHCW_HomePage _dhcwHomePage;
        private DHCW_NewsPage _dhcwNewsPage;

        public TabNavigationStepDefinitions(ScenarioContext context, Browser browser)
        {
            _context = context;
            _browser = browser;
            _dhcwHomePage = new DHCW_HomePage(_browser);
            _dhcwNewsPage = new DHCW_NewsPage(_browser);
        }

        [Given(@"I am on the DHCW Website")]
        public void IAmOnTheDHCWWebsite()
        {
            var url = $"{PageUrl.HOME_PAGE}";
            _dhcwHomePage = _browser.NavigateTo<DHCW_HomePage>(url);
        }

        [When(@"I click the '(news|home)' upper ribbon tab")]
        public void IClickTheUpperRibbonTab(string whichPage)
        {
            if (whichPage.ToLowerInvariant() == "news")
            {
                _dhcwHomePage.ClickNewsButton(); 
                _browser.NavigateTo<DHCW_NewsPage>();
            }
            else if (whichPage.ToLowerInvariant() == "home")
            {
                _dhcwHomePage.ClickHomeButton();
                _browser.NavigateTo<DHCW_HomePage>();
            }

        }

        [Then(@"I should be on the home page")]
        [Then(@"I can see the DHCW Motto")]
        public void ICanSeeTheDHCWMotto()
        {
            _dhcwHomePage.DHCWMottoIsPresent();
        }

        [Then(@"I see the news header")]
        public void ICanSeeTheNewsHeader()
        {
            _dhcwNewsPage.NewsPageHeadingIsPresent();
        }


    }
}