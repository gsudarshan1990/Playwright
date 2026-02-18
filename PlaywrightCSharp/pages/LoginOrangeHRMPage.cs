using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice.pages
{
	public class LoginOrangeHRMPage 
	{
		
		private ILocator _username;

		private ILocator _password;

		private ILocator _loginButton;

		public LoginOrangeHRMPage(IPage _page)
		{
			

			_username = _page.Locator("[name = 'username']");

			_password = _page.Locator("[name = 'password']");

			_loginButton = _page.GetByRole(AriaRole.Button, new() { Name = "Login" });


		}

		public void LoginToOrangeHRMPortal(string username, string password)
		{
			_username.FillAsync(username);
			_password.FillAsync(password);
			_loginButton.ClickAsync();

		}

	
	}
}
