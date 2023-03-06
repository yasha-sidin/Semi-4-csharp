// Given an integer x, return true if is a palindrom, and false otherwise
bool IsPalindrom(int number)
{
    int revNumber = 0;
    int sourceNumber = number;
    while (sourceNumber != 0)
    {
        int pop = sourceNumber % 10;
        sourceNumber = sourceNumber / 10;

        revNumber = (revNumber * 10) + pop;
    }
    bool isResult = revNumber == number;

    return isResult;
}
Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine());
Console.WriteLine(IsPalindrom(number));

