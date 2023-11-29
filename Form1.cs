namespace flights_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FlightsList fl = new FlightsList();

        private void button1_Click(object sender, EventArgs e)
        {
            string a = destinationS.Text;
            string b = codeS.Text;
            int c = int.Parse(seatsS.Text);
            int d = int.Parse(numberS.Text);
            Flight_info info = new Flight_info(a, b, c, d);
            fl.AddFlight(info);
        }

        private void button_2_Click(object sender, EventArgs e)
        {
           Flight_info flc = fl.GetFlight_Info(int.Parse(numberS.Text));
            destinationC.Text = flc.GetDestination();
            codeC.Text = flc.GetCode();
            seatsC.Text = flc.GetSeats().ToString();
        }
    }
}
