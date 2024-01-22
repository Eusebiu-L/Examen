namespace Prima_Problema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The number of people is: ");
            int numarPersoane = Convert.ToInt32(Console.ReadLine());
            Person[] persoane = new Person[numarPersoane];

            for (int i = 0; i < numarPersoane; i++)
            {
                Console.WriteLine("Person" + i + "is:");
                Person persoana = new Person();
                Console.WriteLine("First name is: ");
                persoana.FirstName = Console.ReadLine();
                Console.WriteLine("Last name is: ");
                persoana.LastName = Console.ReadLine();
                Console.WriteLine("The year of Birth is: ");
                persoana.YearOfBirth = Convert.ToInt32(Console.ReadLine());
                persoane[i] = persoana;

                Console.WriteLine($"Person {i + 1}: {persoane[i].FirstName} {persoane[i].LastName}, Year of Birth: {persoane[i].YearOfBirth}, Age: {persoane[i].Age}"); 
               
            }
            Person oldestPerson = PersonProcessor.FindOldestPerson(persoane);
            if (oldestPerson != null)
            {
                Console.WriteLine($"The oldest person is: {oldestPerson.FirstName} {oldestPerson.LastName}, Age: {oldestPerson.Age}");
            }
            else
            {
                Console.WriteLine("No person is introduced");

                Console.WriteLine()
            }
            Console.ReadLine();
        }
    }
}