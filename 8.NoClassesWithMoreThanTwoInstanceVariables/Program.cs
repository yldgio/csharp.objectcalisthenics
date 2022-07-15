

namespace Wrong
{
    class Name
    {
        public string first { get; set; }
        public string middle { get; set; }
        public string last { get; set; }
    }

}
namespace Favour.Composition
{
    class Name
    {
        public Surname family { get; set; }
        public GivenNames given { get; set; }
    }
    class Surname
    {
        public string family { get; set; }
    }
    class GivenNames
    {
        public List<string> names { get; set; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        /**
         *  high cohesion and better encapsulation. 
         *  Limiting yourself to only two instance variables is not an achievable goal for big projects, 
         *  but the intention is to force you to decouple your classes a lot.
         *  decomposing objects from a set of attributes into a hierarchy of collaborating objects, 
         *  leads much more directly to an effective object model
         * **/
    }
}