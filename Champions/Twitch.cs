﻿using System;
using System.Linq;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;
using EloBuddy.SDK.Menu.Values;
using EloBuddy.SDK.Rendering;
using MarksmanAIO.Menu_Settings;
using SharpDX;
using Color = System.Drawing.Color;

namespace MarksmanAIO.Champions
{
    class Twitch : AIOChampion
    {
        #region Initialize and Declare

        private static Spell.Active _q, _e, _r, _recall;
        private static Spell.Skillshot _w, _r2;
        private static readonly int[] RBonusAd = {20, 30, 40};
        private static readonly int[] EStackDamage = {15, 20, 25, 30, 35};
        private static readonly int[] EBaseDamage = {20, 35, 50, 65, 80};
        private static readonly Vector2 Offset = new Vector2(1, 0);



        public override void Init()
        {

            try
            {
                //spells
                _q = new Spell.Active(SpellSlot.Q);
                _w = new Spell.Skillshot(SpellSlot.W, 925, SkillShotType.Circular, 250, 1400, 275)
                {
                    AllowedCollisionCount = int.MaxValue
                };
                _e = new Spell.Active(SpellSlot.E, 1200);
                _r = new Spell.Active(SpellSlot.R, 900);
                _r2 = new Spell.Skillshot(SpellSlot.R, 1200, SkillShotType.Linear, 0, 3000, 100)
                {
                    AllowedCollisionCount = int.MaxValue
                };


                _recall = new Spell.Active(SpellSlot.Recall);

                //menu

                //combo
                MainMenu.ComboKeys(true, true, true, true);
                MainMenu._combo.AddSeparator();
                MainMenu._combo.AddSlider("combo.q.close", "Use Q when {0} enemies are close", 2, 1, 5, true);
                MainMenu._combo.AddSeparator();
                MainMenu._combo.AddSlider("combo.r.aoe", "Use R when {0} enemies can be hit", 2, 1, 5, true);
                MainMenu._combo.AddSeparator();
                MainMenu._combo.AddGroupLabel("Prediction", "combo.grouplabel.addonmenu", true);
                MainMenu._combo.AddSlider("combo.w.prediction", "Hitchance Percentage for W", 80, 0, 100, true);

                //flee
                MainMenu.FleeKeys(true, true, false, false);
                MainMenu._flee.AddSeparator();
                MainMenu._flee.AddGroupLabel("Mana Manager:", "flee.grouplabel.addonmenu", true);
                MainMenu.FleeManaManager(true, true, false, false, 20, 40, 0, 0);


                //laneclear
                MainMenu.LaneKeys(false, true, true, false);
                MainMenu._lane.AddSeparator();
                MainMenu._lane.AddCheckBox("lane.execute", "Use E on Siege Minions", true, true);
                MainMenu._lane.AddSeparator();
                MainMenu._lane.AddSlider("lane.w.min", "Min. {0} minions for W", 3, 1, 7, true);
                MainMenu._lane.AddSlider("lane.e.min", "Min. {0} minions for E", 3, 1, 7, true);
                MainMenu._lane.AddSeparator();
                MainMenu._lane.AddGroupLabel("Mana Manager:", "lane.grouplabel.addonmenu", true);
                MainMenu.LaneManaManager(false, true, true, false, 0, 40, 15, 0);

                //jungleclear
                MainMenu.JungleKeys(false, true, false, false, true);
                MainMenu._jungle.AddSeparator();
                MainMenu._jungle.AddGroupLabel("Mana Manager:", "jungle.grouplabel.addonmenu", true);
                MainMenu.JungleManaManager(false, true, true, false, 0, 40, 15, 0);


                //harass
                MainMenu.HarassKeys(false, true, false, false);
                MainMenu._harass.AddSeparator();
                MainMenu._harass.AddGroupLabel("Mana Manager:", "harass.grouplabel.addonmenu", true);
                MainMenu.HarassManaManager(false, true, false, false, 0, 30, 0, 0);

                //ks
                MainMenu.KsKeys(false, false, true, true);
                MainMenu._ks.AddSeparator();
                MainMenu._ks.AddGroupLabel("Mana Manager:", "killsteal.grouplabel.addonmenu", true);
                MainMenu.KsManaManager(false, false, true, true, 0, 0, 5, 30);

                //misc
                MainMenu.MiscMenu();
                MainMenu._misc.Add("misc.recall", new KeyBind("Stealh Recall", false, KeyBind.BindTypes.HoldActive, 'B'));
                MainMenu._misc.AddSeparator();
                MainMenu._misc.AddGroupLabel("Auto E Settings", "misc.grouplabel.addonmenu", true);
                MainMenu._misc.AddCheckBox("misc.e.range", "E if full stacks and timer is below 1 second", true, true);
                MainMenu._misc.AddSeparator();
                MainMenu._misc.AddCheckBox("misc.e.death", "Use E before death", true, true);
                MainMenu._misc.AddSeparator();
                MainMenu._misc.AddSlider("misc.e.health", "Use E below {0}% Health", 10, 0, 100, true);
                MainMenu._misc.AddSlider("misc.e.stacks", "Min {0} stacks on enemy", 6, 1, 6, true);


                //draw
                MainMenu.DrawKeys(false, true, true, true);
                MainMenu._draw.AddSeparator();
                MainMenu._draw.AddCheckBox("draw.hp.bar", "Draw E Damage", true, true);
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                Chat.Print(
                    "<font color='#23ADDB'>Marksman AIO:</font><font color='#E81A0C'> an error ocurred. (Code MENU)</font>");
            }

            try
            {
                Value.Init();
                Game.OnUpdate += GameOnOnUpdate;
                Drawing.OnDraw += GameOnDraw;
                Drawing.OnEndScene += Drawing_OnEndScene;
            }

            catch (Exception e)
            {

                Console.WriteLine(e);
                Chat.Print(
                    "<font color='#23ADDB'>Marksman AIO:</font><font color='#E81A0C'> an error ocurred. (Code INIT)</font>");
            }

        }




