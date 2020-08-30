using ConsoleAppManager.ContextFolder;
using ConsoleAppManager.Model;
using System;
using System.Linq;

namespace ConsoleAppManager
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dataContext = new ConsoleAppManagerDbcontext())
            {
                var currentTime = DateTime.Now;

                //Add Timelogs
                dataContext.TimeLogs.Add(new TimeLog() { ApplicationName = "Test1", ApplicationTitle ="This is Test1" ,TimestampEnded = currentTime , TimestampStarted = currentTime });
                dataContext.TimeLogs.Add(new TimeLog() { ApplicationName = "Test2", ApplicationTitle = "This is Test2", TimestampEnded = currentTime, TimestampStarted = currentTime });
                dataContext.TimeLogs.Add(new TimeLog() { ApplicationName = "Test3", ApplicationTitle = "This is Test3", TimestampEnded = currentTime, TimestampStarted = currentTime });

                //Add Documents
                dataContext.DocumentsUseds.Add(new DocumentsUsed() { DocumentName = "Document1" ,DocumentPath=" /application/Document1" });
                dataContext.DocumentsUseds.Add(new DocumentsUsed() { DocumentName = "Document2", DocumentPath = " /application/Document2" });

                dataContext.SaveChanges();

                foreach (var timedata in dataContext.TimeLogs.ToList())
                {
                    Console.WriteLine($"ApplicationName= {timedata.ApplicationName}, ApplicationTitle = {timedata.ApplicationTitle}, TimestampStarted = {timedata.TimestampStarted}, TimestampEnded = {timedata.TimestampEnded}");
                }


                foreach (var docdata in dataContext.DocumentsUseds.ToList())
                {
                    Console.WriteLine($"DocumentName= {docdata.DocumentName}, DocumentPath = {docdata.DocumentPath}");
                }

                Console.ReadLine();
            }
        }
    }
}
