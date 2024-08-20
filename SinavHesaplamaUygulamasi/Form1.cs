namespace SinavHesaplamaUygulamasi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double s1, s2, proje, ort;
			string Durum;
			s1=Convert.ToDouble(textBox1.Text);
			s2 = Convert.ToDouble(textBox2.Text);
			proje = Convert.ToDouble(textBox3.Text);

			ort = (s1 + s2 + proje) / 3;

            if (ort < 50)
            {
                Durum = "Kaldý";
            }
            else
            {
                Durum = "Geçti";
            }
            textBox4.Text = ort.ToString("0.00") + " / " + Durum;


        }
	}
}
