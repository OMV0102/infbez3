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
using System.Drawing;

namespace infbez3
{
    public static class global
    {
        public static byte[] Hesh_byte_in; // Входной массив байтов для хэширования
        //=================================
        public static byte[] Simm_byte_in; // Входной массив байтов для Симметричного ШИФРОВАНИЯ
        public static byte[] Simm_byte_out; // ВЫходной массив байтов после Симметричного ШИФРОВАНИЯ
        public static byte[] Simm_byte_key; // Ключ для Симметричного ШИФРОВАНИЯ
        public static byte[] Simm_byte_iv; // Вектор инициализации для Симметричного ШИФРОВАНИЯ
        public static bool Simm_EncryptOrDecrypt; // Режим либо шифруем либо расшифровываем для Симметричного ШИФРОВАНИЯ
        public static bool Simm_KeyIV_isEntry; // Введенны ли ключ и  вектор или нет для Симметричного ШИФРОВАНИЯ
        public static string Simm_file_extension = "";  // Расширение считанного файла данных для Симметричного ШИФРОВАНИЯ
        //=====================================
        public static byte[] Asim_byte_in; // Входной массив байтов для Асимметричного ШИФРОВАНИЯ
        public static byte[] Asim_byte_out; // ВЫходной массив байтов после Асимметричного ШИФРОВАНИЯ
        public static int Asim_size_key_bit = 4096;  // Размер ключа в битах для rsa
        public static int Asim_size_key_byte = Asim_size_key_bit / 8;  // Размер ключа в байтах для rsa (16384 бит = 2048 байт указан макс. размер)
        public static byte[] Asim_byte_keyPublic; // Ключ Открытый для Асимметричного ШИФРОВАНИЯ
        public static byte[] Asim_byte_keyPrivate;  // Ключ Закрытый для Асимметричного ШИФРОВАНИЯ
        public static bool Asim_EncryptOrDecrypt; // Режим либо шифруем либо расшифровываем для Асимметричного ШИФРОВАНИЯ
        public static bool Asim_Keys_isEntry; // Введенны ли ключи или нет для Асимметричного ШИФРОВАНИЯ
        public static string Asim_file_extension = "";  // Расширение считанного файла данных для Асимметричного ШИФРОВАНИЯ
    }
}
