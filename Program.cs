namespace programa {
    public class Program {
        static void Main(){
            int num, num2;

            Console.WriteLine("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A soma é " + Operacoes.Somar(num, num2));
            Console.WriteLine($"A subtração é {Operacoes.Subtrair(num, num2)}");
        
        }
    }
}