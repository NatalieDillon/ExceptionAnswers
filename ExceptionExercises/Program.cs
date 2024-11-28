using System;

namespace ExceptionExercises
{
    internal class Program
    {
        static void Main()
        {            
            //CakeDivision();
            //DetermineHouse();
            ReadDiary();
        }
               
        public static void CakeDivision()
        {
            try
            {
				int cakeSlices = 32;
				Console.WriteLine("Please enter the number of children");
				int children = Convert.ToInt32(Console.ReadLine());
				int slices = cakeSlices / children;
				Console.WriteLine($"Each child will get {slices} slices");
			}
            catch (FormatException ex)
            {
				Console.WriteLine($"Input must be convertible to an int {ex}");
			}
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Cannot divide by zero {e}");
            }
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
            try
            {
				Console.WriteLine("Which house do you want to be added to?");
				string userHouse = Console.ReadLine() ?? string.Empty;
				House house = SortingHat.FindHouse(userHouse);
				Console.WriteLine($"You have been assigned to {house}");
			}
            catch (Exception ex)
            {
                Console.WriteLine($"Could not determine house {ex}");
            }
        }


}
}
