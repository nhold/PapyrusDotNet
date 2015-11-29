using System.Collections.Generic;
using PapyrusDotNet.PapyrusAssembly.Enums;

namespace PapyrusDotNet.PapyrusAssembly.Classes
{
    public class PapyrusInstructionOpCodeDescription
    {
        public int ParamSize { get; }
        public bool HasVariableArguments { get; }

        private static readonly Dictionary<PapyrusOpCode, PapyrusInstructionOpCodeDescription> Descriptions;

        public PapyrusInstructionOpCodeDescription(int paramSize, bool hasVariableArguments)
        {
            ParamSize = paramSize;
            HasVariableArguments = hasVariableArguments;
        }

        public static PapyrusInstructionOpCodeDescription FromOpCode(PapyrusOpCode opcode)
        {
            if (Descriptions.ContainsKey(opcode))
                return Descriptions[opcode];
            return null;
        }

        static PapyrusInstructionOpCodeDescription()
        {
            Descriptions = new Dictionary<PapyrusOpCode, PapyrusInstructionOpCodeDescription>();
            Descriptions.Add(PapyrusOpCode.Nop, new PapyrusInstructionOpCodeDescription(0, false));
            Descriptions.Add(PapyrusOpCode.Iadd, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.Fadd, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.Isub, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.Fsub, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.Imul, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.Fmul, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.Idiv, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.Fdiv, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.Imod, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.Not, new PapyrusInstructionOpCodeDescription(2, false));
            Descriptions.Add(PapyrusOpCode.Ineg, new PapyrusInstructionOpCodeDescription(2, false));
            Descriptions.Add(PapyrusOpCode.Fneg, new PapyrusInstructionOpCodeDescription(2, false));
            Descriptions.Add(PapyrusOpCode.Assign, new PapyrusInstructionOpCodeDescription(2, false));
            Descriptions.Add(PapyrusOpCode.Cast, new PapyrusInstructionOpCodeDescription(2, false));
            Descriptions.Add(PapyrusOpCode.CmpEq, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.CmpLt, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.CmpLte, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.CmpGt, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.CmpGte, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.Jmp, new PapyrusInstructionOpCodeDescription(1, false));
            Descriptions.Add(PapyrusOpCode.Jmpt, new PapyrusInstructionOpCodeDescription(2, false));
            Descriptions.Add(PapyrusOpCode.Jmpf, new PapyrusInstructionOpCodeDescription(2, false));
            Descriptions.Add(PapyrusOpCode.Callmethod, new PapyrusInstructionOpCodeDescription(3, true));
            Descriptions.Add(PapyrusOpCode.Callparent, new PapyrusInstructionOpCodeDescription(2, true));
            Descriptions.Add(PapyrusOpCode.Callstatic, new PapyrusInstructionOpCodeDescription(3, true));
            Descriptions.Add(PapyrusOpCode.Return, new PapyrusInstructionOpCodeDescription(1, false));
            Descriptions.Add(PapyrusOpCode.Strcat, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.Propget, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.Propset, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.ArrayCreate, new PapyrusInstructionOpCodeDescription(2, false));
            Descriptions.Add(PapyrusOpCode.ArrayLength, new PapyrusInstructionOpCodeDescription(2, false));
            Descriptions.Add(PapyrusOpCode.ArrayGetelement, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.ArraySetelement, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.ArrayFindelement, new PapyrusInstructionOpCodeDescription(4, false));
            //Descriptions.Add(PapyrusInstructionOpCodes.ArrayFindelement, new PapyrusInstructionOpCodeDescription(4, false));
            Descriptions.Add(PapyrusOpCode.Is, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.StructCreate, new PapyrusInstructionOpCodeDescription(1, false));
            Descriptions.Add(PapyrusOpCode.StructGet, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.StructSet, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.ArrayFindstruct, new PapyrusInstructionOpCodeDescription(5, false));
            Descriptions.Add(PapyrusOpCode.ArrayAddelements, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.ArrayInsertelement, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.ArrayRemovelastelement, new PapyrusInstructionOpCodeDescription(1, false));
            Descriptions.Add(PapyrusOpCode.ArrayRemoveelements, new PapyrusInstructionOpCodeDescription(3, false));
            Descriptions.Add(PapyrusOpCode.ArrayClearelements, new PapyrusInstructionOpCodeDescription(1, false));
        }
    }
}