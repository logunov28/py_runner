﻿using System;
using Microsoft.Win32;
using System.Diagnostics;

class Reg

{
    public static void Main()
    {


        RegistryKey rk = Registry.CurrentUser;

        PrintKeys(rk);
    }

    static void PrintKeys(RegistryKey rkey)
    {

        if (Registry.CurrentUser.OpenSubKey(@"Software\Python") != null) //если путь существует
        {
            if (System.IO.File.Exists("run.pyc"))
            {
                Process.Start("run.pyc");
            }
			else if (System.IO.File.Exists("run.pyo"))
            {
                Process.Start("run.pyo");
            }
            else if (System.IO.File.Exists("run.pyw"))
            {
                Process.Start("run.pyw");
            }
            else if (System.IO.File.Exists("run.py"))
            {
                Process.Start("run.py");
            }
            else
            {
                
                Console.WriteLine("Nothing to run!");
                for (; ; )
                { }
            }
            
        }
        else {
            Process.Start("winerror.js");
            for (; ; )
            { }
        }

    }

    
}

