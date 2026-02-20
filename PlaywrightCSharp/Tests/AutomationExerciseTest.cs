using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;
using Playwright_Practice.pages;
using static Microsoft.Playwright.Assertions;

namespace Playwright_Practice.Tests
{
	public class AutomationExerciseTest : IAsyncLifetime
	{
		private IPlaywright _playwright = null!;

		private BrowserTypeLaunchOptions _launchOptions = null!;

		private IBrowser _browser = null!;

		private IPage _page = null!;

		private string url = "https://automationexercise.com/";

		private AutomationExercisePage _automationExercisePage = null!;

		private ProductsPage _productsPage = null!;

		public async Task InitializeAsync()
		{
			_playwright = await Playwright.CreateAsync();

			_launchOptions = new BrowserTypeLaunchOptions { Headless = false };

			_browser = await _playwright.Chromium.LaunchAsync(_launchOptions);

			_page = await _browser.NewPageAsync();
		}

		[Fact]

		public async Task TestHomePageNavigation()
		{
			await _page.GotoAsync(url);
			_automationExercisePage = new AutomationExercisePage(_page);
			await Expect(_automationExercisePage.returnImage()).ToBeVisibleAsync();
			await Expect(_automationExercisePage.returnFeatureItems()).ToHaveTextAsync("Features Items");
			await _automationExercisePage.clickWomen();
			await Expect(_automationExercisePage.returnDress()).ToBeVisibleAsync();
			await Expect(_automationExercisePage.returnTops()).ToBeVisibleAsync();
			await Expect(_automationExercisePage.returnSaree()).ToBeVisibleAsync();
		}

		[Fact]
			public async Task EmailSubscription ()
		{
			await _page.GotoAsync(url);
			_automationExercisePage = new AutomationExercisePage(_page);
			await _automationExercisePage.enterEmail("abcdef@gmail.com");
			await _automationExercisePage.ClickEmailSubscription();
			await Expect(_automationExercisePage.returnAlertMessageLocator()).ToBeVisibleAsync();
		}

		[Fact]

		public async Task ClickProductsLink()
		{
			await _page.GotoAsync(url);
			_automationExercisePage = new AutomationExercisePage(_page);
			await _automationExercisePage.ClickProducts();
			_productsPage = new ProductsPage(_page);
			await _productsPage.EnterSearchProduct("TShirt");
			await _productsPage.ClickSearch();
			await Expect(_productsPage.returnText()).ToBeVisibleAsync();

		}
		[Fact]

		public async Task ClickAddToCart()
		{
			await _page.GotoAsync(url);
			_automationExercisePage = new AutomationExercisePage(_page);
			await _automationExercisePage.AddToCartProduct();
			await Task.Delay(5000);
		}

		[Fact]

		public async Task FillContactUsForm()
		{
			await _page.GotoAsync(url);
			_automationExercisePage = new AutomationExercisePage(_page);
			await _automationExercisePage.ClickContactUs();
			_contactUsPage = new ContactUsPage(_page);
			await _contactUsPage.ContactUsFormFilling("Rajesh", "Rajesh@gmail.com", "Inquiry Regarding Services");
			await Expect(_contactUsPage.returnSuccessLocator()).ToBeVisibleAsync();

		}


			public async Task DisposeAsync()
		{
			await _browser.DisposeAsync();
			_playwright.Dispose();
		}	


	}

}
