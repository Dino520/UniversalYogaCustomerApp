using System.Collections.Generic;
using UniversalYogaCustomerApp.Models;

namespace UniversalYogaCustomerApp;

public partial class App : Application
{
    public static List<YogaClass> Cart { get; } = new List<YogaClass>();

    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        // Initialize the main window with MainPage as the root
        return new Window(new MainPage()) { Title = "Universal Yoga Customer App" };
    }
}
