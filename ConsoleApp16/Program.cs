namespace ConsoleApp16
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region answer1
            DeliveryAddress d1 = new DeliveryAddress();
            DeliveryAddress d2 = new DeliveryAddress();
            d1.City = "mansora";
            d1.Street = "elgalaa";
            d2 = d1;
            Console.WriteLine(d1.City);
            Console.WriteLine(d2.City);
            d2.City = "cairo";
            Console.WriteLine(d1.City);
            Console.WriteLine(d2.City);
            //اول حاجه الstruct  ,valuetype  هو عباره عن ,stackبيخزن فى ال,object b object انا باخد كوبي من الداتا مش بيشاور على نفس العنوان 
            //فعند التعديل فى اوبجيكت لايؤثر على الاوبجيكت التاني المتساوي بيه يتاثر فى حاله لو بعت ال reverece 
            #endregion
            #region answer 2


            #endregion


        }
    }
}