namespace AdApp
{
    public class Hoarding: Advert
    {
        private int _rate;
        private int _numDays;
        private int _surCharge;
        private bool _isPrimeLocation;

        public Hoarding(int fee) : base(fee)
        {
        }
        public Hoarding(int fee, int days, int surCharge, bool primeLocation = false) : base(fee)
        {
            _numDays = days;
            _surCharge = surCharge;
            _isPrimeLocation = primeLocation;
        }

        public override int Cost() 
        {
            var costs =  base.Cost() * _numDays;
            if (_isPrimeLocation)
                costs += _surCharge;
            return costs;
        }

        public override string ToString() 
        {
            return $"\nHoarding Cost = {Cost()}";
        }
    }
}