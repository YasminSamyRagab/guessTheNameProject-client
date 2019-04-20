using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace client
{
    static class playerInfo
    {
        public static bool owner;
        public static string playerName;
        public static string player1; //in case of watch
        public static string player2;
        public static int score;
        public static string word;
        public static string RoomName, diff, categ;
        public static TcpClient client;
        public static NetworkStream nt;
        public static BinaryReader br;
        public static BinaryWriter bw;
        public static Thread th;
        public static List<string> char_to_Watch;
    }
}
