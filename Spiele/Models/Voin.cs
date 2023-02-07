namespace Spiele.Models
{
    public class Voin
    {
        private int _chislo = 0;
        private int _zdorovje = 10;
        private int _moguschestvo = 1;
        private bool _isAlive = true;

        public int Number
        {
            get
            {
                return _chislo;
            }
            set
            {
                if (value >= 9)
                {
                    _chislo = 9;
                }
                else if (value <= 1)
                {
                    _chislo = 1;
                }
                else
                {
                    _chislo = value;
                }
            }
        }
        public int Zdorovje
        {
            get
            {
                return _zdorovje;
            }
        }
        public int Moguschestvo
        {
            get
            {
                return _moguschestvo;
            }
            set
            {
                _moguschestvo = value;
            }
        }
        public bool IsAlive
        {
            get
            {
                return _isAlive;
            }
        }

        public bool PoluchitjYron(int uron)
        {
            _zdorovje -= uron;

            if (_zdorovje < 0)
            {
                _isAlive = false;
            }

            return IsAlive;
        }
    }
}
