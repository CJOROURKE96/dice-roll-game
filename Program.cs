Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

Console.WriteLine(roll1);
Console.WriteLine(roll2);
Console.WriteLine(roll3);

if ((roll1 == roll2)|| (roll2 == roll3) || (roll1 == roll3)) {
if ((roll1 == roll2) && (roll2 == roll3)) {
    Console.WriteLine("You rolled triples!");
} else
    {
    Console.WriteLine("You rolled doubles!");
}
}
