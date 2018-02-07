using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using aoe_test_bot_2.Core.UserAccounts;

namespace aoe_test_bot_2.Modules
{
    public class AdminCommands : ModuleBase<SocketCommandContext>
    {
        [Command("Save")]
        public async Task Save(string message1, [Remainder]string message2)
        {
            var embed = new EmbedBuilder();
            embed.WithDescription($"laad het weer met de Key, de key is {message1}, stored bericht is: {message2}");
            embed.WithColor(0, 255, 0);
            embed.WithCurrentTimestamp();
            embed.WithFooter($"saved by { Context.User.Username}");
            embed.WithTitle("saved");
            embed.WithColor(255, 255, 0);
            await Context.Channel.SendMessageAsync("", false, embed);
            DataStorage.AddPairtostorage(message1, message2);
        }
        //load?

        [Command("data")]
        [RequireUserPermission(GuildPermission.Administrator)]
        public async Task GetData()
        {
            await Context.Channel.SendMessageAsync("Data Has " + DataStorage.GetPairsCount() + " pairs");
        }

        [Command("addXP")]
        [RequireUserPermission(GuildPermission.Administrator)]
        public async Task AddXP(uint xp, [Remainder]string arg = "")
        {
            SocketUser target = null;
            var mentionedUser = Context.Message.MentionedUsers.FirstOrDefault();
            target = mentionedUser ?? Context.User;

            var account = UserAccounts.GetAccount(target);
            account.XP += xp;
            UserAccounts.SaveAccounts();

            var embed = new EmbedBuilder();
            embed.WithColor(255, 255, 0);
            embed.WithDescription($"{target.Username} heeft {xp} XP erbij gekregen");
            embed.WithTitle("Add XP");
            embed.WithCurrentTimestamp();
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("addGeld")]
        [RequireUserPermission(GuildPermission.Administrator)]
        public async Task AddGeld(uint Geld, [Remainder]string arg = "")
        {
            SocketUser target = null;
            var mentionedUser = Context.Message.MentionedUsers.FirstOrDefault();
            target = mentionedUser ?? Context.User;

            var account = UserAccounts.GetAccount(target);
            account.Geld += Geld;
            UserAccounts.SaveAccounts();

            var embed = new EmbedBuilder();
            embed.WithDescription($"{target.Username} heeft €{Geld} erbij gekregen");
            embed.WithTitle("Add Geld");
            embed.WithColor(255, 255, 0);
            embed.WithCurrentTimestamp();
            await Context.Channel.SendMessageAsync("", false, embed);
        }
    }
}
