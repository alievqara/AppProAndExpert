using System;

namespace homework
{
    public class Program
    {
        static void Main()
        {



            //HomeWork
            //Console.WriteLine("Test Application");

            //string ba = "Basic"; //Basic

            //string pr = "Pro";  //Pro

            //string expert = "Expert"; //Expert

            ExpertDocumentProgram document = new ExpertDocumentProgram();
            ProDocumentProgram proDocument = new ProDocumentProgram();
            DocumentProgram basicDocument = new DocumentProgram();


            basicDocument.OpenDocument();
            basicDocument.EditDocument();
            basicDocument.SaveDocument();

            //proDocument.OpenDocument();
            //proDocument.EditDocument();
            //proDocument.SaveDocument();


            //document.OpenDocument();
            //document.EditDocument();
            //document.SaveDocument();
            
            
        

           

           





        }


    }

}


