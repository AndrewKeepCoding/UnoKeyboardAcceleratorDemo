using Microsoft.UI.Xaml.Input;

namespace UnoKeyboardAcceleratorDemo.Presentation;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    private bool IgnoreKeyboardAccelerators { get; set; }

    private void RichEditBox_GotFocus(object sender, RoutedEventArgs e)
    {
        IgnoreKeyboardAccelerators = true;
    }

    private void RichEditBox_LostFocus(object sender, RoutedEventArgs e)
    {
        IgnoreKeyboardAccelerators = false;
    }

    private void KeyboardAccelerator_Invoked(KeyboardAccelerator sender, KeyboardAcceleratorInvokedEventArgs args)
    {
        args.Handled = IgnoreKeyboardAccelerators;
    }
}
