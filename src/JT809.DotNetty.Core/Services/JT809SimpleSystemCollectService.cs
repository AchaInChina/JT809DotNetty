﻿using JT809.DotNetty.Abstractions.Dtos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace JT809.DotNetty.Core.Services
{
    /// <summary>
    /// 简单系统收集服务
    /// </summary>
    public class JT809SimpleSystemCollectService
    {
        /// <summary>
        /// 获取系统当前进程使用情况
        /// </summary>
        /// <returns></returns>
        public JT809SystemCollectInfoDto Get()
        {
            JT809SystemCollectInfoDto jT808SystemCollectInfoDto = new JT809SystemCollectInfoDto();
            var proc = Process.GetCurrentProcess();
            jT808SystemCollectInfoDto.ProcessId = proc.Id;
            jT808SystemCollectInfoDto.WorkingSet64 = proc.WorkingSet64 / 1024.0 / 1024.0;
            jT808SystemCollectInfoDto.PeakWorkingSet64 = proc.PeakWorkingSet64 / 1024.0 / 1024.0;
            jT808SystemCollectInfoDto.PrivateMemorySize64 = proc.PrivateMemorySize64 / 1024.0 / 1024.0;
            jT808SystemCollectInfoDto.CPUTotalProcessorTime = proc.TotalProcessorTime;
            return jT808SystemCollectInfoDto;
        }
    }
}
