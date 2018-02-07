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
    public class Misc : ModuleBase<SocketCommandContext>
    {
        [Command("translate")]
        public async Task Translate(string taal1, [Remainder]string message)
        {
            /*string translate = "";
            using (WebClient client = new WebClient())
            {
                translate = client.DownloadString("https://translate.google.nl/?#auto/" + taal1 + "/" + message); 
            }*/
            await Context.Channel.SendMessageAsync("https://translate.google.nl/?#auto/" + taal1 + "/" + message);
        }

        [Command("person")]
        public async Task GetRandomPerson()
        {
            string json = "";
            using (WebClient client = new WebClient())
            {
                json = client.DownloadString("https://randomuser.me/api/");
            }

            var dataObject = JsonConvert.DeserializeObject<dynamic>(json);

            string firstname = dataObject.results[0].name.first.ToString();
            string lastname = dataObject.results[0].name.last.ToString();
            string avartarURL = dataObject.results[0].picture.large.ToString();
            string City = dataObject.results[0].location.city.ToString();
            string State = dataObject.results[0].location.state.ToString();

            var embed = new EmbedBuilder();
            embed.WithCurrentTimestamp();
            embed.WithColor(54, 57, 62); 
            embed.WithTitle("the new you");
            embed.WithThumbnailUrl(avartarURL);
            embed.AddInlineField("first Name", firstname);
            embed.AddInlineField("Last Name", lastname);
            embed.AddInlineField("City", City);
            embed.AddInlineField("State", State);
            await Context.Channel.SendMessageAsync("", embed: embed);
        }

        [Command("verander_kleur")]
        public async Task verander_kleur(string kleur = "white")
        {
            var account = UserAccounts.GetAccount(Context.User);
            if(account.Geld > 100)
            {
                account.Color = kleur;
                account.Geld -= 100;
                UserAccounts.SaveAccounts();

                var embed = new EmbedBuilder();
                embed.WithColor(255, 255, 0);
                embed.WithTitle($"{Context.User.Username} heeft zij kleur verandert");
                embed.WithDescription($"{Context.User.Username} heeft trots zijn kleur naar {kleur} verandert");
                embed.WithCurrentTimestamp();
                await Context.Channel.SendMessageAsync("", false, embed);
            }
            else
            {
                var embed = new EmbedBuilder();
                embed.WithCurrentTimestamp();
                embed.WithColor(255, 0, 0);
                embed.WithDescription(":x: je hebt teweing geld hiervoor, je hebt €100,- nodig :x:");
                await Context.Channel.SendMessageAsync("", false, embed);
            }
        }
        [Command("Hoi")]
        public async Task Hoi()
        {
            var account = UserAccounts.GetAccount(Context.User);

            //#36393e  #2f3338
            string css = "<style>\n    body{\n    background-color: #36393e\n}\n    h1{\n        color: " + account.Color + ";\n    }\n";
            string html = String.Format("</style>\n<h1>hello {0}!</h1>", Context.User.Username);
            var converter = new HtmlToImageConverter();
            converter.Width = 250;
            converter.Height = 50;
            var jpgBytes = converter.GenerateImage(css + html, NReco.ImageGenerator.ImageFormat.Jpeg);
            await Context.Channel.SendFileAsync(new MemoryStream(jpgBytes), "Hello.jpg");
        }

        [Command("Stats")]
        public async Task Stats([Remainder]string arg = "")
        {
            SocketUser target = null;
            var mentionedUser = Context.Message.MentionedUsers.FirstOrDefault();
            target = mentionedUser ?? Context.User;

            var account = UserAccounts.GetAccount(target);

            var embed = new EmbedBuilder();
            embed.WithColor(255, 255, 0);
            embed.WithTitle($"stats of {target}");
            embed.WithDescription($"{target.Username} has {account.XP} XP, €{account.Geld},- and his color is {account.Color}");
            embed.WithThumbnailUrl(target.GetAvatarUrl());
            embed.WithCurrentTimestamp();

            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("Help")]
        public async Task Help()
        {
            // W.I.P (\n voor nieuwe regel
            var embed = new EmbedBuilder();
            embed.WithColor(255, 255, 0);
            embed.WithTitle("Help menu \n Commands");
            embed.WithDescription("[] en <> moet je weglaten, als er [] staat is de inhoud verplicht, als er <> staat is de inhoud optioneel\n\nstats:      laat de stats van jou of de @mention persoon zien `stats <@user>` \necho:       laat de bot je bericht echoën `echo [je bericht]`\nHello:      de bot groet je `hello`\npick:       een random bericht, je kan oneindig veel opties hebben `pick [1|2|3]`\nsave:       saved je data `save [key] [data]`\nload:       load je gesaved data doormiddel van de key `load [key]`\naddxp:      add xp `addxp [hoeveel] <@user>`\naddgeld:    add geld `addgeld [hoeveel] <@user>`\nperson:     laat een random persoon zien met foto, naam en plaats `person`\ntranslate:  geef een link met de vertaling `translate [taal1] [text]`");
            embed.WithCurrentTimestamp();
            embed.WithFooter($"door {Context.User.Username}");

            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("Echo")]
        public async Task Echo([Remainder]string message)
        {
            var account = UserAccounts.GetAccount(Context.User);

            string css = "<style>\n    body{\n    background-color: #36393e;\n}\n    h1{\n        color: " + account.Color + ";\n    }\n    h5{\n        color: blue;\n    }";
            string html = string.Format("\n</style>\n<h1>{0}</h1>\n<h5>bericht door {1}</h5>", message, Context.User.Username);

            var converter = new HtmlToImageConverter();
            converter.Width = 400;
            converter.Height = 80;
            var jpgBytes = converter.GenerateImage(css + html, NReco.ImageGenerator.ImageFormat.Jpeg);
            await Context.Channel.SendFileAsync(new MemoryStream(jpgBytes), "echo.jpg");

            /*
            var embed = new EmbedBuilder();
                        
            embed.WithTitle("message door " + Context.User.Username);
            embed.WithDescription(message);
            embed.WithColor(new Color(0, 255, 0));
            embed.WithThumbnailUrl(Context.User.GetAvatarUrl());
            embed.WithCurrentTimestamp();

            await Context.Channel.SendMessageAsync("", false, embed);
            */
        }

        [Command("pick")]
        public async Task Pickone([Remainder]string message)
        {
            string[] options = message.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            Random r = new Random();
            string seletion = options[r.Next(0, options.Length)];

            var embed = new EmbedBuilder();
            embed.WithTitle("Choice for  " + Context.User.Username);
            embed.WithDescription(seletion);
            embed.WithColor(new Color(0, 200, 255));
            embed.WithThumbnailUrl(Context.User.GetAvatarUrl());
            embed.WithFooter(Context.User.Username);
            embed.WithCurrentTimestamp();

            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("secret")]
        public async Task RevealSecret([Remainder]string arg = "")
        {
            if (!UserIsTaunt((SocketGuildUser)Context.User))
            {
                await Context.Channel.SendMessageAsync(":x: je hebt niet de rol voor dit command " + Context.User.Username);
                return;
            }
            var dmchannel = await Context.User.GetOrCreateDMChannelAsync();
            await dmchannel.SendMessageAsync(Utilities.GetAlert("SECRET"));
        }

        private bool UserIsTaunt(SocketGuildUser user)
        {
            //user.Guild.Roles
            string targetRoleName = "Taunt";
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