        #endregion

        #region Gamerelated Logic

        public override void Combo()
        {
            var target = TargetSelector.GetTarget(_e.Range, DamageType.Physical);

            if (target == null)
            {
                return;
            }

            if (Value.Use("combo.q") && _q.IsReady() && !Ulting)
            {
                if (Player.Instance.CountEnemiesInRange(900) >= Value.Get("combo.q.close"))
                {
                    _q.Cast();
                }
            }

            if (Value.Use("combo.w") && _w.IsReady())
            {
                var targetw = TargetSelector.GetTarget(_w.Range, DamageType.Physical);

                

                if (targetw != null && (!Stealthed && _w.IsInRange(targetw) && EStacks(target) < 5 || !Stealthed && !Player.Instance.IsInAutoAttackRange(targetw)))
                {
                    var wpred = _w.GetPrediction(targetw);

                    if (wpred.HitChancePercent >= Value.Get("combo.w.prediction"))
                    {
                        _w.Cast(wpred.CastPosition);
                    }
                }

                if (Stealthed && target.Distance(Player.Instance.Position) < Player.Instance.GetAutoAttackRange() && EStacks(target) < 5)
                {
                    _w.Cast(target);
                }
            }

            if (Value.Use("combo.e") && _e.IsReady())
            {
                if (EStacks(target) == 6 && _e.IsInRange(target))
                {
                    _e.Cast();
                }
            }

            if (Value.Use("combo.r") && _r.IsReady())
            {
                var targetr = TargetSelector.GetTarget(_r.Range, DamageType.Physical);
                var targetr2 = TargetSelector.GetTarget(_r2.Range, DamageType.Physical);

                if (targetr2 == null)
                {
                    return;
                }

                var r2Pred = _r2.GetPrediction(targetr2);
                var count =
                    r2Pred.CollisionObjects.Count(
                        a =>
                            a.IsValidTarget(_r.Range) && a.IsEnemy && !a.IsZombie && !a.IsDead && !a.IsMinion &&
                            !a.IsMonster);

                if (count >= Value.Get("combo.r.aoe") - 1)
                {
                    _r.Cast();
                }
            }
        }

        public override void Harass()
        {
            var target =
                EntityManager.Heroes.Enemies.OrderByDescending(a => a.TotalAttackDamage)
                    .FirstOrDefault(a => a.IsValidTarget(_w.Range));

            if (target == null)
            {
                return;
            }

            var wpred = _w.GetPrediction(target);

            if (Value.Use("harass.w") && _w.IsReady() && Player.Instance.ManaPercent >= Value.Get("harass.w.mana"))
            {
                if (wpred.HitChancePercent >= Value.Get("combo.w.prediction"))
                {
                    _w.Cast(wpred.CastPosition);
                }
            }
        }

