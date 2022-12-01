namespace Solutions.DayOne
{
    public class Answer
    {
        public static List<int> GetCaloriesPerElf(string[] input)
        {
            List<int> result = new();
            string combinedInput = string.Join(",", input);
            string[] separatedStrings = combinedInput.Split(",,");

            foreach (var seq in separatedStrings)
            {
                var splitArr = seq.Split(",");
                var sum = splitArr.Select(s => int.Parse(s)).Sum();
                result.Add(sum);
            }
            return result;
        }
    }
}