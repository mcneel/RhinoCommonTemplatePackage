using System;
using System.IO;

namespace ZooWizard
{
  static class ZooFinder
  {
    const string ZOO_DIR = "Zoo 6";
    const string ZOO_DLL = "ZooPlugin.dll";

    public static void FindZooDll(out string path, out string dllName)
    {
      string prog_folder = Environment.GetFolderPath(Environment.Is64BitOperatingSystem ?
        Environment.SpecialFolder.ProgramFilesX86 : Environment.SpecialFolder.ProgramFiles);

      if (!Directory.Exists(prog_folder))
        throw new InvalidOperationException("The program files folder could not be found.");

      path = Path.Combine(prog_folder, ZOO_DIR);

      if (!Directory.Exists(path))
        throw new InvalidOperationException(
          string.Format("No zoo directory:\n{0}", path));

      var final_location = Path.Combine(path, ZOO_DLL);

      if (!File.Exists(final_location))
        throw new InvalidOperationException(
          string.Format("The Zoo 5.0 folder was found in {0}\nbut the file \"{1}\" was not present.",
          path, ZOO_DLL));

      dllName = ZOO_DLL;
    }
  }
}
