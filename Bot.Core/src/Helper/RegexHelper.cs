﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bot.Core.src.Helper
{
    public static class RegexHelper
    {

        public static string GetText(string texto, string regexPattern)
        {
            Match resultado = Regex.Match(texto, regexPattern);
            return resultado.Value;
        }

        public static string GetText(string texto, string regexPattern, int regexGroup)
        {
            Match resultado = Regex.Match(texto, regexPattern);
            return resultado.Groups[regexGroup].Value;
        }

        public static string GetText(string texto, string regexPattern, int regexGroup, RegexOptions options)
        {
            Match resultado = Regex.Match(texto, regexPattern, options);
            return resultado.Groups[regexGroup].Value;
        }


    }
}