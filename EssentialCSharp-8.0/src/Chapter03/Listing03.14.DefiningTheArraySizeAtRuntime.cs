namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_14
{
    public class Program
    {
        public static void Main()
        {
            string[] groceryList;//�迭����
            System.Console.Write("How many items on the list? ");
            int size = int.Parse(System.Console.ReadLine()); // �Է��� ���� �Ҵ���
            groceryList = new string[size];
            // ...
        }
    }
}

// �迭�� ũ�⸦ �ʱ�ȭ�ϴ� ���� �ڿ� �ص� ����