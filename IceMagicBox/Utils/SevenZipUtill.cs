using SevenZipExtractor;

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
