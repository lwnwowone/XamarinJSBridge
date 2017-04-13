using System;
using Foundation;
using JavaScriptCore;
using UIKit;

namespace XamarinJSBrige
{
	public class JSBridgeWebView : UIWebView
	{
		private JSContext jsContext;
		public JSContext JSContext { 
			get {
				return jsContext;
			}
		}

		public JSBridgeWebView()
		{
			jsContext = this.ValueForKeyPath(new NSString("documentView.webView.mainFrame.javaScriptContext")) as JSContext;
			jsContext.ExceptionHandler = (JSContext context, JSValue exception) =>
			{
				Console.WriteLine("JS exception : " + exception);
			};
			var exporter = new ALJavaExporter();
			jsContext[(NSString)"native"] = JSValue.From(exporter, jsContext);
		}
	}
}
