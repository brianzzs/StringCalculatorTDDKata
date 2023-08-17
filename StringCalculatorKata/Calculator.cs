namespace Calculator;

public class StringCalculator
{
    public int Add(string numbers)
    {
        int result = 0;
        if(string.IsNullOrEmpty(numbers))
            return 0;

        if(numbers.Contains(","))
        {
            var numbersArray = numbers.Split(',');
            foreach(var number in numbersArray)
            {
                result += int.Parse(number);
            }
            return result;
        }

        return int.Parse(numbers);
    }
}