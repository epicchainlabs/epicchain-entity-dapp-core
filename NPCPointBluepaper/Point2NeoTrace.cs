using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoPesistenceClasses2
{
    public class NeoTrace /* Level *all* */
    {
        public static void Trace(params object[] args)
        {
            EpicChain.SmartContract.Framework.Services.EpicChain.Runtime.Notify(args);
        }
    }
}
