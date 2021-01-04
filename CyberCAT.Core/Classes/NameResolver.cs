﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes
{
    
    public static class NameResolver
    {
        public struct NameStruct
        {
            public string Name { get; set; }
            public string GameName { get; set; }
            public string GameDescription { get; set; }
        }

        static Dictionary<ulong, NameStruct> _items = new Dictionary<ulong, NameStruct>();
        public static string GetName(ulong hash)
        {
            if (_items.ContainsKey(hash))
            {
                return _items[hash].Name;
            }
            return $"Unknown_{hash:X}";
        }

        public static string GetName(TweakDbId tdbid)
        {
            if (_items.ContainsKey(tdbid.Raw64))
            {
                return _items[tdbid.Raw64].Name;
            }
            return $"Unknown_{tdbid}";
        }

        public static string GetGameName(ulong hash)
        {
            if (_items.ContainsKey(hash))
            {
                return _items[hash].GameName;
            }
            return $"";
        }

        public static string GetGameName(TweakDbId tdbid)
        {
            if (_items.ContainsKey(tdbid.Raw64))
            {
                return _items[tdbid.Raw64].GameName;
            }
            return $"";
        }

        public static string GetGameDescription(ulong hash)
        {
            if (_items.ContainsKey(hash))
            {
                return _items[hash].GameDescription;
            }
            return $"";
        }

        public static string GetGameDescription(TweakDbId tdbid)
        {
            if (_items.ContainsKey(tdbid.Raw64))
            {
                return _items[tdbid.Raw64].GameDescription;
            }
            return $"";
        }

        public static void UseDictionary(Dictionary<ulong, NameStruct> dictionary)
        {
            _items = dictionary;
        }
    }
    
}
