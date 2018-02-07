using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using aoe_test_bot_2.Core.UserAccounts;
using NReco.ImageGenerator;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace aoe_test_bot_2.Modules
{
    public class Casino : ModuleBase<SocketCommandContext>
    {
        [Command("Slot")]
        public async Task Slot(uint geld)
        {
            var account = UserAccounts.GetAccount(Context.User);
            if (account.Geld > geld)
            {
                
                string[] options = { ":gem:\n:bell:\n:moneybag:", ":bell:\n:moneybag:\n:crown:", ":moneybag:\n:crown:\n:jack_o_lantern:", ":crown:\n:jack_o_lantern:\n:gem:", ":jack_o_lantern:\n:gem:\n:bell:" };
                Random r = new Random();
                var embed = new EmbedBuilder();
                string eerste = options[r.Next(0, options.Length)];
                string tweede = options[r.Next(0, options.Length)];
                string derde = options[r.Next(0, options.Length)];

                embed.WithColor(255, 69, 0);
                embed.AddInlineField("Slots", eerste);
                embed.AddInlineField("Slots", tweede);
                embed.AddInlineField("Slots", derde);

                account.Geld -= geld;
                UserAccounts.SaveAccounts();
                await Context.Channel.SendMessageAsync("", embed: embed);
                var embed2 = new EmbedBuilder();

                if (eerste == tweede & eerste == derde)
                {
                    uint Geld = geld * 3;
                    account.Geld += Geld;
                    UserAccounts.SaveAccounts();
                    embed2.WithDescription($":smiley: Uw inzet 3X verhoogt, U hebt €{Geld},- winst.\nUw heeft €{account.Geld},-");
                }
                else
                {
                    if (eerste == tweede)
                    {
                        uint Geld = geld * 2;
                        account.Geld += Geld;
                        UserAccounts.SaveAccounts();
                        embed2.WithDescription($":smiley: Uw inzet 2X verhoogt, U hebt €{Geld},- winst.\nUw heeft €{account.Geld},-");
                    }
                    else
                    {
                        if (eerste == derde)
                        {
                            uint Geld = geld * 2;
                            account.Geld += Geld;
                            UserAccounts.SaveAccounts();
                            embed2.WithDescription($":smiley: Uw inzet 2X verhoogt, U hebt €{Geld},- winst.\nUw heeft €{account.Geld},-");
                        }
                        else
                        {
                            if (tweede == derde)
                            {
                                uint Geld = geld * 2;
                                account.Geld += Geld;
                                UserAccounts.SaveAccounts();
                                embed2.WithDescription($":smiley: Uw inzet 2X verhoogt, U hebt €{Geld},- winst.\nUw heeft €{account.Geld},-");
                            }
                            else
                            {
                                embed2.WithDescription($":sob: jammer je hebt €{geld},- verloren, je hebt nog €{account.Geld},- over probeer het nog eens");
                            }
                        }
                    }
                }
                UserAccounts.SaveAccounts();
                embed2.WithCurrentTimestamp();
                embed2.WithColor(255, 69, 0);
                embed2.WithThumbnailUrl("https://media.giphy.com/media/xUOwFTxJtylRggNwhG/giphy.gif");
                await Context.Channel.SendMessageAsync("", embed: embed2);
            }
            else
            {
                await Context.Channel.SendMessageAsync(":x: je hebt niet genoeg geld om dit te doen :x:");
            }
        }
    }
}
