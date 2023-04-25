using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hapticMedia.applicationFrame.Service {
    public class HapticMediaFileService {

        private HapticMediaFileService() {
            // service
        }

        private static string HapticMediaFolder = "HapticMedia";

        private static string GetPath(string folder, string fileName) {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), HapticMediaFolder);
            if (folder != null) {
                path = Path.Combine(path, folder);
            }
            if (fileName != null) {
                path = Path.Combine(path, fileName);
            }
            return path;
        }

        public static void SaveFile(string content, string folder, string fileName) {

            string path = GetPath(folder, fileName);

            if (File.Exists(path)) {
                File.Delete(path);
            }

            new FileInfo(path).Directory.Create();

            using (FileStream fs = File.Create(path)) {
                Byte[] title = new UTF8Encoding(true).GetBytes(content);
                fs.Write(title, 0, title.Length);
            }
        }

        public static void OpenFile(string folder, string fileName) {
            System.Diagnostics.Process.Start(GetPath(folder, fileName));
        }

        public static Dictionary<string, string> GetFilesInDir(string folder) {

            Dictionary<string, string> files = new Dictionary<string, string>();

            string dirPath = GetPath(folder, null);
            string[] filePaths = Directory.GetFiles(dirPath);

            foreach(string filePath in filePaths) {
                files.Add(Path.GetFileName(filePath), filePath);
            }

            return files;
        }

        public static string LoadFileByPath(string path) {

            if (!File.Exists(path)) {
                return null;
            }
            return File.ReadAllText(path);
        }

        public static string LoadFile(string folder, string fileName) {

            string path = GetPath(folder, fileName);

            if (!File.Exists(path)) {
                return null;
            }
            return File.ReadAllText(path);
        }
    }
}
