﻿using System;
using System.Collections.Generic;
using System.Linq;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;
using SharpDX;

namespace OKTRAIO.Database.Spell_Library
{
    #region Skillshot spells
    public static class SpellDatabase
    {
        public static List<Spell> Spells = new List<Spell>();

        static SpellDatabase()
        {
            #region Aatrox

            Spells.Add(
                new Spell
                {
                    ChampionName = "Aatrox",
                    SpellName = "AatroxQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Circular,
                    Delay = 600,
                    Range = 650,
                    Radius = 250,
                    MissileSpeed = 2000,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = ""
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Aatrox",
                    SpellName = "AatroxE",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1075,
                    Radius = 35,
                    MissileSpeed = 1250,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = false,
                    MissileSpellName = "AatroxEConeMissile"
                });

            #endregion Aatrox

            #region Ahri

            Spells.Add(
                new Spell
                {
                    ChampionName = "Ahri",
                    SpellName = "AhriOrbofDeception",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1000,
                    Radius = 100,
                    MissileSpeed = 2500,
                    MissileAccel = -3200,
                    MissileMaxSpeed = 2500,
                    MissileMinSpeed = 400,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "AhriOrbMissile",
                    CanBeRemoved = true,
                    ForceRemove = true,
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Ahri",
                    SpellName = "AhriOrbReturn",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1000,
                    Radius = 100,
                    MissileSpeed = 60,
                    MissileAccel = 1900,
                    MissileMinSpeed = 60,
                    MissileMaxSpeed = 2600,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileFollowsUnit = true,
                    CanBeRemoved = true,
                    ForceRemove = true,
                    MissileSpellName = "AhriOrbReturn",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Ahri",
                    SpellName = "AhriSeduce",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1000,
                    Radius = 60,
                    MissileSpeed = 1550,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "AhriSeduceMissile",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            #endregion Ahri

            #region Amumu

            Spells.Add(
                new Spell
                {
                    ChampionName = "Amumu",
                    SpellName = "BandageToss",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1100,
                    Radius = 90,
                    MissileSpeed = 2000,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "SadMummyBandageToss",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Amumu",
                    SpellName = "CurseoftheSadMummy",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 0,
                    Radius = 550,
                    MissileSpeed = int.MaxValue,
                    FixedRange = true,
                    AddHitbox = false,
                    DangerValue = 5,
                    IsDangerous = true,
                    MissileSpellName = ""
                });

            #endregion Amumu

            #region Anivia

            Spells.Add(
                new Spell
                {
                    ChampionName = "Anivia",
                    SpellName = "FlashFrost",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1100,
                    Radius = 110,
                    MissileSpeed = 850,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "FlashFrostSpell",
                    CanBeRemoved = true,
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Anivia

            #region Annie

            Spells.Add(
                new Spell
                {
                    ChampionName = "Annie",
                    SpellName = "Incinerate",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Cone,
                    Delay = 250,
                    Range = 825,
                    Radius = 80,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = false,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = ""
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Annie",
                    SpellName = "InfernalGuardian",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 600,
                    Radius = 251,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 5,
                    IsDangerous = true,
                    MissileSpellName = ""
                });

            #endregion Annie

            #region Ashe

            Spells.Add(
                new Spell
                {
                    ChampionName = "Ashe",
                    SpellName = "Volley",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1250,
                    Radius = 60,
                    MissileSpeed = 1500,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "VolleyAttack",
                    MultipleNumber = 9,
                    MultipleAngle = 4.62f * (float)Math.PI / 180,
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.YasuoWall,
                            Spell.CollisionObjectTypes.Minion
                        }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Ashe",
                    SpellName = "EnchantedCrystalArrow",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 20000,
                    Radius = 130,
                    MissileSpeed = 1600,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 5,
                    IsDangerous = true,
                    MissileSpellName = "EnchantedCrystalArrow",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[] { Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Ashe

            #region Bard

            Spells.Add(
                new Spell
                {
                    ChampionName = "Bard",
                    SpellName = "BardQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 950,
                    Radius = 60,
                    MissileSpeed = 1600,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "BardQMissile",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[] { Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Bard",
                    SpellName = "BardR",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Circular,
                    Delay = 500,
                    Range = 3400,
                    Radius = 350,
                    MissileSpeed = 2100,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "BardR"
                });

            #endregion

            #region Blatzcrink

            Spells.Add(
                new Spell
                {
                    ChampionName = "Blitzcrank",
                    SpellName = "RocketGrab",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1050,
                    Radius = 70,
                    MissileSpeed = 1800,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 4,
                    IsDangerous = true,
                    MissileSpellName = "RocketGrabMissile",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Blitzcrank",
                    SpellName = "StaticField",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 0,
                    Radius = 600,
                    MissileSpeed = int.MaxValue,
                    FixedRange = true,
                    AddHitbox = false,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = ""
                });

            #endregion Blatzcrink

            #region Brand

            Spells.Add(
                new Spell
                {
                    ChampionName = "Brand",
                    SpellName = "BrandBlaze",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1100,
                    Radius = 60,
                    MissileSpeed = 1600,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "BrandBlazeMissile",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Brand",
                    SpellName = "BrandFissure",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Circular,
                    Delay = 850,
                    Range = 900,
                    Radius = 240,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = ""
                });

            #endregion Brand

            #region Braum

            Spells.Add(
                new Spell
                {
                    ChampionName = "Braum",
                    SpellName = "BraumQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1050,
                    Radius = 60,
                    MissileSpeed = 1700,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "BraumQMissile",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Braum",
                    SpellName = "BraumRWrapper",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 500,
                    Range = 1200,
                    Radius = 115,
                    MissileSpeed = 1400,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 4,
                    IsDangerous = true,
                    MissileSpellName = "braumrmissile",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Braum

            #region Caitlyn

            Spells.Add(
                new Spell
                {
                    ChampionName = "Caitlyn",
                    SpellName = "CaitlynPiltoverPeacemaker",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 625,
                    Range = 1300,
                    Radius = 90,
                    MissileSpeed = 2200,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "CaitlynPiltoverPeacemaker",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Caitlyn",
                    SpellName = "CaitlynEntrapment",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 125,
                    Range = 1000,
                    Radius = 80,
                    MissileSpeed = 2000,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 1,
                    IsDangerous = false,
                    MissileSpellName = "CaitlynEntrapmentMissile",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

             Spells.Add(
                new Spell
                {
                    ChampionName = "Caitlyn",
                    SpellName = "CaitlynAceintheHole",
                    IsInterruptableSpell = true,
                    DangerLevel = Spell.InterruptableDangerLevel.High,
                    Slot = SpellSlot.R,
                    BuffName = "CaitlynAceintheHole",
                    ExtraDuration = 600
                });
            #endregion Caitlyn

            #region Cassiopeia

            Spells.Add(
                new Spell
                {
                    ChampionName = "Cassiopeia",
                    SpellName = "CassiopeiaNoxiousBlast",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Circular,
                    Delay = 750,
                    Range = 850,
                    Radius = 150,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "CassiopeiaNoxiousBlast"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Cassiopeia",
                    SpellName = "CassiopeiaMiasma",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Circular,
                    Delay = 500,
                    Range = 850,
                    Radius = 150,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "CassiopeiaMiasma"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Cassiopeia",
                    SpellName = "CassiopeiaPetrifyingGaze",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Cone,
                    Delay = 600,
                    Range = 825,
                    Radius = 80,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = false,
                    DangerValue = 5,
                    IsDangerous = true,
                    MissileSpellName = "CassiopeiaPetrifyingGaze"
                });

            #endregion Cassiopeia

            #region Chogath

            Spells.Add(
                new Spell
                {
                    ChampionName = "Chogath",
                    SpellName = "Rupture",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Circular,
                    Delay = 1200,
                    Range = 950,
                    Radius = 250,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = false,
                    MissileSpellName = "Rupture"
                });

            #endregion Chogath

            #region Corki

            Spells.Add(
                new Spell
                {
                    ChampionName = "Corki",
                    SpellName = "PhosphorusBomb",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Circular,
                    Delay = 300,
                    Range = 825,
                    Radius = 250,
                    MissileSpeed = 1000,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "PhosphorusBombMissile",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Corki",
                    SpellName = "MissileBarrage",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 200,
                    Range = 1300,
                    Radius = 40,
                    MissileSpeed = 2000,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "MissileBarrageMissile",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Corki",
                    SpellName = "MissileBarrage2",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 200,
                    Range = 1500,
                    Radius = 40,
                    MissileSpeed = 2000,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "MissileBarrageMissile2",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            #endregion Corki

            #region Darius

            Spells.Add(
                new Spell
                {
                    ChampionName = "Darius",
                    SpellName = "DariusCleave",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Circular,
                    Delay = 750,
                    Range = 0,
                    Radius = 425,
                    MissileSpeed = int.MaxValue,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = false,
                    MissileSpellName = "DariusCleave",
                    FollowCaster = true,
                    DisabledByDefault = true
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Darius",
                    SpellName = "DariusAxeGrabCone",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Cone,
                    Delay = 250,
                    Range = 550,
                    Radius = 80,
                    MissileSpeed = int.MaxValue,
                    FixedRange = true,
                    AddHitbox = false,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "DariusAxeGrabCone"
                });

            #endregion Darius

            #region DrMundo

            Spells.Add(
                new Spell
                {
                    ChampionName = "DrMundo",
                    SpellName = "InfectedCleaverMissileCast",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1050,
                    Radius = 60,
                    MissileSpeed = 2000,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = false,
                    MissileSpellName = "InfectedCleaverMissile",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            #endregion DrMundo

            #region Draven

            Spells.Add(
                new Spell
                {
                    ChampionName = "Draven",
                    SpellName = "DravenDoubleShot",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1100,
                    Radius = 130,
                    MissileSpeed = 1400,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "DravenDoubleShotMissile",
                    CanBeRemoved = true,
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Draven",
                    SpellName = "DravenRCast",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 400,
                    Range = 20000,
                    Radius = 160,
                    MissileSpeed = 2000,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 5,
                    IsDangerous = true,
                    MissileSpellName = "DravenR",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Draven

            #region Ekko

            Spells.Add(
                new Spell
                {
                    ChampionName = "Ekko",
                    SpellName = "EkkoQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 950,
                    Radius = 60,
                    MissileSpeed = 1650,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 4,
                    IsDangerous = true,
                    MissileSpellName = "ekkoqmis",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[] { Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Ekko",
                    SpellName = "EkkoW",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Circular,
                    Delay = 3750,
                    Range = 1600,
                    Radius = 375,
                    MissileSpeed = 1650,
                    FixedRange = false,
                    DisabledByDefault = true,
                    AddHitbox = false,
                    DangerValue = 3,
                    IsDangerous = false,
                    MissileSpellName = "EkkoW",
                    CanBeRemoved = true
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Ekko",
                    SpellName = "EkkoR",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 1600,
                    Radius = 375,
                    MissileSpeed = 1650,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = false,
                    MissileSpellName = "EkkoR",
                    CanBeRemoved = true,
                    FromObjects = new[] { "Ekko_Base_R_TrailEnd.troy" }
                });

            #endregion Ekko

            #region Elise

            Spells.Add(
                new Spell
                {
                    ChampionName = "Elise",
                    SpellName = "EliseHumanE",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1100,
                    Radius = 55,
                    MissileSpeed = 1600,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 4,
                    IsDangerous = true,
                    MissileSpellName = "EliseHumanE",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            #endregion Elise

            #region Evelynn

            Spells.Add(
                new Spell
                {
                    ChampionName = "Evelynn",
                    SpellName = "EvelynnR",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 650,
                    Radius = 350,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 5,
                    IsDangerous = true,
                    MissileSpellName = "EvelynnR"
                });

            #endregion Evelynn

            #region Ezreal

            Spells.Add(
                new Spell
                {
                    ChampionName = "Ezreal",
                    SpellName = "EzrealMysticShot",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1200,
                    Radius = 60,
                    MissileSpeed = 2000,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "EzrealMysticShotMissile",
                    ExtraMissileNames = new[] { "EzrealMysticShotPulseMissile" },
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        },
                    Id = 229
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Ezreal",
                    SpellName = "EzrealEssenceFlux",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1050,
                    Radius = 80,
                    MissileSpeed = 1600,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "EzrealEssenceFluxMissile",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Ezreal",
                    SpellName = "EzrealTrueshotBarrage",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 1000,
                    Range = 20000,
                    Radius = 160,
                    MissileSpeed = 2000,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "EzrealTrueshotBarrage",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall },
                    Id = 245
                });

            #endregion Ezreal

            #region Fiddlesticks
            Spells.Add(
    new Spell
    {
        ChampionName = "FiddleSticks",
        SpellName = "Drain",
        IsInterruptableSpell = true,
        DangerLevel = Spell.InterruptableDangerLevel.Medium,
        Slot = SpellSlot.W,
        BuffName = "Drain"
    });

            //Max rank Drain had different buff name
            Spells.Add(
                new Spell
                {
                    ChampionName = "FiddleSticks",
                    SpellName = "Drain",
                    IsInterruptableSpell = true,
                    DangerLevel = Spell.InterruptableDangerLevel.Medium,
                    Slot = SpellSlot.W,
                    BuffName = "fearmonger_marker"
                });
            #endregion

            #region Fiora

            Spells.Add(
                new Spell
                {
                    ChampionName = "Fiora",
                    SpellName = "FioraW",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Linear,
                    Delay = 700,
                    Range = 800,
                    Radius = 70,
                    MissileSpeed = 3200,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "FioraWMissile",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Fiora

            #region Fizz

            Spells.Add(
                new Spell
                {
                    ChampionName = "Fizz",
                    SpellName = "FizzMarinerDoom",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1300,
                    Radius = 120,
                    MissileSpeed = 1350,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 5,
                    IsDangerous = true,
                    MissileSpellName = "FizzMarinerDoomMissile",
                    CollisionObjects =
                        new[] { Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.YasuoWall },
                    CanBeRemoved = true
                });

            #endregion Fizz

            #region Galio

            Spells.Add(
                new Spell
                {
                    ChampionName = "Galio",
                    SpellName = "GalioResoluteSmite",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 900,
                    Radius = 200,
                    MissileSpeed = 1300,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "GalioResoluteSmite"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Galio",
                    SpellName = "GalioRighteousGust",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1200,
                    Radius = 120,
                    MissileSpeed = 1200,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "GalioRighteousGust",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Galio",
                    SpellName = "GalioIdolOfDurand",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 0,
                    Radius = 550,
                    MissileSpeed = int.MaxValue,
                    FixedRange = true,
                    AddHitbox = false,
                    DangerValue = 5,
                    IsDangerous = true,
                    MissileSpellName = "",
                    IsInterruptableSpell = true,
                    DangerLevel = Spell.InterruptableDangerLevel.High
                });

            #endregion Galio

            #region Gnar

            Spells.Add(
                new Spell
                {
                    ChampionName = "Gnar",
                    SpellName = "GnarQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1125,
                    Radius = 60,
                    MissileSpeed = 2500,
                    MissileAccel = -3000,
                    MissileMaxSpeed = 2500,
                    MissileMinSpeed = 1400,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    CanBeRemoved = true,
                    ForceRemove = true,
                    MissileSpellName = "gnarqmissile",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Gnar",
                    SpellName = "GnarQReturn",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 0,
                    Range = 2500,
                    Radius = 75,
                    MissileSpeed = 60,
                    MissileAccel = 800,
                    MissileMaxSpeed = 2600,
                    MissileMinSpeed = 60,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    CanBeRemoved = true,
                    ForceRemove = true,
                    MissileSpellName = "GnarQMissileReturn",
                    DisableFowDetection = false,
                    DisabledByDefault = true,
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Gnar",
                    SpellName = "GnarBigQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 500,
                    Range = 1150,
                    Radius = 90,
                    MissileSpeed = 2100,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "GnarBigQMissile",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Gnar",
                    SpellName = "GnarBigW",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Linear,
                    Delay = 600,
                    Range = 600,
                    Radius = 80,
                    MissileSpeed = int.MaxValue,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "GnarBigW"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Gnar",
                    SpellName = "GnarE",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Circular,
                    Delay = 0,
                    Range = 473,
                    Radius = 150,
                    MissileSpeed = 903,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "GnarE"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Gnar",
                    SpellName = "GnarBigE",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 475,
                    Radius = 200,
                    MissileSpeed = 1000,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "GnarBigE"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Gnar",
                    SpellName = "GnarR",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 0,
                    Radius = 500,
                    MissileSpeed = int.MaxValue,
                    FixedRange = true,
                    AddHitbox = false,
                    DangerValue = 5,
                    IsDangerous = true,
                    MissileSpellName = ""
                });

            #endregion

            #region Gragas

            Spells.Add(
                new Spell
                {
                    ChampionName = "Gragas",
                    SpellName = "GragasQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 1100,
                    Radius = 275,
                    MissileSpeed = 1300,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "GragasQMissile",
                    ExtraDuration = 4500,
                    ToggleParticleName = "Gragas_.+_Q_(Enemy|Ally)",
                    DontCross = true
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Gragas",
                    SpellName = "GragasE",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 0,
                    Range = 950,
                    Radius = 200,
                    MissileSpeed = 1200,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "GragasE",
                    CanBeRemoved = true,
                    ExtraRange = 300,
                    CollisionObjects =
                        new[] { Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Gragas",
                    SpellName = "GragasR",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 1050,
                    Radius = 375,
                    MissileSpeed = 1800,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 5,
                    IsDangerous = true,
                    MissileSpellName = "GragasRBoom",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Gragas

            #region Graves

            Spells.Add(
                new Spell
                {
                    ChampionName = "Graves",
                    SpellName = "GravesClusterShot",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1000,
                    Radius = 50,
                    MissileSpeed = 2000,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "GravesClusterShotAttack",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall },
                    MultipleNumber = 3,
                    MultipleAngle = 15 * (float)Math.PI / 180
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Graves",
                    SpellName = "GravesChargeShot",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1100,
                    Radius = 100,
                    MissileSpeed = 2100,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 5,
                    IsDangerous = true,
                    MissileSpellName = "GravesChargeShotShot",
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            #endregion Graves

            #region Heimerdinger

            Spells.Add(
                new Spell
                {
                    ChampionName = "Heimerdinger",
                    SpellName = "Heimerdingerwm",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1500,
                    Radius = 70,
                    MissileSpeed = 1800,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "HeimerdingerWAttack2",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Heimerdinger",
                    SpellName = "HeimerdingerE",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 925,
                    Radius = 100,
                    MissileSpeed = 1200,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "heimerdingerespell",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Heimerdinger

            #region Irelia

            Spells.Add(
                new Spell
                {
                    ChampionName = "Irelia",
                    SpellName = "IreliaTranscendentBlades",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 0,
                    Range = 1200,
                    Radius = 65,
                    MissileSpeed = 1600,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "IreliaTranscendentBlades",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Irelia

            #region Janna

            Spells.Add(
                new Spell
                {
                    ChampionName = "Janna",
                    SpellName = "JannaQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1700,
                    Radius = 120,
                    MissileSpeed = 900,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "HowlingGaleSpell",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            //Different cast stages calls for different spell names
            Spells.Add(
    new Spell
    {
        ChampionName = "Janna",
        SpellName = "ReapTheWhirlwind",
        BuffName = "ReapTheWhirlwind",
        Slot = SpellSlot.R,
        IsInterruptableSpell = true,
        DangerLevel = Spell.InterruptableDangerLevel.Low
    });
            #endregion Janna

            #region JarvanIV

            Spells.Add(
                new Spell
                {
                    ChampionName = "JarvanIV",
                    SpellName = "JarvanIVDragonStrike",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 600,
                    Range = 770,
                    Radius = 70,
                    MissileSpeed = int.MaxValue,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = false
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "JarvanIV",
                    SpellName = "JarvanIVEQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 880,
                    Radius = 70,
                    MissileSpeed = 1450,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "JarvanIV",
                    SpellName = "JarvanIVDemacianStandard",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Circular,
                    Delay = 500,
                    Range = 860,
                    Radius = 175,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "JarvanIVDemacianStandard"
                });

            #endregion JarvanIV

            #region Jayce

            Spells.Add(
                new Spell
                {
                    ChampionName = "Jayce",
                    SpellName = "jayceshockblast",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1300,
                    Radius = 70,
                    MissileSpeed = 1450,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "JayceShockBlastMis",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Jayce",
                    SpellName = "JayceQAccel",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1300,
                    Radius = 70,
                    MissileSpeed = 2350,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "JayceShockBlastWallMis",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            #endregion Jayce

            #region Jinx

            Spells.Add(
                new Spell
                {
                    ChampionName = "Jinx",
                    SpellName = "JinxW",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Linear,
                    Delay = 600,
                    Range = 1500,
                    Radius = 60,
                    MissileSpeed = 3300,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "JinxWMissile",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Jinx",
                    SpellName = "JinxR",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 600,
                    Range = 20000,
                    Radius = 140,
                    MissileSpeed = 1700,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 5,
                    IsDangerous = true,
                    MissileSpellName = "JinxR",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[] { Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Jinx

            #region Kalista

            Spells.Add(
                new Spell
                {
                    ChampionName = "Kalista",
                    SpellName = "KalistaMysticShot",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1200,
                    Radius = 40,
                    MissileSpeed = 1700,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "kalistamysticshotmis",
                    ExtraMissileNames = new[] { "kalistamysticshotmistrue" },
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            #endregion Kalista

            #region Karma

            Spells.Add(
                new Spell
                {
                    ChampionName = "Karma",
                    SpellName = "KarmaQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1050,
                    Radius = 60,
                    MissileSpeed = 1700,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "KarmaQMissile",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Karma",
                    SpellName = "KarmaQMantra",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 950,
                    Radius = 80,
                    MissileSpeed = 1700,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "KarmaQMissileMantra",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            #endregion Karma

            #region Karthus

            Spells.Add(
                new Spell
                {
                    ChampionName = "Karthus",
                    SpellName = "KarthusLayWasteA2",
                    ExtraSpellNames =
                        new[]
                        {
                            "karthuslaywastea3", "karthuslaywastea1", "karthuslaywastedeada1", "karthuslaywastedeada2",
                            "karthuslaywastedeada3"
                        },
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Circular,
                    Delay = 625,
                    Range = 875,
                    Radius = 160,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = ""
                });

            Spells.Add(
    new Spell
    {
        ChampionName = "Karthus",
        SpellName = "KarthusFallenOne",
        IsInterruptableSpell = true,
        DangerLevel = Spell.InterruptableDangerLevel.High,
        Slot = SpellSlot.R,
        BuffName = "karthusfallenonecastsound"
    });

            #endregion Karthus

            #region Kassadin

            Spells.Add(
                new Spell
                {
                    ChampionName = "Kassadin",
                    SpellName = "RiftWalk",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 450,
                    Radius = 270,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "RiftWalk"
                });

            #endregion Kassadin

            #region Katarina

            Spells.Add(
                new Spell
                {
                    ChampionName = "Katarina",
                    SpellName = "KatarinaR",
                    IsInterruptableSpell = true,
                    DangerLevel = Spell.InterruptableDangerLevel.High,
                    Slot = SpellSlot.R,
                    BuffName = "katarinarsound"
                });

            #endregion

            #region Kennen

            Spells.Add(
                new Spell
                {
                    ChampionName = "Kennen",
                    SpellName = "KennenShurikenHurlMissile1",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 125,
                    Range = 1050,
                    Radius = 50,
                    MissileSpeed = 1700,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "KennenShurikenHurlMissile1",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            #endregion Kennen

            #region Khazix

            Spells.Add(
                new Spell
                {
                    ChampionName = "Khazix",
                    SpellName = "KhazixW",
                    ExtraSpellNames = new[] { "khazixwlong" },
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1025,
                    Radius = 73,
                    MissileSpeed = 1700,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "KhazixWMissile",
                    CanBeRemoved = true,
                    MultipleNumber = 3,
                    MultipleAngle = 22f * (float)Math.PI / 180,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Khazix",
                    SpellName = "KhazixE",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 600,
                    Radius = 300,
                    MissileSpeed = 1500,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "KhazixE"
                });

            #endregion Khazix

            #region Kogmaw

            Spells.Add(
                new Spell
                {
                    ChampionName = "Kogmaw",
                    SpellName = "KogMawQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1200,
                    Radius = 70,
                    MissileSpeed = 1650,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "KogMawQMis",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Kogmaw",
                    SpellName = "KogMawVoidOoze",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1360,
                    Radius = 120,
                    MissileSpeed = 1400,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "KogMawVoidOozeMissile",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Kogmaw",
                    SpellName = "KogMawLivingArtillery",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Circular,
                    Delay = 1200,
                    Range = 1800,
                    Radius = 150,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "KogMawLivingArtillery"
                });

            #endregion Kogmaw

            #region Leblanc

            Spells.Add(
                new Spell
                {
                    ChampionName = "Leblanc",
                    SpellName = "LeblancSlide",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Circular,
                    Delay = 0,
                    Range = 600,
                    Radius = 220,
                    MissileSpeed = 1450,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "LeblancSlide"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Leblanc",
                    SpellName = "LeblancSlideM",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Circular,
                    Delay = 0,
                    Range = 600,
                    Radius = 220,
                    MissileSpeed = 1450,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "LeblancSlideM"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Leblanc",
                    SpellName = "LeblancSoulShackle",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 950,
                    Radius = 70,
                    MissileSpeed = 1600,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "LeblancSoulShackle",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Leblanc",
                    SpellName = "LeblancSoulShackleM",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 950,
                    Radius = 70,
                    MissileSpeed = 1600,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "LeblancSoulShackleM",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            #endregion Leblanc

            #region LeeSin

            Spells.Add(
                new Spell
                {
                    ChampionName = "LeeSin",
                    SpellName = "BlindMonkQOne",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1100,
                    Radius = 65,
                    MissileSpeed = 1800,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "BlindMonkQOne",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            #endregion LeeSin

            #region Leona

            Spells.Add(
                new Spell
                {
                    ChampionName = "Leona",
                    SpellName = "LeonaZenithBlade",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 905,
                    Radius = 70,
                    MissileSpeed = 2000,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    TakeClosestPath = true,
                    MissileSpellName = "LeonaZenithBladeMissile",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Leona",
                    SpellName = "LeonaSolarFlare",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Circular,
                    Delay = 1000,
                    Range = 1200,
                    Radius = 300,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 5,
                    IsDangerous = true,
                    MissileSpellName = "LeonaSolarFlare"
                });

            #endregion Leona

            #region Lissandra

            Spells.Add(
                new Spell
                {
                    ChampionName = "Lissandra",
                    SpellName = "LissandraQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 700,
                    Radius = 75,
                    MissileSpeed = 2200,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "LissandraQMissile",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Lissandra",
                    SpellName = "LissandraQShards",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 700,
                    Radius = 90,
                    MissileSpeed = 2200,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "lissandraqshards",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Lissandra",
                    SpellName = "LissandraE",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1025,
                    Radius = 125,
                    MissileSpeed = 850,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "LissandraEMissile",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Lulu

            #region Lucian

            Spells.Add(
                new Spell
                {
                    ChampionName = "Lucian",
                    SpellName = "LucianQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 500,
                    Range = 1300,
                    Radius = 65,
                    MissileSpeed = int.MaxValue,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "LucianQ"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Lucian",
                    SpellName = "LucianW",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1000,
                    Radius = 55,
                    MissileSpeed = 1600,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "lucianwmissile"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Lucian",
                    SpellName = "LucianRMis",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 500,
                    Range = 1400,
                    Radius = 110,
                    MissileSpeed = 2800,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "lucianrmissileoffhand",
                    ExtraMissileNames = new[] { "lucianrmissile" },
                    DontCheckForDuplicates = true,
                    DisabledByDefault = true
                });

            //This one is the r channel, where the top one detects only the missiles.
            Spells.Add(
                new Spell
                {
                    ChampionName = "Lucian",
                    SpellName = "LucianR",
                    IsInterruptableSpell = true,
                    DangerLevel = Spell.InterruptableDangerLevel.High,
                    Slot = SpellSlot.R,
                    BuffName = "LucianR"
                });

            #endregion Lucian

            #region Lulu

            Spells.Add(
                new Spell
                {
                    ChampionName = "Lulu",
                    SpellName = "LuluQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 950,
                    Radius = 60,
                    MissileSpeed = 1450,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "LuluQMissile",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Lulu",
                    SpellName = "LuluQPix",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 950,
                    Radius = 60,
                    MissileSpeed = 1450,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "LuluQMissileTwo",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Lulu

            #region Lux

            Spells.Add(
                new Spell
                {
                    ChampionName = "Lux",
                    SpellName = "LuxLightBinding",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1300,
                    Radius = 70,
                    MissileSpeed = 1200,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "LuxLightBindingMis"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Lux",
                    SpellName = "LuxLightStrikeKugel",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 1100,
                    Radius = 275,
                    MissileSpeed = 1300,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "LuxLightStrikeKugel",
                    ExtraDuration = 5500,
                    ToggleParticleName = "Lux_.+_E_tar_aoe_",
                    DontCross = true,
                    CanBeRemoved = true,
                    DisabledByDefault = true,
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Lux",
                    SpellName = "LuxMaliceCannon",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 1000,
                    Range = 3500,
                    Radius = 190,
                    MissileSpeed = int.MaxValue,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 5,
                    IsDangerous = true,
                    MissileSpellName = "LuxMaliceCannon"
                });

            #endregion Lux

            #region Malphite

            Spells.Add(
                new Spell
                {
                    ChampionName = "Malphite",
                    SpellName = "UFSlash",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Circular,
                    Delay = 0,
                    Range = 1000,
                    Radius = 270,
                    MissileSpeed = 1500,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 5,
                    IsDangerous = true,
                    MissileSpellName = "UFSlash"
                });

            #endregion Malphite

            #region Malzahar

            Spells.Add(
                new Spell
                {
                    ChampionName = "Malzahar",
                    SpellName = "AlZaharCalloftheVoid",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 1000,
                    Range = 900,
                    Radius = 85,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    DontCross = true,
                    MissileSpellName = "AlZaharCalloftheVoid"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Malzahar",
                    SpellName = "AlZaharNetherGrasp",
                    IsInterruptableSpell = true,
                    DangerLevel = Spell.InterruptableDangerLevel.High,
                    Slot = SpellSlot.R,
                    BuffName = "alzaharnethergraspsound",
                    ExtraDuration = 2000
                });
            #endregion Malzahar

            #region MasterYi
            Spells.Add(
    new Spell
    {
        ChampionName = "MasterYi",
        SpellName = "Meditate",
        BuffName = "Meditate",
        Slot = SpellSlot.W,
        IsInterruptableSpell = true,
        DangerLevel = Spell.InterruptableDangerLevel.Low
    });
            #endregion

            #region MissFortune
            Spells.Add(
    new Spell
    {
        ChampionName = "MissFortune",
        SpellName = "MissFortuneBulletTime",
        IsInterruptableSpell = true,
        DangerLevel = Spell.InterruptableDangerLevel.High,
        Slot = SpellSlot.R,
        BuffName = "missfortunebulletsound"
    });
            #endregion

            #region Morgana

            Spells.Add(
                new Spell
                {
                    ChampionName = "Morgana",
                    SpellName = "DarkBindingMissile",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1300,
                    Radius = 80,
                    MissileSpeed = 1200,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "DarkBindingMissile",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            Spells.Add(
                 new Spell
                 {
                     ChampionName = "Morgana",
                     SpellName = "TormentedSoil",
                     Slot = SpellSlot.W,
                     Type = SkillShotType.Circular,
                     Delay = 250,
                     Range = 900,
                     Radius = 400,
                     MissileSpeed = 2200,
                     FixedRange = true,
                     AddHitbox = false,
                     DangerValue = 1,
                     IsDangerous = false,
                     MissileSpellName = "TormentedSoil",
                     CanBeRemoved = false
                 });

            #endregion Morgana

            #region Nami

            Spells.Add(
                new Spell
                {
                    ChampionName = "Nami",
                    SpellName = "NamiQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Circular,
                    Delay = 950,
                    Range = 1625,
                    Radius = 150,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "namiqmissile"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Nami",
                    SpellName = "NamiR",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 500,
                    Range = 2750,
                    Radius = 260,
                    MissileSpeed = 850,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "NamiRMissile",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Nami

            #region Nautilus

            Spells.Add(
                new Spell
                {
                    ChampionName = "Nautilus",
                    SpellName = "NautilusAnchorDrag",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1250,
                    Radius = 90,
                    MissileSpeed = 2000,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "NautilusAnchorDragMissile",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            #endregion Nautilus

            #region Nocturne

            Spells.Add(
                new Spell
                {
                    ChampionName = "Nocturne",
                    SpellName = "NocturneDuskbringer",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1125,
                    Radius = 60,
                    MissileSpeed = 1400,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "NocturneDuskbringer",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Nocturne

            #region Nidalee

            Spells.Add(
                new Spell
                {
                    ChampionName = "Nidalee",
                    SpellName = "JavelinToss",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1500,
                    Radius = 40,
                    MissileSpeed = 1300,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "JavelinToss",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            #endregion Nidalee

            #region Nunu
            Spells.Add(
                new Spell
                {
                    ChampionName = "Nunu",
                    SpellName = "AbsoluteZero",
                    IsInterruptableSpell = true,
                    DangerLevel = Spell.InterruptableDangerLevel.High,
                    Slot = SpellSlot.R,
                    BuffName = "AbsoluteZero"
                });
            #endregion

            #region Olaf

            Spells.Add(
                new Spell
                {
                    ChampionName = "Olaf",
                    SpellName = "OlafAxeThrowCast",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1000,
                    ExtraRange = 150,
                    Radius = 105,
                    MissileSpeed = 1600,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "olafaxethrow",
                    CanBeRemoved = true,
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Olaf

            #region Orianna

            Spells.Add(
                new Spell
                {
                    ChampionName = "Orianna",
                    SpellName = "OriannasQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 0,
                    Range = 1500,
                    Radius = 80,
                    MissileSpeed = 1200,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "orianaizuna",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Orianna",
                    SpellName = "OriannaQend",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Circular,
                    Delay = 0,
                    Range = 1500,
                    Radius = 90,
                    MissileSpeed = 1200,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Orianna",
                    SpellName = "OrianaDissonanceCommand",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 0,
                    Radius = 255,
                    MissileSpeed = int.MaxValue,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "OrianaDissonanceCommand",
                    FromObject = "yomu_ring_"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Orianna",
                    SpellName = "OriannasE",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 0,
                    Range = 1500,
                    Radius = 85,
                    MissileSpeed = 1850,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "orianaredact",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Orianna",
                    SpellName = "OrianaDetonateCommand",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Circular,
                    Delay = 700,
                    Range = 0,
                    Radius = 410,
                    MissileSpeed = int.MaxValue,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 5,
                    IsDangerous = true,
                    MissileSpellName = "OrianaDetonateCommand",
                    FromObject = "yomu_ring_"
                });

            #endregion Orianna

            #region Pantheon
            Spells.Add(
    new Spell
    {
        ChampionName = "Pantheon",
        SpellName = "PantheonRJump",
        IsInterruptableSpell = true,
        DangerLevel = Spell.InterruptableDangerLevel.High,
        Slot = SpellSlot.R,
        BuffName = "PantheonRJump"
    });
            #endregion

            #region Quinn

            Spells.Add(
                new Spell
                {
                    ChampionName = "Quinn",
                    SpellName = "QuinnQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1050,
                    Radius = 80,
                    MissileSpeed = 1550,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "QuinnQMissile",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            #endregion Quinn

            #region Rengar

            Spells.Add(
                new Spell
                {
                    ChampionName = "Rengar",
                    SpellName = "RengarE",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1000,
                    Radius = 70,
                    MissileSpeed = 1500,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "RengarEFinal",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            #endregion Rengar

            #region RekSai

            Spells.Add(
                new Spell
                {
                    ChampionName = "RekSai",
                    SpellName = "reksaiqburrowed",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 500,
                    Range = 1625,
                    Radius = 60,
                    MissileSpeed = 1950,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = false,
                    MissileSpellName = "RekSaiQBurrowedMis",
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            #endregion RekSai

            #region Riven

            Spells.Add(
                new Spell
                {
                    ChampionName = "Riven",
                    SpellName = "rivenizunablade",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1100,
                    Radius = 125,
                    MissileSpeed = 1600,
                    FixedRange = false,
                    AddHitbox = false,
                    DangerValue = 5,
                    IsDangerous = true,
                    MultipleNumber = 3,
                    MultipleAngle = 15 * (float)Math.PI / 180,
                    MissileSpellName = "RivenLightsaberMissile",
                    ExtraMissileNames = new[] { "RivenLightsaberMissileSide" }
                });

            #endregion Riven

            #region Rumble

            Spells.Add(
                new Spell
                {
                    ChampionName = "Rumble",
                    SpellName = "RumbleGrenade",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 950,
                    Radius = 60,
                    MissileSpeed = 2000,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "RumbleGrenade",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Rumble",
                    SpellName = "RumbleCarpetBombM",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 400,
                    MissileDelayed = true,
                    Range = 1200,
                    Radius = 200,
                    MissileSpeed = 1600,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 4,
                    IsDangerous = false,
                    MissileSpellName = "RumbleCarpetBombMissile",
                    CanBeRemoved = false,
                    CollisionObjects = new Spell.CollisionObjectTypes[] { }
                });

            #endregion Rumble

            #region Ryze

            Spells.Add(
                new Spell
                {
                    ChampionName = "Ryze",
                    SpellName = "RyzeQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 900,
                    Radius = 50,
                    MissileSpeed = 1700,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "RyzeQ",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Ryze",
                    SpellName = "ryzerq",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 900,
                    Radius = 50,
                    MissileSpeed = 1700,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "ryzerq",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            #endregion

            #region Sejuani

            Spells.Add(
                new Spell
                {
                    ChampionName = "Sejuani",
                    SpellName = "SejuaniArcticAssault",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 0,
                    Range = 900,
                    Radius = 70,
                    MissileSpeed = 1600,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "",
                    ExtraRange = 200,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.Minion,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Sejuani",
                    SpellName = "SejuaniGlacialPrisonStart",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1100,
                    Radius = 110,
                    MissileSpeed = 1600,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "sejuaniglacialprison",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[] { Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Sejuani

            #region Sion

            Spells.Add(
                new Spell
                {
                    ChampionName = "Sion",
                    SpellName = "SionE",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 800,
                    Radius = 80,
                    MissileSpeed = 1800,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "SionEMissile",
                    CollisionObjects =
                        new[] { Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Sion",
                    SpellName = "SionR",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 500,
                    Range = 800,
                    Radius = 120,
                    MissileSpeed = 1000,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    CollisionObjects =
                        new[] { Spell.CollisionObjectTypes.Champions }
                });

            #endregion Sion

            #region Soraka

            Spells.Add(
                new Spell
                {
                    ChampionName = "Soraka",
                    SpellName = "SorakaQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Circular,
                    Delay = 500,
                    Range = 950,
                    Radius = 300,
                    MissileSpeed = 1750,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Soraka

            #region Shen

            Spells.Add(
                new Spell
                {
                    ChampionName = "Shen",
                    SpellName = "ShenShadowDash",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 0,
                    Range = 650,
                    Radius = 50,
                    MissileSpeed = 1600,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "ShenShadowDash",
                    ExtraRange = 200,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Minion, Spell.CollisionObjectTypes.Champions,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

             Spells.Add(
                new Spell
                {
                    ChampionName = "Shen",
                    SpellName = "ShenStandUnited",
                    IsInterruptableSpell = true,
                    DangerLevel = Spell.InterruptableDangerLevel.Low,
                    Slot = SpellSlot.R,
                    BuffName = "shenstandunitedlock"
                });

            #endregion Shen

            #region Shyvana

            Spells.Add(
                new Spell
                {
                    ChampionName = "Shyvana",
                    SpellName = "ShyvanaFireball",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 950,
                    Radius = 60,
                    MissileSpeed = 1700,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "ShyvanaFireballMissile",
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Minion, Spell.CollisionObjectTypes.Champions,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Shyvana",
                    SpellName = "ShyvanaTransformCast",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1000,
                    Radius = 150,
                    MissileSpeed = 1500,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "ShyvanaTransformCast",
                    ExtraRange = 200
                });

            #endregion Shyvana

            #region Sivir

            Spells.Add(
                new Spell
                {
                    ChampionName = "Sivir",
                    SpellName = "SivirQReturn",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 0,
                    Range = 1250,
                    Radius = 100,
                    MissileSpeed = 1350,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "SivirQMissileReturn",
                    DisableFowDetection = false,
                    MissileFollowsUnit = true,
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Sivir",
                    SpellName = "SivirQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1250,
                    Radius = 90,
                    MissileSpeed = 1350,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "SivirQMissile",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Sivir

            #region Skarner

            Spells.Add(
                new Spell
                {
                    ChampionName = "Skarner",
                    SpellName = "SkarnerFracture",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1000,
                    Radius = 70,
                    MissileSpeed = 1500,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "SkarnerFractureMissile",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Skarner

            #region Sona

            Spells.Add(
                new Spell
                {
                    ChampionName = "Sona",
                    SpellName = "SonaR",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1000,
                    Radius = 140,
                    MissileSpeed = 2400,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 5,
                    IsDangerous = true,
                    MissileSpellName = "SonaR",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Sona

            #region Swain

            Spells.Add(
                new Spell
                {
                    ChampionName = "Swain",
                    SpellName = "SwainShadowGrasp",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Circular,
                    Delay = 1100,
                    Range = 900,
                    Radius = 180,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "SwainShadowGrasp"
                });

            #endregion Swain

            #region Syndra

            Spells.Add(
                new Spell
                {
                    ChampionName = "Syndra",
                    SpellName = "SyndraQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Circular,
                    Delay = 600,
                    Range = 800,
                    Radius = 150,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "SyndraQ"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Syndra",
                    SpellName = "syndrawcast",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 950,
                    Radius = 210,
                    MissileSpeed = 1450,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "syndrawcast"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Syndra",
                    SpellName = "syndrae5",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 300,
                    Range = 950,
                    Radius = 90,
                    MissileSpeed = 1601,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "syndrae5",
                    DisableFowDetection = true
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Syndra",
                    SpellName = "SyndraE",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 300,
                    Range = 950,
                    Radius = 90,
                    MissileSpeed = 1601,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    DisableFowDetection = true,
                    MissileSpellName = "SyndraE"
                });

            #endregion Syndra

            #region Talon

            Spells.Add(
                new Spell
                {
                    ChampionName = "Talon",
                    SpellName = "TalonRake",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 800,
                    Radius = 80,
                    MissileSpeed = 2300,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = true,
                    MultipleNumber = 3,
                    MultipleAngle = 20 * (float)Math.PI / 180,
                    MissileSpellName = "talonrakemissileone"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Talon",
                    SpellName = "TalonRakeReturn",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 800,
                    Radius = 80,
                    MissileSpeed = 1850,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = true,
                    MultipleNumber = 3,
                    MultipleAngle = 20 * (float)Math.PI / 180,
                    MissileSpellName = "talonrakemissiletwo"
                });

            #endregion Riven

            #region Tahm Kench

            Spells.Add(
                new Spell
                {
                    ChampionName = "TahmKench",
                    SpellName = "TahmKenchQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 951,
                    Radius = 90,
                    MissileSpeed = 2800,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "tahmkenchqmissile",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Minion, Spell.CollisionObjectTypes.Champions,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            #endregion Tahm Kench

            #region Thresh

            Spells.Add(
                new Spell
                {
                    ChampionName = "Thresh",
                    SpellName = "ThreshQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 500,
                    Range = 1100,
                    Radius = 70,
                    MissileSpeed = 1900,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "ThreshQMissile",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Minion, Spell.CollisionObjectTypes.Champions,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Thresh",
                    SpellName = "ThreshEFlay",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 125,
                    Range = 1075,
                    Radius = 110,
                    MissileSpeed = 2000,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    Centered = true,
                    MissileSpellName = "ThreshEMissile1"
                });

            #endregion Thresh

            #region Tristana

            Spells.Add(
                new Spell
                {
                    ChampionName = "Tristana",
                    SpellName = "RocketJump",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Circular,
                    Delay = 500,
                    Range = 900,
                    Radius = 270,
                    MissileSpeed = 1500,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "RocketJump"
                });

            #endregion Tristana

            #region Tryndamere

            Spells.Add(
                new Spell
                {
                    ChampionName = "Tryndamere",
                    SpellName = "slashCast",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 0,
                    Range = 660,
                    Radius = 93,
                    MissileSpeed = 1300,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "slashCast"
                });

            #endregion Tryndamere

            #region TwistedFate

            Spells.Add(
                new Spell
                {
                    ChampionName = "TwistedFate",
                    SpellName = "WildCards",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1450,
                    Radius = 40,
                    MissileSpeed = 1000,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "SealFateMissile",
                    MultipleNumber = 3,
                    MultipleAngle = 28 * (float)Math.PI / 180,
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
    new Spell
    {
        ChampionName = "TwistedFate",
        SpellName = "Destiny",
        IsInterruptableSpell = true,
        DangerLevel = Spell.InterruptableDangerLevel.Medium,
        Slot = SpellSlot.R,
        BuffName = "Destiny"
    });
            #endregion TwistedFate

            #region Twitch

            Spells.Add(
                new Spell
                {
                    ChampionName = "Twitch",
                    SpellName = "TwitchVenomCask",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 900,
                    Radius = 275,
                    MissileSpeed = 1400,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "TwitchVenomCaskMissile",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Twitch

            #region Urgot

            Spells.Add(
                new Spell
                {
                    ChampionName = "Urgot",
                    SpellName = "UrgotHeatseekingLineMissile",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 125,
                    Range = 1000,
                    Radius = 60,
                    MissileSpeed = 1600,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "UrgotHeatseekingLineMissile",
                    CanBeRemoved = true
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Urgot",
                    SpellName = "UrgotPlasmaGrenade",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 1100,
                    Radius = 210,
                    MissileSpeed = 1500,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "UrgotPlasmaGrenadeBoom"
                });
            Spells.Add(
                 new Spell
                 {
                     ChampionName = "Urgot",
                     SpellName = "UrgotSwap2",
                     IsInterruptableSpell = true,
                     DangerLevel = Spell.InterruptableDangerLevel.High,
                     Slot = SpellSlot.R,
                     BuffName = "UrgotSwap2"
                 });

            #endregion Urgot

            #region Varus

            Spells.Add(
                new Spell
                {
                    ChampionName = "Varus",
                    SpellName = "VarusQMissilee",
                    Slot =  SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1800,
                    Radius = 70,
                    MissileSpeed = 1900,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "VarusQMissile",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall },
                    IsInterruptableSpell = true,
                    DangerLevel = Spell.InterruptableDangerLevel.Low

                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Varus",
                    SpellName = "VarusE",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Circular,
                    Delay = 1000,
                    Range = 925,
                    Radius = 235,
                    MissileSpeed = 1500,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "VarusE"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Varus",
                    SpellName = "VarusR",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1200,
                    Radius = 120,
                    MissileSpeed = 1950,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "VarusRMissile",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[] { Spell.CollisionObjectTypes.Champions, Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Varus

            #region Veigar

            Spells.Add(
                new Spell
                {
                    ChampionName = "Veigar",
                    SpellName = "VeigarBalefulStrike",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 950,
                    Radius = 70,
                    MissileSpeed = 2000,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "VeigarBalefulStrikeMis",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Veigar",
                    SpellName = "VeigarDarkMatter",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Circular,
                    Delay = 1350,
                    Range = 900,
                    Radius = 225,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = ""
                });

            #endregion Veigar

            #region Velkoz

            Spells.Add(
                new Spell
                {
                    ChampionName = "Velkoz",
                    SpellName = "VelkozQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1100,
                    Radius = 50,
                    MissileSpeed = 1300,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "VelkozQMissile",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Minion, Spell.CollisionObjectTypes.Champions,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            Spells.Add(
    new Spell
    {
        ChampionName = "Velkoz",
        SpellName = "VelkozR",
        IsInterruptableSpell = true,
        DangerLevel = Spell.InterruptableDangerLevel.High,
        Slot = SpellSlot.R,
        BuffName = "VelkozR"
    });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Velkoz",
                    SpellName = "VelkozQSplit",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1100,
                    Radius = 55,
                    MissileSpeed = 2100,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "VelkozQMissileSplit",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Minion, Spell.CollisionObjectTypes.Champions,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Velkoz",
                    SpellName = "VelkozW",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1200,
                    Radius = 88,
                    MissileSpeed = 1700,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "VelkozWMissile"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Velkoz",
                    SpellName = "VelkozE",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Circular,
                    Delay = 500,
                    Range = 800,
                    Radius = 225,
                    MissileSpeed = 1500,
                    FixedRange = false,
                    AddHitbox = false,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "VelkozEMissile"
                });

            #endregion Velkoz

            #region Vi

            Spells.Add(
                new Spell
                {
                    ChampionName = "Vi",
                    SpellName = "Vi-q",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1000,
                    Radius = 90,
                    MissileSpeed = 1500,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "ViQMissile"
                });

            #endregion Vi

            #region Viktor

            Spells.Add(
                new Spell
                {
                    ChampionName = "Viktor",
                    SpellName = "Laser",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1500,
                    Radius = 80,
                    MissileSpeed = 780,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "ViktorDeathRayMissile",
                    ExtraMissileNames = new[] { "viktoreaugmissile" },
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Viktor

            #region Vladimir

            Spells.Add(
                new Spell
                {
                    ChampionName = "Vladimir",
                    SpellName = "VladimirHemoplague",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 700,
                    Radius = 375,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true
                });

            #endregion Vladimir

            #region Warwick

            Spells.Add(
                new Spell
                {
                    ChampionName = "Warwick",
                    SpellName = "InfiniteDuress",
                    IsInterruptableSpell = true,
                    DangerLevel = Spell.InterruptableDangerLevel.High,
                    Slot = SpellSlot.R,
                    BuffName = "infiniteduresssound"
                });

            #endregion
            #region Xerath

            Spells.Add(
                new Spell
                {
                    ChampionName = "Xerath",
                    SpellName = "xeratharcanopulse2",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 600,
                    Range = 1600,
                    Radius = 100,
                    MissileSpeed = int.MaxValue,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "xeratharcanopulse2"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Xerath",
                    SpellName = "XerathArcaneBarrage2",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Circular,
                    Delay = 700,
                    Range = 1000,
                    Radius = 200,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "XerathArcaneBarrage2"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Xerath",
                    SpellName = "XerathMageSpear",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 200,
                    Range = 1150,
                    Radius = 60,
                    MissileSpeed = 1400,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = true,
                    MissileSpellName = "XerathMageSpearMissile",
                    CanBeRemoved = true,
                    CollisionObjects =
                        new[]
                        {
                            Spell.CollisionObjectTypes.Minion, Spell.CollisionObjectTypes.Champions,
                            Spell.CollisionObjectTypes.YasuoWall
                        }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Xerath",
                    SpellName = "xerathrmissilewrapper",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Circular,
                    Delay = 700,
                    Range = 5600,
                    Radius = 120,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "xerathrmissilewrapper"
                });

            Spells.Add(
    new Spell
    {
        ChampionName = "Xerath",
        SpellName = "XerathLocusOfPower2",
        BuffName = "XerathLocusOfPower2",
        Slot = SpellSlot.R,
        IsInterruptableSpell = true,
        DangerLevel = Spell.InterruptableDangerLevel.Low
    });

            #endregion Xerath

            #region Yasuo

            Spells.Add(
                new Spell
                {
                    ChampionName = "Yasuo",
                    SpellName = "yasuoq2",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 400,
                    Range = 550,
                    Radius = 20,
                    MissileSpeed = int.MaxValue,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = true,
                    MissileSpellName = "yasuoq2",
                    Invert = true
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Yasuo",
                    SpellName = "yasuoq3w",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 500,
                    Range = 1150,
                    Radius = 90,
                    MissileSpeed = 1500,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "yasuoq3w",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Yasuo",
                    SpellName = "yasuoq",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 400,
                    Range = 550,
                    Radius = 20,
                    MissileSpeed = int.MaxValue,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = true,
                    MissileSpellName = "yasuoq",
                    Invert = true
                });

            #endregion Yasuo

            #region Zac

            Spells.Add(
                new Spell
                {
                    ChampionName = "Zac",
                    SpellName = "ZacQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 500,
                    Range = 550,
                    Radius = 120,
                    MissileSpeed = int.MaxValue,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "ZacQ"
                });

            #endregion Zac

            #region Zed

            Spells.Add(
                new Spell
                {
                    ChampionName = "Zed",
                    SpellName = "ZedQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 925,
                    Radius = 50,
                    MissileSpeed = 1700,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "zedshurikenmisone",
                    FromObjects = new[] { "Zed_Clone_idle.troy", "Zed_Clone_Idle.troy" },
                    ExtraMissileNames = new[] { "zedshurikenmistwo", "zedshurikenmisthree" },
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Zed

            #region Ziggs

            Spells.Add(
                new Spell
                {
                    ChampionName = "Ziggs",
                    SpellName = "ZiggsQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 850,
                    Radius = 140,
                    MissileSpeed = 1700,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "ZiggsQSpell",
                    CanBeRemoved = false,
                    DisableFowDetection = true
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Ziggs",
                    SpellName = "ZiggsQBounce1",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 850,
                    Radius = 140,
                    MissileSpeed = 1700,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "ZiggsQSpell2",
                    ExtraMissileNames = new[] { "ZiggsQSpell2" },
                    CanBeRemoved = false,
                    DisableFowDetection = true
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Ziggs",
                    SpellName = "ZiggsQBounce2",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 850,
                    Radius = 160,
                    MissileSpeed = 1700,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "ZiggsQSpell3",
                    ExtraMissileNames = new[] { "ZiggsQSpell3" },
                    CanBeRemoved = false,
                    DisableFowDetection = true
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Ziggs",
                    SpellName = "ZiggsW",
                    Slot = SpellSlot.W,
                    Type = SkillShotType.Circular,
                    Delay = 250,
                    Range = 1000,
                    Radius = 275,
                    MissileSpeed = 1750,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "ZiggsW",
                    DisableFowDetection = true,
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Ziggs",
                    SpellName = "ZiggsE",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Circular,
                    Delay = 500,
                    Range = 900,
                    Radius = 235,
                    MissileSpeed = 1750,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "ZiggsE",
                    DisableFowDetection = true
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Ziggs",
                    SpellName = "ZiggsR",
                    Slot = SpellSlot.R,
                    Type = SkillShotType.Circular,
                    Delay = 0,
                    Range = 5300,
                    Radius = 500,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "ZiggsR",
                    DisableFowDetection = true
                });

            #endregion Ziggs

            #region Zilean

            Spells.Add(
                new Spell
                {
                    ChampionName = "Zilean",
                    SpellName = "ZileanQ",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Circular,
                    Delay = 300,
                    Range = 900,
                    Radius = 210,
                    MissileSpeed = 2000,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "ZileanQMissile",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Zilean

            #region Zyra

            Spells.Add(
                new Spell
                {
                    ChampionName = "Zyra",
                    SpellName = "ZyraQFissure",
                    Slot = SpellSlot.Q,
                    Type = SkillShotType.Circular,
                    Delay = 850,
                    Range = 800,
                    Radius = 220,
                    MissileSpeed = int.MaxValue,
                    FixedRange = false,
                    AddHitbox = true,
                    DangerValue = 2,
                    IsDangerous = false,
                    MissileSpellName = "ZyraQFissure"
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Zyra",
                    SpellName = "ZyraGraspingRoots",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 250,
                    Range = 1150,
                    Radius = 70,
                    MissileSpeed = 1150,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "ZyraGraspingRoots",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            Spells.Add(
                new Spell
                {
                    ChampionName = "Zyra",
                    SpellName = "zyrapassivedeathmanager",
                    Slot = SpellSlot.E,
                    Type = SkillShotType.Linear,
                    Delay = 500,
                    Range = 1474,
                    Radius = 70,
                    MissileSpeed = 2000,
                    FixedRange = true,
                    AddHitbox = true,
                    DangerValue = 3,
                    IsDangerous = true,
                    MissileSpellName = "zyrapassivedeathmanager",
                    CollisionObjects = new[] { Spell.CollisionObjectTypes.YasuoWall }
                });

            #endregion Zyra
        }



        public static Spell GetByName(string spellName)
        {
            spellName = spellName.ToLower();
            foreach (var spellData in Spells)
            {
                if (spellData.SpellName.ToLower() == spellName || spellData.ExtraSpellNames.Contains(spellName))
                {
                    return spellData;
                }
            }

            return null;
        }

        public static Spell GetByMissileName(string missileSpellName)
        {
            missileSpellName = missileSpellName.ToLower();
            foreach (var spellData in Spells)
            {
                if (spellData.MissileSpellName != null && spellData.MissileSpellName.ToLower() == missileSpellName ||
                    spellData.ExtraMissileNames.Contains(missileSpellName))
                {
                    return spellData;
                }
            }

            return null;
        }

        public static Spell GetBySpeed(string ChampionName, int speed, int id = -1)
        {
            foreach (var spellData in Spells)
            {
                if (spellData.ChampionName == ChampionName && spellData.MissileSpeed == speed &&
                    (spellData.Id == -1 || id == spellData.Id))
                {
                    return spellData;
                }
            }

            return null;
        }
    }
    #endregion

    #region CC Spells
    public class CCDataBase
    {
        static readonly string[] _nonskillshots =
           {
                "ShenShadowDash", "Pulverize", "GragasE", "FizzPiercingStrike", "reksaiqburrowed",
                "RunePrison", "Fling", "NocturneUnspeakableHorror", "SejuaniArcticAssault", "ShyvanaTransformCast",
                "PantheonW", "Ice Blast", "Terrify", "GalioIdolOfDurand", "GnarR", "JaxCounterStrike", "BlindMonkRKick",
                "UFSlash", "JayceThunderingBlow", "ZacR", "StaticField", "GarenQ", "TalonCutthroat", "ViR", "LissandraR", "CurseoftheSadMummy" , "OrianaDetonateCommand"
            };

        static readonly string[] _skillShots =
        {
                "AhriSeduce", "AhriOrbofDeception", "SwainShadowGrasp", "syndrae5", "SyndraE", "TahmKenchQ", "VarusE",
                "VeigarBalefulStrike", "VeigarDarkMatter", "VeigarEventHorizon", "VelkozQ", "VelkozQSplit", "VelkozE",
                "Laser", "Vi-q", "xeratharcanopulse2", "XerathArcaneBarrage2", "XerathMageSpear",
                "xerathrmissilewrapper", "BraumQ", "RocketGrab", "JavelinToss", "BrandBlazeMissile", "Heimerdingerwm",
                "JannaQ", "JarvanIVEQ", "BandageToss", "CaitlynEntrapment", "PhosphorusBomb", "MissileBarrage2",
                "DariusAxeGrabCone", "DianaArc", "DianaArcArc", "InfectedCleaverMissileCast", "DravenDoubleShot",
                "EkkoQ", "EkkoW", "EkkoR", "EliseHumanE", "GalioResoluteSmite", "GalioRighteousGust",
                "FlashFrost", "EvelynnR", "QuinnQ", "yasuoq3w",
                "RengarEFinal", "ZiggsW", "ZyraGraspingRoots", "ZyraBrambleZone", "Dazzle", "FiddlesticksDarkWind",
                "FeralScream", "ZiggsW", "ViktorChaosStorm", "AlZaharCalloftheVoid",
                "RumbleCarpetBombMissile", "ThreshQ", "ThreshE", "NamiQ", "DarkBindingMissile",
                "NautilusAnchorDrag",
                "SejuaniGlacialPrisonCast", "SonaR", "VarusR", "rivenizunablade", "EnchantedCrystalArrow", "BardR",
                "InfernalGuardian",
                "CassiopeiaPetrifyingGaze",
                "BraumRWrapper", "FizzMarinerDoomMissile", "ViktorDeathRay", "ViktorDeathRay3", "XerathMageSpear",
                "GragasR", "HecarimUlt", "LeonaSolarFlare", "LuxLightBinding", "LuxMaliceCannon", "JinxW",
                "LuxLightStrikeKugel"
            };

        public static bool IsCC(string spell)
        {
            return _skillShots.Contains(spell) || _nonskillshots.Contains(spell);
        }

        public static bool IsCC_SkillShot(string spell)
        {
            return _skillShots.Contains(spell);
        }

        public static bool IsCC_NonSkillShot(string spell)
        {
            return _nonskillshots.Contains(spell);
        }
    }
    #endregion

    #region Targeted Spell
    public class TargetSpell
    {
        public int blockBelow = 0;

        public AIHeroClient Caster { get; set; }
        public Obj_AI_Base Target { get; set; }
        public TargetSpellData Spell { get; set; }
        public int StartTick { get; set; }
        public Vector2 StartPosition { get; set; }

        public bool hadPart = false;
        public GameObject particle { get; set; }
        public GameObjectProcessSpellCastEventArgs spellArgs;

        public String particleName;

        public int created = 0;

        public int EndTick
        {
            get { return (Spell == null) ? 0 : (int)(StartTick + Spell.Delay + 1000 * (StartPosition.Distance(EndPosition) / Spell.Speed)); }
        }

        public Vector2 EndPosition
        {
            get { return Target.ServerPosition.To2D(); }
        }

        public Vector2 Direction
        {
            get { return (EndPosition - StartPosition).Normalized(); }
        }

        public double Damage
        {
            get { return Caster.GetSpellDamage(Target, Spell.Spellslot); }
        }

        public bool IsKillable
        {
            get { return Damage >= Target.Health; }
        }

        public CcType CrowdControl
        {
            get { return Spell.CcType; }
        }

        public SpellType Type
        {
            get { return Spell.Type; }
        }

        public bool IsActive
        {
            get { return Environment.TickCount <= EndTick || StartTick + 4000 < Environment.TickCount; }
        }

        public bool HasMissile
        {
            get { return Spell.Speed == float.MaxValue || Spell.Speed == 0; }
        }
    }

    public class TargetSpellData
    {
        public string ChampionName { get; set; }
        public SpellSlot Spellslot { get; set; }
        public SpellType Type { get; set; }
        public CcType CcType { get; set; }
        public string Name { get; set; }
        public float Range { get; set; }
        public double Delay { get; set; }
        public double Speed { get; set; }

        public TargetSpellData(string champion, string name, SpellSlot slot, SpellType type, CcType cc, float range,
            float delay, float speed)
        {
            ChampionName = champion;
            Name = name;
            Spellslot = slot;
            Type = type;
            CcType = cc;
            Range = range;
            Speed = speed;
            Delay = delay;
        }
    }

    public enum SpellType
    {
        Skillshot,
        Targeted,
        Self,
        AutoAttack
    }


    public enum CcType
    {
        No,
        Stun,
        Silence,
        Taunt,
        Polymorph,
        Slow,
        Snare,
        Fear,
        Charm,
        Suppression,
        Blind,
        Flee,
        Knockup,
        Knockback,
        Pull
    }
    #endregion  
}
