﻿using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace WhatGameToPlay
{
    public class OptionsFile : TextFile, IFileCreator, IFileWriter
    {
        public OptionsFile(string name) : base(name) {}

        public void CreateFileIfNotExists()
        {
            if (FilesCreator.CreateFileIfNotExists(_name))
            {
                string trueOption = true.ToString(),
                      falseOption = false.ToString();

                string[] standardOptions = { trueOption, trueOption, trueOption, falseOption, trueOption, falseOption };
                WriteToFile(standardOptions);
            }
        }

        public void WriteToFile(string[] options) => File.WriteAllLines(_name, options);

        public string[] CurrentOptions => File.ReadAllLines(_name);
    }
}
