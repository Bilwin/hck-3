using System;
using System.IO;
using Xamarin.Forms;
using HackatonProject.Droid;

[assembly: Dependency(typeof(AndroidDbPath))]
namespace HackatonProject.Droid
{
    public class AndroidDbPath : IPath
    {
        public string GetDatabasePath(string filename)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), filename);
        }
    }
}