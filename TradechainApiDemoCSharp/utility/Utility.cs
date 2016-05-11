using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TradechainApiDemoCSharp
{
    class Utility
    {
        public static DateTime ConvertFromUnixTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return origin.AddSeconds(timestamp);
        }

        public static double ConvertToUnixTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);
        }

        public static void LongLongToBytes(long num, ref byte[] arr)
        {
	        arr[0]= (byte)((num >> 56) & 0xFF);
	        arr[1]= (byte)((num >> 48) & 0xFF);
	        arr[2]= (byte)((num >> 40) & 0xFF);
	        arr[3]= (byte)((num >> 32) & 0xFF);
	        arr[4]= (byte)((num >> 24) & 0xFF);
	        arr[5]= (byte)((num >> 16) & 0xFF);
	        arr[6]= (byte)((num >> 8) & 0xFF);
	        arr[7]= (byte)(num & 0xFF);
        }

        public static void SignHashString(string apikey, string secretkey, long timestamp, out string signhash)
        {
            signhash= "";

	        if(apikey.Length==0) return;
            if(secretkey.Length==0) return;

            byte[] apikey_bytes= Encoding.UTF8.GetBytes(apikey);
            if(apikey_bytes.Length==0) return;

            byte[] secretkey_bytes= Encoding.UTF8.GetBytes (secretkey);
            if(secretkey_bytes.Length==0) return;

            //byte[] timestamp_bytes= BitConverter.GetBytes(timestamp);
            byte[] timestamp_bytes= new byte[8];
            Array.Clear(timestamp_bytes, 0, 8);
            LongLongToBytes(timestamp, ref timestamp_bytes);

            byte[] buff = new byte[apikey_bytes.Length + secretkey_bytes.Length + timestamp_bytes.Length];
            int bufflen= 0;
            Array.Copy(apikey_bytes, 0, buff, bufflen, apikey_bytes.Length);
            bufflen += apikey_bytes.Length;
            Array.Copy(secretkey_bytes, 0, buff, bufflen, secretkey_bytes.Length);
            bufflen += secretkey_bytes.Length;
            Array.Copy(timestamp_bytes, 0, buff, bufflen, timestamp_bytes.Length);
            bufflen += timestamp_bytes.Length;
            
            //signhash= BitConverter.ToString(buff).Replace("-", string.Empty);
            signhash= BitConverter.ToString(Ripemd160(Hash256(buff))).Replace("-", string.Empty);
            //signhash= BitConverter.ToString(Hash256(buff)).Replace("-", string.Empty);

            //release memory or GC        
        }

        public static byte[] HexStringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        public static string AttachmentHashString(string attachment)
        {
            using (SHA256 hash = SHA256.Create())
            {
                using (var stream = File.OpenRead(attachment))
                {
                    return BitConverter.ToString(hash.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
        }

        public static string AuthHashString(byte[] data)
        {
            return BitConverter.ToString(Ripemd160(Hash256(data))).Replace("-", string.Empty);
        }

        public static byte[] Ripemd160(byte[] data)
        {
            using (RIPEMD160 hash = RIPEMD160.Create())
            {
                return hash.ComputeHash(data);
            }
        }

        public static byte[] Hash256(byte[] data)
        {
            using (SHA256 hash = SHA256.Create())
            {
                return hash.ComputeHash(data);
            }
        }
    }
}
