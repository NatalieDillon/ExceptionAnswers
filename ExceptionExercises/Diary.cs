using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExercises
{
    public record DiaryRecord(DateOnly Date, TimeOnly Time, string Location, string Description, int Duration = 60);
    public class Diary
    {       
        public static List<DiaryRecord> ReadDiaryEvents(string fileName)
        {
            var diaryEvents = new List<DiaryRecord>();
            using (var streamReader = new StreamReader(fileName))
            {
                streamReader.ReadLine();
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine() ?? string.Empty;
                    string[] fields = line.Split(',');
                    DateOnly date = DateOnly.ParseExact(fields[0], "yyyyMMdd");
                    TimeOnly time = TimeOnly.ParseExact(fields[1], "Hss");
                    int duration = int.Parse(fields[2]);
                    var diaryEvent = new DiaryRecord(date, time, fields[3], fields[4], duration);
                    diaryEvents.Add(diaryEvent);
                }
            }
            return diaryEvents;
        }
    }
}
