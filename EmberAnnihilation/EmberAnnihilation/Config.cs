using System;
using Ensage.Common.Menu;
using Ensage.SDK.Menu;
using System.Collections.Generic;

namespace EmberAnnihilation
{
    public class Config : IDisposable
    {
        public Config()
        {
            Factory = MenuFactory.Create("Ember Annihilation");
            FistAndComboKey = Factory.Item("Fist + Chain Key", new KeyBind('F'));
            RemntantCombo = Factory.Item("3x Remntant Combo", new KeyBind('D'));
            PussyKey = Factory.Item("Pussy key", new KeyBind('G'));
            AutoChain = Factory.Item("Auto chain in fist", true);
        }
public MenuItem<AbilityToggler> UseItemsInit { get; }
public MenuItem<AbilityToggler> UseItems { get; }

public MenuFactory Menu { get; }
public MenuItem<bool> Enabled { get; }
public MenuItem<KeyBind> Key { get; }        
public MenuItem<KeyBind> PussyKey { get; set; }

        public MenuItem<bool> AutoChain { get; set; }

        public MenuItem<KeyBind> RemntantCombo { get; set; }

        public MenuFactory Factory { get; }

        public MenuItem<KeyBind> FistAndComboKey { get; }

public Dictionary<string, bool> Items = new Dictionary<string, bool>
{
{ "item_blade_mail", true },
{ "item_lotus_orb", true },
{ "item_mjollnir", true },
{ "item_black_king_bar", false },
{ "item_shivas_guard", true },
{ "item_bloodthorn", true },
{ "item_rod_of_atos", true },
{ "item_orchid", true },
{ "item_veil_of_discord", true },
{ "item_ethereal_blade", true },
{ "item_dagon", true }
};
        public void Dispose()
        {
            Factory?.Dispose();
        }
    }
}
