using System;
using Foundation;
using JavaScriptCore;

namespace XamarinJSBrige
{
	[Protocol()]
	interface IALJavaExporter : IJSExport
	{
		[Export("myFunc")]
		string MyFunc();
	}

	class ALJavaExporter : NSObject, IALJavaExporter
	{
		public string MyFunc()
		{
			Console.WriteLine("MyFunc");
			return "Hello world!";
		}
	}
}
