using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Telper.Utilities
{
    class MemStream
    {

        public static MemoryStream AddObjectToMemStream<T>(T data, MemoryStream mStream)
        {
            byte[] buffer = new byte[Marshal.SizeOf(data)];
            mStream.Write(buffer, (int)mStream.Length, buffer.Length);
            return mStream;
        }

        public static void AddObjectToMemStream<T>(T data, ref MemoryStream mStream)
        {
            byte[] buffer = new byte[Marshal.SizeOf(data)];
            mStream.Write(buffer, (int)mStream.Length, buffer.Length);
        }
    }
}
