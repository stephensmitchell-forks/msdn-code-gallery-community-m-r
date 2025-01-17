﻿// <copyright file="TrackEventArgs.cs" company="Microsoft Corporation">
// ===============================================================================
//
//
// Project: Microsoft Silverlight Rough Cut Editor
// FILES: BalanceEventArgs.cs                    
//
// ===============================================================================
// Copyright 2010 Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
// ===============================================================================
// </copyright>

namespace RCE.Modules.Timeline.Models
{
    using System;

    using RCE.Infrastructure.Models;

    public class TrackMuteEventArgs : EventArgs
    {
        public TrackMuteEventArgs(Track track)
        {
            this.Track = track;
        }

        public Track Track { get; private set; }
    }
}
