using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string call = "http://radoslaw.idzikowski.staff.iiar.pwr.wroc.pl/instruction/students.json";
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(call);
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(response);
            foreach (var s in students)
                Console.WriteLine(s.studentId + ":\t" + s.studentName);
            Console.Read();
        }
        
    }
}
