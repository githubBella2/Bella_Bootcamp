// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using DelegateDemo;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        DelegateMethod my = new DelegateMethod(MyDelegate.Print);
        my += MyDelegate.Run;
        my.Invoke();

        Operation myOp = new Operation(DelegateOperation.Add);
        myOp += DelegateOperation.Multiply;
        myOp.Invoke(2, 4);

        DelegateEmail email = new();
        DelegateEmail sms = new();
        Notification del = email.EmailNotify;
        del += sms.SMSNotify;
        del.Invoke();

        Subscriber subscriber = new();
        MyDelegateSubs delSubs = subscriber.Add;
        delSubs += subscriber.Mul;
        float? result = delSubs?.Invoke(2, 78);
        System.Console.WriteLine(result);

        // Nge print semua delegate
        Delegate[] dell = delSubs.GetInvocationList(); //menyimpan semua data disini, lalu tinggal diakses
        foreach (Delegate dg in dell)
        {
            System.Console.WriteLine(
                dg.GetMethodInfo().Name + ": " + 
                ((MyDelegateSubs)dg).Invoke(2, 4 )
            );
        }



    }
}