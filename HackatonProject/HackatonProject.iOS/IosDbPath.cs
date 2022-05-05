using System;
using Xamarin.Forms;
using System.IO;
using HackatonProject.iOS;

[assembly: Dependency(typeof(IosDbPath))]
namespace HackatonProject.iOS
{
    public class IosDbPath : IPath
    {
        public string GetDatabasePath(string sqliteFilename)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", sqliteFilename);
        }
    }
}