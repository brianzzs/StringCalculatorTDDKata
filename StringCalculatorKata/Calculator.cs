namespace Calculator;

public class StringCalculator
{
    public int Add(string numbers)
    {
        int result = 0;
        bool isStringEmpty = string.IsNullOrEmpty(numbers);
        bool numbersContainsNewLine = numbers.Contains("\n");
        bool numbersContainsComma = numbers.Contains(",");

        if (isStringEmpty)
            return 0;

        if (numbersContainsNewLine)
            numbers = numbers.Replace("\n", ",");

        if (numbersContainsComma)
        {
            var numbersArray = numbers.Split(',');
            foreach (var number in numbersArray)
            {
                result += int.Parse(number);
            }
            return result;
        }
        else
            return int.Parse(numbers);
    }
}