namespace ConsoleApp1
{
    public class FuelGauge
    {
        private int _fuelLevel;
        public int Level;
        public int Fuel;
        public int ReportLevel()
        {
            return _fuelLevel;
        }

        public void Fill()
        {
            if(_fuelLevel < 70)
                _fuelLevel++;
        }

        public void DecreaseLevel()
        {
            _fuelLevel--;
        }
    }
}
