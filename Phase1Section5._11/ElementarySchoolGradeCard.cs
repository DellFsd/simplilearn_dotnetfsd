
namespace Phase1Section5._11
{
    class ElementarySchoolGradeCard : BasicGradeCard
    {
        private int _math = 0;
        private int _english = 0;
        private int _secondLanguage = 0;
        private int _socialScience = 0;

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

        public int SocialScience
        {
            get { return _socialScience; }
            set
            {
                TotalMarks -= _socialScience;
                _socialScience = value;
                TotalMarks += _socialScience;
            }
        }

        public ElementarySchoolGradeCard() { }

        public ElementarySchoolGradeCard(int math, int english, int secondLanguge, int socialScience)
        {
            _math = math;
            _english = english;
            _secondLanguage = secondLanguge;
            _socialScience = socialScience;
            TotalMarks = math + english + secondLanguge + socialScience;
        }

    }
}
