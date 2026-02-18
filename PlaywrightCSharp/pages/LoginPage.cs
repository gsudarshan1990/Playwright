using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice.pages
{
	public class LoginPage
	{
		private ILocator _username;
		private ILocator _password;
		private ILocator _loginButton;

		public LoginPage(IPage _page)
		{
			_username = _page.Locator("#user-name");
			_password = _page.Locator("#password");
			_loginButton = _page.Locator("#login-button");

		}

		public async Task LoginToPage(string username,string password)
		{
			await _username.FillAsync(username);
			await _password.FillAsync(password);
			await _loginButton.ClickAsync();
		}
	}

}
