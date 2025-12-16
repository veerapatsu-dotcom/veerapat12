using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veerapat12
{
    internal class Program
    {

           
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("กรุณาใส่คะแนน (0 - 100) หรือพิมพ์ exit เพื่อออกจากโปรแกรม:");
                string input = Console.ReadLine();

                // ตรวจสอบคำสั่งออกจากโปรแกรม
                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("ออกจากโปรแกรม");
                    break;
                }

                try
                {
                    int score = int.Parse(input);

                    // ตรวจสอบช่วงคะแนน
                    if (score < 0 || score > 100)
                    {
                        Console.WriteLine("ข้อผิดพลาด: คะแนนต้องอยู่ระหว่าง 0 - 100");
                    }
                    else
                    {
                        string grade;

                        if (score >= 80) grade = "A";
                        else if (score >= 75) grade = "B+";
                        else if (score >= 70) grade = "B";
                        else if (score >= 65) grade = "C+";
                        else if (score >= 60) grade = "C";
                        else if (score >= 55) grade = "D+";
                        else if (score >= 50) grade = "D";
                        else grade = "F";

                        Console.WriteLine($"คะแนน: {score} ได้เกรด: {grade}");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("ข้อผิดพลาด: กรุณาใส่ตัวเลขเท่านั้น");
                }

                Console.WriteLine(); // เว้นบรรทัดก่อนเริ่มรอบใหม่
            }
        }
    }
}