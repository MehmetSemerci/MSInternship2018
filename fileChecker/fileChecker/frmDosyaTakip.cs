using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetFwTypeLib;

namespace fileChecker
{
    

    public partial class frmDosyaTakip : Form
    {

        public class FWCtrl
        {
            const string guidFWPolicy2 = "{E2B3C97F-6AE1-41AC-817A-F6F92166D7DD}";
            const string guidRWRule = "{2C5BC43E-3369-4C33-AB0C-BE9469677AF4}";
            static void Main1(string[] args)
            {
                FWCtrl ctrl = new FWCtrl();
                
            }
            public void ipAddToList(string ip)
            {

                INetFwPolicy2 firewallPolicy = (INetFwPolicy2) Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                var rule = firewallPolicy.Rules.Item("fileChecker Automatic IP Blocks");
                rule.RemoteAddresses += "," + ip;

                //Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
                //Type typeFWRule = Type.GetTypeFromCLSID(new Guid(guidRWRule));
                //INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
                //INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
                ////INetFwRule rule = (INetFwRule)Activator.GetObject()
                //newRule.Name = "fileChecker Automatic IP Blocks";
                //newRule.Description = "Blocked:"+ip+" over TCP port 4000";
                //newRule.Protocol = (int) NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP;
                //newRule.LocalPorts = "any";
                //newRule.RemoteAddresses = ip;
                //newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
                //newRule.Enabled = true;
                //newRule.Grouping = "@firewallapi.dll,-23255";
                //newRule.Profiles = fwPolicy2.CurrentProfileTypes;
                //newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
                //fwPolicy2.Rules.Add(newRule);
            }
        }

        public frmDosyaTakip()
        {
            InitializeComponent();
            // Create an instance of a ListView column sorter and assign it // to the ListView control.
            lvwColumnSorter = new ListViewColumnSorter();
            this.listPath.ListViewItemSorter = lvwColumnSorter;
            this.IPListView.ListViewItemSorter = lvwColumnSorter;

        }

        static long GetDirectorySize(string path)
        {
           
                // 1.
                // Get array of all file names.
                string[] array = Directory.GetFiles(path, "*.*");

                // 2.
                // Calculate total bytes of all files in a loop.
                long size = 0;
                foreach (string name in array)
                {
                    // 3.
                    // Use FileInfo to get length of each file.
                    FileInfo info = new FileInfo(name);
                    size += info.Length;
                }

                // 4.
                // Return total size
                return size;
           
        }