        public override void Laneclear()
        {
            var minionw = EntityManager.MinionsAndMonsters.GetLaneMinions().Where(a => a.IsValidTarget(_w.Range));
            var minione = EntityManager.MinionsAndMonsters.GetLaneMinions(EntityManager.UnitTeam.Enemy,
                Player.Instance.Position, _e.Range);
            var siege =
                EntityManager.MinionsAndMonsters
                    .GetLaneMinions()
                    .FirstOrDefault(
                        a =>
                            a.IsValidTarget(_e.Range) && a.BaseSkinName.Contains("Siege") &&
                            a.HasBuff("twitchdeadlyvenom"));

            var wfarm = EntityManager.MinionsAndMonsters.GetCircularFarmLocation(minionw, _w.Width, (int) _w.Range);

            if (Value.Use("lane.w") && _w.IsReady() && Player.Instance.ManaPercent >= Value.Get("lane.w.mana"))
            {
                if (wfarm.HitNumber >= Value.Get("lane.w.min"))
                {
                    _w.Cast(wfarm.CastPosition);
                }
            }

            if (Value.Use("lane.e") && _e.IsReady() && Player.Instance.ManaPercent >= Value.Get("lane.e.mana"))
            {
                if (minione.Count(a => a.IsValidTarget() && a.HasBuff("twitchdeadlyvenom") && a.Health <= EDamageMinion(a)) >= Value.Get("lane.e.min"))
                {
                    _e.Cast();
                }
            }

            if (Value.Use("lane.execute") && _e.IsReady() && Player.Instance.ManaPercent >= Value.Get("lane.e.mana"))
            {
                if (siege != null)
                {
                    if (siege.Health <= EDamageMinion(siege))
                    {
                        _e.Cast();
                    }
                }
            }

        }

        public override void Jungleclear()
        {
            var monster =
                EntityManager.MinionsAndMonsters.GetJungleMonsters()
                    .FirstOrDefault(
                        a =>
                            a.IsValidTarget(_w.Range) && Variables.SummonerRiftJungleList.Contains(a.BaseSkinName) &&
                            EStacksMinion(a) < 5);

            if (Value.Use("jungle.w") && _w.IsReady() && Player.Instance.ManaPercent >= Value.Get("jungle.w.mana"))
            {
                if (monster != null)
                {
                    _w.Cast(monster);
                }
            }
        }

        public override void Flee()
        {
            var target = TargetSelector.GetTarget(_w.Range, DamageType.Physical);

            if (target == null)
            {
                return;
            }

            var wpred = _w.GetPrediction(target);

            if (Value.Use("flee.w") && _w.IsReady())
            {
                if (wpred.HitChancePercent >= Value.Get("combo.w.prediction"))
                {
                    _w.Cast(wpred.CastPosition);
                }
            }

            if (Value.Use("flee.q") && _q.IsReady())
            {
                _q.Cast();
            }
        }

        private static void GameOnOnUpdate(EventArgs args)
        {

            Ks();

            JungleSteal();

            Recall();

            AutoE();

            AutoEDeath();

        }

        #endregion

        #region Utils

        private static int EStacks(Obj_AI_Base obj)
        {
            var twitchECount = 0;
            for (var i = 1; i < 7; i++)
            {
                if (ObjectManager.Get<Obj_GeneralParticleEmitter>()
                    .Any(e => e.Position.Distance(obj.ServerPosition) <= 125 &&
                              e.Name == "twitch_poison_counter_0" + i + ".troy"))
                {
                    twitchECount = i;
                }
            }
            return twitchECount;
        }

        private static int EStacksMinion(Obj_AI_Minion obj)
        {
            var twitchECount = 0;
            for (var i = 1; i < 7; i++)
            {
                if (ObjectManager.Get<Obj_GeneralParticleEmitter>()
                    .Any(e => e.Position.Distance(obj.ServerPosition) <= 350 &&
                              e.Name == "twitch_poison_counter_0" + i + ".troy"))
                {
                    twitchECount = i;
                }
            }
            return twitchECount;
        }

        private static float ERaw(Obj_AI_Base target)
        {
            var stacks = EStacks(target);
            if (stacks == 0)
            {
                return 0.0f;
            }
            return
                (float)
                    ((EBaseDamage[_e.Level - 1]) +
                     (EStackDamage[_e.Level - 1]*stacks) +
                     (.2*Player.Instance.FlatMagicDamageMod) +
                     (.25*(Player.Instance.TotalAttackDamage - Player.Instance.BaseAttackDamage)));
        }

        private static float ERawMinion(Obj_AI_Minion minion)
        {
            var stacks = EStacksMinion(minion);
            if (stacks == 0)
            {
                return 0.0f;
            }
            return
                (float)
                    ((EBaseDamage[_e.Level - 1]) +
                     (EStackDamage[_e.Level - 1] * stacks) +
                     (.2 * Player.Instance.FlatMagicDamageMod) +
                     (.25 * (Player.Instance.TotalAttackDamage - Player.Instance.BaseAttackDamage)));
        }

