using RoomQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        // ผู้ถูกนวดเข้ามาในห้อง
        Queue<Person> peopleQ = new Queue<Person>();
        peopleQ.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47, Timestamp = "2022‑09‑25 17:45:30" });
        peopleQ.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45, Timestamp = "2022‑09‑25 18:20:18" });
        peopleQ.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9, Timestamp = "2022‑09‑25 19:17:50" });
        // Peek at first person in Q.
        Console.WriteLine("{0} is first in line!", peopleQ.Peek().FirstName);
        // ผู้ถูกนวดออกจากห้อง
        GetRoom(peopleQ.Dequeue());
        GetRoom(peopleQ.Dequeue());
        GetRoom(peopleQ.Dequeue());
        
        //ผู้ถูกนวดใหม่เข้ามาในห้องที่ผู้ถูกนวดเก่าออกไปนานที่สุด 
        peopleQ.Enqueue(new Person { FirstName = "Tanade", LastName = "Korwanitgun", Age = 33, Timestamp = "2022‑11‑01 12:25:56" });

        
        try
        {
            GetRoom(peopleQ.Dequeue());
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine("Error! {0}", e.Message);
        }

    }
    static void GetRoom(Person p)
    {
        Console.WriteLine("{0} got room!", p.FirstName);
        //sort timestamp เก่าสุด
        //???
    }
}