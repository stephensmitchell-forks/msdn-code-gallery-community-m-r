﻿// <copyright file="AssetsAvailableEvent.cs" company="Microsoft Corporation">
// ===============================================================================
//
//
// Project: Microsoft Silverlight Rough Cut Editor
// FILES: AssetsAvailableEvent.cs                     
//
// ===============================================================================
// Copyright 2010 Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
// ===============================================================================
// </copyright>

namespace RCE.Infrastructure.Events
{
    using System.Collections.Generic;
    using Microsoft.Practices.Composite.Presentation.Events;
    using Models;

    /// <summary>
    /// Defines a class that manages publication and subscription to <see cref="AssetsAvailableEvent"/>.
    /// </summary>
    public class AssetsAvailableEvent : CompositePresentationEvent<DataEventArgs<List<Asset>>>
    {
    }
}
