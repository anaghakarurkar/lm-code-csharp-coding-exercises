using System;
using Exercises.Models;

namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester(Person person)
        {
            return (person != null && person.City.Equals("Manchester"));
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            //if persong is 18 or over person can watch a film
            return person.Age >= 18;
        }
    }
}
