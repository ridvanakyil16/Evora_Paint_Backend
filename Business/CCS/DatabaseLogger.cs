﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CCS
{
    public class DatabaseLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Veritabanına Loglandı");
        }
    }
}