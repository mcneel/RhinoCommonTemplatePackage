$if$ ($notutility$ == 1)
using System;
using Rhino;

$endif$namespace $safeprojectname$
{
    ///<summary>
    /// Every RhinoCommon PlugIn must have one and only one PlugIn-derived
    /// class. DO NOT create instances of this class yourself. It is the
    /// responsibility of Rhino to create an instance of this class.
    ///</summary>
$if$ ($utility$ == 1)    public class $pluginname$ : Rhino.PlugIns.PlugIn
$endif$$if$ ($digitizer$ == 1)    public class $pluginname$ : Rhino.PlugIns.DigitizerPlugIn
$endif$$if$ ($import$ == 1)    public class $pluginname$ : Rhino.PlugIns.FileImportPlugIn
$endif$$if$ ($export$ == 1)    public class $pluginname$ : Rhino.PlugIns.FileExportPlugIn
$endif$$if$ ($rendering$ == 1)    public class $pluginname$ : Rhino.PlugIns.RenderPlugIn
$endif$
    {
        static $pluginname$ _instance;

        public $pluginname$()
        {
            _instance = this;
        }
        
        ///<summary>Gets the only instance of the $pluginname$ plug-in.</summary>
        public static $pluginname$ Instance
        {
            get { return _instance; }
        }
$if$ ($digitizer$ == 1)
        ///<summary>
        /// Defines the behavior in response to a request of a user to either enable or disable
        /// input from the digitizer.
        /// It is called by Rhino. If enable is true and EnableDigitizer() returns false,
        /// then Rhino will not calibrate the digitizer.
        ///</summary>
        ///<param name="enable">If true, enable the digitizer. If false, disable the digitizer.</param>
        ///<returns>You should return true if the digitizer should be calibrated. Otherwise, false.</returns>
        protected override bool EnableDigitizer(bool enable)
        {
            throw new NotImplementedException("EnableDigitizer has no defined behavior.");
        }

        ///<summary>
        /// Gets the unit system in which the digitizer works.
        /// passes points to SendPoint().  Rhino uses this value when it calibrates a digitizer.
        /// This unit system must not change.
        /// </summary>
        protected override UnitSystem DigitizerUnitSystem
        {
            get { throw new NotImplementedException("DigitizerUnitSystem is not implemented."); }
        }

        /// <summary>
        /// Gets the point tolerance, or the distance the digitizer must move (in digitizer
        /// coordinates) for a new point to be considered real rather than noise. Small
        /// desktop digitizer arms have values like 0.001 inches and 0.01 millimeters.
        /// This value should never be smaller than the accuracy of the digitizing device.
        /// </summary>
        protected override double PointTolerance
        {
            get { throw new NotImplementedException("PointTolerance is unknown."); }
        }
$endif$$if$ ($import$ == 1)
        ///<summary>Defines file extensions that this import plug-in is designed to read.</summary>
        /// <param name="options">Options that specify how to read files.</param>
        /// <returns>A list of file types that can be imported.</returns>
        protected override Rhino.PlugIns.FileTypeList AddFileTypes(Rhino.FileIO.FileReadOptions options)
        {
            var result = new Rhino.PlugIns.FileTypeList();
            result.AddFileType("$description$ (*.$extension$)", "$extension$");
            return result;
        }

        /// <summary>
        /// Is called when a user requests to import a ."$extension$ file.
        /// It is actually up to this method to read the file itself.
        /// </summary>
        /// <param name="filename">The complete path to the new file.</param>
        /// <param name="doc">The document to be written.</param>
        /// <param name="options">Options that specify how to write file.</param>
        /// <returns>A value that defines success or a specific failure.</returns>
        protected override bool ReadFile(string filename, int index, RhinoDoc doc, Rhino.FileIO.FileReadOptions options)
        {
            bool read_success = false;
            // TODO: Add code for reading file
            return read_success;
        }
$endif$$if$ ($export$ == 1)
        /// <summary>Defines file extensions that this export plug-in is designed to write.</summary>
        /// <param name="options">Options that specify how to write files.</param>
        /// <returns>A list of file types that can be exported.</returns>
        protected override Rhino.PlugIns.FileTypeList AddFileTypes(Rhino.FileIO.FileWriteOptions options)
        {
            var result = new Rhino.PlugIns.FileTypeList();
            result.AddFileType("$description$ (*.$extension$)", "$extension$");
            return result;
        }

        /// <summary>
        /// Is called when a user requests to export a ."$extension$ file.
        /// It is actually up to this method to write the file itself.
        /// </summary>
        /// <param name="filename">The complete path to the new file.</param>
        /// <param name="doc">The document to be written.</param>
        /// <param name="options">Options that specify how to write file.</param>
        /// <returns>A value that defines success or a specific failure.</returns>
        protected override Rhino.PlugIns.WriteFileResult WriteFile(string filename, int index, RhinoDoc doc, Rhino.FileIO.FileWriteOptions options)
        {
            return Rhino.PlugIns.WriteFileResult.Failure;
        }
$endif$$if$ ($rendering$ == 1)
        /// <summary>
        /// Is called when the user calls the _Render command
        /// </summary>
        /// <param name="doc">The document to be rendered.</param>
        /// <param name="mode">The run mode: interactive or scripted.</param>
        /// <param name="fastPreview">Whether the render is in preview-mode.</param>
        /// <returns>The result of the command.</returns>
        protected override Rhino.Commands.Result Render(RhinoDoc doc, Rhino.Commands.RunMode mode, bool fastPreview)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Is called when the user calls the _RenderWindow command
        /// </summary>
        /// <param name="doc">The document to be rendered.</param>
        /// <param name="mode">The run mode: interactive or scripted.</param>
        /// <param name="fastPreview">Whether the render is in preview-mode.</param>
        /// <param name="view">The view being rendered.</param>
        /// <param name="rect">The rendering rectangle.</param>
        /// <param name="inWindow">Whether rendering should appear in the window.</param>
        /// <returns>The result of the command.</returns>
        protected override Rhino.Commands.Result RenderWindow(RhinoDoc doc, Rhino.Commands.RunMode modes, bool fastPreview, Rhino.Display.RhinoView view, System.Drawing.Rectangle rect, bool inWindow)
        {
            throw new NotImplementedException();
        }
$endif$
        // You can override methods here to change the plug-in behavior on
        // loading and shut down, add options pages to the Rhino _Option command
        // and mantain plug-in wide options in a document.
    }
}