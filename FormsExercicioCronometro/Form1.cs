namespace FormsExercicioCronometro
{
    public partial class Form1 : Form
    {
        private readonly Cronometro _cronometro; // Atributo só de leitura
        public Form1()
        {
            InitializeComponent();
            _cronometro = new Cronometro();
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (_cronometro.ClockState())
            {
                _cronometro.StopClock();
                btnOnOff.Text = "Liga";
                TimerRelogio.Enabled = false;
                //lblContador.Text = _cronometro.GetTimeSpan().ToString();
            }
            else
            {
                _cronometro.StartClock();
                btnOnOff.Text = "Desliga";
                TimerRelogio.Enabled = true;
            }
        }

        private void UpdateLabel()
        {
            var tempo = DateTime.Now - _cronometro.StartTime();

            lblContador.Text = $"{tempo.Hours:00}:{tempo.Minutes:00}:{tempo.Seconds:00}:{tempo.Milliseconds}";

        }

        private void TimerRelogio_Tick(object sender, EventArgs e)
        {
            UpdateLabel();
        }
    }
}

    