        private void btnGozat_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.ShowDialog();
                txtPath.Text = folder.SelectedPath;
            }
            catch
            {
            }
        }
        string Path = String.Empty;
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            txtMaxSize.Enabled = false;
            txtPath.Enabled = false;
            btnGozat.Enabled = false;
            

            try
            {
                var path = txtPath.Text.ToUpper().Replace(" ", "");

                var watcher = new FileSystemWatcher
                {
                    IncludeSubdirectories = true,
                    Path = path
                };
                //watcher.Filter = "*.*";
                watcher.Created += new FileSystemEventHandler(FileCreated);
                watcher.Changed += new FileSystemEventHandler(FileCreated);
                watcher.Changed += new FileSystemEventHandler(logCheck);
                watcher.EnableRaisingEvents = true;
                //System.Diagnostics.Process.Start("explorer.exe",path);

                Int32.Parse(txtMaxSize.Text);

                btnBaslat.Hide();
                this.WindowState = FormWindowState.Minimized;
                
                lblProgramStatus.Text = "Program çalışıyor...";
           
                notifyIcon.BalloonTipText = "Uygulama çalışmaya devam ediyor.";
                notifyIcon.BalloonTipTitle = "File Checker";
                
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(500);
                this.Hide();
                                
            }
            catch
            {
                MessageBox.Show("Invalid path or size!", "Error!");
                txtMaxSize.Enabled =true;
                txtPath.Enabled = true;               
                btnGozat.Enabled = true;
            }
        }


        private FileSystemEventArgs logFileNow = null;
        private FileSystemEventArgs logFileBefore = null;
        private DateTime lastCheck = DateTime.Now;
        SortedDictionary<string,int> totalIPDictionaryToBlock = new SortedDictionary<string, int>();
        SortedDictionary<string,int> totalIpDictionary = new SortedDictionary<string, int>();
        
        private void logCheck(object sender, FileSystemEventArgs e)
        {
            try
            {
                if (e.Name.StartsWith("ex"))
                {
                    if (DateTime.Now.Minute>=lastCheck.Minute+5)
                    {
                        if (lastCheck.Hour == DateTime.Now.Hour)
                        {
                            logFileBefore = logFileNow;
                            logFileNow = e; 
                        }
                        else
                        {
                            logFileBefore = logFileNow;
                        }
                        lastCheck=DateTime.Now;
                        
                        System.IO.StreamReader file = new System.IO.StreamReader(e.FullPath);

                        var aLine = file.ReadLine();

                        string[] lineSplit = null;
                        
                        while (aLine != null)
                        {

                            if (aLine.Contains(DateTime.Now.Year.ToString()))
                            {

                                lineSplit = aLine.Split(' ');

                                if (lineSplit[9].Contains("Invalid+Username+or+Password"))
                                {
                                    if (totalIpDictionary.ContainsKey(lineSplit[2]))
                                    {
                                        totalIpDictionary.TryGetValue(lineSplit[2], out int oldValue);
                                        totalIpDictionary[lineSplit[2]] = oldValue + 1;                                       
                                    }
                                    else
                                    {
                                        totalIpDictionary.Add(lineSplit[2], 1);
                                                                           
                                    }
                                }

                            }

                            aLine = file.ReadLine();

                        }

                        file.Close();

                        string pathToWrite = @"C:\fileCheckerBlockedIPList.txt";

                        System.IO.StreamWriter myFileOpener = new System.IO.StreamWriter(pathToWrite, true);
                        myFileOpener.Close(); 

                        System.IO.StreamReader myFileReader = new System.IO.StreamReader(pathToWrite);

                        List<string> ipListOnFile = new List<string>();

                        string line = myFileReader.ReadLine();

                        while (line != null)
                        {
                            ipListOnFile.Add(line);
                            line = myFileReader.ReadLine();
                        }
                        myFileReader.Close();

                        System.IO.StreamWriter myFileWriter = new System.IO.StreamWriter(pathToWrite, true);

                        var matches = totalIpDictionary.Where(element => element.Value > 2);
                        for (int j = 0; j < matches.ToList().Count; j++)
                        {
                            if (!ipListOnFile.Contains(matches.ToArray()[j].Key))
                            {                     
                                totalIPDictionaryToBlock.Add(matches.ToArray()[j].Key,matches.ToArray()[j].Value);
                                myFileWriter.WriteLine(matches.ToArray()[j].Key);
                                FWCtrl fw = new FWCtrl();
                                fw.ipAddToList(matches.ToArray()[j].Key); 
                            }
                         
                        }
                        myFileWriter.Close();
                        IPListView.Items.Clear();
                        for (int i = 0; i < totalIPDictionaryToBlock.Count; i++)
                        {
                            string[] bilgiler =
                            {
                                totalIPDictionaryToBlock.Keys.ToArray()[i], 
                                DateTime.Now.ToString(),
                                totalIPDictionaryToBlock.Values.ToArray()[i].ToString()
                            };

                            var n = new ListViewItem(bilgiler);
                            IPListView.Items.Add(n);
                            IPListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                        }

                        if(totalIPDictionaryToBlock.Count>50) totalIPDictionaryToBlock.Clear();
                        if(totalIpDictionary.Count>100) totalIpDictionary.Clear();
                        
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void FileCreated(object sender, FileSystemEventArgs e)
        {
            
            System.Threading.Thread.Sleep(500);

            try
            {
                if (e.FullPath!=Path)
                {
                    Path = e.FullPath;
                    long maxSize = Int32.Parse(txtMaxSize.Text) * 1000;
                    // get the file attributes for file or directory
                    FileAttributes attr = File.GetAttributes(e.FullPath);

                    MailMessage mail = new MailMessage { From = new MailAddress("msemerciii@gmail.com", "fileChecker") };
                    mail.To.Add("mehmet.semerci@metu.edu.tr");
                    mail.Subject = "Dosya Takip Sistemi Uyarısı";
                    SmtpClient client = new SmtpClient("smtp.gmail.com");

                    if (!attr.HasFlag(FileAttributes.Directory))
                    {
                        //File
                        FileInfo file = new FileInfo(e.FullPath);
                        int boyut = Int32.Parse(file.Length.ToString()) / 1000;
                        if (file.Length > maxSize && file.Name.StartsWith("ex"))
                        {

                            string[] bilgiler = { boyut.ToString(), DateTime.Now.ToString(), file.FullName };
                            var n = new ListViewItem(bilgiler);
                            listPath.Items.Add(n);
                            listPath.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                            mail.Body = "Dosya adı: '" + file.Name + "' \nDosya boyutu: " + file.Length / 1000 + "Kb. \nDosya yolu: '" + file.Directory + "'";

                            notifyIcon.BalloonTipText = "Dosya adı: '" + e.Name + "' \nDosya boyutu: " + file.Length / 1000 + "Kb. \nDosya yolu: '" + file.FullName + "'";
                            notifyIcon.ShowBalloonTip(500);

                        }

                    }

                    else
                    {
                        //Directory
                        DirectoryInfo directory = new DirectoryInfo(e.FullPath);
                        int boyut = Int32.Parse(GetDirectorySize(e.FullPath).ToString()) / 1000;
                        if (GetDirectorySize(e.FullPath) > maxSize)
                        {
                            string[] bilg = { boyut.ToString(), DateTime.Now.ToString(), directory.FullName };
                            var n = new ListViewItem(bilg);
                            listPath.Items.Add(n);
                            listPath.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                            mail.Body += "Klasör adı: '" + e.Name + "' \nKlasör boyutu: " + GetDirectorySize(e.FullPath) / 1000 + "Kb. \nKlasör yolu: '" + directory.FullName + "'";

                            notifyIcon.BalloonTipText = "Klasör adı: '" + e.Name + "' \nKlasör boyutu: " + GetDirectorySize(e.FullPath) / 1000 + "Kb. \nKlasör yolu: '" + directory.FullName + "'";
                            notifyIcon.ShowBalloonTip(500);

                        }
                    }
                    client.Port = 587;
                    client.Credentials = new System.Net.NetworkCredential("msemerciii@gmail.com", "Ticaret1");
                    client.EnableSsl = true;
                    client.Timeout = 4000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Send(mail); 
                }     
            }
            catch
            {

            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.notifyIcon.Visible = false;
                this.TopMost = true;
                this.BringToFront();
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            catch{}
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.notifyIcon_MouseDoubleClick(sender,e);
            this.WindowState = FormWindowState.Normal;
        }

        private void frmDosyaTakip_Resize(object sender, EventArgs e)
        {
            try
            {
                if (this.WindowState == FormWindowState.Minimized)
                {

                    notifyIcon.BalloonTipText = "Uygulama çalışmaya devam ediyor.";
                    notifyIcon.BalloonTipTitle = "File Checker";

                    notifyIcon.Visible = true;
                    notifyIcon.ShowBalloonTip(500);
                    this.Hide();
                }

                else
                {
                    this.Show();
                    this.TopMost = true;
                    this.WindowState = FormWindowState.Normal;
                    this.Show();
                    notifyIcon.Visible = false;
                    
                }
            }
            catch{}
        }

        private void listPath_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.if ( e.Column == lvwColumnSorter.SortColumn )
            if ( e.Column == lvwColumnSorter.SortColumn ){
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listPath.Sort();

        }

        private void IPListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.if ( e.Column == lvwColumnSorter.SortColumn )
            if ( e.Column == lvwColumnSorter.SortColumn ){
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.IPListView.Sort();
        }
    }
}
