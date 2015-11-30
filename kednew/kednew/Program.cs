using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kednew.MailsSender;

namespace kednew
{
    class Program
    {
        static void Main(string[] args)
        {
            MailApp SMails = new MailApp();
            string _ComputName = System.Net.Dns.GetHostName();
            DriveInfo driveinfo = new DriveInfo(args[0].ToString());
            long a=driveinfo.AvailableFreeSpace/1024/1024/1024;
            int b = (int)a;
            StringBuilder _body = new StringBuilder();
            _body.AppendFormat("{0}上的{1}盘还有备份空间{2}G", _ComputName, args[0].ToString(),b);
            if (b <= 250)
            {
                SMails.SendMailbyID("Basis", "备份磁盘监控", _body.ToString());
            }
        }
    }
}
