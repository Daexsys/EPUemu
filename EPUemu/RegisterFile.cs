using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPUemu
{
    public enum Register { ProgramCounter, StackPointer, BasePointer, r0, r1, r2, r3, r4, r5, r6, r7 }

    public class RegisterFile
    {
        public ushort programCounter { get; set; }
        public ushort stackPointer { get; set; }
        public ushort basePointer { get; set; }
        public ushort r0 { get; set; }
        public ushort r1 { get; set; }
        public ushort r2 { get; set; }
        public ushort r3 { get; set; }
        public ushort r4 { get; set; }
        public ushort r5 { get; set; }
        public ushort r6 { get; set; }
        public ushort r7 { get; set; }

        public bool overflow { get; set; }
        public bool carry { get; set; }

        public RegisterFile()
        {
            initializeRegisters();
        }

        public void initializeRegisters() {
            this.programCounter = 0;
            this.stackPointer = 0;
            this.basePointer = 0;
            this.r0 = 0;
            this.r1 = 0;
            this.r2 = 0;
            this.r3 = 0;
            this.r4 = 0;
            this.r5 = 0;
            this.r6 = 0;
            this.r7 = 0;
        }
    }
}