        public static float PassiveTime(Obj_AI_Base target)
        {
            if (target.HasBuff("twitchdeadlyvenom"))
            {
                return Math.Max(0, target.GetBuff("twitchdeadlyvenom").EndTime) - Game.Time;
            }
            return 0;
        }

        public static float Passivedamage(Obj_AI_Base target)
        {
            float dmg = 0;
            if (!target.HasBuff("twitchdeadlyvenom")) return 0;

            if (Player.Instance.Level < 5)
            {
                dmg = 2;
            }
            if (Player.Instance.Level < 9)
            {
                dmg = 3;
            }
            if (Player.Instance.Level < 13)
            {
                dmg = 4;
            }
            if (Player.Instance.Level < 17)
            {
                dmg = 5;
            }
            if (Player.Instance.Level == 18)
            {
                dmg = 6;
            }
            return (dmg * EStacks(target) * PassiveTime(target)) - target.HPRegenRate * PassiveTime(target);
        }



        private static float EDamage(Obj_AI_Base target)
        {
            return Player.Instance.CalculateDamageOnUnit(target, DamageType.Physical, ERaw(target))*
                   (Player.Instance.HasBuff("summonerexhaust") ? 0.6f : 1);
        }

        private static float EDamageMinion(Obj_AI_Minion minion)
        {
            return Player.Instance.CalculateDamageOnUnit(minion, DamageType.Physical, ERawMinion(minion)) *
                   (Player.Instance.HasBuff("summonerexhaust") ? 0.6f : 1);
        }

        private static void Ks()
        {
            foreach (var enemy in EntityManager.Heroes.Enemies.Where(
                    a =>
                        a.IsValidTarget(_e.Range) && !a.IsDead && !a.IsZombie && a.HasBuff("twitchdeadlyvenom")))
            {
                if (Value.Use("killsteal.e") && _e.IsReady() && Player.Instance.ManaPercent >= Value.Get("killsteal.e.mana"))
                {
                    if (enemy.TotalShieldHealth() <= EDamage(enemy))
                    {
                        _e.Cast();
                    }

                    if (enemy.Distance(Player.Instance.Position) > 900 &&
                        enemy.TotalShieldHealth() <= EDamage(enemy) + Passivedamage(enemy))
                    {
                        _e.Cast();
                    }
                }            
            }
            
            
            if (Value.Use("killsteal.r") && _r.IsReady() && Player.Instance.ManaPercent >= Value.Get("killsteal.r.mana"))
            {
                var rks = TargetSelector.GetTarget(_r.Range, DamageType.Physical);

                if (rks != null)
                {
                    if (rks.Distance(Player.Instance.Position) > Player.Instance.GetAutoAttackRange() &&
                        rks.Health <= Player.Instance.TotalAttackDamage + RBonusAd[_r.Level - 1]*2 && rks.CountAlliesInRange(550) == 0)
                    {
                        _r.Cast();
                        Player.IssueOrder(GameObjectOrder.AutoAttack, rks);
                    }
                }
            }
        }

        private static void AutoEDeath()
        {
            var targete =
                EntityManager.Heroes.Enemies.FirstOrDefault(
                    a => a.IsValidTarget(_e.Range) && a.HasBuff("twitchdeadlyvenom") && EStacks(a) > Value.Get("misc.e.stacks"));

            if (_e.IsReady() && Value.Use("misc.e.death") && targete != null)
            {
                if (Player.Instance.HealthPercent <= Value.Get("misc.e.health"))
                {
                    _e.Cast();
                }
            }
        }

        private static void JungleSteal()
        {
            var monster =
                EntityManager.MinionsAndMonsters.GetJungleMonsters()
                    .FirstOrDefault(
                        a =>
                            a.IsValidTarget(_e.Range) && a.HasBuff("twitchdeadlyvenom") && a.Health <= EDamageMinion(a));

            if (Value.Use("jungle.stealenabled") && _e.IsReady() && Player.Instance.ManaPercent >= Value.Get("jungle.e.mana"))
            {
                if (monster != null)
                {
                    if (monster.BaseSkinName == "SRU_Baron" && Value.Use("jungle.SRU_Baron"))
                    {
                        _e.Cast();
                    }

                    if (monster.BaseSkinName == ("SRU_Dragon") && Value.Use("jungle.SRU_Dragon"))
                    {
                        _e.Cast();
                    }

                    if (monster.BaseSkinName == ("SRU_Blue") && Value.Use("jungle.SRU_Blue"))
                    {
                        _e.Cast();
                    }

                    if (monster.BaseSkinName == ("SRU_Red") && Value.Use("jungle.SRU_Red"))
                    {
                        _e.Cast();
                    }

                    if (monster.BaseSkinName == ("SRU_Gromp") && Value.Use("jungle.SRU_Gromp"))
                    {
                        _e.Cast();
                    }

                    if (monster.BaseSkinName == ("SRU_Murkwolf") && Value.Use("jungle.SRU_Murkwolf"))
                    {
                        _e.Cast();
                    }

                    if (monster.BaseSkinName == ("SRU_Krug") && Value.Use("jungle.SRU_Krug"))
                    {
                        _e.Cast();
                    }

                    if (monster.BaseSkinName == ("SRU_Razorbeak") && Value.Use("jungle.SRU_Razorbeak"))
                    {
                        _e.Cast();
                    }

                    if (monster.BaseSkinName == ("SRU_Crab") && Value.Use("jungle.SRU_Crab"))
                    {
                        _e.Cast();
                    }
                }
            }
        }

