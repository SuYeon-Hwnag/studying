namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_17
{
    public class Uppercase
    {
        public static void Main()
        {
            string text;

            System.Console.Write("Enter text: ");
            text = System.Console.ReadLine();

            // UNEXPECTED: Does not convert text to uppercase
            text.ToUpper(); //�ؽ�Ʈ ���� �빮�ڷ�

            string s1 = "hello";
            string s2 = "world";

            string s3 = s1 + s2; //helloworld
            System.Console.WriteLine(text);
        }
    }
}

// string ���ڿ� �Ұ�

/*
 �빮�ڷ� ǥ���ϱ�
string ���ڿ� Ŭ������ �پ��� Ȱ���
.compare ��
.format �ʱ�ȭ
.concat ��ġ��
.ToLower
.ToUpper
.
.
 */
