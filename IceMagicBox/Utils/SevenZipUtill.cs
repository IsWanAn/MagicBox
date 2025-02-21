using SevenZipExtractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceMagicBox.Utils
{
    public class SevenZipUtill
    {
       public static void Extract(string archivePath, string extractPath)
        {
            using (ArchiveFile archiveFile = new ArchiveFile(archivePath))
            {
                archiveFile.Extract(extractPath);
            }
        }
    }
}
