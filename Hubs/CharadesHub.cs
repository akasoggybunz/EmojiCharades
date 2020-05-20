using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmojiCharades.Hubs
{
    public class CharadesHub : Hub<ICharadesHub>
    {
        /// <summary>
        /// Send a Message to a specific user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.ReceiveMessage(user, message);
        }

        /// <summary>
        /// Send message to caller
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public Task SendMessageToCaller(string message)
        {
            return Clients.Caller.ReceiveMessage(message);
        }

        /// <summary>
        /// Start Game message
        /// </summary>
        /// <returns></returns>
        public Task StartGame()
        {
            return Clients.Caller.ReceiveMessage("StartGame");
        }
    }
}
