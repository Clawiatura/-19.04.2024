//Console.WriteLine("Введите целое число: ");
//int userNumber = int.Parse(Console.ReadLine());


//Number(userNumber-1, 1, 0);


//void Number (int max,int min,int result)
//{
//    result = min / 2;
//    min++;
//    if(min%2!=0)
//    {
//        Console.Write(min + " ");
//    }
//    if(min==max)
//    {
//        return;
//    }
//    Number(max, min, result );
//}





Console.WriteLine("Введите слово: ");
string UserWord  = Console.ReadLine(); // level




IsPalindrom(UserWord, 0, UserWord.Length-1);




void IsPalindrom(string word, int startIndex,int maxIndex)
{
    if (word[startIndex] == word[maxIndex])
    {
        startIndex++;
        maxIndex--;

        if (word[startIndex] == word[maxIndex])
        {
            Console.WriteLine($"{word} - это слово палиндром. ");
        }
    }
    else
    {
        Console.WriteLine($"{word} - это слово не является палиндромом. ");
    }
    if (word[startIndex] == word[maxIndex] || word[startIndex] != word[maxIndex])
    {
        return;
    }
    IsPalindrom(word, startIndex,maxIndex - 1);
}