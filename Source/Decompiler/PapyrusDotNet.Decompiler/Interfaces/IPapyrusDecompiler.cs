﻿//     This file is part of PapyrusDotNet.
//     But is a port of Champollion, https://github.com/Orvid/Champollion
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
//     Copyright © 2016, Karl Patrik Johansson, zerratar@gmail.com
//     Copyright © 2015, Orvid King
//     Copyright © 2013, Paul-Henry Perrin

#region

using System.Collections.Generic;
using PapyrusDotNet.PapyrusAssembly;

#endregion

namespace PapyrusDotNet.Decompiler.Interfaces
{
    public interface IPapyrusDecompiler
    {
        /// <summary>
        ///     Creates the context.
        /// </summary>
        /// <returns></returns>
        IDecompilerContext CreateContext();

        /// <summary>
        ///     Decompiles the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        IPapyrusDecompilerResult Decompile(IDecompilerContext context);

        /// <summary>
        ///     Decompiles the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="method">The method.</param>
        /// <returns></returns>
        IPapyrusDecompilerResult Decompile(IDecompilerContext context, PapyrusMethodDefinition method);

        /// <summary>
        ///     Merges the results.
        /// </summary>
        /// <param name="methodResults">The results.</param>
        /// <returns></returns>
        IPapyrusDecompilerResult MergeResults(IEnumerable<IPapyrusDecompilerResult> methodResults);
    }
}