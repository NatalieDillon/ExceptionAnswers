using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExercises
{
    public enum House
    {
        Griffindor,
        Hufflepuff,
        Ravenclaw,
        Slytherin
    }

    public static class SortingHat
    {
        public static House FindHouse(string possibleHouse)
        {
            possibleHouse = possibleHouse.Trim().ToLower();
            House house = House.Slytherin;
            switch (possibleHouse)
            {
                case "griffindor":
                    house = House.Griffindor;
                    break;
                case "hufflepuff":
                    house = House.Hufflepuff;
                    break;
                case "ravenclaw":
                    house = House.Ravenclaw;
                    break;
                case "slytherin":
                    house = House.Slytherin;
                    break;
            }
            return house;
        }
    }

}
