﻿using System.Collections.Generic;

namespace Base.Services
{
    public class _List
    {
        /// <summary>
        /// convert list<string> to string
        /// </summary>
        /// <param name="list"></param>
        /// <param name="quote">是否加上單引號</param>
        /// <param name="sep"></param>
        /// <returns></returns>
        public static string ToStr(List<string> list, bool quote = false, string sep = ",")
        {
            var result = (list == null || list.Count == 0)
                ? ""
                : string.Join(sep, list);
            return (quote)
                ? "'" + result.Replace(sep, "'" + sep + "'") + "'"
                : result;
        }

        //overloading
        public static string ToStr(List<int> list, bool quote, string sep = ",")
        {
            var result = (list == null || list.Count == 0)
                ? ""
                : string.Join(sep, list);
            return (quote)
                ? "'" + result.Replace(sep, "'" + sep + "'") + "'"
                : result;
        }

        public static bool IsAlphaNum(List<string> list)
        {
            return _Str.CheckKeyRule(ToStr(list));
        }

        public static List<string> Concat(List<string> list1, List<string> list2)
        {
            var list = new List<string>();
            if (list1 != null && list1.Count > 0)
                list.AddRange(list1);
            if (list2 != null && list2.Count > 0)
                list.AddRange(list2);
            return (list.Count == 0) ? null : list;
        }

    }//class
}
