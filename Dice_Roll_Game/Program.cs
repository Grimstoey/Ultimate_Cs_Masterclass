using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Dice rolled. Guess whar number it shows in 3 tries.");
int getNumber = RandomNumber.Random(1, 7);
GuessDiceRoll();

void GuessDiceRoll()
{
    bool checkNum = false;
    int convert_num;
    int count = 0;
    do
    {
        Console.Write("Enter a number : ");
        string tryGuess = Console.ReadLine();
        bool tryGuess_Number = Int32.TryParse(tryGuess, out convert_num);
        if(tryGuess_Number == true)
        {
            if(convert_num >= 1 && convert_num <=9)
            {
                checkNum = CompareNumber(getNumber, convert_num);
            }
            else
            {
                InvalidInput();
            }
        }
        else
        {
            InvalidInput();
        }
        count++;

        if(!(convert_num >= 1 && convert_num <= 9))
        {
            count--;
        }
        
        if(count == 3 && checkNum == false)
        {
            Console.WriteLine("You Lose!!");
        }
    }
    while (checkNum == false && count < 3);
}

bool CompareNumber(int first, int second)
{
    bool guess = false;

    if ((first >= 1 && first <= 9) && (second >= 1 && second <= 9))
    {
        if (getNumber == second)
        {
            Console.WriteLine("You win");
            guess = true;
        }
        else if (getNumber != second)
        {
            Console.WriteLine("Wrong Number!!");
            Console.WriteLine();
            guess = false;
        }
    }
    return guess;
}

void InvalidInput()
{
    Console.WriteLine("Invalid Input!!!");
    Console.WriteLine();
}