/*
    This file is part of PapyrusDotNet.

    PapyrusDotNet is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    PapyrusDotNet is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with PapyrusDotNet.  If not, see <http://www.gnu.org/licenses/>.
	
	Copyright 2015, Karl Patrik Johansson, zerratar@gmail.com
 */

using System.Collections.Generic;

namespace PapyrusDotNet.CoreBuilder.Papyrus.Assembly
{
    public class PapyrusAssemblyObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ExtendsName { get; set; }
        // public PapyrusAsmObject Extends { get; set; }
        public List<PapyrusAssemblyVariable> VariableTable { get; private set; } = new List<PapyrusAssemblyVariable>();
        public List<PapyrusAssemblyVariable> PropertyTable { get; private set; } = new List<PapyrusAssemblyVariable>();
        public List<PapyrusAssemblyState> States { get; private set; } = new List<PapyrusAssemblyState>();

        public PapyrusAssemblyObject()
        {
        }
    }
}