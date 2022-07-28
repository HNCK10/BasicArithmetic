// See https://aka.ms/new-console-template for more information
int friends = 5;
//Incrementing a variable
//This is the normal way but there is a shorcut
//friends = friends + 1;
//Here is the shortcut
//friends += 1;
//There is a third way to increment which
//is used in loops, and adds 1
//friends++;
//------------------------------------------
//Decrementing a variable
//friends = friends - 1;
//friends -= 1;
//friends--;
//-------------------------------------------
//Multiplication
//friends = friends * 2;
//friends *= 2;
//-------------------------------------------
//Division
//since friends is an int, it will not return the decimal
//friends = friends / 2;
//friends /= 2;
//If you make friends a double instead it will return the decimal
//double friend = 5;
//friend /= 2;
//----------------------------------------------------------------
//Modulus option or also known as the remainder operator
int remainder = friends % 3;
//The result will be a remainder of 2
//If it was 10%2 the remainder will be 0 since it can fit in equally
int remain = 10 % 2;
Console.WriteLine(remainder);
Console.WriteLine(remain);
Console.ReadKey();
