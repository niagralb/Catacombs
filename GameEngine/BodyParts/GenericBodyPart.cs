using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.BodyParts
{
    class GenericBodyPart : BodyPartData
    {
        public string BodyPartName { get; set; }
        public string BodyPartDesc { get; set; }

        public GenericBodyPart(string bodyPartName, string bodyPartDesc)
        {
            this.BodyPartName = bodyPartName;
            this.BodyPartDesc = bodyPartDesc;
        }
    }
}
