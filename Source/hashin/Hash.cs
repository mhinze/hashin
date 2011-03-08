using System;
using System.Dynamic;

namespace Hashin
{
    public class Hash : DynamicObject
    {
        public Hash(string hash) {}

        public dynamic to_mash()
        {
            return new Mash();
        }

        public Hash stringify_keys()
        {
            return null;
        }
    }
}