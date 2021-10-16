using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using QueryApi.Domain;

//Escuela: Universidad Tecnológica Metropolitana
//Asignatura: Aplicaciones Web Orientada a Servicios
//Maestro: Chuc Uc Joel Ivan
//Actividad: Actividad 1
//Nombre del alumno: Jonathan Missael Sabido Reynoso 
//Cuatrimestre: 4
//Grupo: C
//Parcial: 2


namespace QueryApi.Repositories
{
    public class PersonRepository
    {
        List<Person> _persons;

        public PersonRepository()
        {
            var fileName = "dummy.data.queries.json";
            if(File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                _persons = JsonSerializer.Deserialize<IEnumerable<Person>>(json).ToList();
            }
        }

        // Escribe un método en el cual se retorne la información de todas las personas.
        public IEnumerable<Person> Get_All()
        {
            var info = _persons.Select(person => person);
            return info;
        }

        
        // Escribe un método en el cual se retorne únicamente el nombre completo de las personas, el correo y el año de nacimiento.
        public IEnumerable<Object> Get_Fields()
        {
            var info =_persons.Select(person => new{
                Full_Name = $"{person.FirstName} {person.LastName}",
                Date_of_birth = DateTime.Now.AddYears((person.Age * -1)).Year,
                Email = person.Email
            });
            return info;
        }
        //Escribe un método que retorne la información de todas las personas cuyo genero sea Femenino.
        public IEnumerable <Person> GetBy_Gender(char Gender)
        {
            Gender = Char.ToUpper(Gender);
            var info = _persons.Where(person => person.Gender == Gender);
            return info; 
        }
        
        // Escribe un método que retorne la información de todas las personas cuya edad se encuentre entre los 20 y 30 años.
        public IEnumerable<Person> GetBy_Range(int min, int max)
        {
            var info = _persons.Where(person => person.Age >= min && person.Age <= max);
            return info;
        }
        // Escribe un método que retorne la información de los diferentes trabajos que tienen las personas
        public IEnumerable<string> Get_Jobs()
        {
            var info = _persons.Select(person => person.Job).Distinct();
            return info;
        }

        //Escribe un método que retorne la información de las personas cuyo nombre contenga la palabra “ar”
        public IEnumerable<Person> Get_Contain(string cadena)
        {
            var info = _persons.Where(person => person.FirstName.Contains(cadena));
            return info;
        }

        //Escribe un método que retorna la información de las personas cuyas edades sean 25, 35 y 45 años
        public IEnumerable<Person> Get_PeopleBy_Age(int first_age,int second_age, int third_age)
        {
            var list = new List <int>{first_age, second_age, third_age};
            var info = _persons.Where(person => list.Contains(person.Age));
            return info;
        }

        

        // Escribe un método que retorne la información ordenada por edad para las personas que sean mayores a 40 años
        public IEnumerable<Person> Get_OrderedByAge(int age)
        {
            var info = _persons.Where(person => person.Age > age).OrderBy(person => person.Age);
            return info;
        }
        //Escribe un método que retorne la información ordenada de manera descendente para todas las personas de género masculino y que se encuentren entre los 20 y 30 años de edad
        public IEnumerable<Person> Get_OrderedMultiple(char gender, int min, int max)
        {
            gender = Char.ToUpper(gender);
            var info = _persons.Where(person => person.Gender == gender && person.Age >= min && person.Age <= max);
            info = info.OrderByDescending(person => person.Age);
            return info;
        }

        // Escribe un método que retorne la cantidad de personas con género femenino.
        public int Get_CountBy_Gender(char gender)
        {
            gender = char.ToUpper(gender);
            var info = _persons.Where(person => person.Gender == gender).Count();
            return info;
        }
        //Escribe un método que retorna si existen personas con el apellido “Shemelt”.
        public bool Get_ExistBy_LastName(string lastName)
        {
            var info = _persons.Exists(person=> person.LastName == lastName);
            return info;
        }

        //Escribe un método que retorne únicamente una persona cuyo trabajo sea “Software Consultant” y tenga 25 años de edad
        public Person Get_UniqueBy_Job_Age(string job, int age)
        {
            var info= _persons.Single(person=>person.Job == job && person.Age == age);
            return info;
        }   
        //Escribe un método que retorne la información de las primeras 3 personas cuyo puesto de trabajo sea “Software Consultant”
        public IEnumerable<Person> Get_TakeBy_Job(int take, string job)
        {
            var info = _persons.Where(person => person.Job == job).Take(take);
            return info;
        }

        //Escribe un método que omita la información de las primeras 3 personas cuyo puesto de trabajo sea “Software Consultant”
        public IEnumerable<Person> Get_SkipBy_Job(int skip, string job)
        {
        var info = _persons.Where(person => person.Job == job);
        info = info.Skip(skip);
        return info;
        }

        //Escribe un método que omita la información de las primeras 3 personas y que retorne la información de las siguientes 3 personas cuyo puesto de trabajo sea “Software Consultant”
        public IEnumerable<Person> Get_SkipTakeBy_Job(string job, int skip, int take)
        {
            var info = _persons.Where(person => person.Job == job);
            info = info.Skip(skip).Take(take);
            return info;
        }
    }
}