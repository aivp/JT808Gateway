using JT808.Protocol;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Gateway.Client
{
    public interface IJT808MessageConsumer
    {
        public void Consumer(JT808HeaderPackage message);
    }
}
