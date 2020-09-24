using System.Diagnostics;
using ConfReaderLib;

namespace Open_Chrome
{
    // Chrome Icon  Artist: firstfear(firstfear.deviantart.com)
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var conf = new ConfReader(new[] { "program path", "instance path" }, "Path.txt");
                var programpath = conf.GetConf("program path");
                var instancepath = conf.GetConf("instance path");
                Process.Start(programpath, $"--user-data-dir=\"{instancepath}\"");
            }
            catch { }
        }
    }
}
