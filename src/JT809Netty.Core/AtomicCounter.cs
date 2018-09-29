﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace JT809Netty.Core
{
    /// <summary>
    /// 
    /// ref:Grpc.Core.Internal
    /// </summary>
    public class AtomicCounter
    {
        long counter = 0;

        public AtomicCounter(long initialCount = 0)
        {
            this.counter = initialCount;
        }

        public long Increment()
        {
            return Interlocked.Increment(ref counter);
        }

        public long Decrement()
        {
            return Interlocked.Decrement(ref counter);
        }

        public long Count
        {
            get
            {
                return Interlocked.Read(ref counter);
            }
        }
    }
}
