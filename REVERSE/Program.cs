namespace REVERSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[20];
            Console.WriteLine("Enter the Name");
            
            a= Console.ReadLine();
            var b = a.Reverse();
            Console.WriteLine("reversed name is"+ b );
            Console.WriteLine("kkk");

                }
    }
}