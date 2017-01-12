 using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 using System.Threading.Tasks; 
 using System.IO; 
 
 
 namespace Outcome2 
 { 
    class Program 
    { 
         string[] Data; 

 
         static void Main(string[] args) 
         { 
 
 
            ReadIn(); 
 
 
         } 
        public static void ReadIn() 
        { 

 
            StreamReader Reader = new StreamReader(@"C:\Users\20178667.GLASGOWCLYDE\Desktop\\Test Data.csv");

 
             string datafile = Reader.ReadToEnd(); 

 
            char[] Seperators = new char[] { ' ', ',', '.' }; 
            string[] Data = datafile.Split(Seperators); 

 
            for (int i = 0; i < Data.Length; i++ ) 
             { 

 
                 Console.WriteLine(Data[i]); 
                // Console.Write(Data[i + 1]); 
               //  Console.Write(Data[i + 2]); 
           } 
           Console.Read(); 

 
        } 
     } 
 } 
