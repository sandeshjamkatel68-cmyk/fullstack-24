using System.Security.Cryptography.X509Certificates;

int quantity = 3;
decimal price = 249.99m; // the m suffix makes it decimal
double distanceKm = 200.5;
bool inStock = true;
string product = "Dhaka Topi";
var total = quantity * price; //var: the compiler works out the type (decimal)


Console.WriteLine(quantity);
Console.WriteLine(price);
Console.WriteLine(distanceKm);
Console.WriteLine(inStock);
Console.WriteLine(product);
Console.WriteLine(total);



const decimal VarRate = 0.13m; //fixed at compile , never change

Console.WriteLine(VarRate);

// value types vs references types

Console.WriteLine(0.1+0.2);
Console.WriteLine(0.1m+0.2m);


int big = int.MaxValue;

Console.WriteLine(big);
Console.WriteLine(big+1);

//Strings are immutable
string city = "pokhara";
city.ToUpper(); //result thrown away
Console.WriteLine(city); //pokhara
city = city.ToUpper();
Console.WriteLine(city);


//Nullable references types
// string name  = "ram";
// string? nickname = null; // the ? says "may be null"

// Console.WriteLine(nickname.Length);
// Console.WriteLine(nic)