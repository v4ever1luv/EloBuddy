﻿using EloBuddy.SDK;

namespace Kitelyn.Modes
{
    public abstract class ModeBase
    {
        // Change the spell type to whatever type you used in the SpellManager
        // here to have full features of that spells, if you don't need that,
        // just change it to Spell.SpellBase, this way it's dynamic with still
        // the most needed functions
        protected Spell.Skillshot Q
        {
            get { return SpellManager.Q; }
        }
        protected Spell.Skillshot W
        {
            get { return SpellManager.W; }
        }
        protected Spell.Skillshot E
        {
            get { return SpellManager.E; }
        }
        protected Spell.Targeted R
        {
            get { return SpellManager.R; }
        }
        protected Spell.Active heal
        {
            get { return SpellManager.heal; }
        }
        protected Spell.Targeted Ignite
        {
            get { return SpellManager.ignite; }
        }
        public abstract bool ShouldBeExecuted();

        public abstract void Execute();
    }
}
