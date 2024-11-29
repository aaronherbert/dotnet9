using System.Data.Common;

namespace Linq
{
    internal class Program
    {
        record CompletedLesson(long CourseId, long LessionId, long LessiondurationSeconds);

        static void Main(string[] args)
        {
            var totalWatchTime = new List<(long CourseId, long LessionDurationSeconds)>();

            var completedLessons = new List<CompletedLesson>()
            {
                new(1, 1, 345),

                new(1, 2, 345),
                new(2, 1, 345),
                new(2, 3, 345),
                new(3, 1, 345),
            };

            foreach (var completedLesson in completedLessons)
            {
                totalWatchTime.Add((completedLesson.CourseId, completedLesson.LessiondurationSeconds));
            }

            //AggregateBy is new
            var coursewtchtime = totalWatchTime.AggregateBy(x => x.CourseId, _ => 0m,
                (seconds, item) => decimal.Add(seconds, item.LessionDurationSeconds));

            //countby is new
            foreach (var item in completedLessons.CountBy(x => x.LessionId))
            {
                Console.WriteLine($"CourseId: {item.Key} TotalWatchTime: {item.Value}");
            }
        }
    }
}
