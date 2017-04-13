using System;
using JavaScriptCore;
using UIKit;
using Foundation;
using CoreGraphics;

namespace XamarinJSBrige
{
	public class MainViewController : UIViewController
	{
		private JSBridgeWebView webView;

		public MainViewController()
		{
			webView = new JSBridgeWebView();
			string filePath = NSBundle.MainBundle.PathForResource("TestBrigeHtml", "html");
			string htmlStr = System.IO.File.ReadAllText(filePath);
			webView.LoadHtmlString(htmlStr, NSUrl.FromString(""));
			webView.Frame = new CGRect(20, 80, UIScreen.MainScreen.Bounds.Width - 40, UIScreen.MainScreen.Bounds.Height - 100);
			this.Add(webView);
		}
	}
}
