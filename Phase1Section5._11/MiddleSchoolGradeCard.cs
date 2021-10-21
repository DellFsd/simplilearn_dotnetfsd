
namespace Phase1Section5._11
{
    class MiddleSchoolGradeCard : BasicGradeCard
    {
        private int _math = 0;
        private int _english = 0;
        private int _secondLanguage = 0;
        private int _geography = 0;
        private int _history = 0;

        public int Math
        {
            get { return _math; }
            set
            {
                TotalMarks -= _math;
                _math = value;
                TotalMarks += _math;
            }
        }

        public int English
        {
            get { return _english; }
            set
            {
                TotalMarks -= _english;
                _english = value;
                TotalMarks += _english;
            }
        }

        public int SecondLanguage
        {
            get { return _secondLanguage; }
            set
            {
                TotalMarks -= _secondLanguage;
                _secondLanguage = value;
                TotalMarks += _secondLanguage;
            }
        }

        public int Geography
        {
            get { return _geography; }
            set
            {
                TotalMarks -= _geography;
                _geography = value;
                TotalMarks += _geography;
            }
        }

        public int History
        {
            get { return _history; }
            set
            {
                TotalMarks -= _history;
                _history = value;
                TotalMarks += _history;
            }
        }

        public MiddleSchoolGradeCard() { }

        public MiddleSchoolGradeCard(int math, int english, int secondLanguge, int geography, int history)
        {
            _math = math;
            _english = english;
            _secondLanguage = secondLanguge;
            _geography = geography;
            _history = history;
            TotalMarks = math + english + secondLanguge + geography + history;
        }
    }
}
