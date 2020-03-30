﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Collections;
using System.Text;
using System.Drawing;

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

        // функция для СИММ. Шифрования массива байт заданным алгоритмом и режимом, на выходе массив байт
        // аргументы: вход. байты; ключ; вектор инициализации; алгоритм AES / 3DES; режим шифруем / расшифровываем
        public static Byte[] SimmAlg(Byte[] arrayByte_in, Byte[] key, Byte[] iv, string selectedAlgSimm, bool EncryptIsTrue)
        {
            byte[] arrayByte_out = new byte[0]; // Выходная последовательность байт после шифрования/расшифровки
            ICryptoTransform cryptoTransform;

            try
            {
                switch (selectedAlgSimm) // Получение хеша определенным алгоритмом
                {
                    case "AES":
                        AesCng aescng = new AesCng(); // объект класса у алгоритма AES
                        aescng.Key = key; // присваиваем ключ из аргумента
                        aescng.IV = iv; // присваиваем вектор из аргумента
                        if (EncryptIsTrue == true) // если вызвали для ШИФРования AES
                        {
                            // создали объект-шифратор
                            cryptoTransform = aescng.CreateEncryptor();
                        }
                        else  // если вызвали для РАСшифровки AES
                        {
                            // создали объект-расшифратор
                            cryptoTransform = aescng.CreateDecryptor();
                        }
                        // получили байты на выходе
                        arrayByte_out = cryptoTransform.TransformFinalBlock(arrayByte_in, 0, arrayByte_in.Length);
                        //cryptoTransform.TransformBlock(arrayByte_in, 0, arrayByte_in.Length, arrayByte_out, 0);

                        aescng.Dispose(); // освобождаем ресурсы
                        cryptoTransform.Dispose(); // освобождаем ресурсы
                        break;

                    case "3DES":
                        TripleDESCng tripledescng = new TripleDESCng(); // объект класса у алгоритма AES
                        tripledescng.Key = key; //  присваиваем ключ из аргумента
                        tripledescng.IV = iv; //  присваиваем вектор из аргумента
                        if (EncryptIsTrue == true) // если вызвали для ШИФРования AES
                        {
                            // создали объект-шифратор
                            cryptoTransform = tripledescng.CreateEncryptor();
                        }
                        else  // если вызвали для РАСшифровки 3DES
                        {
                            // создали объект-расшифратор
                            cryptoTransform = tripledescng.CreateDecryptor();
                        }
                        // получили байты на выходе
                        arrayByte_out = cryptoTransform.TransformFinalBlock(arrayByte_in, 0, arrayByte_in.Length);

                        tripledescng.Dispose(); // освобождаем ресурсы
                        cryptoTransform.Dispose(); // освобождаем ресурсы
                        break;

                    default: break;
                }
            }
            catch (Exception error)
            {
                //MessageBox.Show(error.Message, "НЕПРЕДВИДЕННАЯ ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (EncryptIsTrue == true) // если шифрование
                    MessageBox.Show(error.Message, "НЕПРЕДВИДЕННАЯ ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show("Ключ или вектор инициализации не подходят", "Ошибка шифрования", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Заданные ключ или вектор инициализации не подходят для заданного шифра!\nРасшифровка не возможна.", "Ошибка расшифровки", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return arrayByte_out;
        }

        // Переводит 16-ричную строку в байты
        public static byte[] StringHEXToByteArray(string strHEX)
        {
            int N = strHEX.Length;
            byte[] bytes = new byte[N / 2];
            for (int i = 0; i < N; i += 2)
                bytes[i / 2] = Convert.ToByte(strHEX.Substring(i, 2), 16);
            return bytes;
        }

        // Переводит байты в значение 16 ричной строки
        public static string ByteArrayTOStringHEX(byte[] byteArr)
        {
            return BitConverter.ToString(byteArr).Replace("-", "").ToUpper();
        }
    }

}
