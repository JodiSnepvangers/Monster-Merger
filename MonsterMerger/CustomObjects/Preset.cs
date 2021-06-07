using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterMerger.CustomObjects {
    public class Preset {

        //holds a list of modifiers (names only) which can be recalled later. also holds its own infocontainer as a final layer ontop of it all
        public List<string> ModifierList { get; set; } = new List<string>();
        public InfoContainer finalContainer { get; set; } = new InfoContainer();
    }
}
