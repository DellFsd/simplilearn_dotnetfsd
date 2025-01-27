﻿using System;

namespace Phase1Section5._10
{
    class ElementarySchoolGradeCard : BasicGradeCard
    {
        public int Mathematics { get; set; }
        public int English { get; set; }
        public int SecondLanguage { get; set; }
        public int SocialScience { get; set; }
        public override int TotalMarks { get { return Mathematics + English + SecondLanguage + SocialScience; } }
        public ElementarySchoolGradeCard() { }

        public ElementarySchoolGradeCard(int mathematics, int english, int secondLanguge, int socialScience)
        {
            Mathematics = mathematics;
            English = english;
            SecondLanguage = secondLanguge;
            SocialScience = socialScience;
        }
        public static ElementarySchoolGradeCard operator +(ElementarySchoolGradeCard a, ElementarySchoolGradeCard b)
        {
            return new ElementarySchoolGradeCard(a.Mathematics + b.Mathematics, a.English + b.English, a.SecondLanguage + b.SecondLanguage, a.SocialScience + b.SocialScience);
        }

        public static ElementarySchoolGradeCard operator *(ElementarySchoolGradeCard a, int mul)
        {
            return new ElementarySchoolGradeCard(a.Mathematics * mul, a.English * mul, a.SecondLanguage * mul, a.SocialScience * mul);
        }
        public static ElementarySchoolGradeCard operator *(ElementarySchoolGradeCard a, double mul)
        {
            return new ElementarySchoolGradeCard(a.Mathematics * (int)mul, a.English * (int)mul, a.SecondLanguage * (int)mul, a.SocialScience * (int)mul);
        }

    }
}
