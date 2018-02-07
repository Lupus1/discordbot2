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

namespace aoe_test_bot_2.CODE_commands
{
    public class code_command : ModuleBase<SocketCommandContext>
    {
        [Command("Decode")]
        public async Task Decode(string letter, string letter2, string letter3, string letter4, string letter5, string letter6)
        {
            if (!UserHasDeCode((SocketGuildUser)Context.User))
            {
                await Context.Channel.SendMessageAsync(":x: je hebt niet de rol voor dit command " + Context.User.Username);
                return;
            }

            var embed = new EmbedBuilder();
            embed.WithDescription("`" + Utilities.GetAlert(letter) + Utilities.GetAlert(letter2) + Utilities.GetAlert(letter3) + Utilities.GetAlert(letter4) + Utilities.GetAlert(letter5) + Utilities.GetAlert(letter6) + "`");
            embed.WithColor(new Color(255, 0, 0));
            embed.WithCurrentTimestamp();
            embed.WithTitle("DECODED message");

            var dmchannel = await Context.User.GetOrCreateDMChannelAsync();
            await dmchannel.SendMessageAsync("", false, embed);
            await Context.Channel.SendMessageAsync("Done");
        }

        [Command("Decode")]
        public async Task Decode(string letter, string letter2, string letter3, string letter4, string letter5)
        {
            if (!UserHasDeCode((SocketGuildUser)Context.User))
            {
                await Context.Channel.SendMessageAsync(":x: je hebt niet de rol voor dit command " + Context.User.Username);
                return;
            }

            var embed = new EmbedBuilder();
            embed.WithDescription("`" + Utilities.GetAlert(letter) + Utilities.GetAlert(letter2) + Utilities.GetAlert(letter3) + Utilities.GetAlert(letter4) + Utilities.GetAlert(letter5) + "`");
            embed.WithColor(new Color(255, 0, 0));
            embed.WithCurrentTimestamp();
            embed.WithTitle("DECODED message");

            var dmchannel = await Context.User.GetOrCreateDMChannelAsync();
            await dmchannel.SendMessageAsync("", false, embed);
            await Context.Channel.SendMessageAsync("Done");
        }

        [Command("Decode")]
        public async Task Decode(string letter, string letter2, string letter3, string letter4)
        {
            if (!UserHasDeCode((SocketGuildUser)Context.User))
            {
                await Context.Channel.SendMessageAsync(":x: je hebt niet de rol voor dit command " + Context.User.Username);
                return;
            }

            var embed = new EmbedBuilder();
            embed.WithDescription("`" + Utilities.GetAlert(letter) + Utilities.GetAlert(letter2) + Utilities.GetAlert(letter3) + Utilities.GetAlert(letter4) + "`");
            embed.WithColor(new Color(255, 0, 0));
            embed.WithCurrentTimestamp();
            embed.WithTitle("DECODED message");

            var dmchannel = await Context.User.GetOrCreateDMChannelAsync();
            await dmchannel.SendMessageAsync("", false, embed);
            await Context.Channel.SendMessageAsync("Done");
        }

        [Command("Decode")]
        public async Task Decode(string letter, string letter2, string letter3)
        {
            if (!UserHasDeCode((SocketGuildUser)Context.User))
            {
                await Context.Channel.SendMessageAsync(":x: je hebt niet de rol voor dit command " + Context.User.Username);
                return;
            }

            var embed = new EmbedBuilder();
            embed.WithDescription("`" + Utilities.GetAlert(letter) + Utilities.GetAlert(letter2) + Utilities.GetAlert(letter3) + "`");
            embed.WithColor(new Color(255, 0, 0));
            embed.WithCurrentTimestamp();
            embed.WithTitle("DECODED message");

            var dmchannel = await Context.User.GetOrCreateDMChannelAsync();
            await dmchannel.SendMessageAsync("", false, embed);
            await Context.Channel.SendMessageAsync("Done");
        }

        [Command("Decode")]
        public async Task Decode(string letter, string letter2)
        {
            if (!UserHasDeCode((SocketGuildUser)Context.User))
            {
                await Context.Channel.SendMessageAsync(":x: je hebt niet de rol voor dit command " + Context.User.Username);
                return;
            }

            var embed = new EmbedBuilder();
            embed.WithDescription("`" + Utilities.GetAlert(letter) + Utilities.GetAlert(letter2) + "`");
            embed.WithColor(new Color(255, 0, 0));
            embed.WithCurrentTimestamp();
            embed.WithTitle("DECODED message");

            var dmchannel = await Context.User.GetOrCreateDMChannelAsync();
            await dmchannel.SendMessageAsync("", false, embed);
            await Context.Channel.SendMessageAsync("Done");
        }

        private bool UserHasDeCode(SocketGuildUser user)
        {
            //user.Guild.Roles
            string targetRoleName = "DeCode";
            var result = from r in user.Guild.Roles
                         where r.Name == targetRoleName
                         select r.Id;
            ulong roleID = result.FirstOrDefault();
            if (roleID == 0)
            {
                Console.WriteLine("role " + targetRoleName + " Not Found in server " + Context.Guild);
                return false;
            }
            var targetRole = user.Guild.GetRole(roleID);
            return user.Roles.Contains(targetRole);
        }

    }
}
