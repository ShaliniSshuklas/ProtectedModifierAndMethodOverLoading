using System;

namespace InternalAndProtectedInternalModifier
{
    public class Internal
    {
        private int _privateId;
        protected int _protectedId;
        internal int _internalId;
        protected internal int _protectedInternalId;
        public int _publicid;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Internal obj = new Internal();
            obj._internalId = 123;
            obj._protectedInternalId = 123;
            obj._publicid = 123;
        }
    }
}
