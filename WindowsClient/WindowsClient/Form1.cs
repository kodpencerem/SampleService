using System;
using System.Windows.Forms;

namespace WindowsClient
{
    public partial class Form1 : Form
    {
        SampleService.SampleServiceClient serviceClient = new SampleService.SampleServiceClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnRequestReplyOperation_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("Request-Reply Operation Started @ " + DateTime.Now.ToString());
                btnRequestReplyOperation.Enabled = false;
                listBox1.Items.Add(serviceClient.RequestReplyOperation());
                btnRequestReplyOperation.Enabled = true;
                listBox1.Items.Add("Request-Reply Operation Completed @ " + DateTime.Now.ToString());
                listBox1.Items.Add("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRequestReplyOperation_ThrowsException_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("Request-Reply Throws Exception Operation Started @ " + DateTime.Now.ToString());
                serviceClient.RequestReplyOperation_ThrowsException();
                listBox1.Items.Add("Request-Reply Throws Exception Operation Completed @ " + DateTime.Now.ToString());
                listBox1.Items.Add("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OneWayOperation_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("OneWay Operation Started @ " + DateTime.Now.ToString());
                OneWayOperation.Enabled = false;
                serviceClient.OneWayOperation();
                OneWayOperation.Enabled = true;
                listBox1.Items.Add("OneWay Operation Completed @ " + DateTime.Now.ToString());
                listBox1.Items.Add("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OneWayOperation_ThrowsException_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("OneWay Throws Exception Operation Started @ " + DateTime.Now.ToString());
                serviceClient.OneWayOperation_ThrowsException();
                listBox1.Items.Add("OneWay Throws Exception Operation Completed @ " + DateTime.Now.ToString());
                listBox1.Items.Add("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
