using System;
using System.Collections.Generic;

using ZooPlugin;

namespace $safeprojectname$
{
	public class $pluginclassname$ : IZooPlugin
	{
    /// <summary>
    /// Returns a guid that uniquely identifies this Zoo plug-in class.
    /// </summary>
    public Guid ZooPluginId()
    {
      return new Guid("$guid2$");
    }

    /// <summary>
    /// Returns the name of your company or organization.
    /// (e.g. "Robert McNeel and Associates")
    /// </summary>
    public string Organization()
    {
      return "$registeredorganization$";
    }

    /// <summary>
    /// Returns the address of your company or organization. Use a "\r\n"
    /// character combination to separate lines.
    /// (e.g. "3670 Woodland Park Avenue North\r\nSeattle, WA 98115")
    /// </summary>
    public string Address()
    {
      return "3670 Woodland Park Avenue North\r\nSeattle, WA 98115";
    }

    /// <summary>
    /// Returns the country in which your company or organization is located.
    /// (e.g. "United States")
    /// </summary>
    public string Country()
    {
      return "United States";
    }

    /// <summary>
    /// Returns an email address that a customer can use to contact you.
    /// (e.g. "tech@mcneel.com")
    /// </summary>
    public string Email()
    {
      return "example@example.com";
    }

    /// <summary>
    /// Returns a phone number that a customer can use to contact you.
    /// (e.g. "(206) 545-7000")
    /// </summary>
    public string Phone()
    {
      return "(000) 000-7000";
    }

    /// <summary>
    /// Returns a FAX number that a customer can use to contact you.
    /// (e.g. "(206) 545-7321")
    /// </summary>
    public string Fax()
    {
      return "(000) 000-1234";
    }

    /// <summary>
    /// Returns the web address or url of your company or organization.
    /// (e.g. "http://www.rhino3d.com")
    /// </summary>
    public string Web()
    {
      return "http://www.example.com";
    }

    /// <summary>
    /// Returns your unique identifier, or PlugInId, of your Rhino plug-in.
    /// If this does not return the same guid as your Rhino plug-in, then
    /// it will not be able to obtain a license from the Zoo.
    /// </summary>
    public Guid RhinoPluginId()
    {
      // If your Rhino plug-in uses the C++ SDK, this is returned by your
      //    plug-in object's CRhinoPlugIn::PlugInID() override.
      //
      // If your Rhino plug-in uses the .NET SDK, this is returned by your
      //    plug-in object's MRhinoPlugIn.PlugInID() override.
      //
      // If your Rhino plug-in uses the RhinoCommon SDK, this is returned by your
      //    plug-in project's "Guid" assembly attribute.
      return new Guid("$zooguid$");
    }

    /// <summary>
    /// Returns the name, version, and/or type of the product that this plug-in
    /// validates. This string will appear in user interfaces were one can 
    /// choose type type of license to validate.
    /// </summary>
    /// <returns></returns>
    public string ProductTitle()
    {
      return "$safeprojectname$ 1.0";
    }

