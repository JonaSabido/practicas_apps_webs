using System.Collections;
using Microsoft.AspNetCore.Mvc;
using QueryApi.Repositories;

//Escuela: Universidad Tecnológica Metropolitana
//Asignatura: Aplicaciones Web Orientada a Servicios
//Maestro: Chuc Uc Joel Ivan
//Actividad: Actividad 1
//Nombre del alumno: Jonathan Missael Sabido Reynoso 
//Cuatrimestre: 4
//Grupo: C
//Parcial: 2

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("Get_All")]
        public IActionResult Get_All()
        {
            var repository = new PersonRepository();
            var persons = repository.Get_All();
            return Ok(persons);
        }
        [HttpGet]
        [Route("Get_Fields")]
        public IActionResult Get_Fields()
        {
            var repository = new PersonRepository();
            var persons = repository.Get_Fields();
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetBy_Gender")]
        public IActionResult GetBy_Gender(char Gender)
        {
            var repository = new PersonRepository();
            var persons = repository.GetBy_Gender(Gender);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetBy_Range")]
        public IActionResult GetBy_Range(int min, int max)
        {
            var repository = new PersonRepository();
            var persons = repository.GetBy_Range(min,max);
            return Ok(persons);
        }  

        [HttpGet]
        [Route("Get_Jobs")]
        public IActionResult Get_Jobs()
        {
            var repository = new PersonRepository();
            var persons = repository.Get_Jobs();
            return Ok(persons);
        }    

        [HttpGet]
        [Route("Get_Contain")]
        public IActionResult Get_Contain(string cadena)
        {
            var repository = new PersonRepository();
            var persons = repository.Get_Contain(cadena);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("Get_PeopleBy_Age")]
        public IActionResult Get_PeopleBy_Age(int first_age,int second_age, int third_age)
        {
            var repository = new PersonRepository();
            var persons = repository.Get_PeopleBy_Age(first_age,second_age,third_age);
            return Ok(persons);
        }
        
        [HttpGet]
        [Route("Get_OrderedByAge")]
        public IActionResult Get_OrderedByAge(int age)
        {
            var repository = new PersonRepository();
            var persons = repository.Get_OrderedByAge(age);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Get_OrderedMultiple")]
        public IActionResult Get_OrderedMultiple(char gender, int min, int max)
        {
            var repository = new PersonRepository();
            var persons = repository.Get_OrderedMultiple(gender,min,max);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Get_CountBy_Gender")]
        public IActionResult GetCount(char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.Get_CountBy_Gender(gender);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Get_ExistBy_LastName")]
        public IActionResult Get_ExistBy_LastName(string lastName)
        {
            var repository = new PersonRepository();
            var persons = repository.Get_ExistBy_LastName(lastName);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Get_UniqueBy_Job_Age")]
        public IActionResult Get_UniqueBy_Job_Age(string job, int age)
        {
            var repository = new PersonRepository();
            var persons = repository.Get_UniqueBy_Job_Age(job,age);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Get_TakeBy_Job")]
        public IActionResult Get_TakeBy_Job(int take, string job)
        {
            var repository = new PersonRepository();
            var persons = repository.Get_TakeBy_Job(take, job);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Get_SkipBy_Job")]
        public IActionResult Get_SkipBy_Job(int skip,string job)
        {
            var repository = new PersonRepository();
            var persons = repository.Get_SkipBy_Job(skip,job);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Get_SkipTakeBy_Job")]
        public IActionResult Get_SkipTakeBy_Job(string job, int skip, int take)
        {
            var repository = new PersonRepository();
            var persons = repository.Get_SkipTakeBy_Job(job,skip,take);
            return Ok(persons);
        }
        
    }
}