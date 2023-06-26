using Windows.UI.Xaml.Controls;
using PSPDFKit.Pdf;
using PSPDFKit.UI;
using PSPDFKit.Document;
using System;
using Windows.Storage;

namespace PreventTextCopyInUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void PdfViewOnInitializationCompletedHandler(PdfView sender, Document args)
        {
            StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Assets/demo.pdf"));
            DocumentSource documentSource = DocumentSource.CreateFromStorageFile(file);
            
            await PdfView.Controller.ShowDocumentWithViewStateAsync(documentSource, new ViewState
            {
                PreventTextCopy = true
            });
        }
    }
}
