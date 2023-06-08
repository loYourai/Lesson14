// See https://aka.ms/new-console-template for more information
using Lesson14;
using System;

//var struct1 = new Point(10, 12,13);
//var struct2 = new Point(12, 10, 0);

//var struct3 = struct1 + struct2;


Stack<string> numbers = new Stack<string>();
numbers.Push("one");
numbers.Push("two");
numbers.Push("three");
numbers.Push("four");
numbers.Push("five");

string[] arr = numbers.ToArray();


foreach (string number in numbers)
{
    Console.WriteLine(number);
}
Console.WriteLine(numbers.Pop());
Console.WriteLine(numbers.Count());
Console.WriteLine(numbers.Peek());
//Console.WriteLine(numbers.CopyTo(arr));
numbers.Clear();

var user = new User
{
    Name = "Test",
    Password = "qwerty"
};

//string test = "sdads";
//int i = (int)test;

/*
int i = 100;
long l = i;

int intFromLong = (int)l;

object intObj = (object)l;
int intFromObj = (int)intObj;

object longObj = (object)i;
int intFromLongObj = (int)longObj;
*/


/*
var userType  = user.GetType();
object userObject = (object)user;
var userObjectType = user.GetType();

//var userFromObject = (User)userObject;
//var name = userFromObject.Name;
userObject = (object)1200;
if (userObject is int)
{
    CancellationTokenRegistration itFromObject = (int)userObject;
}

if (userObject is User)
{
    var userFromObject = (User)userObject;
}
*/
Console.ReadLine();


