
namespace Phase1Section5._10
{
    class HighSchoolGradeCard : BasicGradeCard
    {
        public int Math { get; set; }
        public int English { get; set; }
        public int SecondLanguage { get; set; }
        public int Geography { get; set; }
        public int History { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Biology { get; set; }
        public override int TotalMarks { get { return Math + English + SecondLanguage + Geography + History + Physics + Chemistry + Biology; } }
        public HighSchoolGradeCard() { }

        public HighSchoolGradeCard(int math, int english, int secondLanguge, int geography, int history, int physics, int chemistry, int biology)
        {
            Math = math;
            English = english;
            SecondLanguage = secondLanguge;
            Geography = geography;
            History = history;
            Physics = physics;
            Chemistry = chemistry;
            Biology = biology;
        }
    }
}
