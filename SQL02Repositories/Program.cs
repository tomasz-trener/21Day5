

using SQL02Repositories;

PersonsRepository personsRepository = new PersonsRepository();

Person[] people = personsRepository.GetPersons();


Person newPerson = new Person()
{
    FirstName = "jan",
    LastName = "kowalski"
};
personsRepository.CreatePerson(newPerson);




foreach (var p in people)
{
    Console.WriteLine(p.FirstName + " " + p.LastName);
 }


//

