﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiMay.Core.Entitys
{
    public class ServiceOptions
    {
        public string Id { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string Remark { get; set; }
        public bool IsHide { get; set; }
        public bool IsAutoRun { get; set; }
        public int SessionMode { get; set; }
        public int AccessKey { get; set; }
        public bool IsMutex { get; set; }
    }
}
