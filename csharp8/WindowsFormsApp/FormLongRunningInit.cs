using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormLongRunningInit : Form
    {
        public FormLongRunningInit()
        {
            InitializeComponent();
        }

        private int ExecuteFooOnUIThread()
        {
            Thread.Sleep(TimeSpan.FromSeconds(10));
            return 42;
        }

        /// <summary>
        /// Approved nothing on https://stackoverflow.com/questions/22645024/when-would-i-use-task-yield
        /// </summary>
        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Yield(); // Make us async right away

            var data = ExecuteFooOnUIThread(); // This will run on the UI thread at some point later

            await UseDataAsync(data);
        }

        private async Task UseDataAsync(int data)
        {
            await Task.Delay(1);
            MessageBox.Show($"Finish. {data}");
        }
    }
}
