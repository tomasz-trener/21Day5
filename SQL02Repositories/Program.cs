

using SQL02Repositories;

PersonsRepository personsRepository = new PersonsRepository();

Person[] people = personsRepository.GetPersons();



foreach (var p in people)
{
    Console.WriteLine(p.FirstName + " " + p.LastName);
 }


//

