namespace nov16_04_01
{
    public partial class Jugador : Form
    {
        public string NumUniforme { get; set; }
        public string Nombre { get; set; }
        public string Ponches { get; set; }
        public string Errores { get; set; }
        public string Posicion { get; set; }
        public int Hits { get; set; }

        public Jugador()
        {
            InitializeComponent();
        }

        List<Jugador> jugadores = new List<Jugador>();

        private void buttonCapturar_Click(object sender, EventArgs e)
        {
            Jugador jugadorInfo = new Jugador();

            jugadorInfo.NumUniforme = txtNumUniforme.Text;
            jugadorInfo.Nombre = txtNombre.Text;
            jugadorInfo.Ponches = txtPonches.Text;
            jugadorInfo.Hits = (int)numHits.Value;
            jugadorInfo.Errores = txtErrores.Text;

            //Capturar la posicion de la posicion

            if (radioButtonPitcher.Checked)
            {
                jugadorInfo.Posicion = "Pitcher";
            }
            else if (radioButtonJugador.Checked)
            {
                jugadorInfo.Posicion = "Jugador de posicion";
            }
            else if (radioButtonBateador.Checked)
            {
                jugadorInfo.Posicion = "Bateador";
            }
            else
            {
                MessageBox.Show("Selecciona una posicion");
                return;
            }

            jugadores.Add(jugadorInfo);
            MessageBox.Show("Los datos se han capturado");
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            string infoJugadores = "";

            foreach (Jugador jug in jugadores)
            {
                infoJugadores += $"Nombre: {jug.Nombre}\r\n Uniforme:{jug.NumUniforme}\r\n" +
                    $" Posicion: {jug.Posicion}\r\n Hits: {jug.Hits}\r\n" +
                    $" Punches: {jug.Ponches}\r\n Errores{jug.Errores}\r\n";

                txtMuestra.Text = infoJugadores;
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
