int random1 = 0;
int random2 = 0;
int random3 = 0;
int random4 = 0;
int random5 = 0;

bool dice1 = false;
bool dice2 = false;
bool dice3 = false;
bool dice4 = false;
bool dice5 = false;



int fix1;
int fix2;
int fix3;
int fix4;
int fix5;
int j = 0;

Console.WriteLine("Press any key to roll the dices!");
Console.ReadKey();
for (int i = 0; i < 3 && j == 0; i++)
{
    RollDice();
    PrintDice();
    FixDice();
    if (dice1 == true && dice2 == true && dice3 == true && dice4 == true && dice5 == true)
    {
        j++;
    }
}

void RollDice()
{
    if (dice1 == false)
    {
        random1 = Random.Shared.Next(1, 7);
    }
    if (dice2 == false)
    {
        random2 = Random.Shared.Next(1, 7);
    }
    if (dice3 == false)
    {
        random3 = Random.Shared.Next(1, 7);
    }
    if (dice4 == false)
    {
        random4 = Random.Shared.Next(1, 7);
    }
    if (dice5 == false)
    {
        random5 = Random.Shared.Next(1, 7);
    }
}
void PrintDice()
{
    System.Console.WriteLine("=====================");
    Console.WriteLine(random1);
    Console.WriteLine(random2);
    Console.WriteLine(random3);
    Console.WriteLine(random4);
    Console.WriteLine(random5);
    System.Console.WriteLine("=====================");
}

Console.WriteLine();
void FixDice()
{
    Console.WriteLine("Do want to fix dice 1?");
    fix1 = int.Parse(Console.ReadLine()!);
    if (fix1 == 1)
    {
        dice1 = true;
    }
    Console.WriteLine("Do want to fix dice 2?");
    fix2 = int.Parse(Console.ReadLine()!);
    if (fix2 == 1)
    {
        dice2 = true;
    }
    Console.WriteLine("Do want to fix dice 3?");
    fix3 = int.Parse(Console.ReadLine()!);
    if (fix3 == 1)
    {
        dice3 = true;
    }
    Console.WriteLine("Do want to fix dice 4?");
    fix4 = int.Parse(Console.ReadLine()!);
    if (fix4 == 1)
    {
        dice4 = true;
    }
    Console.WriteLine("Do want to fix dice 5?");
    fix5 = int.Parse(Console.ReadLine()!);
    if (fix5 == 1)

        dice5 = true;
}
    