# PreventTextCopy In UWP
A sample that shows how to use `PreventTextCopy` in UWP SDK. We can use this property in XAML as well as C# before loading the document.

There are two ways you can use the `PreventTextCopy` property:
1. **In code behind**
   Run the application, select some text, and copy it. Try to paste it in the text box at the bottom of the app.
   You should not be able to paste text from PDF except text annotations.
   
2. **In XAML**
   Uncomment line 19 `<pspdfkit:PdfView x:Name="PdfView" PdfUriSource="ms-appx:///Assets/demo.pdf" PreventTextCopy="True"/>` in _MainPage.xaml_
   and
   Comment out line 21 `<pspdfkit:PdfView x:Name="PdfView" InitializationCompletedHandler="PdfViewOnInitializationCompletedHandler"/>` in _MainPage.xaml_

   Run the application, select some text, and copy it. Try to paste it in the text box at the bottom of the app.
   You should not be able to paste text from PDF except text annotations.
   
