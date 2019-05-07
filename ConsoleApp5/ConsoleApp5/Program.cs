using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            WSJobQueue.JobQueue_Service ServiceJobQueue = new WSJobQueue.JobQueue_Service();


            ServiceJobQueue.Url = "http://veronin.arbentia.com:7051/NAVExt/WS/CRONUS%20International%20Ltd./Page/JobQueue";
            ServiceJobQueue.Credentials = new NetworkCredential("WSAdmin", "Alcachofa2014");

            WSJobQueue.JobQueue[] ListaTareas;
      
            WSJobQueue.JobQueue_Filter[] ListaTareasFiltro = new WSJobQueue.JobQueue_Filter[0];

            ListaTareas = ServiceJobQueue.ReadMultiple(ListaTareasFiltro,null,0);

            foreach(WSJobQueue.JobQueue Tarea in ListaTareas)
            {
                Console.WriteLine(Tarea.Object_Caption_to_Run);
                
            }
            
        }
    }
}
