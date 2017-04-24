using System;
using Rhino;
using Rhino.Commands;

namespace $rootnamespace$
{
    public class $safeitemrootname$ : Command
    {
        static $safeitemrootname$ _instance;
        public $safeitemrootname$()
        {
            _instance = this;
        }

        ///<summary>The only instance of the $safeitemrootname$ command.</summary>
        public static $safeitemrootname$ Instance
        {
            get { return _instance; }
        }

        public override string EnglishName
        {
            get { return "$safeitemrootname$"; }
        }

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {
            // TODO: complete command.
            return Result.Success;
        }
    }
}