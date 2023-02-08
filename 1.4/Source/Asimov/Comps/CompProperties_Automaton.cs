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
    public class CompProperties_Automaton : CompProperties
    {
        public CompProperties_Automaton()
        {
            compClass = typeof(Comp_Automaton);
        }

        public List<WorkTypeDef> enabledWorkTypes = new List<WorkTypeDef>();

        public List<SkillLevelSetting> skillSettings = new List<SkillLevelSetting>();

        public bool noSkillLoss = true;

        public bool noSkillGain = true;
        public float skillGainMulti = 1f;

        public bool canSocialize = false;

        public bool deathMatters = false;

        public bool corpseEdible = false;

        public bool corpseRots = false;

        public List<ThingDef> repairThings = new List<ThingDef>();
    }
}
