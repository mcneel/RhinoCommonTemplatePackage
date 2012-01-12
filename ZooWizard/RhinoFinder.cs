using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.IO;

namespace ZooWizard
{
  static class ZooFinder
  {
    const string zooDir = "Zoo 5.0";
    const string zooDll = "ZooPlugin.dll";

    public static void FindZooDll(out string path, out string dllName)
    {
      string progFolder;
      if (Environment.Is64BitOperatingSystem)
      {
        progFolder = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
      }
      else
      {
        progFolder = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
      }

      if (!Directory.Exists(progFolder))
        throw new InvalidOperationException("The program files folder could not be found.");

      path = Path.Combine(progFolder, zooDir);

      if (!Directory.Exists(path))
        throw new InvalidOperationException(
          string.Format("No zoo directory:\n{0}", path));

      var finalLocation = Path.Combine(path, zooDll);

      if (!File.Exists(finalLocation))
        throw new InvalidOperationException(
          string.Format("The Zoo 5.0 folder was found in {0}\nbut the file \"{1}\" was not present.",
          path, zooDll));

      dllName = zooDll;
    }
  }
}
