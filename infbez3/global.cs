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

namespace infbez3
{
    public static class global
    {
        public static byte[] Hesh_byte_in; // Входной массив байтов для хэширования
        public static byte[] Simm_byte_in; // Входной массив байтов для Симметричного ШИФРОВАНИЯ
        public static byte[] Simm_byte_key; // Ключ для Симметричного ШИФРОВАНИЯ
        public static byte[] Simm_byte_iv; // Вектор инициализации для Симметричного ШИФРОВАНИЯ
    }
}
