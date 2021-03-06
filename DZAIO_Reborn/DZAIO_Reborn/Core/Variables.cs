﻿using System;
using System.Collections.Generic;
using DZAIO_Reborn.Plugins.Champions.Ahri;
using DZAIO_Reborn.Plugins.Champions.Bard;
using DZAIO_Reborn.Plugins.Champions.Trundle;
using DZAIO_Reborn.Plugins.Champions.Veigar;
using DZAIO_Reborn.Plugins.Interface;
using LeagueSharp;
using LeagueSharp.Common;
using Menu = LeagueSharp.Common.Menu;

namespace DZAIO_Reborn.Core
{
    class Variables
    {
        public static Bootstrap BootstrapInstance;

        public static Menu AssemblyMenu = new Menu("DZAio: Reborn","dzaio", true);

        public static Orbwalking.Orbwalker Orbwalker = new Orbwalking.Orbwalker(AssemblyMenu);

        public static Dictionary<String, Func<IChampion>> ChampList = new Dictionary<string, Func<IChampion>>
        {
            {"Trundle", () => new  Trundle()},
            {"Veigar", () => new Veigar()},
            {"Ahri", ()=> new Ahri()},
            {"Bard", ()=> new Bard()}
        };

        public static IChampion CurrentChampion { get; set; }

        public static Dictionary<SpellSlot, Spell> Spells
            => CurrentChampion?.GetSpells();
    }
}
