﻿/*
 * This file is part of alphaTab.
 * Copyright (c) 2014, Daniel Kuschny and Contributors, All rights reserved.
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3.0 of the License, or at your option any later version.
 * 
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library.
 */

using AlphaTab.Model;

namespace AlphaTab.Rendering
{
    /// <summary>
    /// This is the base public class for creating factories providing BarRenderers
    /// </summary>
    public abstract class BarRendererFactory
    {
        public bool IsInAccolade { get; set; }
        public bool HideOnMultiTrack { get; set; }
        public bool HideOnPercussionTrack { get; set; }

        protected BarRendererFactory()
        {
            IsInAccolade = true;
            HideOnMultiTrack = false;
            HideOnPercussionTrack = false;
        }

        public virtual bool CanCreate(Track track)
        {
            return !HideOnPercussionTrack || !track.IsPercussion;
        }
        public abstract BarRendererBase Create(Bar bar);
    }
}
