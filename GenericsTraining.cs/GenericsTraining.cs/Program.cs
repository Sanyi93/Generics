// See https://aka.ms/new-console-template for more information
using GenericsTraining.cs;


Generic gen = new Generic();

int x = 10;
int y = 33;
gen.Swap(ref x, ref y);

string txt1 = "abc";
string txt2 = "xyz";
gen.Swap(ref txt1, ref txt2);

//creating a generic instance of typ int of class GenericClass
//GenericClass<int> genericInt = new GenericClass<int>();
//GenericClass<double> genericDouble = new GenericClass<double>();

//genericInt.Push(99);
//genericInt.Push(80);
//genericInt.Push(100);
//int popInt = genericInt.Pop();
//Console.WriteLine(popInt.ToString());

//genericDouble.Push(101.05);
//genericDouble.Push(102.05);
//genericDouble.Push(103.05);
//double popDouble = genericDouble.Pop();
//Console.WriteLine(popDouble.ToString());

//creating a generic instance of a int typ of class NewGenericClass

NewGenericClass<int> newGenericInt = new NewGenericClass<int>();
NewGenericClass<string> newGenericString = new NewGenericClass<string>();

newGenericInt.PushIt(77);
newGenericInt.PushIt(74);
newGenericInt.PushIt(108);
newGenericInt.PushIt(111);

newGenericString.PushIt("Labubu");
newGenericString.PushIt("Hey");
newGenericString.PushIt("Way");
newGenericString.PushIt("CLK");

Console.WriteLine("----");
string poppedString = newGenericString.PopIt();
Console.WriteLine(poppedString.ToString());
int poppedInt = newGenericInt.PopIt();
Console.WriteLine(poppedInt.ToString());



