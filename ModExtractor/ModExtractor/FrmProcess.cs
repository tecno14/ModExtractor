using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModExtractor
{
    public partial class FrmProcess : Form
    {
        #region Ctor
        string ModedGameRoot, OrginalGameRoot, DestinationModRoot;
        string _FILES_DIR, _UnKnw_DIR, _DELETED_FILE;

        private FrmProcess()
        {
            InitializeComponent();
        }

        public FrmProcess(string modedGameRoot, string orginalGameRoot, string destinationModRoot) : this()
        {
            ModedGameRoot = FixDirectoryName(modedGameRoot);
            OrginalGameRoot = FixDirectoryName(orginalGameRoot);
            DestinationModRoot = FixDirectoryName(destinationModRoot);

            _FILES_DIR = FixDirectoryName(Path.Combine(DestinationModRoot, Program._FILES_DIR));
            _UnKnw_DIR = FixDirectoryName(Path.Combine(DestinationModRoot, Program._UnKnw_DIR));
            _DELETED_FILE = Path.Combine(DestinationModRoot, Program._DELETED_FILE);
        }
        public string FixDirectoryName(string path)
        {
            if (path[path.Length - 1] != '\\')
                path += "\\";
            return path;
        }
        public string GetDirectoryName(string path)
        {
            if (!path.Contains("\\"))
                return "";
            int i = path.LastIndexOf("\\");
            return path.Substring(0, i);
        }
        private void DeleteEmptyFolders(string dir, bool delete = false)
        {
            if (!Directory.Exists(dir))
                return;

            if (Directory.GetFiles(dir).Length != 0)
                return;

            foreach (string subdir in Directory.GetDirectories(dir))
                DeleteEmptyFolders(subdir, true);

            if (Directory.GetDirectories(dir).Length == 0)
                if (delete)
                    Directory.Delete(dir, false);
        }
        #endregion

        private void FrmProcess_Load(object sender, EventArgs e)
        {
            Task.Run(new Action(MyProcess));
            //MyProcess();
        }
        private void MyProcess()
        {
            try
            {
                LbStatus.Invoke((MethodInvoker)delegate { LbStatus.Text = "preparing"; });
                progressBar1.Invoke((MethodInvoker)delegate { progressBar1.Value = 10; });

                #region chk folders and files

                if (!Directory.Exists(ModedGameRoot))
                    throw new DirectoryNotFoundException($"'{ModedGameRoot}' not found");

                if (!Directory.Exists(OrginalGameRoot))
                    throw new DirectoryNotFoundException($"'{OrginalGameRoot}' not found");

                if (!Directory.Exists(DestinationModRoot))
                    Directory.CreateDirectory(DestinationModRoot);
                if (!Directory.Exists(_FILES_DIR))
                    Directory.CreateDirectory(_FILES_DIR);
                if (!Directory.Exists(_UnKnw_DIR))
                    Directory.CreateDirectory(_UnKnw_DIR);
                if (File.Exists(_DELETED_FILE))
                    File.Delete(_DELETED_FILE);
                File.Create(_DELETED_FILE).Close();
                //if (!File.Exists(_DELETED_FILE))
                //File.Create(_DELETED_FILE).Close();

                #endregion

                #region Def       

                List<string> ModedGameFiles = new List<string>();
                ModedGameFiles.AddRange(Directory.GetFiles(ModedGameRoot, "*.*", SearchOption.AllDirectories));

                List<string> DeletedOrginalGameFiles = new List<string>();
                DeletedOrginalGameFiles.AddRange(Directory.GetFiles(OrginalGameRoot, "*.*", SearchOption.AllDirectories));

                List<string> ModFiles = new List<string>();
                List<string> UnknownFiles = new List<string>();
                List<string> DeletedFiles = new List<string>();

                #endregion

                LbStatus.Invoke((MethodInvoker)delegate { LbStatus.Text = "Scanning"; });
                progressBar1.Invoke((MethodInvoker)delegate { progressBar1.Value = 30; });
                #region Compair

                int i = 0;
                foreach (string ModFile in ModedGameFiles)
                {
                    i++;
                    LbStatus.Invoke((MethodInvoker)delegate { LbStatus.Text = $"Scanning  [{i}\\{ModedGameFiles.Count}]"; });
                    string GameFile = ModFile.Replace(ModedGameRoot, OrginalGameRoot);

                    if (File.Exists(GameFile))
                    {
                        DeletedOrginalGameFiles.Remove(GameFile);

                        var ModFI = new FileInfo(ModFile);
                        var GameFI = new FileInfo(GameFile);

                        if (ModFI.Length == GameFI.Length)
                            if (ModFI.LastWriteTimeUtc == GameFI.LastWriteTimeUtc)
                                continue;//its a Orginal Game File
                            else
                            {
                                //chksum
                                byte[] hash1, hash2;

                                using (var md5 = MD5.Create())
                                using (var stream = File.OpenRead(ModFile))
                                    hash1 = md5.ComputeHash(stream);

                                using (var md5 = MD5.Create())
                                using (var stream = File.OpenRead(GameFile))
                                    hash2 = md5.ComputeHash(stream);

                                if (hash1.SequenceEqual(hash2))
                                    continue;

                                UnknownFiles.Add(ModFile);
                                continue;
                            }
                    }

                    ModFiles.Add(ModFile);
                }

                DeletedOrginalGameFiles.ForEach(file => { DeletedFiles.Add(file.Replace(OrginalGameRoot, "")); });

                #endregion

                LbStatus.Invoke((MethodInvoker)delegate { LbStatus.Text = "Move Mod Files"; });
                progressBar1.Invoke((MethodInvoker)delegate { progressBar1.Value = 60; });
                #region MoveModFiles

                ModFiles.ForEach(file =>
                {
                    string fileDist = file.Replace(ModedGameRoot, _FILES_DIR);
                    string DIR = GetDirectoryName(fileDist);
                    if (!Directory.Exists(DIR))
                        Directory.CreateDirectory(DIR);
                    File.Move(file, fileDist);
                });

                UnknownFiles.ForEach(file =>
                {
                    string fileDist = file.Replace(ModedGameRoot, _UnKnw_DIR);
                    string DIR = GetDirectoryName(fileDist);
                    if (!Directory.Exists(DIR))
                        Directory.CreateDirectory(DIR);
                    File.Move(file, fileDist);
                });

                using (StreamWriter sw = File.AppendText(_DELETED_FILE))
                    DeletedFiles.ForEach(file => { sw.WriteLine(file); });

                DeleteEmptyFolders(ModedGameRoot);

                #endregion

                progressBar1.Invoke((MethodInvoker)delegate { progressBar1.Value = 100; });
                LbStatus.Invoke((MethodInvoker)delegate { LbStatus.Text = "-==:: Done ::==-"; });
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Invoke((MethodInvoker)delegate { MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); });               
            }
            Invoke((MethodInvoker)delegate { Close(); });
        }
    }
}
