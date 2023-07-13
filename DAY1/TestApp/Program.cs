// See https://aka.ms/new-console-template for more information
using PRSN;
using STD;
Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome G20 deligates");

Console.WriteLine("Enter number..");
 int  n=Convert.ToInt32(Console.ReadLine());
int fact=1;
for(int i=1;i<=n;i++){
    fact=fact*i;
}
Console.WriteLine(fact);
 
Person p1=new Person(18,"Virat","viratkohli12@gmail.com","Delhi",new DateTime(1987,12,21));
Console.WriteLine(p1);
Student s1=new Student(18,"Virat","viratkohli12@gmail.com","Delhi",new DateTime(1987,12,21),"Cricket",new DateTime(1997,12,21));
Console.WriteLine(s1);
Console.WriteLine("Hello, World! this is .net");
Console.WriteLine("Welcome G20 deligates");