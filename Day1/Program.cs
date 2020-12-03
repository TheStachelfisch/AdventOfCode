﻿using System;

namespace Day1
{
    internal class Program
    {
        private static int[] _correctNumbersPartOne = new int[1];
        private static int _correctNumberPartOne;

        private static int[] _correctNumbersPartTwo = new int[2];
        private static int _correctNumberPartTwo;

        private const string NUMBERS = @"1939,1585,1712,1600,1370,1447,1247,1446,1323,1713,1277,1946,1677,1428,1231,1481,1976,1709,1508,1668,1302,77,1351,1605,1999,1982,1583,1756,1957,1624,1745,1938,1784,1403,1642,1691,569,1762,1555,1937,1383,1897,1334,1965,1683,1475,1776,1791,1707,1987,1233,1416,1769,1345,1874,1255,1744,1944,1404,1360,1304,1417,1977,1656,790,1788,1353,1296,1673,1810,1684,1742,1425,1887,1444,1352,1229,1414,1493,1402,1947,1669,1412,1531,1474,1637,1314,1607,1829,1923,1949,1757,1307,1714,1748,1550,1372,1615,1235,1272,1408,1749,1687,1613,1528,1561,341,1308,1660,1667,1313,1991,1675,1394,1704,1303,1440,1592,1857,1752,1839,1397,1699,1426,1878,1759,1814,1096,372,1596,1500,1774,1627,1696,1851,1020,1819,1292,1616,1672,1279,1543,1526,1682,1568,1582,1921,922,1773,1482,1238,1973,1517,1909,409,1634,1468,1445,1801,1631,1407,1820,1603,1495,1333,1241,1849,82,1339,1413,90,1662,1291,1740,1340,1365,2003,1546,1621,1650,1518,1807,1382,1433,1968,1940,1986,1437,1651,1237,1862,1409,1200,2002,2009,1735,1487,1706,1643,1505";

        private static void Main(string[] args)
        {
            int[] numbersArray = Array.ConvertAll(NUMBERS.Split(','), int.Parse);

            for (var i = 0; i < numbersArray.Length; i++)
                for (var j = 0; j < numbersArray.Length; j++)
                {
                    if (numbersArray[i] + numbersArray[j] == 2020)
                        _correctNumbersPartOne = new[] {numbersArray[i], numbersArray[j]};

                    for (var k = 0; k < numbersArray.Length; k++)
                        if (numbersArray[i] + numbersArray[j] + numbersArray[k] == 2020)
                            _correctNumbersPartTwo = new[] {numbersArray[i], numbersArray[j], numbersArray[k]};
                }

            _correctNumberPartOne = _correctNumbersPartOne[0] * _correctNumbersPartOne[1];
            _correctNumberPartTwo = _correctNumbersPartTwo[0] * _correctNumbersPartTwo[1] * _correctNumbersPartTwo[2];
            Console.WriteLine($"The Correct number for part 1 is {_correctNumberPartOne}\nThe Correct number for part 2 is {_correctNumberPartTwo}");
        }
    }
}