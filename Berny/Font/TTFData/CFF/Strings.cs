﻿// MIT License
// 
// Copyright (c) 2020 Pixel Precision LLC
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PxPre
{
    namespace Berny
    {
        namespace CFF
        {
            /// <summary>
            /// The values strings in a CFF file.
            /// </summary>
            public class Strings
            {
                // The last predefined string in the CFF (5176.CFF) appendix (+1)
                const int StdNStrings = 391;

                /// <summary>
                /// Standard CFF string values. There as Strings.StdNStrings values in
                /// here, and are expected to be shared and reused between all implementations
                /// of CFF fonts.
                /// </summary>
                public static readonly string[] StandardStrings =
                    new string[]
                    {
                        ".notdef",
                        "space",
                        "exclam",
                        "quotedbl",
                        "numbersign",
                        "dollar",
                        "percent",
                        "ampersand",
                        "quoteright",
                        "parenleft",
                        "parenright",
                        "asterisk",
                        "plus",
                        "comma",
                        "hyphen",
                        "period",
                        "slash",
                        "zero",
                        "one",
                        "two",
                        "three",
                        "four",
                        "five",
                        "six",
                        "seven",
                        "eight",
                        "nine",
                        "colon",
                        "semicolon",
                        "less",
                        "equal",
                        "greater",
                        "question",
                        "at",
                        "A",
                        "B",
                        "C",
                        "D",
                        "E",
                        "F",
                        "G",
                        "H",
                        "I",
                        "J",
                        "K",
                        "L",
                        "M",
                        "N",
                        "O",
                        "P",
                        "Q",
                        "R",
                        "S",
                        "T",
                        "U",
                        "V",
                        "W",
                        "X",
                        "Y",
                        "Z",
                        "bracketleft",
                        "backslash",
                        "bracketright",
                        "AppendixAStandardStrings(18Mar98)",
                        "asciicircum",
                        "underscore",
                        "quoteleft",
                        "a",
                        "b",
                        "c",
                        "d",
                        "e",
                        "f",
                        "g",
                        "h",
                        "i",
                        "j",
                        "k",
                        "l",
                        "m",
                        "n",
                        "o",
                        "p",
                        "q",
                        "r",
                        "s",
                        "t",
                        "u",
                        "v",
                        "w",
                        "x",
                        "y",
                        "z",
                        "braceleft",
                        "bar",
                        "braceright",
                        "asciitilde",
                        "exclamdown",
                        "cent",
                        "sterling",
                        "fraction",
                        "yen",
                        "florin",
                        "section",
                        "currency",
                        "quotesingle",
                        "quotedblleft",
                        "guillemotleft",
                        "guilsinglleft",
                        "guilsinglright",
                        "fi",
                        "fl",
                        "endash",
                        "dagger",
                        "daggerdbl",
                        "periodcentered",
                        "paragraph",
                        "bullet",
                        "quotesinglbase",
                        "quotedblbase",
                        "quotedblright",
                        "guillemotright",
                        "ellipsis",
                        "perthousand",
                        "questiondown",
                        "grave",
                        "acute",
                        "circumflex",
                        "tilde",
                        "macron",
                        "breve",
                        "dotaccent",
                        "dieresis",
                        "ring",
                        "cedilla",
                        "hungarumlaut",
                        "ogonek",
                        "caron",
                        "emdash",
                        "AE",
                        "ordfeminine",
                        "Lslash",
                        "Oslash",
                        "OE",
                        "ordmasculine",
                        "ae",
                        "dotlessi",
                        "lslash",
                        "oslash",
                        "oe",
                        "germandbls",
                        "onesuperior",
                        "logicalnot",
                        "mu",
                        "trademark",
                        "Eth",
                        "onehalf",
                        "plusminus",
                        "Thorn",
                        "onequarter",
                        "divide",
                        "brokenbar",
                        "degree",
                        "thorn",
                        "threequarters",
                        "twosuperior",
                        "registered",
                        "minus",
                        "eth",
                        "multiply",
                        "threesuperior",
                        "copyright",
                        "Aacute",
                        "Acircumflex",
                        "Adieresis",
                        "Agrave",
                        "Aring",
                        "Atilde",
                        "Ccedilla",
                        "Eacute",
                        "Ecircumflex",
                        "Edieresis",
                        "Egrave",
                        "Iacute",
                        "Icircumflex",
                        "Idieresis",
                        "Igrave",
                        "Ntilde",
                        "Oacute",
                        "Ocircumflex",
                        "Odieresis",
                        "Ograve",
                        "Otilde",
                        "Scaron",
                        "Uacute",
                        "Ucircumflex",
                        "Udieresis",
                        "Ugrave",
                        "Yacute",
                        "Ydieresis",
                        "Zcaron",
                        "aacute",
                        "acircumflex",
                        "adieresis",
                        "agrave",
                        "aring",
                        "atilde",
                        "ccedilla",
                        "eacute",
                        "ecircumflex",
                        "edieresis",
                        "egrave",
                        "iacute",
                        "icircumflex",
                        "idieresis",
                        "igrave",
                        "ntilde",
                        "oacute",
                        "ocircumflex",
                        "odieresis",
                        "ograve",
                        "otilde",
                        "scaron",
                        "uacute",
                        "ucircumflex",
                        "udieresis",
                        "ugrave",
                        "yacute",
                        "ydieresis",
                        "zcaron",
                        "exclamsmall",
                        "Hungarumlautsmall",
                        "dollaroldstyle",
                        "dollarsuperior",
                        "ampersandsmall",
                        "Acutesmall",
                        "parenleftsuperior",
                        "parenrightsuperior",
                        "twodotenleader",
                        "onedotenleader",
                        "zerooldstyle",
                        "oneoldstyle",
                        "twooldstyle",
                        "threeoldstyle",
                        "fouroldstyle",
                        "fiveoldstyle",
                        "sixoldstyle",
                        "sevenoldstyle",
                        "eightoldstyle",
                        "nineoldstyle",
                        "commasuperior",
                        "threequartersemdash",
                        "periodsuperior",
                        "questionsmall",
                        "asuperior",
                        "bsuperior",
                        "centsuperior",
                        "dsuperior",
                        "esuperior",
                        "isuperior",
                        "lsuperior",
                        "msuperior",
                        "nsuperior",
                        "osuperior",
                        "rsuperior",
                        "ssuperior",
                        "tsuperior",
                        "ff",
                        "ffi",
                        "ffl",
                        "parenleftinferior",
                        "parenrightinferior",
                        "Circumflexsmall",
                        "hyphensuperior",
                        "Gravesmall",
                        "Asmall",
                        "Bsmall",
                        "Csmall",
                        "Dsmall",
                        "Esmall",
                        "Fsmall",
                        "Gsmall",
                        "Hsmall",
                        "Ismall",
                        "Jsmall",
                        "Ksmall",
                        "Lsmall",
                        "Msmall",
                        "Nsmall",
                        "Osmall",
                        "Psmall",
                        "Qsmall",
                        "Rsmall",
                        "Ssmall",
                        "Tsmall",
                        "Usmall",
                        "Vsmall",
                        "Wsmall",
                        "Xsmall",
                        "Ysmall",
                        "Zsmall",
                        "colonmonetary",
                        "onefitted",
                        "rupiah",
                        "Tildesmall",
                        "exclamdownsmall",
                        "centoldstyle",
                        "Lslashsmall",
                        "Scaronsmall",
                        "Zcaronsmall",
                        "Dieresissmall",
                        "Brevesmall",
                        "Caronsmall",
                        "Dotaccentsmall",
                        "Macronsmall",
                        "figuredash",
                        "hypheninferior",
                        "Ogoneksmall",
                        "Ringsmall",
                        "Cedillasmall",
                        "questiondownsmall",
                        "oneeighth",
                        "threeeighths",
                        "fiveeighths",
                        "seveneighths",
                        "onethird",
                        "twothirds",
                        "zerosuperior",
                        "foursuperior",
                        "fivesuperior",
                        "sixsuperior",
                        "sevensuperior",
                        "eightsuperior",
                        "ninesuperior",
                        "zeroinferior",
                        "oneinferior",
                        "twoinferior",
                        "threeinferior",
                        "fourinferior",
                        "fiveinferior",
                        "sixinferior",
                        "seveninferior",
                        "eightinferior",
                        "nineinferior",
                        "centinferior",
                        "dollarinferior",
                        "periodinferior",
                        "commainferior",
                        "Agravesmall",
                        "Aacutesmall",
                        "Acircumflexsmall",
                        "Atildesmall",
                        "Adieresissmall",
                        "Aringsmall",
                        "AEsmall",
                        "Ccedillasmall",
                        "Egravesmall",
                        "Eacutesmall",
                        "Ecircumflexsmall",
                        "Edieresissmall",
                        "Igravesmall",
                        "Iacutesmall",
                        "Icircumflexsmall",
                        "Idieresissmall",
                        "Ethsmall",
                        "Ntildesmall",
                        "Ogravesmall",
                        "Oacutesmall",
                        "Ocircumflexsmall",
                        "Otildesmall",
                        "Odieresissmall",
                        "OEsmall",
                        "Oslashsmall",
                        "Ugravesmall",
                        "Uacutesmall",
                        "Ucircumflexsmall",
                        "Udieresissmall",
                        "Yacutesmall",
                        "Thornsmall",
                        "Ydieresissmall",
                        "001.000",
                        "001.001",
                        "001.002",
                        "001.003",
                        "Black",
                        "Bold",
                        "Book",
                        "Light",
                        "Medium",
                        "Regular",
                        "Roman",
                        "Semibold"
                    };

                /// <summary>
                /// Strings unique to a CFF file. 
                /// 
                /// Listed in the order they were parsed from a file.
                /// </summary>
                /// <remarks>Given a SID, if the SID value is greater than StdNStrings, the string is located 
                /// at index SID-StdNStrings</remarks>
                public List<string> uniqueStrings = new List<string>();

                /// <summary>
                /// Add a unique string.
                /// </summary>
                /// <param name="str">The unique string to store.</param>
                /// <returns>The SID of the string.</returns>
                public int Add(string str)
                { 
                    int ct = this.uniqueStrings.Count;
                    this.uniqueStrings.Add(str);
                    return StdNStrings + ct;
                }

                /// <summary>
                /// Get a string via SID.
                /// </summary>
                /// <param name="sid">The requested string ID.</param>
                /// <returns>The string, or error message.</returns>
                /// <remarks>Handles both unique values and standard string values.</remarks>
                public string GetString(int sid)
                {
                    if (sid == -1)
                        return "Value not set.";

                    if (sid < StdNStrings)
                        return StandardStrings[sid];

                    int idx = sid - StdNStrings;
                    if (idx < 0 || idx >= this.uniqueStrings.Count)
                        return "SID out of bounds.";

                    return this.uniqueStrings[idx];
                }

                /// <summary>
                /// Clear all stored unique strings.
                /// </summary>
                public void Clear()
                { 
                    this.uniqueStrings.Clear();
                }
            }
        }
    }
}