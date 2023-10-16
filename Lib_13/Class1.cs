using System;

namespace Lib_13
{
    public class CLasspr1
    {
        /// <summary>
        /// ������� ���������� ��������� �����, � ����� ����������� 2 ���������� ������, ���������� ����������
        /// </summary>
        /// <param name="ch">���������� �����</param>
        /// <param name="zn">��������� ����������</param>
        public static void GenerateNumber(out string ch, out string zn)
        {
            Random rnd = new Random(); int X = rnd.Next(-5, 6); double a = X; int b = 0;
            for (int i = 0; i < 1;)//����������� ����, ����� ����� �������� ������
            {
                X = rnd.Next(-5, 6); b = X;
                if (a == b)//���� 2 ����� ��������� �����������
                {
                    if (a > 0)
                    {
                        a = Math.Sqrt(a);//��������� ������
                    }
                    else if (a < 0)
                    {
                        a = Math.Pow(a, 2);//��������� �������
                    }
                    break;//������� �� �����
                }
                a = b;
            }
            ch = Convert.ToString(b); zn = Convert.ToString(a);
        }
    }
}
