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
            nameAddPas.Text = "";
            ageAddPas.Text = "";
            idAddPas.Text = "";
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
            destinationC.Text = flc.Destination;
            codeC.Text = flc.Flight_Code;
            seatsC.Text = flc.Seats.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Flight_info flc = fl.GetFlight_Info(codeAddPas.Text.ToUpper());
            destinationText.Text = flc.Destination;
            capacityText.Text = flc.Seats.ToString();
        }

        private void addPas_Click(object sender, EventArgs e)
        {
            Flight_info flc = fl.GetFlight_Info(codeAddPas.Text.ToUpper());
            string cd = codeAddPas.Text;
            string name = nameAddPas.Text;
            int id = int.Parse(idAddPas.Text);
            int age = int.Parse(ageAddPas.Text);
            Pasajero p = new Pasajero(name, age, id, cd);
            flc.AddPassenger(p);
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Flight_info flc = fl.GetFlight_Info(consultPassengers.Text.ToUpper());
            List<Pasajero> pasajeros = flc.Pasajeros;
            listBox1.Items.Add("  Nombre  " + "  Edad  " + "  ID  " + "  Codigo de vuelo");
            foreach (var i in pasajeros)
            {

                listBox1.Items.Add("___________________________");
                listBox1.Items.Add(i.Name+"  "+i.Age+"  "+i.Id+"  "+i.FlightCode);
            }
        }
    }
}
