using System;
using System.Collections.Generic;
using System.Linq;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;
using EloBuddy.SDK.Menu.Values;
using EloBuddy.SDK.Rendering;
using OKTRAIO;
using OKTRAIO.Champions;
using OKTRAIO.Menu_Settings;
using OKTRAIO.Utility;
using SharpDX;
using Color = System.Drawing.Color;

namespace OKTRAIO.Champions
{
	class VelKoz: AIOChampion
	{
		private Utility.Spell.Triangular _q;
		private Spell.Skillshot _qFallBack, _w, _e, _r;
		public override void Init()
		{
			throw new Exception("inDev");
			MainMenu.ComboKeys(true, true, true, true);
			MainMenu.HarassKeys(true, true, false, false);
			_q = new Utility.Spell.Triangular(SpellSlot.Q, 250.0f, 250.0f, 1300.0f, 2100.0f, 1050.0f, 1050.0f, 45.0f);
			_qFallBack = new Spell.Skillshot(SpellSlot.Q, 1050, SkillShotType.Linear, 250, 1300, 45);
			_w = new Spell.Skillshot(SpellSlot.W, 1050, SkillShotType.Linear, 250, 1700, 80);
			_e = new Spell.Skillshot(SpellSlot.E, 850, SkillShotType.Circular, 500, 1500, 120);
			_r = new Spell.Skillshot(SpellSlot.R, 1550, SkillShotType.Linear);
		}

		public override void Combo()
		{
			Obj_AI_Base target = GetTarget();
			if (target == null)
				return;
			_e.Cast(target);
			_w.Cast(target);
			AttemptCastQ(target);
		}

		//needs more selection logic
		private void AttemptCastQ(Obj_AI_Base target)
		{
			if (_q.Cast(target.Position))
				return;
			_qFallBack.Cast(target);
		}

		private Obj_AI_Base GetTarget()
		{
			var targ = TargetSelector.GetTarget(_e.Range, DamageType.Magical);
			if (targ != null)
				return targ;
			targ = TargetSelector.GetTarget(_w.Range, DamageType.Magical);
			if (targ != null)
				return targ;
			targ = TargetSelector.GetTarget(_q.Range, DamageType.Magical);
			if (targ != null)
				return targ;
			targ = TargetSelector.GetTarget(_r.Range, DamageType.Magical);
			if (targ != null)
				return targ;
			return null;
		}
	}
}
