using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string material { get; set; } //Make it public DesktopMaterial material {get;set;}
        public int expectancy { get; set; }



        //public string DesktopMaterial DesktopMaterial { get;set }
    }
}
