using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presso
{
    public class NewLockObject
    {
        public NewLockObject()
        {
            //https://okyrylchuk.dev/blog/whats-new-in-charp13/
        }
    }

    public class NewLock
    {
        private readonly Lock _lockObj = new();
        private static int sharedResource = 0;

        public void IncrementResource()
        {
            using (_lockObj.EnterScope())
            {
                sharedResource++;
            }
        }
    }

    public class OldLock
    {
        private readonly object _lockObj = new();
        private static int sharedResource = 0;

        public void IncrementResource()
        {
            lock (_lockObj)
            {
                sharedResource++;
            }
        }
    }


}
