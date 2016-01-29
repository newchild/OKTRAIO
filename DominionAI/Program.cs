using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
using SharpDX;

namespace DominionAI
{
	class DominionAI
	{

		private MovementHandler _moveHandler;
		private SpellCastHandler _spellHandler;
		private ItemHandler _itemHandler;
		private EvadeHandler _evadeHandler;
		private ActionHandler _actionHandler;
		private ChatHandler _chatHandler;


		public DominionAI()
		{
			Console.WriteLine("Loading Dominion AI");
			if (Game.Type != GameType.Dominion)
				return;
			Console.WriteLine("Loaded Dominion AI");
			_moveHandler = new MovementHandler();
			_spellHandler = new SpellCastHandler();
			_itemHandler = new ItemHandler();
			_evadeHandler = new EvadeHandler();
			_actionHandler = new ActionHandler();
			_chatHandler = new ChatHandler();
			Game.OnTick += Game_OnTick;
			Obj_AI_Base.OnSpellCast += AIHeroClient_OnSpellCast;
		}

		private void AIHeroClient_OnSpellCast(Obj_AI_Base sender, GameObjectProcessSpellCastEventArgs args)
		{
			if (sender.Team != Player.Instance.Team && sender.Team != GameObjectTeam.Neutral)
				_evadeHandler.OnSpellcast(sender, args);
			_actionHandler.OnSpellcast(sender, args);
		}

		private void Game_OnTick(EventArgs args)
		{
			_moveHandler.Tick();
			_spellHandler.Tick();
			_itemHandler.Tick();
			_evadeHandler.Tick();
			_actionHandler.Tick();
			_chatHandler.Tick();
		}
	}
}
