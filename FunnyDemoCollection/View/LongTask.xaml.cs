using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Http;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FunnyDemoCollection.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LongTask : Page
    {
       

        public LongTask()
        {
            
            this.InitializeComponent();
            //SynchronousProcess();

            object outValue;
            StreamSocket socket;
            socket = (StreamSocket)outValue;
            var writer = new DataWriter(socket.OutputStream);

        }

        private static void PostData()
        {
            // Code to send data to  web API ( web service ).
            Thread.Sleep(6000);
        }

        private static void SynchronousProcess()
        {
            Debug.WriteLine("Syncronus Process Started");
            DateTime startTime = DateTime.Now;
            List<int> batchList = new List<int> { 1, 2, 3, 4, 5 };
            Debug.WriteLine("Start Time:" + startTime);
            //Normal loop behavior
            //foreach (int item in batchList)
            //{
            //    Debug.WriteLine("Begin task..." + item);
            //    PostData();
            //    Debug.WriteLine("End task..." + item);
            //}

            Parallel.ForEach(batchList, item =>
            {

                Console.WriteLine("Begin task..." + item);
                PostData();
                Console.WriteLine("End task..." + item);
            });
           
            DateTime endTime = DateTime.Now;
            Debug.WriteLine("End Time:" + endTime);
            TimeSpan timeExecution = endTime - startTime;
            Debug.WriteLine("Total time execution :" + timeExecution);
            Debug.WriteLine("Syncronus Process End");
        }

        private List<string> SetUpURLList()
        {
            List<string> urls = new List<string>
            {
                "https://msdn.microsoft.com",
                "https://msdn.microsoft.com/library/windows/apps/br211380.aspx",
                "https://msdn.microsoft.com/library/hh290136.aspx",
                "https://msdn.microsoft.com/library/dd470362.aspx",
                "https://msdn.microsoft.com/library/aa578028.aspx",
                "https://msdn.microsoft.com/library/ms404677.aspx",
                "https://msdn.microsoft.com/library/ff730837.aspx"
            };
            return urls;
        }

   
        private static void dosomething()
        {
            Task[] taskArray = new Task[10];
            for (int i = 0; i < taskArray.Length; i++)
            {
                taskArray[i] = Task.Factory.StartNew(() =>
                {
                    Debug.WriteLine("test");
                },new CancellationToken() { });
                   
            }
            Task.WaitAll(taskArray);
        }

    }
}
