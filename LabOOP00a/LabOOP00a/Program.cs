using System;

namespace LabOOP00a
{
    class Program
    {

        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.name = "นายกฤตวัฒน์ อินทรสิทธิ์";
            student1.weight = 45.6f;

            Student student2 = new Student();
            student2.name = "นางสาวณัฐธิดา บุญพา";
            student2.weight = 65.8f;

            Student student3 = new Student();
            student3.name = "นายเทพทินกร พรมโสภา";
            student3.weight = 54.9f;

            Student student4 = new Student();
            student4.name = "นายรัตพงษ์ ปานเจริญ";
            student4.weight = 74.2f;

            Student student5 = new Student();
            student5.name = "นางสาวอฆพร ไร่ขาม";
            student5.weight = 56.7f;

            float alweight = (student1.weight + student2.weight + student3.weight + student4.weight + student5.weight)/2;
            Console.WriteLine("All Student wight = "+ alweight);

        }
    }
}
