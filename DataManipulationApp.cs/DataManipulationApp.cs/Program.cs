// See https://aka.ms/new-console-template for more information
using DataManipulationApp.cs;

while (true)
{
    Console.WriteLine("Welcome to the DataManipulationApp.");
    Console.WriteLine("Please select the criterion ('id, 'name', 'city' or 'exit' to close the app) based on which you wish to select the person");
    string criterion = Console.ReadLine().ToLower();

    if (criterion == "exit")
    {
        Console.WriteLine("Thanks for using the app. Have a nice day!");
        break;
    }

    switch (criterion)
    {
        case "id":
            Console.WriteLine("Thanks for selecting the id criterion. Please enter the id: ");
            Console.ReadLine();
            if(!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid input, try again please");

            }
            IEnumerable<Person> personsById = Person.PersonRepository.SelectById(id);
            foreach(Person person in personsById)
            {
                Console.WriteLine($"The people with id {id} : " + person.ToString());
            }
            break;
        case "name":
            Console.WriteLine("Thanks for selecting the name criterion. Please enter the name: ");
            string name = Console.ReadLine();
            IEnumerable<Person> personsByName = Person.PersonRepository.SelectByName(name);
            foreach(Person person in personsByName)
            {
                Console.WriteLine($"The people with name {name}: " + person.ToString());
            }
            break;
        case "city":
            Console.WriteLine("Thanks for selecting the city criterion. Please enter the city: ");
            string city = Console.ReadLine();
            IEnumerable<Person> personsByCity = Person.PersonRepository.SelectByCity(city);
            foreach(Person person in personsByCity)
            {
                Console.WriteLine($"The people with city {city}: " + person.ToString());
            }
            break;
        default: Console.WriteLine("Incorrect input. Try again, please.");
            break;
    }
   
}





