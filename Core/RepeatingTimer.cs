using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace aoe_test_bot_2.Core
{
    internal static class RepeatingTimer
    {
        private static Timer loopingTimer;
        private static SocketTextChannel channel;

        internal static Task StartTimer()
        {
            channel = Global.Client.GetGuild(391212220618506240).GetTextChannel(391212220618506242);
            //channel = Global.Client.GetGuild(264366364695855114).GetTextChannel(264366364695855114);
            loopingTimer = new Timer()
            {
                Interval = 750,
                AutoReset = true,
                Enabled = true
            };
            loopingTimer.Elapsed += OnTimerTicked;

            return Task.CompletedTask;
        }

        private static async void OnTimerTicked(object sender, ElapsedEventArgs e)
        {
            await channel.SendMessageAsync("🧀");
        }
    }
}
