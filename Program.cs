namespace programa {
    public class Program {
        static void Main(){
            int num, num2;

            Console.WriteLine("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O valor digitado foi " + (num + num2));
            Console.WriteLine($"O valor digitado foi {num + num2}");
        }
    }
}