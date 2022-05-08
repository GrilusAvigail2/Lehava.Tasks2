using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehava.Tasks2.Core
{
    public class Main
    {
        string path = @"C:\Users\USER\Desktop\Zionet course\Tasks2";
        Random random = new Random();
        //create 10 files
        public void CreateFiles()
        {           
            for (int i = 0; i < 10; i++)
            {
                string fileName = $"{path}\\files\\{random.Next(10, 10000)}.txt";
                if (!File.Exists(fileName))
                {
                    Task task = Task.Factory.StartNew(() => {
                        //lock the critical section
                        lock (fileName)
                        {
                            //write to the file '*' 10000000 times
                            File.WriteAllText(fileName, string.Concat(Enumerable.Repeat("*", 10000000)));
                        }
                    });
                }
            }
           
        }

        //create 5 threads. each of them run the CreateFiles function
        public void Create5Threads()
        {
           for (int i = 0; i < 5; i++)
           {
              Task task = Task.Factory.StartNew(CreateFiles);
           }
        }

        //create one file and write to it 30,000,000 '*' character
        public Task<string> CreateOneFile()
        {
            string fileName = $"{path}\\{random.Next(10, 10000)}.txt";
            Task<string> task = Task.Factory.StartNew(() =>
            {
                File.WriteAllText(fileName, string.Concat(Enumerable.Repeat("*", 30000000)));
                return fileName;
            });
            return task;
        }

        //wait until CreateOneFile will finished, then delete the returned file
        public async void DeleteAfterCreate()
        {
            //wait until the task will finished his work-create a file
            string file = await CreateOneFile();
            //delete the file returned from the task
            File.Delete(file);
        }

        public async void DeleteBigFile()
        {
            //wait until the task will finished to create a big file
            string file = await CreateOneFile();
            //create a task that deletes the returned file
            Task task = Task.Factory.StartNew(()=>{
                File.Delete(file);
            });
        }
    }
}
