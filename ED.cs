using System;
using System.Collections.Generic;
using System.Text;

namespace RC4
{
    class ED
    {
        public static byte[] Encrypt(byte[] pwd, byte[] data)
        {
            int a, i, j, m, tbox;
            int[] key, box;
            byte[] result;

            key = new int[256];
            box = new int[256];
            result = new byte[data.Length];

            for (i = 0; i < 256; i++)
            {
                key[i] = pwd[i % pwd.Length];
                box[i] = i;
            }

            for (j = i = 0; i < 256; i++)
            {
                j = (j + box[i] + key[i]) % 256;
                tbox = box[i];
                box[j] = box[i];
                box[j] = tbox;
            }

            for (a = j = i = 0; i < data.Length; i++)
            {
                a++;
                a = a%256;
                j += box[a];
                j = j%256;
                tbox = box[a];
                box[j] = box[a];
                box[j] = tbox;
                m = box[((box[a] + box[j]) % 256)];
                result[i] = (byte)(data[i] ^ m);
            }
            return result;
        }

        public static byte[] Decrypt(byte[] pwd, byte[] data)
        {
            return Encrypt(pwd, data);
        }

    }
}
