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
        //timestamp ขาเข้าไม่ต้องมี แต่ต้องมี timestamp ขาออก (timestamp เป็น timestamp ขาออก)
        // ผู้ถูกนวดเข้ามาในห้อง
        Queue<Person> peopleQ = new Queue<Person>();



        // ผู้ถูกนวดออกจากห้อง ผู้ถูกนวดใหม่เข้ามาในห้องที่ผู้ถูกนวดเก่าออกไปนานที่สุด 
        peopleQ.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47, Timestamp = "2022‑09‑25 17:45:30" });
        GetRoom(peopleQ.Dequeue());
        peopleQ.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45, Timestamp = "2022‑09‑25 18:20:18" });
        GetRoom(peopleQ.Dequeue());
        peopleQ.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9, Timestamp = "2022‑09‑25 19:17:50" });
        GetRoom(peopleQ.Dequeue());
        
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
        //sort timestamp, เก่าสุด ก่อน
        //???
        Console.WriteLine("{0} got room!", p.FirstName);
        
    }
}