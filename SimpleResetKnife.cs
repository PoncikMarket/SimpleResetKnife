using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Commands;

namespace SimpleResetKnifePlugin;

public partial class SimpleResetKnife : BasePlugin
{
    public override string ModuleName => "ResetKnife";
    public override string ModuleVersion => "0.0.4";
    public override string ModuleAuthor => "Poncik";
    public override string ModuleDescription => "Reset Knife Plugin";

    public override void Load(bool hotReload)
    {
    }

    [ConsoleCommand("css_rk", "Gives default knife!")]
    [CommandHelper(whoCanExecute: CommandUsage.CLIENT_ONLY)]
    public void GiveDefaultKnifeCommand(CCSPlayerController? player, CommandInfo command)
    {
        if (player == null) return;

        player.GiveNamedItem("weapon_knife");
        player.PrintToChat("[ResetKnife] Knife Given.");
    }
}