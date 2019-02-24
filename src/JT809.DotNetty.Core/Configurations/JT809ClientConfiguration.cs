﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace JT809.DotNetty.Core.Configurations
{
    public class JT809ClientConfiguration
    {
        public string Host { get; set; }

        public int Port { get; set; }

        private EndPoint endPoint;

        public EndPoint EndPoint
        {
            get
            {
                if (endPoint == null)
                {
                    if (IPAddress.TryParse(Host, out IPAddress ip))
                    {
                        endPoint = new IPEndPoint(ip, Port);
                    }
                }
                return endPoint;
            }
        }
    }
}
