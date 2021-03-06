﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Ransom Note 383
    /// </summary>
    public class RansomNote
    {
        /*
            https://leetcode.com/problems/ransom-note/#/description

            Given an arbitrary ransom note string and another string containing letters from all the magazines, write a function that will return true if the ransom note can be constructed from the magazines ; otherwise, it will return false.

            Each letter in the magazine string can only be used once in your ransom note.
            
            Note:
            You may assume that both strings contain only lowercase letters.
            
            canConstruct("a", "b") -> false
            canConstruct("aa", "ab") -> false
            canConstruct("aa", "aab") -> true
        */

        public static bool CanConstruct(string ransomNote, string magazine)
        {
            return magazine.Contains(ransomNote);
        }
    }
}
