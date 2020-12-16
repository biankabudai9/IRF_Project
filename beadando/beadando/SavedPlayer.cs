using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando
{
    //SavedPlayer osztály létrehozása
    public class SavedPlayer
    {
        public int player_id { get; set; }
        public string name { get; set; }

        private int _age;


        //AgeGroup meghatározása setter ágon
        public int age
        {
            get { return _age; }
            set {
                _age = value;
                {
                    if (age <= 10 && age >= 6)
                    {
                        AgeGroup = "6-10";
                    }

                    else if (age <= 20 && age > 10)
                    {
                        AgeGroup = "11-20";
                    }

                    else if (age <= 30 && age > 20)
                    {
                        AgeGroup = "21-30";
                    }

                    else if (age <= 40 && age > 30)
                    {
                        AgeGroup = "31-40";
                    }

                    else if (age <= 50 && age > 40)
                    {
                        AgeGroup = "41-50";
                    }

                    else if (age <= 60 && age > 50)
                    {
                        AgeGroup = "51-60";
                    }
                    else if (age <= 70 && age > 60)
                    {
                        AgeGroup = "61-70";
                    }
                    else if (age <= 80 && age > 70)
                    {
                        AgeGroup = "71-80";
                    }

                    else if (age <= 90 && age > 80)
                    {
                        AgeGroup = "81-90";
                    }

                    else if (age < 100 && age > 90)
                    {
                        AgeGroup = "91-99";
                    }
                    else
                    {
                        AgeGroup = "x";
                    }
                }
            }
        }

        public string AgeGroup { get; set; }

        public string password { get; set; }
        public int score { get; set; }
    }
}
