using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Collections;
using System.Text;

namespace infbez3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_main());
        }
    }

    public static class global
    {
        // Блок переменный для хэширования
        public static byte[] Hesh_byte_in; // Входной массив байтов для хэширования
    }

    public static class alg
    {
        // функция для хэширования массива байт заданным алгоритмом, на выходе 16-ричная строка
        public static string HeshAlg(Byte[] arrayByte_in, string selectedAlgHesh)
        {
            byte[] arrayByte_out = new byte[0]; // Выходная последовательность байт после хеширования
            string heshString = ""; // Хеш строка (16 ричный вид)

            try
            {

                switch (selectedAlgHesh) // Получение хеша определенным алгоритмом
                {
                    case "MD5":
                        MD5 md5 = MD5.Create();
                        arrayByte_out = md5.ComputeHash(arrayByte_in);
                        md5.Dispose();
                        break;

                    case "RIPEMD160":
                        RIPEMD160 ripemd160 = RIPEMD160.Create();
                        arrayByte_out = ripemd160.ComputeHash(arrayByte_in);
                        ripemd160.Dispose();
                        break;

                    case "SHA1":
                        SHA1 sha1 = SHA1.Create();
                        arrayByte_out = sha1.ComputeHash(arrayByte_in);
                        sha1.Dispose();
                        break;

                    case "SHA256":
                        SHA256 sha256 = SHA256.Create();
                        arrayByte_out = sha256.ComputeHash(arrayByte_in);
                        sha256.Dispose();
                        break;

                    case "SHA384":
                        SHA384 sha384 = SHA384.Create();
                        arrayByte_out = sha384.ComputeHash(arrayByte_in);
                        sha384.Dispose();
                        break;

                    case "SHA512":
                        SHA512 sha512 = SHA512.Create();
                        arrayByte_out = sha512.ComputeHash(arrayByte_in);
                        sha512.Dispose();
                        break;

                    default: break;
                }
                heshString = BitConverter.ToString(arrayByte_out).Replace("-", "");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "НЕПРЕДВИДЕННАЯ ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return heshString;
        }


    }

}
