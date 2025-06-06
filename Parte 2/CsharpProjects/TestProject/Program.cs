// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, C#!");

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);


int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);*/

Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"{roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}
if (total >= 15)
{
    Console.WriteLine("You Win");
}
else
{
    Console.WriteLine("You Lose");
}

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

string message = "";

if (daysUntilExpiration <= 10)
{
    if (daysUntilExpiration <= 5)
    {
        if (daysUntilExpiration == 1)
        {
            message = "Your subscription expires within a day!";
            discountPercentage = 20;
        }
        else if (daysUntilExpiration == 0)
        {
            message = "Your subscription has expired.";
        }
        else
        {
            message = $"Your subscription expires in {daysUntilExpiration} days";
            discountPercentage = 10;
        }
    }
    else
    {
        message = "Your subscription will expire soon. Renew now!";
    }
}
string finalMsg;
if (discountPercentage != 0)
{
    message += $"\n\tRenew now and save {discountPercentage}%!";
}
Console.WriteLine(message);

/****************************************************************************************************************************************************************/
/*ARRAYS*/

string[] arrayStr = new string[3];

arrayStr[0] = "A123";
arrayStr[1] = "B456";
arrayStr[2] = "C789";

foreach (string name in arrayStr)
{
    Console.WriteLine(name);
}

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");

string[] codigos ={
    "B123",
"C234",
"A345",
"C15",
"B177",
"G3003",
"C235",
"B179"
};
foreach (string codigo in codigos)
{
    if (codigo.StartsWith("B")){
        Console.WriteLine(codigo);
    }
}