using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string ThreadId()
        {
            return Thread.CurrentThread.ManagedThreadId.ToString( );}

        private async void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine($"Main: {ThreadId()}");
            var hash = await DownloadGoogle()
                             .ConfigureAwait(true); // This is default behaviour
                                                                         // Equivalent to:  var hash = await DownloadGoogle()

            Debug.WriteLine($"Write hash: {ThreadId()}");
            this.textBox1.Text = hash;
        }

        private async Task<string> DownloadGoogle()
        {
            var uri = new Uri("http://www.google.com");
            var client = new HttpClient { BaseAddress = uri };

            Debug.WriteLine($"Before download: {ThreadId()}");

            var downloadGoogle = (await client.GetAsync(uri)).GetHashCode().ToString();

            Debug.WriteLine($"After download: {ThreadId()}");
            return downloadGoogle;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Debug.WriteLine($"Main: {ThreadId()}");
            await DownloadGoogle().ContinueWith(async (Task<string> task, object state) =>
            {
                var hash = await task;
                Debug.WriteLine($"Write hash: {ThreadId()}");
                this.textBox1.Text = hash;
            }, null, TaskScheduler.FromCurrentSynchronizationContext()); 
        }
    }
}
