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
            //�f�t�H���g��1���� Timeout���� DB�������� Timeout���邱�Ƃ����������̂� 10���ɕύX�B
            client.Endpoint.Binding.SendTimeout = new TimeSpan(0, 10, 0);
            await client.InsertTableAAsync(insertTableA);

            MessageBox.Show("����");
        }
    }
}