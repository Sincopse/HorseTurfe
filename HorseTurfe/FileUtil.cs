using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace HorseTurfe
{
    public static class FileUtil
    {
        public static void SaveFile(Player player)
        {
            string fileName = "player.txt";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            FileStream fileStream = File.Create(fileName);
            BinaryFormatter f = new BinaryFormatter();

            f.Serialize(fileStream, player);

            fileStream.Close();
        }

        public static Player LoadFile()
        {
            string fileName = "player.txt";

            if (File.Exists(fileName))
            {
                FileStream fileStream = File.OpenRead(fileName);
                BinaryFormatter f = new BinaryFormatter();

                return f.Deserialize(fileStream) as Player;
            }
            else
            {
                return null;
            }
        }
    }
}
