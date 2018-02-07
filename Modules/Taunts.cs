using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace aoe_test_bot_2.Modules
{
    public class Taunts : ModuleBase<SocketCommandContext>
    {

        [Command("1")]
        public async Task Taunt_1()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("Yes");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("https://vignette.wikia.nocookie.net/steamtradingcards/images/b/b8/Age_of_Empires_III_Complete_Collection_Artwork_1.jpg/revision/latest?cb=20140820080102");

            await Context.Channel.SendMessageAsync("Yes", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("2")]
        public async Task Taunt_2()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("No");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("https://vignette.wikia.nocookie.net/steamtradingcards/images/2/28/Age_of_Empires_III_Complete_Collection_Artwork_7.jpg/revision/latest?cb=20140820080109");

            await Context.Channel.SendMessageAsync("No", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("3")]
        public async Task Taunt_3()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("I need food");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("https://vignette.wikia.nocookie.net/ageofempires/images/5/54/Animals.png/revision/latest?cb=20140314133956");

            await Context.Channel.SendMessageAsync("I need food", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("4")]
        public async Task Taunt_4()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("Somebody pass the wood");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("http://namonitore.ru/uploads/catalog/games/age_of_empires_iii_1280.jpg");

            await Context.Channel.SendMessageAsync("Somebody pass the wood", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("5")]
        public async Task Taunt_5()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("I need coin");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("https://www.mariowiki.com/images/thumb/1/17/CoinMK8.png/150px-CoinMK8.png");

            await Context.Channel.SendMessageAsync("I need coin", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("6")]
        public async Task Taunt_6()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("Do you have extra resources? ");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("https://vignette.wikia.nocookie.net/steamtradingcards/images/2/2d/Age_of_Empires_III_Complete_Collection_Artwork_6.jpg/revision/latest?cb=20140820080108");

            await Context.Channel.SendMessageAsync("Do you have extra resources? ", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("7")]
        public async Task Taunt_7()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("I have extra food");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("https://pre00.deviantart.net/9455/th/pre/i/2017/196/a/a/sliced__red_apple_on_a_transparent_background__by_prussiaart-dbgfhwd.png");

            await Context.Channel.SendMessageAsync("I have extra food", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("8")]
        public async Task Taunt_8()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("I have extra wood");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("http://www.sloveniatimes.com/modules/uploader/uploads/Aktualno/Podobe1/pexels-photo-128639.jpg");

            await Context.Channel.SendMessageAsync("I have extra wood", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("9")]
        public async Task Taunt_9()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("I have extra coin");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("http://d1w116sruyx1mf.cloudfront.net/ee-assets/gsd/yesterday/ZKB_Gold.jpg");

            await Context.Channel.SendMessageAsync("I have extra coin", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("10")]
        public async Task Taunt_10()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("Meet here");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("http://icons.iconarchive.com/icons/icons8/windows-8/512/Maps-Map-Marker-icon.png");

            await Context.Channel.SendMessageAsync("Meet here", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("11")]
        public async Task Taunt_11()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("Are you ready?");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("http://randalldsmith.com/wp-content/uploads/2016/03/get-ready.jpg");

            await Context.Channel.SendMessageAsync("Are you ready? ", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("12")]
        public async Task Taunt_12()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("I need help! ");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("https://i.pinimg.com/originals/3b/34/59/3b3459453002504718e8d3d8f6c05e25.jpg");

            await Context.Channel.SendMessageAsync("I need help! ", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("13")]
        public async Task Taunt_13()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("Attack now! ");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("https://vignette.wikia.nocookie.net/steamtradingcards/images/c/cb/Age_of_Empires_III_Complete_Collection_Artwork_3.jpg/revision/latest?cb=20140820080105");

            await Context.Channel.SendMessageAsync("Attack now! ", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("14")]
        public async Task Taunt_14()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("Upgrade your trade route");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("http://blogs.reuters.com/anya-schiffrin/files/2011/09/india.jpg");

            await Context.Channel.SendMessageAsync("Upgrade your trade route", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("15")]
        public async Task Taunt_15()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("Wololo");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("https://i.imgur.com/gdJYECr.gif");

            await Context.Channel.SendMessageAsync("Wololo", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("16")]
        public async Task Taunt_16()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("I'm in your base, killing your dudes 🗡️ ");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("https://us.v-cdn.net/6029970/uploads/editor/xj/d9v7487cwq7k.gif");

            await Context.Channel.SendMessageAsync("I'm in your base, killing your dudes", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("17")]
        public async Task Taunt_17()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("Check in your wallet. That's me on the dollar bill");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("https://atotz.net/geld/gulden/gulden-biljet-015.gif");

            await Context.Channel.SendMessageAsync("Check in your wallet. That's me on the dollar bill", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("18")]
        public async Task Taunt_18()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("I believe that makes me your daddy");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("https://i.ytimg.com/vi/jptLavPbVdc/maxresdefault.jpg");

            await Context.Channel.SendMessageAsync("I believe that makes me your daddy", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("19")]
        public async Task Taunt_19()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("El-Oh-El, I am R-Oh-Tee-Eff-El");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("https://www.clipartsgram.com/image/1674925429-4i9ongbet.png");

            await Context.Channel.SendMessageAsync("El-Oh-El, I am R-Oh-Tee-Eff-El Laugh out Loud, I am Rolling on the Floor Laughing", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("20")]
        public async Task Taunt_20()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("Aren't you becoming quite the little problem");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("https://i.pinimg.com/736x/00/9c/50/009c5071220deeee3597cf9c418d608c--behavior-charts-for-kids-school-psychology.jpg");

            await Context.Channel.SendMessageAsync("Aren't you becoming quite the little problem", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("21")]
        public async Task Taunt_21()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("https://media0.giphy.com/media/CoDp6NnSmItoY/200.gif");

            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("22")]
        public async Task Taunt_22()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("This will give me cred, street cred! ");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("https://upload.wikimedia.org/wikipedia/commons/4/48/Breede_-_straat_met_huizen.jpg");

            await Context.Channel.SendMessageAsync("This will give me cred, street cred! ", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("23")]
        public async Task Taunt_23()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("Hey, shut your pie hole! ");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("https://dawnhburke.com/wp-content/uploads/2012/05/shut_your_pie_hole_by_crosspollenation.jpg?w=300");

            await Context.Channel.SendMessageAsync("Hey, shut your pie hole! ", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("24")]
        public async Task Taunt_24()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("I'll take that trade!");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("http://wallpapered.net/wp-content/uploads/Games1/Age%20of%20empires%203.jpg");

            await Context.Channel.SendMessageAsync("I'll take that trade!", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }
        /*
        [Command("25")]
        public async Task Taunt_25()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Taunt Door " + Context.User.Username);
            embed.WithDescription("");
            embed.WithColor(new Color(0, 0, 255));
            embed.WithThumbnailUrl("");

            await Context.Channel.SendMessageAsync("", isTTS: true);
            await Context.Channel.SendMessageAsync("", false, embed);
        }
        */

    }
}
