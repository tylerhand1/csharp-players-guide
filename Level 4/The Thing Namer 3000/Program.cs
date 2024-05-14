Console.WriteLine("What kind of thing are we talking about?");
string? a = Console.ReadLine(); // a is the name of the thing
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string? b = Console.ReadLine(); // b is the description of the thing
/*
 * c and d are string literals
 */
string c = "Doom";
string d = "3000";
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");