﻿using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace Asimov
{
    public class CompProperties_WirelessCharger : CompProperties
    {
        public CompProperties_WirelessCharger()
        {
            compClass = typeof(Comp_WirelessCharger);
        }

        public float range = 0f;

        public bool mapWide = false;
        public bool worldWide = false;
    }
}
