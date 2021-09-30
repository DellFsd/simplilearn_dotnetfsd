
namespace Phase1Section5._10
{
    class MiddleSchoolGradeCard : BasicGradeCard
    {
        public int Math { get; set; }
        public int English { get; set; }
        public int SecondLanguage { get; set; }
        public int Geography { get; set; }
        public int History { get; set; }
        public override int TotalMarks { get { return Math + English + SecondLanguage + Geography + History; } }

        public MiddleSchoolGradeCard() { }

        public MiddleSchoolGradeCard(int math, int english, int secondLanguge, int geography, int history)
        {
            Math = math;
            English = english;
            SecondLanguage = secondLanguge;
            Geography = geography;
            History = history;
        }
    }
}
