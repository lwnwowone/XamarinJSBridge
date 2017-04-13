# XamarinJSBridge
A bridge to make interaction between Xamarin.iOS native and WebView's JSContext

At the first of all, you must do some modifications for your iOS project:

Step1: Doulbe click the project item(or right click it and select "options") to open the project's setting menu.
![](https://github.com/lwnwowone/XamarinJSBridge/raw/master/Important_Step1.png)

Step2: Select "iOS Build" in left side and add "--registrar:static" into "Addtional mtouch arguments" like the picture.
![](https://github.com/lwnwowone/XamarinJSBridge/raw/master/Important_Step2.png)



Then, you just need to import the "ALJavaExporter.cs" and "JSBridgeWebView.cs", and modify the function in "ALJavaExporter.cs", then invoke them like this:

    webView = new JSBridgeWebView();
    string filePath = NSBundle.MainBundle.PathForResource("TestBrigeHtml", "html");
    string htmlStr = System.IO.File.ReadAllText(filePath);
    webView.LoadHtmlString(htmlStr, NSUrl.FromString(""));
    webView.Frame = new CGRect(20, 80, UIScreen.MainScreen.Bounds.Width - 40, UIScreen.MainScreen.Bounds.Height - 100);
    this.Add(webView);
    
Sample:
![](https://github.com/lwnwowone/XamarinJSBridge/blob/master/Testing_Result.png)
