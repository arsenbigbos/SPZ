using System.Net.Mail;
using System.Net;

namespace Task4
{
    class task4
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                try
                {
                    Console.WriteLine("Send to {0} with article {1}", args[0], args[1]);
                    string message = DateTime.Now.ToString("d MMM  HH:mm:ss");
                    message += " Arsen Ukrainets";
                    Console.WriteLine(message);

                    var smtpClient = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        Credentials = new NetworkCredential("arsen2004ana@gmail.com", "eqbnrgaruwvuraoh"),
                        EnableSsl = true,
                    };

                    smtpClient.Send("arsen2004ana@gmail.com", args[0], args[1], message);
                    Console.WriteLine("Done!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
                Console.Write("Args problem, use: <email> <theme>");
            }
        }
    }
}
