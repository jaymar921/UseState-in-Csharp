using Csharp_Deconstructing_Tuples.Classes;

namespace Csharp_Deconstructing_Tuples
{
    internal class State_Example
    {
        static void Main(string[] args)
        {
            /*
                Creating State just inspired by ReactJS hehehe, it's ReactCS XD
                
                Creating a state
                
                     getter    setter
                var (Func<T>, Action<T>) = new State<T>().CreateState();

                example:
                var (name, setName) = new State<string>().CreateState();

                setName("hello World"); // < -- setting the name value to "hello World"
                Console.WriteLine(name()) // < -- getting the name value by invoking the getter method
                Console.WriteLine(name.Invoke()) // < -- another way of invoking the getter method
            */

            var (name, setName) = new State<string>().CreateState("jay");
            var (age, setAge) = new State<int>().CreateState(22);

            Console.WriteLine("Original Name: "+name());
            setName("jayharron");
            Console.WriteLine("New Name: " + name());

            Console.WriteLine("Original Age: " + age());
            setAge(23);
            Console.WriteLine("New Age: " + age());
        }
    }
}