using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Assignment_filestream
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var studentinfo = Studentdata.GetStudentdatas();




            string use = "";
            foreach (var item in studentinfo)
            {

                use = use + "\n" + item;
            }
            string word = use;

            string path = @"C:\Users\RESIDENT FINTECH\Documents\Student Data\StudentInformation.txt";
            FileStream fs = File.Open(path, FileMode.Create);



            //to convert Studentdata.GetStudentdatas(); to string

            byte[] buffer = Encoding.Default.GetBytes(word);
            fs.Write(buffer, 0, buffer.Length);

            fs.Position = 0;

            //Filestream Read
            byte[] filelist = new byte[buffer.Length];
            for (int i = 0; i < buffer.Length; i++)
            {
                filelist[i] = (byte)fs.ReadByte();
            }
            Console.WriteLine(Encoding.Default.GetString(filelist));
            fs.Close();


        }

        //static void WriteToFile(List<Studentdata> students, string path)
        //{
        //    var filestream = new FileStream(path, FileMode.Open);
        //    string usingToWrite = "";

        //    foreach (var item in students)
        //    {
        //        usingToWrite = $"Name: {item.Name}, Age: {item.Age}, Class: {item.Class}";
        //        byte[] toBytes = Encoding.Default.GetBytes(usingToWrite);
        //        filestream.Write(toBytes, 0, toBytes.Length);
        //    }
        //    filestream.Close();
        //}



        //static void ReadFromFile(string path)
        //{
        //    var filestream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);

        //    byte[] toBytes = new byte[1024];
        //    var byteRead = filestream.Read(toBytes, 0, toBytes.Length);

        //    var stringResult = Encoding.Default.GetString(toBytes, 0, byteRead);

        //    Console.WriteLine(stringResult);
        //    filestream.Close();
        //}


    }
}
