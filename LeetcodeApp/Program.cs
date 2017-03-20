using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LeetcodeApp

            #region 2017/3/2

            //NumberComplement.FindComplement(1111111111);

            //KeyboardRow.FindWords(new string[4] { "Hello", "Alaska", "Dad", "Peace" });

            //FizzBuzz.FizzBuzzDisplay(15);

            //ReverseString.ReverseStringFunc("Hello");

            //IslandPerimeter.IslandPerimeterFunc(new int[4, 4] { { 0, 1, 0, 0 }, { 1, 1, 1, 0 }, { 0, 1, 0, 0 }, { 1, 1, 0, 0 } });

            #endregion

            #region 2017/3/3

            //MaxConsecutiveOnes.FindMaxConsecutiveOnes(new int[16] { 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1 });
            //MaxConsecutiveOnes.FindMaxConsecutiveOnes(new int[6] { 1, 1, 0, 1, 1, 1 });

            //DetectCapital.DetectCapitalUse("FlaG");

            //FindAllNumbersDisappearedinanArray.FindDisappearedNumbers(new int[8] { 4, 3, 2, 7, 8, 2, 3, 1 });

            //FindtheDifference.FindTheDifference("abcd", "zzabcde");

            #endregion

            #region 2017/3/6

            //TwoSumII_Inputarrayissorted.TwoSum(new int[5] { 2, 7, 11, 15, 18 }, 33);

            //ExcelSheetColumnNumber.TitleToNumber("AZ");

            //MissingNumber.missingNumber(new int[5] { 0, 1, 3, 4, 5 });

            //MaximumSubarray.MaxSubArray(new int[9] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });

            #endregion

            #region 2017/3/7

            //RepeatedSubstringPattern.RepeatedSubstringPatternFunc("abcabc");

            //PowerofFour.IsPowerOfFour(64);

            //ValidPerfectSquare.IsPerfectSquare(19);

            //NumberofSegmentsinaString.CountSegments("Hello");

            //ArrangingCoins.ArrangeCoins(8);

            #endregion

            #region 2017/3/8 

            //Happy Women's Day

            //ValidParentheses.IsValid("(abc))");

            //WordPattern.WordPatternFunc("aaaa", "dog dog dog dog");

            //LengthofLastWord.LengthOfLastWord("Hello World");

            //AddBinary.AddBinaryFunc("11", "1");

            //ThirdMaximumNumber.ThirdMax(new int[3] { 3, 2, 1 });

            #endregion

            #region 2017/3/9

            //ExcelSheetColumnTitle.ConvertToTitle(53);

            //string result = EncodeandDecodeTinyURL.encode("http://10.10.2.4:8080/secure/Dashboard.jspa");
            //string result = EncodeandDecodeTinyURL.decode("http://tinyurl.com/732764945");

            //FindAllDuplicatesinanArray.FindDuplicates(new int[8] { 4, 3, 2, 7, 8, 2, 3, 1 });

            //SingleNumberIII.SingleNumber(new int[6] { 1, 2, 1, 3, 2, 5 });

            #endregion

            #region 2017/3/10

            //LicenseKeyFormatting.LicenseKeyFormattingFunc("2-4A0r7-4k", 2);

            //Permutations.PermuteFunc(new int[] { 1, 2, 3 });

            //DecodeString.DecodeStringFunc("3[a]2[bc]");

            //GrayCode.grayCode(2);

            //RotateImage.Rotate(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });

            #endregion

            #region 2017/3/13

            //ReverseWordsinaString.ReverseWords("the sky is blue");

            //RestoreIPAddresses.RestoreIpAddressesFunc("25525511135");

            //LargestNumber.LargestNumberFunc(new int[] { 30, 30, 34, 5, 9 });

            //ValidateIPAddress.ValidIPAddressFunc("256.256.256.256");

            //SudokuSolver.solve(null);

            #endregion

            #region 2017/3/14

            //HammingDistance.HammingDistanceFunc(1, 4);

            //NextGreaterElementI.NextGreaterElement(new int[2] { 2, 4 }, new int[4] { 1, 2, 3, 4 });

            //SingleNumber.SingleNumberFunc(new int[7] { 3, 7, 9, 7, 6, 6, 9 });

            //SumofTwoIntegers.GetSum(3, 5);

            //MoveZeroes.MoveZeroesFunc(new int[7] { 3, 7, 0, 7, 6, 6, 9 });

            #endregion

            #region 2017/3/15

            //RansomNote.CanConstruct("aa", "ab");

            //Base7.ConvertToBase7(100);

            //FirstUniqueCharacterinaString.FirstUniqChar("eee");

            //MajorityElement.MajorityElementFunc(new int[7] { 7, 7, 7, 7, 6, 6, 9 });

            //ValidAnagram.IsAnagram("rat", "car");

            #endregion

            #region 2017/3/17

            //LongestPalindrome.LongestPalindromeFunc("abccccdda");

            //ContainsDuplicate.ContainsDuplicateFunc(new int[7] { 8, 7, 6, 5, 4, 2, 1 });

            //RomantoInteger.RomanToInt("XLMD");

            //AddStrings.AddStringsFunc("123", "123");

            //PowerofTwo.IsPowerOfTwo(16);

            #endregion

            #region 2017/3/20

            //PowerofThree.IsPowerOfThree(27);

            //SearchInsertPosition.SearchInsert(new int[7] { 1, 3, 4, 5, 6, 7, 8 }, 3);

            //ReverseVowelsofaString.ReverseVowels("leetcode");

            //FactorialTrailingZeroes.TrailingZeroes(100);

            //PalindromeNumber.IsPalindrome(12121);

            #endregion

            #region 2017/3/21

            //SortCharactersByFrequency.FrequencySort("Aabb");

            //ProductofArrayExceptSelf.ProductExceptSelf(new int[4] { 1, 2, 3, 4 });

            //TopKFrequentElements.TopKFrequent(new int[6] { 1, 1, 1, 2, 2, 3 }, 2);

            //IntegerBreak.IntegerBreakFunc(10);

            //IsSubsequence.IsSubsequenceFunc("axc", "ahbgdc");

            #endregion

            #region 2017/3/22

            //GenerateParentheses.GenerateParenthesis(3);

            //LexicographicalNumbers.LexicalOrder(101);

            #endregion

            #endregion
        }
    }
}
