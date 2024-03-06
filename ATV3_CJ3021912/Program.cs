namespace ATV3_CJ3021912
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota;
            Console.WriteLine("insira a sua nota: ");
            nota = float.Parse(Console.ReadLine());
            if (nota >= 6.0)
            {
                Console.WriteLine("voce passou");
            }
            else { Console.WriteLine("voce reprovou"); }

        }
    }
}
