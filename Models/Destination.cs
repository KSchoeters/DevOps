using System;
using Contentful.Core.Models;

namespace Vacation.Models
{
    public class Destination
    {
        public string? Name {get; set;}

        public string? Description {get; set;}

        public Asset? Image { get; set;}

        public string? ReviewName { get; set;}

        public int Rating { get; set;}

        public string? ReviewDescription {get; set;}
    }
}