using System;
using System.Windows.Forms;

namespace DiskwatchCS
{
  /// <summary>
  /// Program
  /// </summary>
  internal static class Program
  {
    /// <summary>
    /// main entrance point of the application
    /// </summary>
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(defaultValue: false);
      Application.Run(mainForm: new Form());
    }
  }
}
