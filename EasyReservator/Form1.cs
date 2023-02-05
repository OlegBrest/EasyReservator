using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EasyReservator
{
    public partial class MainForm : Form
    {
        bool isInProgress = false;
        System.Timers.Timer updtTimer = new System.Timers.Timer(100);
        string[] extensions = null;
        List<string> excludePaths = null;
        string currentFileText = "";
        string currentDirText = "";

        int findeddirs = 0;
        int findedfiles = 0;
        int workeddirs = 0;
        int workedfiles = 0;

        string logFilePath = @"C:\EasyReservator.log";

        string copyType = "С сохранением путей";
        string savepath = @"C:\tmp";
        bool autorename = true;
        bool deleteSource = false;
        bool deleteEmptyDirs = false;

        bool islastupdate = false;
        bool isHidden = false;
        

        List<string> scannedDirs = null;
        public MainForm()
        {
            InitializeComponent();
            InterfaceUpdater.DoWork += InterfaceUpdater_DoWork;
            InterfaceUpdater.RunWorkerAsync();
            excludePaths = new List<string>();
            scannedDirs = new List<string>();

            updtTimer.AutoReset = true;
            updtTimer.Elapsed += UpdtTimer_Tick;
        }


        public MainForm(string [] args)
        {
            InitializeComponent();
            InterfaceUpdater.DoWork += InterfaceUpdater_DoWork;
            InterfaceUpdater.RunWorkerAsync();
            excludePaths = new List<string>();
            scannedDirs = new List<string>();

            updtTimer.AutoReset = true;
            updtTimer.Elapsed += UpdtTimer_Tick;
            HidedConsolas(args);
        }

        public void HidedConsolas(string [] args)
        {
            foreach(string arg in args)
            {
                if (arg.ToLower() == "-hide")
                {
                    isHidden = true;
                }
                if (arg.ToLower().Contains("-filter/"))
                {
                    filterTextBox.Text = arg.Split('/')[1];
                }
                if (arg.ToLower().Contains("-savepath/"))
                {
                    savePathTextBox.Text = arg.Split('/')[1];
                }
                if (arg.ToLower().Contains("-scandirs/"))
                {
                    scanedDirsListBox.Items.Clear();
                    string[] dirs = arg.Split('/')[1].Split(';');
                    foreach(string dir in dirs)
                    {
                        scanedDirsListBox.Items.Add(dir);
                    }
                }
                if (arg.ToLower().Contains("-excldirs/"))
                {
                    excludeDirsListBox.Items.Clear();
                    string[] dirs = arg.Split('/')[1].Split(';');
                    foreach (string dir in dirs)
                    {
                        excludeDirsListBox.Items.Add(dir);
                    }
                }
                if (arg.ToLower().Contains("-delsource"))
                {
                    deleteCheckBox.Checked = true;
                }
                if (arg.ToLower().Contains("-delempty"))
                {
                    deleteEmptyDirCheckBox.Checked = true;
                }
            }
            if (isHidden) startButton_Click(this, new EventArgs());
        }

        private void InterfaceUpdater_DoWork(object sender, DoWorkEventArgs e)
        {
           if (!isHidden) mainFormUpdater();
        }

        private void UpdtTimer_Tick(object sender, EventArgs e)
        {
            if (!InterfaceUpdater.IsBusy) InterfaceUpdater.RunWorkerAsync();
        }

        private void mainFormUpdater()
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        currentFileTextBox.Text = currentFileText;
                        currentDirTextBox.Text = currentDirText;
                        filesFindedTextBox.Text = findedfiles.ToString();
                        dirsFindedTextBox.Text = findeddirs.ToString();
                        dirsWorkedTextBox.Text = workeddirs.ToString();
                        filesWorkedTextBox.Text = workedfiles.ToString();
                        if (!isInProgress)
                        {
                            progressBar.Visible = false;
                            copyTypeComboBox.Enabled = true;
                            filterTextBox.Enabled = true;
                            savePathTextBox.Enabled = true;
                            addButton.Enabled = true;
                            delButton.Enabled = true;
                            excludeAddButton.Enabled = true;
                            excludeDelButton.Enabled = true;
                            savePathButton.Enabled = true;
                            startButton.Enabled = true;
                            stopButton.Enabled = false;
                            panel5.Enabled = true;
                        }
                        else
                        {
                            progressBar.Visible = true;
                            copyTypeComboBox.Enabled = false;
                            filterTextBox.Enabled = false;
                            savePathTextBox.Enabled = false;
                            addButton.Enabled = false;
                            delButton.Enabled = false;
                            excludeAddButton.Enabled = false;
                            excludeDelButton.Enabled = false;
                            savePathButton.Enabled = false;
                            startButton.Enabled = false;
                            stopButton.Enabled = true;
                            panel5.Enabled = false;
                        }
                    }));
                }
                else
                {
                    currentFileTextBox.Text = currentFileText;
                    currentDirTextBox.Text = currentDirText;
                    filesFindedTextBox.Text = findedfiles.ToString();
                    dirsFindedTextBox.Text = findeddirs.ToString();
                    dirsWorkedTextBox.Text = workeddirs.ToString();
                    filesWorkedTextBox.Text = workedfiles.ToString();
                    if (!isInProgress)
                    {
                        progressBar.Visible = false;
                        copyTypeComboBox.Enabled = true;
                        filterTextBox.Enabled = true;
                        savePathTextBox.Enabled = true;
                        addButton.Enabled = true;
                        delButton.Enabled = true;
                        excludeAddButton.Enabled = true;
                        excludeDelButton.Enabled = true;
                        savePathButton.Enabled = true;
                    }
                    else
                    {
                        progressBar.Visible = true;
                        copyTypeComboBox.Enabled = false;
                        filterTextBox.Enabled = false;
                        savePathTextBox.Enabled = false;
                        addButton.Enabled = false;
                        delButton.Enabled = false;
                        excludeAddButton.Enabled = false;
                        excludeDelButton.Enabled = false;
                        savePathButton.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                // WriteToLogString(ex.Message);
            }
        }

        #region кнопки добавления каталогов в исключения и скан
        private void addButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowNewFolderButton = false;
            DialogResult dialogResult = folderBrowserDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                scanedDirsListBox.Items.Add(folderBrowserDialog.SelectedPath);
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            scanedDirsListBox.Items.Remove(scanedDirsListBox.SelectedItem);
        }


        private void excludeAddButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowNewFolderButton = false;
            DialogResult dialogResult = folderBrowserDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                excludeDirsListBox.Items.Add(folderBrowserDialog.SelectedPath);
            }
        }

        private void excludeDelButton_Click(object sender, EventArgs e)
        {
            excludeDirsListBox.Items.Remove(excludeDirsListBox.SelectedItem);
        }
        #endregion
        private void savePathButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult dialogResult = folderBrowserDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                savePathTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void WriteToLogString(string line)
        {
            if (!File.Exists(logFilePath))
            {
                using (var outf = File.CreateText(logFilePath))
                {
                    outf.WriteLine(DateTime.Now.ToString() + "  " + line);
                    return;
                }
            }
            using (var outf = File.AppendText(logFilePath))
            {
                outf.WriteLine(DateTime.Now.ToString() + "  " + line);
                return;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!isHidden)updtTimer.Start();
            WriteToLogString("Начало");
            if (!RequestSeBackupPrivilege())
            {
                WriteToLogString("Cannot request privilege: ");
            }

            copyType = copyTypeComboBox.Text;
            autorename = autoRenameCheckBox.Checked;
            deleteSource = deleteCheckBox.Checked;
            deleteEmptyDirs = deleteEmptyDirCheckBox.Checked;
            currentFileText = "";
            currentDirText = "";
            savepath = savePathTextBox.Text;

            findeddirs = 0;
            findedfiles = 0;
            workeddirs = 0;
            workedfiles = 0;

            isInProgress = true;
            extensions = filterTextBox.Text.Split(';');
            excludePaths.Clear();
            scannedDirs.Clear();
            scannedDirs.Add(savepath);
            foreach (string item in excludeDirsListBox.Items)
            {
                excludePaths.Add(item);
            }

            Thread thread = new Thread(StartProgress);
            thread.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            WriteToLogString("Остановлено пользователем");
            isInProgress = false;
            islastupdate = true;
        }

        private void StartProgress()
        {
            foreach (string mainPath in scanedDirsListBox.Items)
            {
                WorkOnDir(mainPath);
            }
            isInProgress = false;
            islastupdate = true;
            WriteToLogString("Выполнено");
            if (isHidden) this.Close();
            else Process.Start("notepad.exe", logFilePath);
        }

        private void WorkOnDir(string path)
        {
            if ((isInProgress) && (!scannedDirs.Contains(path)))
            {
                scannedDirs.Add(path);
                DirectoryInfo dirinfo = new DirectoryInfo(new DirectoryInfo(path).GetSymbolicLinkTarget());
                currentDirText = dirinfo.FullName;

                List<FileInfo> totalfilesinfo = new List<FileInfo>();
                List<string> filenamelist = new List<string>();
                foreach (string ext in extensions)
                {
                    FileInfo[] filesinfo = null;
                    try
                    {
                        filesinfo = dirinfo.GetFiles(ext, SearchOption.TopDirectoryOnly);
                    }
                    catch (Exception ex)
                    {
                        WriteToLogString(ex.Message);
                        WriteToLogString(dirinfo.FullName);
                    }
                    if (filesinfo != null)
                    {
                        foreach (FileInfo file in filesinfo)
                        {
                            if (!filenamelist.Contains(file.FullName) && (file.Extension == ext.Replace("*", "")))
                            {
                                filenamelist.Add(file.FullName);
                                totalfilesinfo.Add(file);
                            }
                        }
                    }
                }

                if (totalfilesinfo != null)
                {

                    findedfiles += totalfilesinfo.Count();
                    foreach (FileInfo file in totalfilesinfo)
                    {
                        currentFileText = file.Name;
                        WorkOnFile(file);
                    }
                }
                DirectoryInfo[] dirsinfos = null;
                try
                {
                    dirsinfos = dirinfo.GetDirectories("*", SearchOption.TopDirectoryOnly);// dirsinfos = dirinfo.GetDirectories("*", SearchOption.AllDirectories);
                }
                catch (Exception ex)
                {
                    WriteToLogString(ex.Message);
                    WriteToLogString(dirinfo.FullName);
                }

                if (dirsinfos != null)
                {
                    findeddirs += dirsinfos.Count();
                    foreach (DirectoryInfo di in dirsinfos)
                    {
                        try
                        {
                            WorkOnDir(di.FullName);
                        }
                        catch (Exception ex)
                        {
                            WriteToLogString(ex.Message);
                            WriteToLogString(dirinfo.FullName);
                        }
                    }
                }
                if (deleteEmptyDirs)
                {
                    bool canDelete = true;
                    foreach (string exludePath in excludePaths)
                    {
                        if (dirinfo.FullName.ToLower().Contains(exludePath.ToLower())) canDelete = false;
                    }
                    if ((dirinfo.GetDirectories("*", SearchOption.TopDirectoryOnly).Count() == 0) && (dirinfo.GetFiles("*", SearchOption.TopDirectoryOnly).Count() == 0) && canDelete)
                    {
                        Directory.Delete(dirinfo.FullName);
                    }
                }
                workeddirs++;
            }
        }

        private void WorkOnFile(FileInfo fileSource)
        {
            string fullsavepath = savepath;
            if (copyType == "С сохранением путей")
            {
                fullsavepath += ("\\" + (fileSource.DirectoryName.Replace(":", "")));
            }
            if (copyType == "Сортировать по типам файлов")
            {
                fullsavepath += ("\\" + (fileSource.Extension.Replace(".", "")));
            }
            DirectoryInfo di = new DirectoryInfo(fullsavepath);
            if (!di.Exists) di.Create();
            string fullNewFileName = (fullsavepath + "\\" + fileSource.Name);
            try
            {
                if (autorename)
                {
                    if (File.Exists(fullNewFileName))
                    {
                        fullNewFileName = GetNewFileName(fullNewFileName);
                        workFile(fullNewFileName, fileSource, false);
                    }
                    else
                    {
                        workFile(fullNewFileName, fileSource, false);
                    }
                }
                else
                {
                    workFile(fullNewFileName, fileSource, true);
                }
            }
            catch (Exception ex)
            {
                WriteToLogString(ex.Message);
            }
            workedfiles++;
        }



        private void workFile(string fullNewFileName, FileInfo filesource, bool overwrite)
        {
            bool canDelete = true;
            foreach (string exludePath in excludePaths)
            {
                if (filesource.FullName.ToLower().Contains(exludePath.ToLower())) canDelete = false;
            }
            try
            {
                if ((deleteSource) && canDelete)
                {
                    filesource.MoveTo(fullNewFileName);
                }
                else
                    filesource.CopyTo(fullNewFileName, overwrite);
            }
            catch (Exception ex)
            {
                WriteToLogString(ex.Message);
            }
        }

        private string GetNewFileName(string namesource)
        {
            string fileextention = "";
            string clearedfilename = "";
            string[] analyze = namesource.Split('.');
            if (analyze.Count() > 1)
            {
                fileextention = ("." + analyze[analyze.Count() - 1]);
                for (int i = 0; i < (analyze.Count() - 1); i++)
                {
                    if (clearedfilename != "") clearedfilename += ".";
                    clearedfilename += analyze[i];
                }
            }
            string[] newNameArr = clearedfilename.Split('#');
            int lastnum = 1;
            string newfilename = "";
            if (newNameArr.Count() > 1)
            {
                if (int.TryParse(newNameArr[newNameArr.Count() - 1], out lastnum))
                {
                    lastnum++;
                    newNameArr[newNameArr.Count() - 1] = lastnum.ToString();
                }
                foreach (string part in newNameArr)
                {
                    if (newfilename != "") newfilename += "#";
                    newfilename += part;
                }
                newfilename += fileextention;
            }
            else
            {
                newfilename = clearedfilename + "#" + lastnum + fileextention;
            }
            if (File.Exists(newfilename))
            {
                newfilename = GetNewFileName(newfilename);
            }
            return newfilename;
        }

        #region установка повышенных прав приложения
        static bool RequestSeBackupPrivilege()
        {
            LUID luid;

            if (!LookupPrivilegeValue(null, "SeBackupPrivilege", out luid))
                return false;

            TOKEN_PRIVILEGES_SINGLE tp = new TOKEN_PRIVILEGES_SINGLE
            {
                PrivilegeCount = 1,
                Luid = luid,
                Attributes = SE_PRIVILEGE_ENABLED
            };

            IntPtr hToken;
            return
                OpenProcessToken(
                    GetCurrentProcess(), TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, out hToken) &&
                AdjustTokenPrivileges(
                    hToken, false, ref tp, 0, IntPtr.Zero, IntPtr.Zero) &&
                (Marshal.GetLastWin32Error() != ERROR_NOT_ALL_ASSIGNED);
        }

        const int SE_PRIVILEGE_ENABLED = 0x00000002;
        const int TOKEN_QUERY = 0x00000008;
        const int TOKEN_ADJUST_PRIVILEGES = 0x00000020;
        const int ERROR_NOT_ALL_ASSIGNED = 1300;

        [DllImport("kernel32.dll", ExactSpelling = true)]
        static extern IntPtr GetCurrentProcess();

        [StructLayout(LayoutKind.Sequential)]
        struct TOKEN_PRIVILEGES_SINGLE
        {
            public UInt32 PrivilegeCount;
            public LUID Luid;
            public UInt32 Attributes;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct LUID
        {
            public uint LowPart;
            public int HighPart;
        }

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool LookupPrivilegeValue(
            string lpSystemName, string lpName, out LUID lpLuid);

        [DllImport("advapi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool OpenProcessToken(
            IntPtr ProcessHandle, UInt32 DesiredAccess, out IntPtr TokenHandle);

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        static extern bool AdjustTokenPrivileges(
            IntPtr htok, bool disall, ref TOKEN_PRIVILEGES_SINGLE newst,
            int len, IntPtr prev, IntPtr relen);
        #endregion


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isHidden)updtTimer.Stop();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
