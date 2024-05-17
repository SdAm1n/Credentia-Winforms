using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class UserCredModel
    {
        public byte[] SecretKey { get; set; }
        public byte[] AesKey { get; set; }
        public byte[] AesIV { get; set; }
    }
}
