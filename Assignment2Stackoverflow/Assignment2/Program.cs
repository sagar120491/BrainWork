using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

           
            int like = 0;
            int unlike = 0;

            String title = "How to show current date and time in c#";
          

            String description = "For showing current date and time c# allows dateTime.now method from directory";
            DateTime created = new DateTime();
            created = DateTime.Now;


            Console.WriteLine("Title :-" + title);
           // Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("Description :-" + description);
            int finalResul = 0;


            Console.ReadLine();
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Enter the 1 for up and 2 for down ");




                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {

                    case 1:

                        like = like + 1;

                        break;

                    case 2:

                        unlike = unlike + 1;


                        break;

                    default :

                        Console.WriteLine("Please Enter 1 or 2");
                        break;


                }

            }

            finalResul = like - unlike;
            Console.WriteLine("Total like and dislike:- " +finalResul);
            Console.WriteLine("post Created date and Time :-" + created);


        }
    }
}
