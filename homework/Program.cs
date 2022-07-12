using System;

namespace homework
{
    public class Program
    {
        static void Main()
        {



            //HomeWork
            //Console.WriteLine("Test Application");

            

            string text = "Pro"; //Expert


            if (text == "Basic")
            {
            DocumentProgram basicDocument = new DocumentProgram();

            basicDocument.OpenDocument();
            basicDocument.EditDocument();
            basicDocument.SaveDocument();

            }
            else if (text == "Pro")
            {
            ProDocumentProgram proDocument = new ProDocumentProgram();


            proDocument.OpenDocument();
            proDocument.EditDocument();
            proDocument.SaveDocument();
            }
            else if (text == "Expert")
            {
            ExpertDocumentProgram document = new ExpertDocumentProgram();



            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();

            }
            else
            {
                Console.WriteLine(" 404 Not Fount ");
            }














        }


    }

}


