namespace MICT
{
    public class Age
        {
            public virtual void p(double age)
            {
                Console.Write("입력한 나이:"+age);
            }
        }
        public class young : Age
        {
            public virtual void p(double age, int[] i)
            {
                double young=0;
                //young
                young = (i[1] - age) / (i[1] - i[0]);
                if(young > 1)
                {
                    young = 1;
                }
                else if(young < 0)
                {
                    young = 0;
                }
                Console.Write("\n25의 소속도:"+young);
            }
        }
        public class standard : Age
        {
            public virtual void p(double age, int[] i)
            {
                double standard=0;
                //standard
                if(age >= i[0] && age <= i[1])
                {
                    standard = (age - i[0]) / (i[1] - i[0]);
                }
                else if(age >= i[1] && age <= i[2])
                {
                    standard = (i[2] - age) / (i[2] - i[1]);
                }
                else if(age < i[0])
                {
                    standard = 0;
                }
                else if(age > i[1])
                {
                    standard = 0;
                }
                else if(standard >= 1)
                {
                    standard = 1;
                }
                else if(standard < 0)
                {
                    standard = 0;
                }
                Console.Write("\n45의 소속도:"+standard);
            }
        }
        public class old : Age
        {
            public virtual void p(double age, int[] i)
            {
                double old=0;
                //old
                old = (age - i[1]) / (i[2] - i[1]);
                if(old > 1)
                {
                    old = 1;
                }
                else if(old < 0 )
                {
                    old = 0;
                }
                Console.Write("\n55의 소속도:"+old);
            }
        }
    class Form1
    {
        static void Main(string[] args)
        {
            // 25 나이적음, 45 나이 보통, 55 나이많음
            int[] i  = {25,45,55}; 
            Console.WriteLine("나이를 입력하세요:");
            int age = int.Parse(Console.ReadLine());

            Age input_age1 = new Age();
            young input_age2 = new young();
            standard input_age3 = new standard();
            old input_age4 = new old();

            input_age1.p(age);
            input_age2.p(age,i);
            input_age3.p(age,i);
            input_age4.p(age,i);
        }
    }
}
