namespace TDD_Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("Thank You Led Zeppelin"));
            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("Thank you led zeppelin"));
            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("Led zeppelin thank You"));

            Console.ReadLine();
        }
    }
}