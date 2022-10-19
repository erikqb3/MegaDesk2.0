using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MegaDesk2._0
{
    public enum DesktopMaterial
    {
        Oak,
        Laminated,
        Pine,
        Rosewood,
        Veneer

    }
    public enum RushDays
    {
        [Description("14")] RushOption14,
        [Description("3")] RushOption3,
        [Description("5")] RushOption5,
        [Description("7")] RushOption7
    }
    public class Desk
    {
        //CONSTANTS
        public const short MIN_WIDTH = 24;
        public const short MAX_WIDTH = 96;
        public const short MIN_DEPTH = 12;
        public const short MAX_DEPTH = 48;
        public const short MIN_DESK_DRAWERS = 0;
        public const short MAX_DESK_DRAWERS = 7;



        public int width { get; set; }
        public int depth { get; set; }
        public int drawerCount { get; set; }
        //public string material { get; set; } //Make it public DesktopMaterial material {get;set;}
        public DesktopMaterial material { get; set; }
        public RushDays rushDays { get; set; }



        //public string DesktopMaterial DesktopMaterial { get;set }

        
    }
}
