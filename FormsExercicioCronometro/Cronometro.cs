namespace FormsExercicioCronometro
{
    public class Cronometro
    {
        #region Atributos

        private DateTime _start; // Inicio do cronometro

        private DateTime _stop; // Fim do cronometro

        private bool _isrunning; // Indica se o cronometro está a correr

        #endregion

        public void StartClock() // Liga o cronometro na prática
        {
            if (_isrunning)
                throw new InvalidOperationException("O cronómetro já está ligado!");

            _start = DateTime.Now;
            _isrunning = true;
        }

        public void StopClock() // Desliga o cronometro na prática
        {
            if (!_isrunning)
                throw new InvalidOperationException("O cronómetro já está desligado!");

            _stop = DateTime.Now;
            _isrunning = false;
        }

        public TimeSpan GetTimeSpan() // Tempo entre os dois
        {
            return _stop - _start;
        }

        public bool ClockState() // Indica se o cronometro está ligado ou não
        {
            return _isrunning;
        }

        public DateTime StartTime() // Envia para fora o tempo de inicio
        {
            return _start;
        }

    }
}
