﻿using System;

namespace Adapter
{


    /// <summary>
    /// Adaptee
    /// </summary>

    public interface IExternalLog
    {
        bool LogSave(string msg);
    }

    public class ExternalLog : IExternalLog
    {
        public bool LogSave(string msg)
        {
            Console.WriteLine("External log : {0}", msg);

            return true;
        }
    }
}
