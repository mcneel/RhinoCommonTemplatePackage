Imports System
Imports System.Collections.Generic
Imports Rhino
Imports Rhino.Commands
$if$ ($utility$ == 1)Imports Rhino.Geometry
$endif$Imports Rhino.Input
Imports Rhino.Input.Custom

Namespace $safeprojectname$

    Public Class $commandname$
    Inherits Command

        Shared _instance As $commandname$ 

    Public Sub New()
      ' Rhino only creates one instance of each command class defined in a
      ' plug-in, so it is safe to store a refence in a static field.
      _instance = Me
    End Sub

    '''<summary>The only instance of this command.</summary>
        Public Shared ReadOnly Property Instance() As $commandname$
      Get
        Return _instance
      End Get
    End Property

    '''<returns>The command name as it appears on the Rhino command line.</returns>
    Public Overrides ReadOnly Property EnglishName() As String
      Get
        Return "$commandname$"
      End Get
    End Property

    Protected Overrides Function RunCommand(ByVal doc As RhinoDoc, ByVal mode As RunMode) As Result
$if$ ($utilitywithsample$ == 1)            ' TODO: start here modifying the behaviour of your command.
      ' ---
      RhinoApp.WriteLine("The {0} command will add a line right now.", EnglishName)

      Dim pt0 As Point3d
      Using getPointAction As New GetPoint()
        getPointAction.SetCommandPrompt("Please select the start point")
        If getPointAction.[Get]() <> GetResult.Point Then
          RhinoApp.WriteLine("No start point was selected.")
          Return getPointAction.CommandResult()
        End If
        pt0 = getPointAction.Point()
      End Using

      Dim pt1 As Point3d
      Using getPointAction As New GetPoint()
        getPointAction.SetCommandPrompt("Please select the end point")
        getPointAction.SetBasePoint(pt0, True)
        AddHandler getPointAction.DynamicDraw, _
            Sub(sender, e) e.Display.DrawLine(pt0, e.CurrentPoint, System.Drawing.Color.DarkRed)
        If getPointAction.[Get]() <> GetResult.Point Then
          RhinoApp.WriteLine("No end point was selected.")
          Return getPointAction.CommandResult()
        End If
        pt1 = getPointAction.Point()
      End Using

      doc.Objects.AddLine(pt0, pt1)
      doc.Views.Redraw()
      RhinoApp.WriteLine("The {0} command added one line to the document.", EnglishName)
      '' ---
$endif$$if$ ($utilitywithoutsample$ == 1)            ' TODO: modify command.
      RhinoApp.WriteLine("The {0} command is under construction.", EnglishName)
$endif$$if$ ($utility$ == 0)            ' Usually commands in $plugintype$ plug-ins are used to modify settings and behavior.
      ' The $plugintype$ work itself is performed by the $pluginname$ class.
$endif$
      Return Result.Success
    End Function
  End Class
End Namespace