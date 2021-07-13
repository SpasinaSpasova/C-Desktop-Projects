using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassIO
{
    public class Reader : BaseIO
    {
        BinaryReader br;
        /// <summary>
        /// Create a reader to read a file.
        /// </summary>
        /// <param name="path">The path to file to read.</param>
        public Reader(string path)
        {
            br = new BinaryReader(File.OpenRead(path));
            this.byteOrder = ByteOrder.BigEndian;
        }
        /// <summary>
        /// Create a reader to read a file.
        /// </summary>
        /// <param name="path">The path to file to read.</param>
        /// <param name="bo">The order of the bytes to read.</param>
        public Reader(string path, ByteOrder bo)
        {
            br = new BinaryReader(File.OpenRead(path));
            this.byteOrder = bo;
        }
        /// <summary>
        /// The position to read at.
        /// </summary>
        public long position
        {
            get => br.BaseStream.Position;
            set
            {
                br.BaseStream.Position = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public byte ReadByte()
        {
            return br.ReadByte();
        }
        public sbyte ReadSByte()
        {
            return (sbyte)br.ReadByte();
        }
        public short ReadInt16()
        {
            short myShort = br.ReadInt16();
            if (byteOrder == ByteOrder.BigEndian)
            {
                byte[] buffer = BitConverter.GetBytes(myShort);
                Array.Reverse(buffer);
                myShort = BitConverter.ToInt16(buffer, 0);
            }
            return myShort;
        }
        public ushort ReadUInt16()
        {
            ushort myuShort = br.ReadUInt16();
            if (byteOrder == ByteOrder.BigEndian)
            {
                byte[] buffer = BitConverter.GetBytes(myuShort);
                Array.Reverse(buffer);
                myuShort = BitConverter.ToUInt16(buffer, 0);
            }
            return myuShort;
        }
        public int ReadInt32()
        {
            int myint = br.ReadInt32();
            if (byteOrder == ByteOrder.BigEndian)
            {
                byte[] buffer = BitConverter.GetBytes(myint);
                Array.Reverse(buffer);
                myint = BitConverter.ToUInt16(buffer, 0);
            }
            return myint;
        }
        public long ReadInt64()
        {
            long mylong = br.ReadInt64();
            if (byteOrder == ByteOrder.BigEndian)
            {
                byte[] buffer = BitConverter.GetBytes(mylong);
                Array.Reverse(buffer);
                mylong = BitConverter.ToUInt16(buffer, 0);
            }
            return mylong;
        }
        public uint ReadUInt32()
        {
            uint myuint = br.ReadUInt32();
            if (byteOrder == ByteOrder.BigEndian)
            {
                byte[] buffer = BitConverter.GetBytes(myuint);
                Array.Reverse(buffer);
                myuint = BitConverter.ToUInt32(buffer, 0);
            }
            return myuint;
        }
        public ulong ReadUInt64()
        {
            ulong myulong = br.ReadUInt64();
            if (byteOrder == ByteOrder.BigEndian)
            {
                byte[] buffer = BitConverter.GetBytes(myulong);
                Array.Reverse(buffer);
                myulong = BitConverter.ToUInt64(buffer, 0);
            }
            return myulong;
        }

        public byte[] ReadBytes(int amount)
        {
            byte[] buffer = br.ReadBytes(amount);
            if (byteOrder == ByteOrder.LitlleEndian)
            {
                Array.Reverse(buffer);
            }
            return buffer;
        }
        public void Close()
        {
            br.Close();
        }
       
        public string ReadString(int lenght)
        {
            return new string(br.ReadChars(lenght));
        }
        public string ReadUnicodeString(int lenght)
        {
            if (byteOrder == ByteOrder.BigEndian)
            {
                return Encoding.BigEndianUnicode.GetString(br.ReadBytes(lenght));
            }
            else
            {
                return Encoding.Unicode.GetString(br.ReadBytes(lenght));
            }
        }
        public char ReadChar()
        {
            return br.ReadChar();
        }
        public char[] ReadChars(int amount)
        {
            return br.ReadChars(amount);
        }

    }
    public class Writer : BaseIO
    {
        BinaryWriter bw;
        public Writer(string path)
        {
            bw = new BinaryWriter(File.OpenWrite(path));
            byteOrder = ByteOrder.BigEndian;
        }
        public Writer(string path, ByteOrder bo)
        {
            bw = new BinaryWriter(File.OpenWrite(path));
            byteOrder = bo;
        }
        public long Position
        {
            get => bw.BaseStream.Position;
            set
            {
                bw.BaseStream.Position = value;
            }
        }
        public void WriteByte(byte toWrite)
        {
            bw.Write(toWrite);
        }
        public void WriteBytes(byte[] bytesToWrite)
        {
            if (byteOrder == ByteOrder.BigEndian)
            {
                Array.Reverse(bytesToWrite);
            }
            bw.Write(bytesToWrite);
        }
        public void WriteInt16(short toWrite)
        {
            byte[] buffer = BitConverter.GetBytes(toWrite);
            if (byteOrder == ByteOrder.BigEndian)
            {
                Array.Reverse(buffer);
            }
            bw.Write(buffer);
        }
        public void WriteUInt16(ushort toWrite)
        {
            byte[] buffer = BitConverter.GetBytes(toWrite);
            if (byteOrder == ByteOrder.BigEndian)
            {
                Array.Reverse(buffer);
            }
            bw.Write(buffer);
        }
        public void WriteInt32(int toWrite)
        {
            byte[] buffer = BitConverter.GetBytes(toWrite);
            if (byteOrder == ByteOrder.BigEndian)
            {
                Array.Reverse(buffer);
            }
            bw.Write(buffer);
        }
        public void WriteUInt32(uint toWrite)
        {
            byte[] buffer = BitConverter.GetBytes(toWrite);
            if (byteOrder == ByteOrder.BigEndian)
            {
                Array.Reverse(buffer);
            }
            bw.Write(buffer);
        }
        public void WriteUInt64(ulong toWrite)
        {
            byte[] buffer = BitConverter.GetBytes(toWrite);
            if (byteOrder == ByteOrder.BigEndian)
            {
                Array.Reverse(buffer);
            }
            bw.Write(buffer);
        }
        public void WriteInt64(long toWrite)
        {
            byte[] buffer = BitConverter.GetBytes(toWrite);
            if (byteOrder == ByteOrder.BigEndian)
            {
                Array.Reverse(buffer);
            }
            bw.Write(buffer);
        }
        public void WriteString(string toWrite)
        {
            bw.Write(toWrite.ToCharArray());
        }
        public void WriteUnicodString(string toWrite)
        {
            byte[] buffer = (byteOrder == ByteOrder.BigEndian) ? Encoding.BigEndianUnicode.GetBytes(toWrite) : Encoding.Unicode.GetBytes(toWrite);
            bw.Write(toWrite);
        }
        public void WriteCharacter(char toWrite)
        {
            bw.Write(toWrite);
        }
        public void WriteCharacters(char[] toWrite)
        {
            bw.Write(toWrite);
        }
        public void Close()
        {
            bw.Close();
        }

    }
    public abstract class BaseIO
    {
        /// <summary>
        /// The order of the bytes both read and written
        /// </summary>
        public enum ByteOrder
        {
            BigEndian,
            LitlleEndian
        }
        protected ByteOrder byteOrder;
        public void ChangeByteOrder(ByteOrder bo)
        {
            this.byteOrder = bo;
        }

    }
}
