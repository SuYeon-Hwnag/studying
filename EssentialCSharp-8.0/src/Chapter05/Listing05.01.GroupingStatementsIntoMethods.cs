namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_01
{
    /*public class LineCount
    {
        /*public static void Main()
        {
            int lineCount;
            string files;

            DisplayHelpText();
            files = GetFiles();
            lineCount = CountLines(files); // file���� ���� �μ� �ؿ��� �����
            DisplayLineCount(lineCount);
        }

        private static void DisplayLineCount(int lineCount)
        {
            throw new System.NotImplementedException();
        }

        private static int CountLines(string files)
        {
            throw new System.NotImplementedException();
        }

        private static string GetFiles()
        {
            throw new System.NotImplementedException();
        }

        private static void DisplayHelpText()
        {
            throw new System.NotImplementedException();
        }

        // ...
    }

        /*
        public static void Main()  // static ���� �� void �����ϴ� ����ִ� static ��ȯ
        {
            string s1 = "";
            string s2 = "";

            WriteThisName(s1); // �Ű�����, �������, �ι�° �ܶ����� �ǳ� ��
            int kk = WriteThisName(); // �żҵ� ȣ�� 
            int kk2 = 1;
        }

        static void WriteThisName(string ss)
        {
            if(ss == "Hello")
            {
                System.Console.WriteLine("this is Hello");
            }
            else
            {
                System.Console.WriteLine("What is this"); // ����� ����
            }
        }
        
        static int WriteThisName()
        {
            return 1;
        }
        */

    public class Counting
    {
        public static void Main()

        {
            string a = "";
            string b = "";
            string type = "";

            System.Console.WriteLine("Input a");
            a = System.Console.ReadLine();

            System.Console.WriteLine("Input b");
            b = System.Console.ReadLine();

            System.Console.WriteLine("Input type +,-,* or /");
            type = System.Console.ReadLine();

            int resultNew = Cal(int.Parse(a), int.Parse(b), type);


        }
        static int Cal(int a, int b, string type) // ��ȯ ���� �ʿ� ���� �� void 
        {
            int result = 0;

            switch (type)
            {
                case "+":
                    result = a + b;
                    break;

                case "-":
                    result = a - b;
                    break;

                case "*":
                    result = a * b;
                    break;

                case "/":
                    result = a / b;
                    break;
                
                default:
                    break;
            }
            return result;
        }
    }
}

