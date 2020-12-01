using System;
using System.Windows.Forms;

namespace OnvifEvents
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //WebServer ws = new WebServer(SendResponse, GetOnvifHttpPrefix(8080)); // "http://localhost:8080/test/");
            //ws.Run();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EventForm());
        }

        //public static string SendResponse(HttpListenerRequest request)
        //{
        //    return string.Format("<HTML><BODY>My web page.<br>{0}</BODY></HTML>", DateTime.Now);
        //}

        public static string GetOnvifHttpPrefix(int port)
        {
            return string.Format("http://*:{0}/subscription-1/", port);
        }
    }
}