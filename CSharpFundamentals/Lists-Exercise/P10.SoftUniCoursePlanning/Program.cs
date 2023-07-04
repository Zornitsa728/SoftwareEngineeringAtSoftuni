namespace P10.SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();
            string input;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] inputToArray = input.Split(":");
                string cmd = inputToArray[0];
                string lessonTitle = inputToArray[1];

                if (cmd == "Add")
                {
                    AddLesson(schedule, lessonTitle);
                }
                else if (cmd == "Insert")
                {
                    int index = int.Parse(inputToArray[2]);
                    InsertLesson(schedule, lessonTitle, index);
                }
                else if (cmd == "Remove")
                {
                    RemoveLesson(schedule, lessonTitle);
                }
                else if (cmd == "Swap")
                {
                    string secondLesson = inputToArray[2];
                    int firstIndex = 0;
                    int secondIndex = 0;

                    if (IsBothLessonsExists(schedule, lessonTitle, secondLesson, ref firstIndex, ref secondIndex))
                    {
                        SwapLesson(schedule, lessonTitle, secondLesson, firstIndex, secondIndex);
                    }
                }
                else if (cmd == "Exercise")
                {
                    Exercise(schedule, lessonTitle);
                }
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }

        static void AddLesson(List<string> schedule, string lessonTitle)
        {
            bool isTitleExist = false;

            foreach (string item in schedule)
            {
                if (lessonTitle == item)
                {
                    isTitleExist = true;
                }
            }

            if (!isTitleExist)
            {
                schedule.Add(lessonTitle);
            }
        }

        static void InsertLesson(List<string> schedule, string lessonTitle, int index)
        {
            bool isTitleExist = false;

            foreach (string item in schedule)
            {
                if (lessonTitle == item)
                {
                    isTitleExist = true;
                }
            }

            if (!isTitleExist)
            {
                schedule.Insert(index, lessonTitle);
            }
        }

        static void RemoveLesson(List<string> schedule, string lessonTitle)
        {
            bool isTitleExist = false;

            foreach (string item in schedule)
            {
                if (lessonTitle == item)
                {
                    isTitleExist = true;
                }
            }

            if (isTitleExist)
            {
                if (schedule.Contains($"{lessonTitle}-Exercise"))
                {
                    schedule.Remove($"{lessonTitle}-Exercise");
                }

                schedule.Remove(lessonTitle);
            }
        }

        static bool IsBothLessonsExists(List<string> schedule, string lessonTitle, string secondLesson, ref int firstIndex, ref int secondIndex)
        {
            bool isFirstTitleExist = false;
            bool isSecondTitleExist = false;

            for (int i = 0; i < schedule.Count; i++)
            {
                if (schedule[i] == lessonTitle)
                {
                    isFirstTitleExist = true;
                    firstIndex = i;
                }
                else if (schedule[i] == secondLesson)
                {
                    isSecondTitleExist = true;
                    secondIndex = i;
                }
            }

            if (isSecondTitleExist && isFirstTitleExist)
            {
                return true;
            }

            return false;
        }
        static void SwapLesson(List<string> schedule, string lessonTitle, string secondLesson, int firstIndex, int secondIndex)
        {
            schedule.RemoveAt(firstIndex);
            schedule.Insert(firstIndex, secondLesson);
            schedule.RemoveAt(secondIndex);
            schedule.Insert(secondIndex, lessonTitle);

            if (schedule.Contains($"{lessonTitle}-Exercise"))
            {
                schedule.RemoveAt(firstIndex + 1);
                schedule.Insert(secondIndex + 1, $"{lessonTitle}-Exercise");
            }

            if (schedule.Contains($"{secondLesson}-Exercise"))
            {

                schedule.RemoveAt(secondIndex + 1);
                schedule.Insert(firstIndex + 1, $"{secondLesson}-Exercise");
            }

        }

        static void Exercise(List<string> schedule, string lessonTitle)
        {

            bool isLessonExist = false;
            bool isExerciseExist = false;
            int currIndex = 0;

            for (int i = 0; i < schedule.Count; i++)
            {
                if (schedule[i] == lessonTitle)
                {
                    isLessonExist = true;
                    currIndex = i;
                }
                else if (schedule[i] == $"{lessonTitle}-Exercise")
                {
                    isExerciseExist = true;
                }
            }

            if (!isExerciseExist && isLessonExist)
            {
                schedule.Insert(currIndex + 1, $"{lessonTitle}-Exercise");
            }
            else if (!isLessonExist)
            {
                schedule.Add(lessonTitle);
                schedule.Add($"{lessonTitle}-Exercise");
            }
        }
    }
}