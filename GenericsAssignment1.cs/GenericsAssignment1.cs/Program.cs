// See https://aka.ms/new-console-template for more information

using GenericsAssignment1.cs;

GenericStack<Person> personList = new GenericStack<Person>();

personList.AddItem(new Person("Karl", 28));
personList.AddItem(new Person("Gabriel", 50));
personList.AddItem(new Person("Hans", 56));

personList.DisplayIt();

GenericStack<int> genericStackInt = new GenericStack<int>();
genericStackInt.AddItem(575);
genericStackInt.AddItem(7000);
genericStackInt.RemoveItem();
Console.WriteLine($"The item removed is {genericStackInt.RemoveItem()}");
