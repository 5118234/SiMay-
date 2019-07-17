﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiMay.Core.Packets.FileManager
{
    public class FileOpenTextPack : BasePacket
    {
        public string FileName { get; set; }
    }
    public class FileTextPack : BasePacket
    {
        /// <summary>
        /// 是否可以访问
        /// </summary>
        public bool IsSuccess { get; set; }
        public string Text { get; set; }
    }
}
