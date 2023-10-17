using System;
namespace TusWASM.Server.Helper
{
    public class TusDiskStorageOptionHelper
    {
        public string StorageDiskPath { get; }

        public TusDiskStorageOptionHelper()
        {
            string path = Path.Combine("/Users/bennyadiwijaya/Developer/NET/Files/TusWASM","files");
            if (!File.Exists(path))
                Directory.CreateDirectory(path);

            StorageDiskPath = path;
        }
    }
}

