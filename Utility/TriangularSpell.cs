using EloBuddy;
using EloBuddy.SDK;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKTRAIO.Utility.Spell
{
	class Triangular
	{
		private SpellSlot _slot;
		private float _delay1, _delay2, _mspeed1, _mspeed2, _range1, _range2, _rangeMain, _spellWidth;
		public Triangular(SpellSlot slot, float delay1, float delay2, float mspeed1, float mspeed2, float range1, float range2, float SpellWidth)
		{
			_slot = slot;
			_delay1 = delay1;
			_delay2 = delay2;
			_mspeed1 = mspeed1;
			_mspeed2 = mspeed2;
			_range1 = range1;
			_range2 = range2;
			_spellWidth = SpellWidth;
			_rangeMain = CalcLength(_range1, range2);
		}

		public float Range
		{
			get
			{
				return _rangeMain;
			}
		}

		public bool Cast(Vector3 target)
		{
			if (Player.Instance.Distance(target) > _rangeMain)
				return false;
			float RecastDelay = CalcDelay(target);
			Vector3 CastPos = CalcCastPos(target);
			Player.CastSpell(_slot, CastPos);
			Core.DelayAction(RecastSpell, (int)RecastDelay);
			return true;
		}

		private void RecastSpell()
		{
			Player.CastSpell(SpellSlot.Q);
		}

		private float DegToRad(float deg)
		{
			return (float)(deg * (180.0 / Math.PI));
		}

		private Vector3 CalcCastPos(Vector3 target)
		{
			float len = CalcNeededLen(Player.Instance.Distance(target));
			return (target - Player.Instance.Position).To2D().Rotated(DegToRad(45.0f)).To3D();
		}

		private float CalcDelay(Vector3 target)
		{
			float len = CalcNeededLen(Player.Instance.Distance(target));
			return _delay1 + (len / _mspeed1);
		}

		private float CalcNeededLen(float length)
		{
			float q = length / 2.0f;
			return (float)Math.Sqrt(q * length);
		}


		private float CalcLength(float _range1, float range2)
		{
			return (float)Math.Sqrt(Math.Pow(_range1, 2) + Math.Pow(_range2, 2));
		}
	}
}
