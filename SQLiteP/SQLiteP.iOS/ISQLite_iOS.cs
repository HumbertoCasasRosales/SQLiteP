using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SQLiteP.iOS;
using System.IO;

[assembly: Dependency(typeof(ISQLite_iOS))]
namespace SQLiteP.iOS
{
    public class ISQLite_iOS: ISQLite
    {
        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, filename);
        }
    }
}
