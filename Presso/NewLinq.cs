using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presso
{
    public class NewLinq
    {


        record Student(string Name, string Score);

        //These LINQ methods are part of the release candidate, the final release may include changes or removals.
        public NewLinq()
        {
            Student[] students = [
                new("Alice", "A"),
            new("Bob", "B"),
            new("Charlie", "C"),
            new("David", "B"),
            new("Eve", "A")
                ];

            IEnumerable<(int, Student)> studentsWithIndex = students.Index();

            foreach (var (index, student) in studentsWithIndex)
            {
                Console.WriteLine($"Student {index}: {student.Name}");
            }



            IEnumerable<KeyValuePair<string, int>> studentsByScore = students
                .CountBy(keySelector: student => student.Score);

            foreach (var (score, count) in studentsByScore)
            {
                Console.WriteLine($"Students with a {score}-score: {count}");
            }


            IEnumerable<KeyValuePair<bool, int>> studentsCountPassedOrFailed = students
                .CountBy(keySelector: student => student.Score is "A" or "B");

            foreach (var (passed, count) in studentsCountPassedOrFailed)
            {
                Console.WriteLine($"Students that {(passed ? "passed" : "failed")}: {count}");
            }


            IEnumerable<KeyValuePair<string, List<string>>> studentsByScore2 = students
                    .AggregateBy(
                        keySelector: student => student.Score,
                        seed: new List<string>(),
                        func: (group, student) => [.. group, student.Name]
                );

            foreach (var (score, studentGroup) in studentsByScore2)
            {
                Console.WriteLine($"Students with a {score}-score: {string.Join(", ", studentGroup)}");
            }

        }
    }
}
