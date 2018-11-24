using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{

    enum EntryType { FOLDER, ARCHIVE, FILE, EXE, IMG, DRIVE, TXT };


    class Funcs
    {

        static List<string> imageTypes = new List<string> { ".jpg", ".png" };
        static List<string> archTypes  = new List<string> { ".zip", ".rar" };

        public static bool isHidden(FileSystemInfo fsi)
        {
            return fsi.Attributes.HasFlag(FileAttributes.Hidden);
        }

        public static EntryType TypeOf(FileSystemInfo fsi)
        {
            if (fsi.Attributes.HasFlag(FileAttributes.Directory))
            {
                if (isDrive(fsi.FullName))
                    return EntryType.DRIVE;
                else
                    return EntryType.FOLDER;
            }
            else
            {
                var ext = Path.GetExtension(fsi.FullName);
                if (ext == ".txt")
                    return EntryType.TXT;
                if (isImage(ext))
                    return EntryType.IMG;
                if (ext == ".exe")
                    return EntryType.EXE;
                if (isArchive(ext))
                    return EntryType.ARCHIVE;
                return EntryType.FILE;
            }
        }

        private static bool isImage(string extention)
        {
            return imageTypes.Contains(extention);
        }

        private static bool isArchive(string extention)
        {
            return archTypes.Contains(extention);
        }

        private static bool isDrive(string path)
        {
            return new DirectoryInfo(path).Parent == null;
        }
    }
}
