using System;

namespace ExceptionExercises
{
    internal class Program
    {
        static void Main()
        {            
            CakeDivision();
            //DetermineHouse();
            //ReadDiary();
        }
               
        public static void CakeDivision()
        {
            int cakeSlices = 32;
            Console.WriteLine("Please enter the number of children");
            int children = Convert.ToInt32(Console.ReadLine());
            int slices = cakeSlices / children;
            Console.WriteLine($"Each child will get {slices} slices");
        }

        public static void ReadDiary()
        {
            string fileName = @"Files\DiaryEvents.csv";
            List<DiaryRecord> diaryRecords = Diary.ReadDiaryEvents(fileName);
            foreach (var entry in diaryRecords)
            {
                Console.WriteLine(entry);
            }
        }

        public static void DetermineHouse()
        {
            Console.WriteLine("Which house do you want to be added to?");
            string userHouse = Console.ReadLine() ?? string.Empty;
            House house = SortingHat.FindHouse(userHouse);
            Console.WriteLine($"You have been assigned to {house}");
        }


}
}
