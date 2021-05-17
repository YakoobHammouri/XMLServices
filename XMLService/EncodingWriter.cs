using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace Eservices.XMLService
{
    public class EncodingWriter : StringWriter
    {
        public override Encoding Encoding => _encoding ?? base.Encoding;
        private readonly Encoding _encoding;
        public EncodingWriter() { }

        public EncodingWriter(Encoding encoding)
        {
            _encoding = encoding;
        }
    }
}