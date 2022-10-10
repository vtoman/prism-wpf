using _1_InitialApp.Views;
using Prism.DryIoc;
using Prism.Ioc;
using System;
using System.Windows;

namespace _1_InitialApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<ShellWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
