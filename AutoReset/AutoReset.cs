
// namespace AutoReset;

// public class AutoReset
// {
//     static AutoResetEvent autoResetEvent = new AutoResetEvent(true);
//     static void Main(string[] args)
//     {
//         Thread thread = new Thread(SomeMethod)
//         {
//             Name = "New Thread"
//         };

//         Thread thread2 = new Thread(SomeMethod)
//         {
//             Name = "Another thread"
//         };
//         thread.Start();
//         thread2.Start();
//         Console.ReadLine();
//     }

//     static void SomeMethod()
//     {
//         autoResetEvent.WaitOne();
//         System.Console.WriteLine("Starting...");
//         System.Console.WriteLine(Thread.CurrentThread.Name);
//         Thread.Sleep(2000);
//         System.Console.WriteLine("Finishing.. ");
//         System.Console.WriteLine(Thread.CurrentThread.Name);
//         autoResetEvent.Set();
//     }
// }
