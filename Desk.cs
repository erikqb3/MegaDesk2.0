using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk1._0
{
    public enum DesktopMaterial
    {
        Laminated,
        Oak,
        Rosewood,
        Veneer,
        Pine,
        Mahogany,
        Birch
    }
    internal class Desk
    {
        //CONSTANTS
        public const short MIN_WIDTH = 24;
        public const short MAX_WIDTH = 96;
        public const short MIN_DEPTH = 12;
        public const short MAX_DEPTH = 48;
        public const short MIN_DESK_DRAWERS = 0;
        public const short MAX_DESK_DRAWERS = 7;



        public float width { get; set; }
        public float depth { get; set; }

        //public string DesktopMaterial DesktopMaterial { get;set }
    }
}
