using FunnyDemoCollection.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FunnyDemoCollection.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AnimatedControl : Page
    {
        EventWaiter waiter = new EventWaiter();
       


        public AnimatedControl()
        {
            this.InitializeComponent();
            
        }

        //Light funtion from this thread:https://stackoverflow.com/questions/56949736/uwp-xaml-larger-reveal-effect-or-gradient-customization-on-listview
        //As I've discussed with Nico
        private PointLight _pointLight;
        private void Rectangle_Loaded(object sender, RoutedEventArgs e)
        {
            var compositor = Window.Current.Compositor;
            var visual = ElementCompositionPreview.GetElementVisual(sender as UIElement);
            _pointLight = compositor.CreatePointLight();
            _pointLight.Color = Colors.Yellow;
            _pointLight.CoordinateSpace = visual;
            _pointLight.Targets.Add(visual);
        }

        private void Rectangle_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            var point = e.GetCurrentPoint(sender as UIElement).Position;

            // If you want to make light large, please set large Z Value for `Vector3`

            _pointLight.Offset = new Vector3((float)point.X, (float)point.Y, (float)100);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //scrollerrotation.CenterX = myScroller.ActualWidth / 2;
            //scrollerrotation.CenterY = myScroller.ActualHeight / 2;
            //scrollerrotation.Angle = 90;

        }

      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this is a test for checking the waiter object
            if (waiter.IsEnabled)
            {
                //do something 
            }
        }

        private void Paragrid_Loaded(object sender, RoutedEventArgs e)
        {
            //ScrollViewer scrollview = CommonHelper.FindChildOfType<ScrollViewer>(wavelist);
            //CompositionPropertySet scrollerManipProps = ElementCompositionPreview.GetScrollViewerManipulationPropertySet(scrollview);
            //Compositor compositor = scrollerManipProps.Compositor;
            //// Create the expression
            //ExpressionAnimation expression = compositor.CreateExpressionAnimation("scrollview.Translation.X * parallaxFactor");
            //// wire the ParallaxMultiplier constant into the expression
            //expression.SetScalarParameter("parallaxFactor", 0.3f);
            //// set "dynamic" reference parameter that will be used to evaluate the current position of the scrollbar every frame
            //expression.SetReferenceParameter(nameof(scrollview), scrollerManipProps);
            //// Get the background image and start animating it's offset using the expression
            //Visual backgroundVisual = ElementCompositionPreview.GetElementVisual(background);
            //backgroundVisual.StartAnimation("Offset.X", expression);
        }


        //For lottie, it comes from community toolkit: Microsoft.Toolkit.Uwp.UI.Lottie
        //Startup: https://docs.microsoft.com/zh-cn/windows/communitytoolkit/animations/lottie-scenarios/getting_started_json

    }
}
