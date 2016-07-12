﻿
/* MlIB.Reply
 * https://github.com/LeandroMBarreto
 * http://www.codeproject.com/Members/LeandroMBarreto
 * 
 The MIT License (MIT)

Copyright (c) 2014-2016 LeandroMBarreto

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
 */

using System;
using System.Collections.Generic;
using MlIB;

namespace M
{
    /// <summary>
    /// Factory which provides easy shortcut to instantiate an Error object
    /// </summary>
    public static partial class Reply
    {
        public static readonly Version Version
        = new Version(0, //workflow version
                      1, //contract version
                      0, //feature version
                      0  //hotfix version
                      );

        public static Reply<T> NoError<T>(T value)
        {
            return new Reply<T>(value);
        }

        public static Reply<T> Error<T>(Enum error, T value)
        {
            return new Reply<T>(value, error);
        }

        public static Reply<T> Error<T>(Enum error, T value, string errorMessage = "")
        {
            return new Reply<T>(value, error, errorMessage);
        }

        public static Reply<T> Error<T>(string errorMessage, T value)
        {
            return new Reply<T>(value, errorMessage);
        }

    }

}
