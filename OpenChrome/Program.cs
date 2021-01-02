using System.Diagnostics;
using ConfReaderLib;

// Chrome Icon  Artist: firstfear(firstfear.deviantart.com)

try
{
    var conf = new ConfReader(new[] { "program path", "instance path" }, "Path.txt");
    var programpath = conf.GetConf("program path");
    var instancepath = conf.GetConf("instance path");
    Process.Start(programpath, $"--user-data-dir=\"{instancepath}\"");
}
catch { }