namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_31
{
    public class Program
    {
        public static void Main(params string[] args)
        {
            string input = args[0];
            string currentPlayer = args[1];

            if (input.Length == 0 || input == "quit") // ||�� or 
            {
                System.Console.WriteLine($"Player {currentPlayer} quit!!");
            }
        }
    }
}

/*
 not - ��Ʈ ���� 0->1 1->0
and & 0110 0100 �� �� and 0100  
or 0110
Layer: ������ stencil �� �κи� �Ⱥ��̰� �ϴ� ��� object, outline, stencil ���� -> ���� ������ �˻�
Tag
 
 
 */