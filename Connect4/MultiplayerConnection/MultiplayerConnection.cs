﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using Newtonsoft.Json;

namespace Connect4
{
    public class MultiplayerConnection
    {
        private WebSocket clientWebSocket;

        private GameLogic gameLogic;

        private string jwt;

        public MultiplayerConnection(string url, string username) {
            clientWebSocket = new WebSocket(url);
            clientWebSocket.OnMessage += messageHandler;
            clientWebSocket.Connect();

            clientWebSocket.Send(JsonConvert.SerializeObject(new MessageTypes.Registration(username)));

            gameLogic = new GameLogic(this, 1);
        }

        private void messageHandler(object sender, MessageEventArgs e) {
            dynamic message = JsonConvert.DeserializeObject(e.Data);

            Console.WriteLine(e.Data);
            Console.WriteLine((string) message.type);
            
            if (message.type == "RegistrationReturn") {
                RegistrationReturnHandler(message);
            }
        }

        private void RegistrationReturnHandler(dynamic message)
        {
            jwt = message.data.jwt;
        }

        public void columnClick(int column )
        {
            var message = new MessageTypes.PlayPosition(this.jwt, column);
            clientWebSocket.Send(JsonConvert.SerializeObject(message));
        }
    }
}
