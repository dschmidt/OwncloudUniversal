﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwncloudUniversal.Synchronization.Model
{
    public enum SyncResult
    {
        Sent,
        Received,
        Deleted,
        Moved,
        Renamed,
        Ignored,
        Failed
    }
}
