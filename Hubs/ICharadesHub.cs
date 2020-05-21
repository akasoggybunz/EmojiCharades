using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmojiCharades.Hubs
{
    public interface ICharadesHub
    {
        /// <summary>
        /// Default Recieve Message for a USer
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        Task ReceiveMessage(string user, string message);

        /// <summary>
        /// Default Recieve Message
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        Task ReceiveMessage(string message);

        /// <summary>
        /// Start the Game for this hub
        /// </summary>
        /// <returns></returns>
        Task StartGame();

        /// <summary>
        /// End Game for this Hub
        /// </summary>
        /// <returns></returns>
        Task EndGame();

        /// <summary>
        /// Assign User a Question
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        Task AssignQuestionToUser(string User, string question);

        /// <summary>
        /// Send 
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        Task SendAnswerToHub(string User, string answer);

        Task VoteForAnswer(string user, string vote);

        /// <summary>
        /// Stream Results
        /// </summary>
        /// <returns></returns>
        Task StreamCharadesToHub();

        /// <summary>
        /// Enter a group
        /// </summary>
        /// <param name="groupName">Name of Group</param>
        /// <returns></returns>
        Task AddToGroup(string groupName);

        /// <summary>
        /// Leave a group
        /// </summary>
        /// <param name="groupName">Name of Group</param>
        /// <returns></returns>
        Task RemoveFromGroup(string groupName);
    }
}
