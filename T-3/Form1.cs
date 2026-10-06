namespace T_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {  
                 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtCelsius.Text != "" || txtFahrenheit.Text != "" || txtKelvin.Text != "")
            {
                if (!string.IsNullOrEmpty(txtCelsius.Text))
                {
                    float Ce = float.Parse(txtCelsius.Text);
                    float Fa = (Ce * 9f / 5f) + 32;
                    
                    float Ke = Ce + 273;
                    txtKelvin.Text = Ke.ToString();

                }
                else if (!string.IsNullOrEmpty(txtFahrenheit.Text))
                {
                    float Fa = float.Parse(txtFahrenheit.Text);
                    float Ce = (Fa - 32) * 5.0f / 9.0f;
                    float Cexi = (Fa - 32) * 5.0f / 9.0f;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCelsius.Clear();
            txt
        }

        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
