using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Tema1
{
    class GSMTest
            //Problem 7. GSM test
            //Write a class GSMTest to test the GSM class:            
    {
        static void GMSTest()
        {   //Create an array of few instances of the GSM class.
            GSM[] arrayList = new GSM[3];

            GSM FirstPhone = new GSM("Lenovo", "Lenovo", 50.00, "Ieronim");
            arrayList[0] = FirstPhone;

            GSM SecondPhone = new GSM("HTC", "HTC", 150.25, "Ieronim2");
            arrayList[1] = SecondPhone;

            GSM ThirdPhone = new GSM("Sony", "Sony", 204.54, "Ieronim3");
            arrayList[2] = ThirdPhone;

            //Display the information about the GSMs in the array.
            for (int i = 0; i < arrayList.Length; i++)
            {
                arrayList[i].ToString();
            }

            //Display the information about the static property IPhone4S.
            GSM.IPhone4S.ToString();


        }

    }
}
