using log4net;
using Pdelvo.Minecraft.Protocol.Packets;
using Pdelvo.Minecraft.Proxy.Library.Plugins;
using Pdelvo.Minecraft.Proxy.Library.Plugins.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineProxyPluginTemplate
{
    public class MineProxyPlugin : PluginBase
    {
        ILog _logger = LogManager.GetLogger(typeof(MineProxyPlugin));

        public override string Name
        {
            get { return "My Cool Plugin"; }
        }

        public override Version Version
        {
            get { return new Version("0.0.0.1"); }
        }

        public override string Author
        {
            get { return "me"; }
        }

        public override void Load(PluginManager manager)
        {
            _logger.Info("Hello, World!");
        }

        public override async void OnUserConnectedCompleted(UserEventArgs args)
        {
            await args.Connection.ClientEndPoint.SendPacketAsync(new ChatPacket { Message = "Ths proxy is using a fancy plugin!" });
        }
    }
}
