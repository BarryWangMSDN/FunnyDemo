using FunnyDemoCollection.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FunnyDemoCollection
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

        private void NvTopLevelNav_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            //TextBlock ItemContent = args.InvokedItem as TextBlock;
            //if (ItemContent != null)
            //{
            //    switch (ItemContent.Tag)
            //    {
            //        case "AControl":
            //            contentFrame.Navigate(typeof(AnimatedControl));
            //            break;
            //    }
            //}



            if (args.InvokedItem != null)
            {
                switch (args.InvokedItemContainer.Tag)
                {
                    case "AControl":
                        contentFrame.Navigate(typeof(AnimatedControl));
                        break;

                    case "LTask":
                        contentFrame.Navigate(typeof(LongTask));
                        break;
                }
            }

        }

        //MainPage Contains the basic navigation. So it's a good place to put introduction to navigationview
        //Reference articles are the following blogs:
        //1. Animation: https://medium.com/@Niels9001/create-more-responsive-menusuis-using-animations-2c9e77595a85
        //2. Navigationview quick usage: https://blogs.msdn.microsoft.com/appconsult/2018/05/06/using-the-navigationview-in-your-uwp-applications/
    }
}
