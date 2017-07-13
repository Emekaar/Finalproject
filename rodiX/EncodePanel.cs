using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rodiX
{
    class EncodePanel
    {
        public EncodePanel() { }
        public string decrypt64(string loui)
        {
            //method to decrypt base 64
            var ta = Convert.FromBase64String(loui);
            return Encoding.UTF8.GetString(ta);

        }
        public string encrypt64(string loui)
        {
            //method to encrypt string to base 64
            var t = System.Text.Encoding.UTF8.GetBytes(loui);
            return Convert.ToBase64String(t);
        }
        static protected string M1encrypt(string loui)
        {
            //method to encrypt data to m1
            string y = loui;
            string final = "";
            string a = string.Format("abcdefghijklmnopqrstuvwxyz= {0}0123456789",Environment.NewLine);
            string b = string.Format("zyxwvutsrqponmlkjihgfedcba!.~!@#$%^&*()");
            for (int ai = 0; ai < loui.Length; ai++)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (y[ai] == a[i])
                    {
                        final += b[i];
                    }
                }
            }
            return final;
        }
        static protected string M1decrypt(string loui)
        {
            //method to decrypt data to m1
            string y = loui;
            string final = "";
            string b = string.Format("abcdefghijklmnopqrstuvwxyz= {0}0123456789", Environment.NewLine);
            string a = string.Format("zyxwvutsrqponmlkjihgfedcba!.~!@#$%^&*()");
            for (int ai = 0; ai < loui.Length; ai++)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (y[ai] == a[i])
                    {
                        final += b[i];
                    }
                }
            }
            return final;
        }
        static protected string reverse(string loui)
        {
            char[] k = loui.ToCharArray();
            Array.Reverse(k);
            return new string(k);

        }
        public  string finalencryption(string loui)
        {
            //encode with m1
            //reverse
            //to base64 code
            //reverse
            //to base 64 code
            //reverse
            //replace == with ?
            string k = loui;
            k = M1encrypt(k);
            k = reverse(k);
            k = encrypt64(k);
            k = reverse(k);
            k = encrypt64(k);
            k = reverse(k);
            k = k.Replace("=", "?");
            return k;
        }
        public string finaldecryption(string loui, string password)
        {
            //replace == with ?
            //reverse
            //to base 64 code
            //reverse
            //to base64 code
            //reverse
            //decode with m1
            if (password == "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv")
            {
                string k = loui;
                k = k.Replace("?", "=");
                k = reverse(k);
                k = decrypt64(k);

                k = reverse(k);
                k = decrypt64(k);
                k = reverse(k);
                k = M1decrypt(k);
                return k;
            }
            return "";
            
        }
    }
}
