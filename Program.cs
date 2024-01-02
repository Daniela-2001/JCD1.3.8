namespace JCD1._3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de linhas para a árvore: ");

            // Obter o número de linhas a partir da entrada do usuário
            int numeroDeLinhas = Convert.ToInt32(Console.ReadLine());

            // Loop para desenhar a árvore
            for (int i = 1; i <= numeroDeLinhas; i++)
            {
                // Espaços em branco antes dos asteriscos para alinhar a árvore
                for (int j = 0; j < numeroDeLinhas - i; j++)
                {
                    Console.Write(" ");
                }

                // Números ímpares representados por asteriscos
                for (int k = 0; k < (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                // Mover para a próxima linha após desenhar uma linha completa
                Console.WriteLine();
            }

            Console.ReadLine(); // Manter o console aberto após a execução
        }

    }

}