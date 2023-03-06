namespace VideoStore
{
    class Video
    {
        private string _title;
        private bool _checkedOut;
        private int _timesRated;
        private double _totalRating;
        private double _averageRating;

        public Video(string title)
        {
            _title = title;
            _checkedOut = false;
            _averageRating = 0;
            _timesRated = 0;
        }

        public void BeingCheckedOut()
        {
            _checkedOut = true;
        }

        public void BeingReturned()
        {
            _checkedOut = false;
        }

        public void ReceivingRating(double rating)
        {
            _timesRated++;
            _totalRating += rating;
            _averageRating = _totalRating / _timesRated;
        }

        public double AverageRating()
        {
            return _averageRating;
        }

        public bool Available()
        {
            return !_checkedOut;
        }

        public string Title => _title;

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
