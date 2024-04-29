/*
 * Auhtor: Sakthi Santhosh
 * Created on: 29/04/2024
 */
public class Solution
{
    public async Task<string> ConvertToTitle(int columnNumber)
    {
        StringBuilder result = new StringBuilder();
        char character;

        while (columnNumber > 0)
        {
            character = (char)('A' + --columnNumber % 26);

            result.Insert(0, character);
            columnNumber /= 26;
        }

        return result.ToString();
    }
}
