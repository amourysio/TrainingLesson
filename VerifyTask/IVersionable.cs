using System;
using System.Collections.Generic;
using System.Text;

namespace VerifyTask
{
    internal interface IVersionable
    {


        public void SetVersion(byte[] version);
        public byte[] GetVersion();
       
    }
}