    /// <summary>
    /// Validates a product, or CD, key that was entered into the Zoo administrator
    /// console, and returns license data. This data will, in turn, be serialized,
    /// maintained, and distributed by the Zoo.
    /// </summary>
    /// <param name="productKey">
    /// The product, or CD, key to validate. This is the raw, unmodified product key
    /// string as entered into the Zoo Administrator console.
    /// </param>
    /// <param name="licenseData">
    /// If productKey represents a valid license for your product, then licenseData
    /// should be filled in with information about the license.
    /// </param>
    /// <returns>
    /// Return 0 on success; the output Message is ignored.
    /// Return any other number to indicate failure. 
    /// The Zoo will call FormatErrorMessage with the value you return in order to get
    /// a human-readable error message for display and logging purposes.
    /// </returns>
    public int ValidateProductKey(string productKey, out ZooPluginLicenseData licenseData)
    {
      // This class contains information about your product's license.
      licenseData = new ZooPluginLicenseData();

      // If this example, we won't do much valiation...
      if (string.IsNullOrEmpty(productKey))
        return -1;

      // This value will never be display in any user interface.
      // When your plugin's ValidateProductKey member is called, it is
      // passed a a product, or CD, key that was entered into the Zoo
      // administrator console. Your ValidateProductKey will validate
      // the product key and decode it into a product license. This is
      // where you can store this license. This value will be passed
      // to your application at runtime when it requests a license.
      licenseData.ProductLicense = productKey;

      // This value will display in user interface items, such as in
      // the Zoo console and in About dialog boxes. Also, this value
      // is used to uniquely identify this license. Thus, it is
      // critical that this value be unique per product key, entered
      // by the administrator. No other license of this product, as
      // valided by this plugin, should return this value.
      //
      // This example just scrambles the productKey...
      licenseData.SerialNumber = Scramble(productKey);

      // This value will display in user interface items, such as in
      // the Zoo console and in About dialog boxes.
      // (e.g. "Rhinoceros 5.0", "Rhinoceros 5.0 Commercial", etc.)
      licenseData.LicenseTitle = "$safeprojectname$ 1.0 Educational";

      // The build of the product that this license work with.
      // When your product requests a license from the Zoo, it
      // will specify one of these build types.
      licenseData.BuildType = LicenseBuildType.Release;

      // Zoo licenses can be used by more than one instance of any application.
      // For example, a single Rhion Education Lab license can be used by up
      // to 30 systems simulaneously. If your license supports multiple instance,
      // then specify the number of supported instances here. Otherwise just
      // specify a value of 1 for single instance use.
      licenseData.LicenseCount = 1;

      // The Zoo supports licenses that expire. If your licensing scheme
      // is sophisticated enough to support this, then specify the
      // expiration date here. Note, this value must be speicified in
      // Coordinated Universal Time (UTC). If your license does not expire,
      // then just this value to null.
      licenseData.DateToExpire = null;

      return 0;
    }

    /// <summary>
    /// Looks up a human-readable, properly localized error message for logging and
    /// display purposes.
    /// </summary>
    /// <param name="messageID">
    /// MessageID is a plug-in specific ID that is returned when ValidateProductKey
    /// fails to validate the key.
    /// </param>
    /// <param name="locale">
    /// The CultureInfo associated with the currently running process; use this info
    /// to localize your error messages appropriately.
    /// </param>
    /// <returns></returns>
    public string FormatErrorMessage(int messageID, System.Globalization.CultureInfo locale)
    {
      string message = null;
      switch (messageID)
      {
        case -1:
        default:
          message = "The license is invalid.";
          break;
      }
      return message;
    }

    /// <summary>
    /// Randomizes character positions in string
    /// </summary>
    static string Scramble(string input)
    {
      if (string.IsNullOrEmpty(input)) 
        return input;

      List<char> inputChars = new List<char>(input);
      char[] outputChars = new char[inputChars.Count];
      
      Random rand = new Random();

      for (int i = inputChars.Count - 1; i >= 0; i--)
      {
        int index = rand.Next(i);
        outputChars[i] = inputChars[index];
        inputChars.RemoveAt(index);
      }

      return new string(outputChars);
    }
    
    /// <summary>
	/// We do not need to show any UI.
	/// If we wanted to, we could show it here before the key is passed over
	/// to <see cref="ValidateProductKey">ValidateProductKey</see>.
	/// </summary>
	/// <param name="productKey">The product, or CD, key to validate.
	/// This is the raw, unmodified product key string as entered into the
	/// Zoo Administrator console.</param>
	/// <param name="validatedKey">The modified productKey string.
	/// Again, in most cases you will set validatedKey equal productKey.
	/// This value will be passed to ValidateProductKey().</param>
	/// <returns>Return 0 on success; the output Message is ignored.
	/// Return any other number to indicate failure. The Zoo will call
	/// FormatErrorMessage with the value you return in order to get a
	/// human-readable error message for display and logging purposes.
	/// </returns>
	public int ValidateProductKeyUI(string productKey, out string validatedKey)
	{
	    validatedKey = productKey;
	    return 0;
	}
	}
}
