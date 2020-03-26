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
        
        
        public static Byte[] SimmAlg(Byte[] arrayByte_in, Byte[] key, Byte[] iv, string selectedAlgSimm, bool EncryptIsTrue)
        {
            byte[] arrayByte_out = new byte[0]; // Выходная последовательность байт после шифрования/расшифровки
            ICryptoTransform cryptoTransform = null;

            try
            {

                switch (selectedAlgSimm) // Получение хеша определенным алгоритмом
                {
                    case "AES":
                        AesCng aescng = new AesCng(); // объект класса у алгоритма AES
                        if (EncryptIsTrue == true) // если вызвали для ШИФРования AES
                         {
                            if (key == null || key.Length != 32) // если ключ не по формату
                            {
                                aescng.GenerateKey(); // генерируем ключ
                                global.Simm_byte_key = aescng.Key;
                            }
                            else
                                aescng.Key = key; // иначе присваиваем ключ из аргумента

                            if (iv == null || iv.Length != 16) // если вектор не по формату
                            {
                                aescng.GenerateIV(); // генерируем вектор инициализации
                                global.Simm_byte_iv = aescng.IV;
                            }
                            else
                                aescng.IV = iv; // иначе присваиваем вектор из аргумента
                            // создали объект-шифратор с ключом и вектором
                            cryptoTransform = aescng.CreateEncryptor(aescng.Key, aescng.IV); 
                            // зашифровали сообщение
                            arrayByte_out = cryptoTransform.TransformFinalBlock(arrayByte_in, 0, arrayByte_in.Length);

                        }
                        else  // если вызвали для РАСшифровки AES
                        {

                        }
                        aescng.Dispose(); // освобождаем ресурсы
                        cryptoTransform.Dispose(); // освобождаем ресурсы
                        break;

                    case "3DES":
                        TripleDESCng tripledescng = new TripleDESCng(); // объект класса у алгоритма AES
                        if (EncryptIsTrue == true) // если вызвали для ШИФРования AES
                        {
                            if (key == null || key.Length != 32) // если ключ не по формату
                            {
                                tripledescng.GenerateKey(); // генерируем ключ
                                global.Simm_byte_key = tripledescng.Key;
                            }
                            else
                                tripledescng.Key = key; // иначе присваиваем ключ из аргумента

                            if (iv == null || iv.Length != 16) // если вектор не по формату
                            {
                                tripledescng.GenerateIV(); // генерируем вектор инициализации
                                global.Simm_byte_iv = tripledescng.IV;
                            }
                            else
                                tripledescng.IV = iv; // иначе присваиваем вектор из аргумента
                            // создали объект-шифратор с ключом и вектором
                            cryptoTransform = tripledescng.CreateEncryptor(tripledescng.Key, tripledescng.IV);
                            // зашифровали сообщение
                            arrayByte_out = cryptoTransform.TransformFinalBlock(arrayByte_in, 0, arrayByte_in.Length);

                        }
                        else  // если вызвали для РАСшифровки 3DES
                        {

                        }
                        tripledescng.Dispose(); // освобождаем ресурсы
                        cryptoTransform.Dispose(); // освобождаем ресурсы
                        break;

                    default: break;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "НЕПРЕДВИДЕННАЯ ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return arrayByte_out;
        }

    }

}
