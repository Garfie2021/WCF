namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var client = new ServiceReference1.ServiceClient();
            var result = await client.GetDataAsync(12345);
            MessageBox.Show(result);
        }
    }
}