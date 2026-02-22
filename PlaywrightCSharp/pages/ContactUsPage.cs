using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace Playwright_Practice.pages
{
	public class ContactUsPage
	{
		private IPage _page = null!;
		public ContactUsPage(IPage _page)
		{
			this._page = _page;
		}

		private ILocator _name => _page.GetByPlaceholder("Name");

		private ILocator _email => _page.GetByRole(AriaRole.Textbox, new() { Name = "Email", Exact = true });

		private ILocator _subject => _page.GetByPlaceholder("Subject");

		private ILocator _message => _page.Locator("#message");

		private ILocator _submit => _page.Locator("#contact-us-form .submit_form");

		private ILocator _successMessage => _page.Locator(".contact-form>div").Nth(1);

		private ILocator _successMessageText => _page.Locator("#contact-page").GetByText("Success! Your details have been submitted successfully.");

		public async Task ContactUsFormFilling(string name, string emailid,string subject)
		{
			var time = DateTime.Now.ToString("yyyyMMddHHmmss");
			await _name.FillAsync(name+time);
			await _email.FillAsync(emailid+time);
			await _subject.FillAsync(subject);
			await _message.FillAsync("Hello,\r\nI would like to get more information about your services and pricing details. Please let me know the next steps and any required documentation.\r\n\r\nThank you for your time.\r\nBest regards,Rajesh");
			await _page.Locator("textarea").PressAsync("Tab");
			var filename = "test_file.txt";
			await File.WriteAllTextAsync(filename, "Hello World!");
			await _page.SetInputFilesAsync("input[name='upload_file']", filename);
			await Task.Delay(2000);
			_page.Dialog += async (_, dialog) =>
			{
				await dialog.AcceptAsync();
			};
			await _submit.ScrollIntoViewIfNeededAsync();
			await _submit.ClickAsync(new() { Force = true });
			
		}

		public ILocator returnSuccessLocator()
		{
			return _successMessage;
		}
		
		public ILocator ReturnSuccessText()
		{
			return _successMessageText;
		}
	}
}
