﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int k = 0; k < 1;)
            {
                string ynAnswer2 = "";
                string dollarString = "";
                string game = "";
                int dollar;
                int tokens = 0;

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Welcome to my illegal gambling machine!\nThere are three games in my machine that require tokens to play.\nFor $1 you can buy 4 tokens.\nCost: 1 token     Game 1: Even or Odd\nCost: 2 tokens    Game 2: Rock, Paper, Scissors, Lizard, Spock\nCost: 3 tokens    Game 3: Blackjack Dice Edition\n");
                        Console.WriteLine($"Current tokens: {tokens}\n");
                        if (tokens == 0)
                        {
                            for (int i = 0; i < 1;)
                            {
                                Console.Write("Please enter your payment by hitting (1) or any other letter key to exit: ");
                                dollar = Convert.ToInt32(dollarString = Console.ReadLine());

                                Random numTokens = new Random();
                                tokens = numTokens.Next(4, 7);
                                if (dollar == 1 && tokens > 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Congratulations, you received 4 tokens plus an extra {tokens - 4} token(s)!");
                                    i++;
                                }
                                else if (dollar == 1 && tokens == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine("You received 4 tokens.");
                                    i++;
                                }
                                else
                                {
                                    Console.WriteLine("That wasn't an option. Hit any key to try again.");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                        }

                        Console.WriteLine($"");
                        Console.Write("Please select either Game 1: (E), Game 2: (R) or Game 3: (B): ");
                        game = Console.ReadLine();
                        switch (game)
                        {
                            case "E":
                                for (int i = 0; i < 1;)
                                {
                                    Console.Clear();
                                    {
                                        for (int h = 0; h < 1;)
                                        {
                                            tokens -= 1;

                                            string num = "";
                                            string ynAnswer = "";
                                            int number;
                                            int remainder;
                                            int isAFactor = 0;
                                            int even = 0;
                                            int odd = 0;
                                            int calculation = 0;

                                            while (true)
                                            {
                                                try
                                                {
                                                    Console.WriteLine("Welcome to my 'Even or Odd' game!\nTo play all you have to do is enter a number and the game will tell you how many even and odd factors it has");
                                                    Console.Write("Please enter your number here: ");
                                                    num = Console.ReadLine();
                                                    number = Convert.ToInt32(num);
                                                    Console.Clear();
                                                }
                                                catch (OverflowException)
                                                {
                                                    Console.WriteLine("That number was either too high or too low. Hit any key to try again.");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    continue;
                                                }
                                                catch (Exception)
                                                {
                                                    Console.WriteLine("That wasn't an option. Hit any key to try again.");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    continue;
                                                }

                                                for (int d = 1; d <= number; d++)
                                                {
                                                    remainder = number % d;
                                                    if (remainder == 0)
                                                    {
                                                        isAFactor = d;
                                                        calculation = isAFactor % 2;
                                                        if (calculation == 0)
                                                        {
                                                            even++;
                                                        }
                                                        else if (calculation == 1)
                                                        {
                                                            odd++;
                                                        }
                                                        else
                                                        {
                                                            continue;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        continue;
                                                    }
                                                }
                                                Console.WriteLine($"Your number was {number}\nThere are {even} even factors\nThere are {odd} odd factors\n");
                                                try
                                                {
                                                    for (int d = 0; d < 1;)
                                                    {
                                                        Console.Write("Would you like to play again?\n(Y)es or (N)o: ");
                                                        even = 0;
                                                        odd = 0;
                                                        ynAnswer = Console.ReadLine();
                                                        switch (ynAnswer)
                                                        {
                                                            case "Y":
                                                                if (tokens >= 1)
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine($"You still have {tokens - 1} token(s) left.\nHit any key to continue.");
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    d++;
                                                                    break;
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Sorry you don't have enough tokens to continue playing.\nHit any key to exit to the main menu.");
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    d++;
                                                                    h++;
                                                                    i++;
                                                                    break;
                                                                }
                                                            case "N":
                                                                Console.Clear();
                                                                Console.WriteLine($"You still have {tokens} token(s) left.\nHit any key to continue.");
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                i++;
                                                                d++;
                                                                h++;
                                                                break;
                                                            default:
                                                                Console.WriteLine("That wasn't an option. Hit any key to try again.");
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                }
                                                catch (Exception)
                                                {
                                                    Console.WriteLine("That wasn't an option. Hit any key to try again.");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    continue;
                                                }
                                            }
                                        }
                                        break;
                                    }
                                }
                                break;
                            case "R":
                                for (int i = 0; i < 1;)
                                {
                                    if (tokens >= 2)
                                    {
                                        {
                                            for (int z = 0; z < 1;)
                                            {
                                                tokens -= 2;

                                                Random number = new Random();
                                                string userInput;
                                                string compPlays = "";
                                                string userOutput = "";
                                                string answer = "";
                                                int compWins = 0;
                                                int userWins = 0;
                                                int draws = 0;
                                                int numRounds = 0;

                                                for (int y = 0; y < 1;)
                                                {
                                                    try
                                                    {
                                                        Console.Clear();
                                                        Console.Write("How Many rounds will determine the winner? (1, 3 or 5): ");
                                                        numRounds = Convert.ToInt32(Console.ReadLine());
                                                        switch (numRounds)
                                                        {
                                                            case 1:
                                                                y++;
                                                                break;
                                                            case 3:
                                                                y++;
                                                                break;
                                                            case 5:
                                                                y++;
                                                                break;
                                                            default:
                                                                Console.WriteLine("That's not an option buddy, press any key to try again.");
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                        }
                                                    }
                                                    catch (OverflowException)
                                                    {
                                                        Console.WriteLine("That number was either too high or too low. Hit any key to try again.");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        continue;
                                                    }
                                                    catch (FormatException)
                                                    {
                                                        Console.WriteLine("That's not an option buddy, press any key to try again.");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        continue;
                                                    }
                                                    catch (Exception)
                                                    {
                                                        Console.WriteLine("That's not an option buddy, press any key to try again.");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        continue;
                                                    }
                                                }
                                                for (int s = 0; s < 1;)
                                                {
                                                    while (true)
                                                    {
                                                        int compChoice = number.Next(1, 6);

                                                        Console.Write("Please enter either (R)ock, (P)aper, (S)cissors, (L)izard, or (SP)ock to play or any other key to quit: ");
                                                        userInput = Console.ReadLine();
                                                        Console.Write('\n');

                                                        //determines what the computer throws
                                                        if (compChoice == 1)
                                                        {
                                                            compPlays = "rock";
                                                        }
                                                        else if (compChoice == 2)
                                                        {
                                                            compPlays = "paper";
                                                        }
                                                        else if (compChoice == 3)
                                                        {
                                                            compPlays = "scissors";
                                                        }
                                                        else if (compChoice == 4)
                                                        {
                                                            compPlays = "lizard";
                                                        }
                                                        else if (compChoice == 5)
                                                        {
                                                            compPlays = "spock";
                                                        }

                                                        //expands the users input
                                                        if (userInput == "R")
                                                        {
                                                            userOutput = "rock";
                                                        }
                                                        else if (userInput == "P")
                                                        {
                                                            userOutput = "paper";
                                                        }
                                                        else if (userInput == "S")
                                                        {
                                                            userOutput = "scissors";
                                                        }
                                                        else if (userInput == "L")
                                                        {
                                                            userOutput = "lizard";
                                                        }
                                                        else if (userInput == "SP")
                                                        {
                                                            userOutput = "spock";
                                                        }
                                                        //exits the game if anything except r, p, s, l or sp are typed in
                                                        else
                                                        {
                                                            Console.WriteLine("Thanks for playing!");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                            s++;
                                                            z++;
                                                            break;
                                                        }
                                                        //prints if game results in a draw
                                                        if (compPlays == userOutput)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine($"How boring...\nThe computer chose {compPlays}.\nYou chose {userOutput}.\nWhich resulted in a draw...duh\n");
                                                            draws++;
                                                            Console.WriteLine($"Computer wins: {compWins}\nUser wins: {userWins}\nDraws: {draws}\n");
                                                        }
                                                        //prints if computer wins game
                                                        else if (compPlays == "rock" && userOutput == "scissors" || compPlays == "rock" && userOutput == "lizard" || compPlays == "paper" && userOutput == "rock" || compPlays == "paper" && userOutput == "spock" || compPlays == "scissors" && userOutput == "paper" || compPlays == "scissors" && userOutput == "lizard" || compPlays == "spock" && userOutput == "scissors" || compPlays == "spock" && userOutput == "rock" || compPlays == "lizard" && userOutput == "spock" || compPlays == "lizard" && userOutput == "paper")
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine($"Wow, you suck!\nThe computer chose {compPlays} which of course beats {userOutput}!\n");
                                                            compWins++;
                                                            if (numRounds == 1)
                                                            {
                                                                Console.WriteLine($"Computer wins: {compWins}\nUser wins: {userWins}\nDraws: {draws}\n");
                                                                Console.WriteLine("The Computer Wins it all!");
                                                                for (int x = 0; x < 1;)
                                                                {
                                                                    Console.Write("Would you like to play again? (Y)es or (N)o: ");
                                                                    answer = Console.ReadLine();

                                                                    switch (answer)
                                                                    {
                                                                        case "Y":
                                                                            if (tokens >= 2)
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine($"You still have {tokens - 2} token(s) left.\nHit any key to continue.");
                                                                                Console.ReadKey();
                                                                                Console.Clear();
                                                                                x++;
                                                                                s++;
                                                                                break;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("Sorry you don't have enough tokens to continue playing.\nHit any key to exit to the main menu.");
                                                                                Console.ReadKey();
                                                                                Console.Clear();
                                                                                i++;
                                                                                z++;
                                                                                x++;
                                                                                s++;
                                                                                break;
                                                                            }
                                                                        case "N":
                                                                            Console.Clear();
                                                                            Console.WriteLine($"You still have {tokens} token(s) left.\nHit any key to continue.");
                                                                            Console.ReadKey();
                                                                            Console.Clear();
                                                                            i++;
                                                                            z++;
                                                                            x++;
                                                                            s++;
                                                                            break;
                                                                        default:
                                                                            Console.Write("That wasn't a choice, hit any key to try again.");
                                                                            Console.ReadKey();
                                                                            Console.Clear();
                                                                            break;
                                                                    }
                                                                }
                                                            }
                                                            else if (numRounds == 3 && compWins == 2)
                                                            {
                                                                Console.WriteLine($"Computer wins: {compWins}\nUser wins: {userWins}\nDraws: {draws}\n");
                                                                Console.WriteLine("The Computer Wins it all!");
                                                                for (int x = 0; x < 1;)
                                                                {
                                                                    Console.Write("Would you like to play again? (Y)es or (N)o: ");
                                                                    answer = Console.ReadLine();

                                                                    switch (answer)
                                                                    {
                                                                        case "Y":
                                                                            if (tokens >= 2)
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine($"You still have {tokens - 2} token(s) left.\nHit any key to continue.");
                                                                                Console.ReadKey();
                                                                                Console.Clear();
                                                                                x++;
                                                                                s++;
                                                                                break;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("Sorry you don't have enough tokens to continue playing.\nHit any key to exit to the main menu.");
                                                                                Console.ReadKey();
                                                                                Console.Clear();
                                                                                i++;
                                                                                z++;
                                                                                x++;
                                                                                s++;
                                                                                break;
                                                                            }
                                                                        case "N":
                                                                            Console.Clear();
                                                                            Console.WriteLine($"You still have {tokens} token(s) left.\nHit any key to continue.");
                                                                            Console.ReadKey();
                                                                            Console.Clear();
                                                                            i++;
                                                                            z++;
                                                                            x++;
                                                                            s++;
                                                                            break;
                                                                        default:
                                                                            Console.Write("That wasn't a choice, hit any key to try again.");
                                                                            Console.ReadKey();
                                                                            Console.Clear();
                                                                            break;
                                                                    }
                                                                }
                                                            }
                                                            else if (numRounds == 5 && compWins == 3)
                                                            {
                                                                Console.WriteLine($"Computer wins: {compWins}\nUser wins: {userWins}\nDraws: {draws}\n");
                                                                Console.WriteLine("The Computer Wins it all!");
                                                                for (int x = 0; x < 1;)
                                                                {
                                                                    Console.Write("Would you like to play again? (Y)es or (N)o: ");
                                                                    answer = Console.ReadLine();

                                                                    switch (answer)
                                                                    {
                                                                        case "Y":
                                                                            if (tokens >= 2)
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine($"You still have {tokens - 2} token(s) left.\nHit any key to continue.");
                                                                                Console.ReadKey();
                                                                                Console.Clear();
                                                                                x++;
                                                                                s++;
                                                                                break;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("Sorry you don't have enough tokens to continue playing.\nHit any key to exit to the main menu.");
                                                                                Console.ReadKey();
                                                                                Console.Clear();
                                                                                i++;
                                                                                z++;
                                                                                x++;
                                                                                s++;
                                                                                break;
                                                                            }
                                                                        case "N":
                                                                            Console.Clear();
                                                                            Console.WriteLine($"You still have {tokens} token(s) left.\nHit any key to continue.");
                                                                            Console.ReadKey();
                                                                            Console.Clear();
                                                                            i++;
                                                                            z++;
                                                                            x++;
                                                                            s++;
                                                                            break;
                                                                        default:
                                                                            Console.Write("That wasn't a choice, hit any key to try again.");
                                                                            Console.ReadKey();
                                                                            Console.Clear();
                                                                            break;
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"Computer wins: {compWins}\nUser wins: {userWins}\nDraws: {draws}\n");
                                                            }
                                                            Console.WriteLine();
                                                            break;
                                                        }
                                                        //prints if user wins game
                                                        else if (compPlays == "rock" && userOutput == "paper" || compPlays == "rock" && userOutput == "spock" || compPlays == "paper" && userOutput == "scissors" || compPlays == "paper" && userOutput == "lizard" || compPlays == "scissors" && userOutput == "spock" || compPlays == "scissors" && userOutput == "rock" || compPlays == "spock" && userOutput == "paper" || compPlays == "spock" && userOutput == "lizard" || compPlays == "lizard" && userOutput == "rock" || compPlays == "lizard" && userOutput == "scissors")
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine($"Zoinks Scoob! You actually managed to be a super simple computer program at a childrens game!\nI mean it was so obvious that you had to play {userOutput} to beat the computers {compPlays}.\nYour mother must be so proud of you!\n");
                                                            userWins++;
                                                            if (numRounds == 1)
                                                            {
                                                                Console.WriteLine($"Computer wins: {compWins}\nUser wins: {userWins}\nDraws: {draws}\n");
                                                                Console.WriteLine("You won it all!\n");
                                                                for (int x = 0; x < 1;)
                                                                {
                                                                    Console.Write("Would you like to play again? (Y)es or (N)o: ");
                                                                    answer = Console.ReadLine();

                                                                    switch (answer)
                                                                    {
                                                                        case "Y":
                                                                            if (tokens >= 2)
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine($"You still have {tokens - 2} token(s) left.\nHit any key to continue.");
                                                                                Console.ReadKey();
                                                                                Console.Clear();
                                                                                x++;
                                                                                s++;
                                                                                break;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("Sorry you don't have enough tokens to continue playing.\nHit any key to exit to the main menu.");
                                                                                Console.ReadKey();
                                                                                Console.Clear();
                                                                                i++;
                                                                                z++;
                                                                                x++;
                                                                                s++;
                                                                                break;
                                                                            }
                                                                        case "N":
                                                                            Console.Clear();
                                                                            Console.WriteLine($"You still have {tokens} token(s) left.\nHit any key to continue.");
                                                                            Console.ReadKey();
                                                                            Console.Clear();
                                                                            i++;
                                                                            z++;
                                                                            x++;
                                                                            s++;
                                                                            break;
                                                                        default:
                                                                            Console.Write("That wasn't a choice, hit any key to try again.");
                                                                            Console.ReadKey();
                                                                            Console.Clear();
                                                                            break;
                                                                    }
                                                                }
                                                            }
                                                            else if (numRounds == 3 && userWins == 2)
                                                            {
                                                                Console.WriteLine($"Computer wins: {compWins}\nUser wins: {userWins}\nDraws: {draws}\n");
                                                                Console.WriteLine("You won it all!");
                                                                for (int x = 0; x < 1;)
                                                                {
                                                                    Console.Write("Would you like to play again? (Y)es or (N)o: ");
                                                                    answer = Console.ReadLine();

                                                                    switch (answer)
                                                                    {
                                                                        case "Y":
                                                                            if (tokens >= 2)
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine($"You still have {tokens - 2} token(s) left.\nHit any key to continue.");
                                                                                Console.ReadKey();
                                                                                Console.Clear();
                                                                                x++;
                                                                                s++;
                                                                                break;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("Sorry you don't have enough tokens to continue playing.\nHit any key to exit to the main menu.");
                                                                                Console.ReadKey();
                                                                                Console.Clear();
                                                                                i++;
                                                                                z++;
                                                                                x++;
                                                                                s++;
                                                                                break;
                                                                            }
                                                                        case "N":
                                                                            Console.Clear();
                                                                            Console.WriteLine($"You still have {tokens} token(s) left.\nHit any key to continue.");
                                                                            Console.ReadKey();
                                                                            Console.Clear();
                                                                            i++;
                                                                            z++;
                                                                            x++;
                                                                            s++;
                                                                            break;
                                                                        default:
                                                                            Console.Write("That wasn't a choice, hit any key to try again.");
                                                                            Console.ReadKey();
                                                                            Console.Clear();
                                                                            break;
                                                                    }
                                                                }
                                                            }
                                                            else if (numRounds == 5 && userWins == 3)
                                                            {
                                                                Console.WriteLine($"Computer wins: {compWins}\nUser wins: {userWins}\nDraws: {draws}\n");
                                                                Console.WriteLine("You won it all!");
                                                                for (int x = 0; x < 1;)
                                                                {
                                                                    Console.Write("Would you like to play again? (Y)es or (N)o: ");
                                                                    answer = Console.ReadLine();

                                                                    switch (answer)
                                                                    {
                                                                        case "Y":
                                                                            if (tokens >= 2)
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine($"You still have {tokens - 2} token(s) left.\nHit any key to continue.");
                                                                                Console.ReadKey();
                                                                                Console.Clear();
                                                                                x++;
                                                                                s++;
                                                                                break;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("Sorry you don't have enough tokens to continue playing.\nHit any key to exit to the main menu.");
                                                                                Console.ReadKey();
                                                                                Console.Clear();
                                                                                i++;
                                                                                z++;
                                                                                x++;
                                                                                s++;
                                                                                break;
                                                                            }
                                                                        case "N":
                                                                            Console.Clear();
                                                                            Console.WriteLine($"You still have {tokens} token(s) left.\nHit any key to continue.");
                                                                            Console.ReadKey();
                                                                            Console.Clear();
                                                                            i++;
                                                                            z++;
                                                                            x++;
                                                                            s++;
                                                                            break;
                                                                        default:
                                                                            Console.Write("That wasn't a choice, hit any key to try again.");
                                                                            Console.ReadKey();
                                                                            Console.Clear();
                                                                            break;
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"Computer wins: {compWins}\nUser wins: {userWins}\nDraws: {draws}\n");
                                                            }
                                                            Console.WriteLine();
                                                            break;
                                                        }
                                                    }
                                                }
                                            }
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Sorry you don't have enough tokens to continue playing.\nHit any key to exit to the main menu.");
                                        Console.ReadKey();
                                        Console.Clear();
                                        i++;
                                    }
                                }
                                break;
                            case "B":
                                for (int i = 0; i < 1;)
                                {
                                    if (tokens >= 3)
                                    {
                                        {
                                            for (int e = 0; e < 1;)
                                            {
                                                tokens -= 3;
                                                Random dice = new Random();
                                                string x = "";
                                                string ynAnswer = "";
                                                string ynAnswer3 = "";
                                                int d1 = dice.Next(1, 7);
                                                int d2 = dice.Next(1, 7);
                                                int total = d1 + d2;

                                                int compd1 = dice.Next(1, 7);
                                                int compd2 = dice.Next(1, 7);
                                                int compTotal = compd1 + compd2;

                                                while (true)
                                                {
                                                    try
                                                    {
                                                        Console.Clear();
                                                        Console.Write("Welcome to my game of blackjack but with dice!\nInstead of drawing cards you will roll dice\nTo start hit 'X': ");
                                                        x = Console.ReadLine();
                                                        Console.Clear();
                                                        switch (x)
                                                        {
                                                            case "X":
                                                                for (int s = 0; s < 1;)
                                                                {
                                                                    Console.WriteLine($"You rolled [{d1}][{d2}]\nTotal = {total}");
                                                                    Console.Write("Would you like to roll again?\n(Y)es or (N)o: ");
                                                                    ynAnswer = Console.ReadLine();
                                                                    switch (ynAnswer)
                                                                    {
                                                                        case "Y":
                                                                            if (total < 21)
                                                                            {
                                                                                d1 = dice.Next(1, 7);
                                                                                d2 = dice.Next(1, 7);
                                                                                total += d1 + d2;
                                                                                Console.Clear();
                                                                                if (total > 21)
                                                                                {
                                                                                    Console.WriteLine("You rolled over 21. You Lose!\n");
                                                                                    Console.Write("Would you like to play again?\n(Y)es or (N)o: ");
                                                                                    ynAnswer3 = Console.ReadLine();
                                                                                    switch (ynAnswer3)
                                                                                    {
                                                                                        case "Y":
                                                                                            if (tokens >= 3)
                                                                                            {
                                                                                                Console.Clear();
                                                                                                Console.WriteLine($"You still have {tokens - 3} token(s) left.\nHit any key to continue.");
                                                                                                Console.ReadKey();
                                                                                                Console.Clear();
                                                                                                d1 = 0;
                                                                                                d2 = 0;
                                                                                                total = 0;
                                                                                                compd1 = 0;
                                                                                                compd2 = 0;
                                                                                                compTotal = 0;
                                                                                                s++;
                                                                                                i++;
                                                                                                break;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Console.Clear();
                                                                                                Console.WriteLine("Sorry you don't have enough tokens to continue playing.\nHit any key to exit to the main menu.");
                                                                                                Console.ReadKey();
                                                                                                Console.Clear();
                                                                                                i++;
                                                                                                s++;
                                                                                                e++;
                                                                                                break;
                                                                                            }
                                                                                        case "N":
                                                                                            Console.Clear();
                                                                                            Console.WriteLine($"You still have {tokens} token(s) left.\nHit any key to continue.");
                                                                                            Console.ReadKey();
                                                                                            Console.Clear();
                                                                                            i++;
                                                                                            s++;
                                                                                            e++;
                                                                                            break;
                                                                                        default:

                                                                                            Console.WriteLine("That wasn't an option. Hit any key to try again.");
                                                                                            Console.ReadKey();
                                                                                            Console.Clear();
                                                                                            continue;
                                                                                    }
                                                                                    break;
                                                                                }
                                                                                else if (total == 21)
                                                                                {
                                                                                    Console.WriteLine("Congratulations, you got a perfect 21!");
                                                                                    Console.Write("Would you like to play again?\n(Y)es or (N)o: ");
                                                                                    ynAnswer3 = Console.ReadLine();
                                                                                    switch (ynAnswer3)
                                                                                    {
                                                                                        case "Y":
                                                                                            if (tokens >= 3)
                                                                                            {
                                                                                                Console.Clear();
                                                                                                Console.WriteLine($"You still have {tokens - 3} token(s) left.\nHit any key to continue.");
                                                                                                Console.ReadKey();
                                                                                                Console.Clear();
                                                                                                d1 = 0;
                                                                                                d2 = 0;
                                                                                                total = 0;
                                                                                                compd1 = 0;
                                                                                                compd2 = 0;
                                                                                                compTotal = 0;
                                                                                                s++;
                                                                                                break;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Console.Clear();
                                                                                                Console.WriteLine("Sorry you don't have enough tokens to continue playing.\nHit any key to exit to the main menu.");
                                                                                                Console.ReadKey();
                                                                                                Console.Clear();
                                                                                                i++;
                                                                                                s++;
                                                                                                e++;
                                                                                                break;
                                                                                            }
                                                                                        case "N":
                                                                                            Console.Clear();
                                                                                            Console.WriteLine($"You still have {tokens} token(s) left.\nHit any key to continue.");
                                                                                            Console.ReadKey();
                                                                                            Console.Clear();
                                                                                            i++;
                                                                                            s++;
                                                                                            e++;
                                                                                            break;
                                                                                        default:
                                                                                            Console.WriteLine("That wasn't an option. Hit any key to try again.");
                                                                                            Console.ReadKey();
                                                                                            Console.Clear();
                                                                                            continue;
                                                                                    }
                                                                                }
                                                                            }
                                                                            break;
                                                                        case "N":
                                                                            if (compTotal <= total)
                                                                            {
                                                                                while (compTotal <= total)
                                                                                {
                                                                                    compd1 = dice.Next(1, 7);
                                                                                    compd2 = dice.Next(1, 7);
                                                                                    compTotal += d1 + d2;
                                                                                    Console.Clear();
                                                                                }
                                                                                if (compTotal > total && compTotal < 21 && compTotal != 21)
                                                                                {
                                                                                    Console.WriteLine($"The computer beat you with {compTotal} compared to your {total}!\n");
                                                                                    Console.Write("Would you like to play again?\n(Y)es or (N)o: ");
                                                                                    ynAnswer3 = Console.ReadLine();
                                                                                    switch (ynAnswer3)
                                                                                    {
                                                                                        case "Y":
                                                                                            if (tokens >= 3)
                                                                                            {
                                                                                                Console.Clear();
                                                                                                Console.WriteLine($"You still have {tokens - 3} token(s) left.\nHit any key to continue.");
                                                                                                Console.ReadKey();
                                                                                                Console.Clear();
                                                                                                d1 = 0;
                                                                                                d2 = 0;
                                                                                                total = 0;
                                                                                                compd1 = 0;
                                                                                                compd2 = 0;
                                                                                                compTotal = 0;
                                                                                                s++;
                                                                                                break;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Console.Clear();
                                                                                                Console.WriteLine("Sorry you don't have enough tokens to continue playing.\nHit any key to exit to the main menu.");
                                                                                                Console.ReadKey();
                                                                                                Console.Clear();
                                                                                                i++;
                                                                                                s++;
                                                                                                e++;
                                                                                                break;
                                                                                            }
                                                                                        case "N":
                                                                                            Console.Clear();
                                                                                            Console.WriteLine($"You still have {tokens} token(s) left.\nHit any key to continue.");
                                                                                            Console.ReadKey();
                                                                                            Console.Clear();
                                                                                            i++;
                                                                                            s++;
                                                                                            e++;
                                                                                            break;
                                                                                        default:
                                                                                            Console.WriteLine("That wasn't an option. Hit any key to try again.");
                                                                                            Console.ReadKey();
                                                                                            Console.Clear();
                                                                                            continue;
                                                                                    }
                                                                                }
                                                                                else if (compTotal >= 21)
                                                                                {
                                                                                    Console.WriteLine("The computer rolled over 21 and lost!\n");
                                                                                    Console.Write("Would you like to play again?\n(Y)es or (N)o: ");
                                                                                    ynAnswer3 = Console.ReadLine();
                                                                                    switch (ynAnswer3)
                                                                                    {
                                                                                        case "Y":
                                                                                            if (tokens >= 3)
                                                                                            {
                                                                                                Console.Clear();
                                                                                                Console.WriteLine($"You still have {tokens - 3} token(s) left.\nHit any key to continue.");
                                                                                                Console.ReadKey();
                                                                                                Console.Clear();
                                                                                                d1 = 0;
                                                                                                d2 = 0;
                                                                                                total = 0;
                                                                                                compd1 = 0;
                                                                                                compd2 = 0;
                                                                                                compTotal = 0;
                                                                                                s++;
                                                                                                break;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Console.Clear();
                                                                                                Console.WriteLine("Sorry you don't have enough tokens to continue playing.\nHit any key to exit to the main menu.");
                                                                                                Console.ReadKey();
                                                                                                Console.Clear();
                                                                                                i++;
                                                                                                s++;
                                                                                                e++;
                                                                                                break;
                                                                                            }
                                                                                        case "N":
                                                                                            Console.Clear();
                                                                                            Console.WriteLine($"You still have {tokens} token(s) left.\nHit any key to continue.");
                                                                                            Console.ReadKey();
                                                                                            Console.Clear();
                                                                                            i++;
                                                                                            s++;
                                                                                            e++;
                                                                                            break;
                                                                                        default:
                                                                                            Console.WriteLine("That wasn't an option. Hit any key to try again.");
                                                                                            Console.ReadKey();
                                                                                            Console.Clear();
                                                                                            continue;
                                                                                    }
                                                                                }
                                                                            }
                                                                            break;
                                                                        default:
                                                                            Console.WriteLine("That wasn't an option. Hit any key to try again.");
                                                                            Console.ReadKey();
                                                                            Console.Clear();
                                                                            total = 20;
                                                                            continue;
                                                                    }
                                                                }
                                                                break;
                                                            default:
                                                                Console.WriteLine("That wasn't an option. Hit any key to try again.");
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                continue;
                                                        }
                                                        break;
                                                    }
                                                    catch (Exception)
                                                    {
                                                        Console.WriteLine("That wasn't an option. Hit any key to try again.");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("That wasn't an option. Hit any key to try again.");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Thank you for playing!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("That wasn't an option. Hit any key to try again.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                break;
            }
        }
    }
}