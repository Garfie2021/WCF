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
            var insertTableA = new ServiceReference1.TableA()
            {
                Id = 1,
                Code = "2",
                ValueString = "3",
                ValueDate = DateTime.Now
            };

            var client = new ServiceReference1.ServiceClient();
            //デフォルトの1分で Timeoutだと DB処理中に Timeoutすることが多かったので 10分に変更。
            client.Endpoint.Binding.SendTimeout = new TimeSpan(0, 10, 0);
            await client.InsertTableAAsync(insertTableA);

            MessageBox.Show("完了");
        }
    }
}