using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokesWebApp.Models
{
    public class Joke
    {
        public int id { get; set; }
        public string jokeQuestion { get; set; }

        public string jokeAnswer { get; set; }
        public Joke()
        {

        }

    }
}
