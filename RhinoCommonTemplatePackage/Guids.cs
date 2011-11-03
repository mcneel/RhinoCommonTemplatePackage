// Guids.cs
// MUST match guids.h
using System;

namespace McNeel.RhinoCommonTemplatePackage
{
    static class GuidList
    {
        public const string guidRhinoCommonTemplatePackagePkgString = "1eb60c29-eb50-46e1-a980-ee12403bb5bf";
        public const string guidRhinoCommonTemplatePackageCmdSetString = "467cc3c3-ce2a-4bd1-b073-21c76d494297";

        public static readonly Guid guidRhinoCommonTemplatePackageCmdSet = new Guid(guidRhinoCommonTemplatePackageCmdSetString);
    };
}