using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    public class FlatWhite : Kaffe, Imælk
    {

        //hvor meget mælk der skal være i en FlatWhite
        public int MlMælk()
        {
            return 160;
        }

        //prisen på en FlatWhite
        public override int Pris()
        {
            return 45;
        }

        //Styrken på en FlatWhite
        public override string Styrke()
        {
            return "mild";
        }
    }
}
