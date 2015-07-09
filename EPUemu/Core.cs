
namespace EPUemu
{
    public enum Cache { Code, Data, Stack }

    public class Core
    {

        public byte[] codeCache { get; set; }
        public byte[] dataCache { get; set; }
        public byte[] stackCache { get; set; }

        public RegisterFile registerFile { get; set; }

        public Core()
        {
            this.codeCache = new byte[8192];
            this.dataCache = new byte[8192];
            this.stackCache = new byte[8192];

            this.registerFile = new RegisterFile();
        }

        public byte readCache(Cache cache, ushort address)
        {
            if (address >= 8192)
                return 0;
            if (cache == Cache.Data)
                return this.dataCache[address];
            else if (cache == Cache.Code)
                return this.codeCache[address];
            else if (cache == Cache.Stack)
                return this.stackCache[address];
            else return 0;
        }

        public void writeCache(Cache cache, ushort address, byte data) {
            if (!(address >= 8192))
            {
                if (cache == Cache.Data)
                    this.dataCache[address] = data;
                else if (cache == Cache.Code)
                    this.codeCache[address] = data;
                else if (cache == Cache.Stack && address < 4092)
                    this.stackCache[address] = data;
            }
        }

        public string[] getFormattedCache(Cache cache)
        {
            string[] entries;

            if (cache == Cache.Data)
            {
                entries = new string[8192];
                for (ushort i = 0; i < 8192; i++)
                    entries[i] = " " + NumberHelper.shortToHex(i) + " | " + NumberHelper.byteToHex(dataCache[i]);
            }
            else if (cache == Cache.Code)
            {
                entries = new string[8192];
                for (ushort i = 0; i < 8192; i++)
                    entries[i] = " " + NumberHelper.shortToHex(i) + " | " + NumberHelper.byteToHex(codeCache[i]);
            }
            else if (cache == Cache.Stack)
            {
                entries = new string[4096];
                for (ushort i = 0; i < 4096; i++)
                    entries[i] = " " + NumberHelper.shortToHex(i) + " | " + NumberHelper.shortToHex(stackCache[i]);
            }
            else entries = null;

            return entries;
        }

        public void pushToStack(ushort immediate)
        {
            this.stackCache[this.registerFile.stackPointer] = (byte)(immediate >> 8);
            this.stackCache[this.registerFile.stackPointer + 1] = (byte)(immediate & 0xFF);
            this.registerFile.stackPointer += 2;
        }

        public void pushToStack(Register register)
        {
            switch (register)
            {
                case Register.ProgramCounter:
                    pushToStack(this.registerFile.programCounter); break;
                case Register.StackPointer:
                    pushToStack(this.registerFile.stackPointer); break;
                case Register.BasePointer:
                    pushToStack(this.registerFile.basePointer); break;
                case Register.r0:
                    pushToStack(this.registerFile.r0); break;
                case Register.r1:
                    pushToStack(this.registerFile.r1); break;
                case Register.r2:
                    pushToStack(this.registerFile.r2); break;
                case Register.r3:
                    pushToStack(this.registerFile.r3); break;
                case Register.r4:
                    pushToStack(this.registerFile.r4); break;
                case Register.r5:
                    pushToStack(this.registerFile.r5); break;
                case Register.r6:
                    pushToStack(this.registerFile.r6); break;
                case Register.r7:
                    pushToStack(this.registerFile.r7); break;
            }
        }

        public void popFromStack(Register register)
        {
            ushort value;
            this.registerFile.stackPointer -= 2;
            value = (ushort)(this.stackCache[this.registerFile.stackPointer]);
            value = (ushort)(value << 8);
            value = (ushort)(value & this.stackCache[this.registerFile.stackPointer + 1]);

            switch (register)
            {
                case Register.ProgramCounter:
                    this.registerFile.programCounter = value; break;
                case Register.StackPointer:
                    this.registerFile.stackPointer = value; break;
                case Register.BasePointer:
                    this.registerFile.basePointer = value; break;
                case Register.r0:
                    this.registerFile.r0 = value; break;
                case Register.r1:
                    this.registerFile.r1 = value; break;
                case Register.r2:
                    this.registerFile.r2 = value; break;
                case Register.r3:
                    this.registerFile.r3 = value; break;
                case Register.r4:
                    this.registerFile.r4 = value; break;
                case Register.r5:
                    this.registerFile.r5 = value; break;
                case Register.r6:
                    this.registerFile.r6 = value; break;
                case Register.r7:
                    this.registerFile.r7 = value; break;
            }
            this.registerFile.stackPointer--;
        }

        public void step()
        {
            //
        }
    }
}
