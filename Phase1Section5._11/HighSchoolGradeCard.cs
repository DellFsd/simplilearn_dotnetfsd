
namespace Phase1Section5._11
{
    class HighSchoolGradeCard : BasicGradeCard
    {
        private int _math = 0;
        private int _english = 0;
        private int _secondLanguage = 0;
        private int _geography = 0;
        private int _history = 0;
        private int _physics = 0;
        private int _chemistry = 0;
        private int _biology = 0;


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

        public int Physics
        {
            get { return _physics; }
            set
            {
                TotalMarks -= _physics;
                _physics = value;
                TotalMarks += _physics;
            }
        }

        public int Chemistry
        {
            get { return _chemistry; }
            set
            {
                TotalMarks -= _chemistry;
                _chemistry = value;
                TotalMarks += _chemistry;
            }
        }

        public int Biology
        {
            get { return _biology; }
            set
            {
                TotalMarks -= _biology;
                _biology = value;
                TotalMarks += _biology;
            }
        }

        public HighSchoolGradeCard() { }

        public HighSchoolGradeCard(int math, int english, int secondLanguge, int geography, int history, int physics, int chemistry, int biology)
        {
            _math = math;
            _english = english;
            _secondLanguage = secondLanguge;
            _geography = geography;
            _history = history;
            _physics = physics;
            _chemistry = chemistry;
            _biology = biology;
            TotalMarks = math + english + secondLanguge + geography + history + physics + chemistry + biology;
        }
    }
}
