namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_06
{



    public class Program
    {
        public static void Main()
        {
            (string Frist, string Second, string Thrid) namedFruits = ("apple", "orange", "banana");

            var nameFruits2 = ("Apples,", "Orange", "Etc...");
                
            namedFruits.Frist = "Eat";
        }

    }
}

// Ʃ�� ����: �� ������ Ʃ�÷� ���ϴ� �������� ���� �����ϴ� ���

/*
 namespace Chapter03
    {
        [return: System.Runtime.CompilerServices.TupleElementNames(new string[] { "First", "Second" })]
        public System.ValueTuple<string, string> ParseNames(string fullName)
        {
            // ...
        }

    }
 */