        private static void Recall()
        {
            if (Value.Active("misc.recall"))
            {
                if (_q.IsReady() && _recall.IsReady())
                {
                    _q.Cast();
                    _recall.Cast();
                }
            }
        }

        private static void AutoE()
        {
            foreach (var enemy in EntityManager.Heroes.Enemies.Where(a => a.HasBuff("twitchdeadlyvenom") && a.IsValidTarget(_e.Range)))
            {
                if (Value.Use("misc.e.range") && _e.IsReady())
                {
                    if (EStacks(enemy) == 6 && PassiveTime(enemy) < 1)
                    {
                        _e.Cast();
                    }
                }
            }
        }

    private static bool Stealthed
        {
            get { return Player.Instance.HasBuff("TwitchHideInShadows"); }
        }

        private static bool Ulting
        {
            get { return Player.Instance.HasBuff("TwitchFullAutomatic"); }
        }

        #endregion

        #region Drawings
        private static void GameOnDraw(EventArgs args)
        {
            Color colorW = MainMenu._draw.GetColor("color.w");
            var widthW = MainMenu._draw.GetWidth("width.w");
            Color colorE = MainMenu._draw.GetColor("color.e");
            var widthE = MainMenu._draw.GetWidth("width.e");
            Color colorR = MainMenu._draw.GetColor("color.r");
            var widthR = MainMenu._draw.GetWidth("width.r");


            if (!Value.Use("draw.disable"))
            {
                if (Value.Use("draw.w") && ((Value.Use("draw.ready") && _w.IsReady()) || !Value.Use("draw.ready")))
                {
                    new Circle
                    {
                        Color = colorW,
                        Radius = _w.Range,
                        BorderWidth = widthW
                    }.Draw(Player.Instance.Position);
                }
                if (Value.Use("draw.e") && ((Value.Use("draw.ready") && _e.IsReady()) || !Value.Use("draw.ready")))
                {
                    new Circle
                    {
                        Color = colorE,
                        Radius = _e.Range,
                        BorderWidth = widthE
                    }.Draw(Player.Instance.Position);
                }
                if (Value.Use("draw.r") && ((Value.Use("draw.ready") && _r.IsReady()) || !Value.Use("draw.ready")))
                {
                    new Circle
                    {
                        Color = colorR,
                        Radius = _r.Range,
                        BorderWidth = widthR
                    }.Draw(Player.Instance.Position);
                }
            }
        }

        private static void Drawing_OnEndScene(EventArgs args)
        {
            if (Value.Use("draw.hp.bar"))
            {
                foreach (var enemy in EntityManager.Heroes.Enemies.Where(a => !a.IsDead && a.HasBuff("twitchdeadlyvenom") && a.IsHPBarRendered))
                {
                    var damage = EDamage(enemy);
                    var damagepercent = ((enemy.TotalShieldHealth() - damage) > 0 ? (enemy.TotalShieldHealth() - damage) : 0) / (enemy.MaxHealth + enemy.AllShield + enemy.AttackShield + enemy.MagicShield);                                             
                    var hppercent = enemy.TotalShieldHealth() / (enemy.MaxHealth + enemy.AllShield + enemy.AttackShield + enemy.MagicShield);
                    var start = new Vector2((int)(enemy.HPBarPosition.X + Offset.X + damagepercent * 104), (int)(enemy.HPBarPosition.Y + Offset.Y) - 5);
                    var end = new Vector2((int)(enemy.HPBarPosition.X + Offset.X + hppercent * 104) + 2, (int)(enemy.HPBarPosition.Y + Offset.Y) - 5);

                    Drawing.DrawLine(start, end, 9, Color.Chartreuse);
                }
            }
        }
        #endregion 
    }
}
