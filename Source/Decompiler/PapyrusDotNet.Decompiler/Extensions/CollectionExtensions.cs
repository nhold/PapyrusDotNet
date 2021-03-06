﻿//     This file is part of PapyrusDotNet.
// 
//     PapyrusDotNet is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     PapyrusDotNet is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with PapyrusDotNet.  If not, see <http://www.gnu.org/licenses/>.
//  
//     Copyright 2016, Karl Patrik Johansson, zerratar@gmail.com

#region

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace PapyrusDotNet.Decompiler.Extensions
{
    public static class CollectionExtensions
    {
        public static T Next<T>(this IEnumerable<T> collection, T item)
        {
            var array = collection.ToArray();
            var index = Array.IndexOf(array, item);
            if (index + 1 >= array.Length)
                //return array.Last();
                return default(T);
            return array[index + 1];
        }
    }
}