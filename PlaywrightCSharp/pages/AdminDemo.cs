using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice.pages
{
	public class AdminDemo
	{
		private readonly IPage _page;
		private readonly ILocator _email;
		private readonly ILocator _password;
		private readonly ILocator _loginbutton;


		public AdminDemo(IPage _page)
		{
			_email = _page.Locator("#Email");
			_password = _page.Locator("#Password");
			_loginbutton = _page.GetByRole(AriaRole.Button, new() { Name = "Log in" });
		}

		public async Task clickSignuplogin(string email, string password)
		{
			_email.ClearAsync();
			_password.ClearAsync();
			await Task.Delay(1000);
			_email.FillAsync(email);
			_password.FillAsync(password);
			_loginbutton.ClickAsync();

		}
	}
}
