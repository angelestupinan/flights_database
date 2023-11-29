namespace flights_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FlightsList fl = new FlightsList();

        public void EliminarCampos()
        {
            destinationS.Text = "";
            codeS.Text = "";
            seatsS.Text = "";
            destinationC.Text = "";
            codeC.Text = "";
            seatsC.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = destinationS.Text;
            string b = codeS.Text.ToUpper();
            int c = int.Parse(seatsS.Text);
            Flight_info info = new Flight_info(a, b, c);
            fl.AddFlight(info);
            EliminarCampos();
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            Flight_info flc = fl.GetFlight_Info(codeC.Text.ToUpper());
            EliminarCampos();
            destinationC.Text = flc.GetDestination();
            codeC.Text = flc.GetCode();
            seatsC.Text = flc.GetSeats().ToString();
        }
    }
}
