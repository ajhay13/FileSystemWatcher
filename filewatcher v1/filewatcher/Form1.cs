using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace filewatcher
{
    public partial class Form1 : Form
    {
        private StringBuilder m_SB;
        private System.IO.FileSystemWatcher my_Watcher1;
        private System.IO.FileSystemWatcher my_Watcher2;
        private System.IO.FileSystemWatcher my_Watcher3;
        private System.IO.FileSystemWatcher my_Watcher4;
        private System.IO.FileSystemWatcher my_Watcher5;

        OpenFileDialog opendlg1 = new OpenFileDialog();

        


        private bool m_bDirty;
        private bool m_bIsWatching;

        public Form1()
        {
            InitializeComponent();
            m_SB = new StringBuilder();
            m_bDirty = false;
            m_bIsWatching = false;
            my_Watcher1 = new System.IO.FileSystemWatcher();
            my_Watcher2 = new System.IO.FileSystemWatcher();
            my_Watcher3 = new System.IO.FileSystemWatcher();
            my_Watcher4 = new System.IO.FileSystemWatcher();
            my_Watcher5 = new System.IO.FileSystemWatcher();
           /* try
            {
                txtpath1.Text = System.IO.File.ReadLines(@"D:\\Path1.txt");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No path was been setup" + "\n" + "Proceed to setup module" );
            }
            */
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Form framemain = new Form1();
            framemain.Close();
            this.Close();
        }

        private void Setupmenu_Click(object sender, EventArgs e)
        {
            panelwatchlist.Visible = false;
            panelconfig.Visible = true;
            panelconfig.Dock = DockStyle.Fill;
                    

        }

        private void onlineActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelwatchlist.Visible = true;
            panelconfig.Visible = false;
            panelwatchlist.Dock = DockStyle.Fill;
        }

        private void btnftowatch_Click(object sender, EventArgs e)
        {
            /*For files selection only*/
            /*OpenFileDialog openwatchfolder = new OpenFileDialog();

            if (openwatchfolder.ShowDialog() == System.Windows.Forms.DialogResult.OK) ;
            {
                string watchfolder = openwatchfolder.FileName;
            }
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string files = Directory.GetFiles(fbd.SelectedPath);

                    System.Windows.Forms.MessageBox.Show("Files found: " + files, "Message");
                }
            }*/

            /*For Folder selection*/
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtfoldertowatch.Text = folderDialog.SelectedPath;
                   
                }
            }
        }

        private void btnBtorun_Click(object sender, EventArgs e)
        {
           
        }
        static bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;
            try
            {
                stream = file.Open(FileMode.Open,
                                   FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }

            }
            return false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
                if (txtpath1.Text == "" && txtevent1.Text == "")
                {

                    if (txtfoldertowatch.Text == txtpath1.Text || txtfoldertowatch.Text == txtpath2.Text || txtfoldertowatch.Text == txtpath3.Text ||
                            txtfoldertowatch.Text == txtpath3.Text || txtfoldertowatch.Text == txtpath4.Text || txtfoldertowatch.Text == txtpath5.Text)

                    {
                        MessageBox.Show("Configuration already available to other watcher" + Environment.NewLine +
                                        "Please check your entry.");
                        return;
                    }
                    else
                    {

                        txtpath1.Text = txtfoldertowatch.Text + "\\";
                        txtevent1.Text = txtbatchfile.Text;
                        txtfoldertowatch.Text = "";
                        txtbatchfile.Text = "";
                        MessageBox.Show("Config already save");
                    }


                }
                else if (txtpath2.Text == "" && txtevent2.Text == "")
                {

                    if (txtfoldertowatch.Text == txtpath1.Text || txtfoldertowatch.Text == txtpath2.Text || txtfoldertowatch.Text == txtpath3.Text ||
                            txtfoldertowatch.Text == txtpath3.Text || txtfoldertowatch.Text == txtpath4.Text || txtfoldertowatch.Text == txtpath5.Text)

                    {
                        MessageBox.Show("Configuration already available to other watcher" + Environment.NewLine +
                                        "Please check your entry.");
                        return;
                    }
                    else
                    {

                        txtpath2.Text = txtfoldertowatch.Text + "\\";
                        txtevent2.Text = txtbatchfile.Text;
                        txtfoldertowatch.Text = "";
                        txtbatchfile.Text = "";
                        MessageBox.Show("Config already save");
                    }
                }
                else if (txtpath3.Text == "" && txtevent3.Text == "")
                {

                    if (txtfoldertowatch.Text == txtpath1.Text || txtfoldertowatch.Text == txtpath2.Text || txtfoldertowatch.Text == txtpath3.Text ||
                            txtfoldertowatch.Text == txtpath3.Text || txtfoldertowatch.Text == txtpath4.Text || txtfoldertowatch.Text == txtpath5.Text)

                    {
                        MessageBox.Show("Configuration already available to other watcher" + Environment.NewLine +
                                        "Please check your entry.");
                        return;
                    }
                    else
                    {
                        txtpath3.Text = txtfoldertowatch.Text + "\\";
                        txtevent3.Text = txtbatchfile.Text;
                        txtfoldertowatch.Text = "";
                        txtbatchfile.Text = "";
                        MessageBox.Show("Config already save");
                    }
                }
                else if (txtpath4.Text == "" && txtevent4.Text == "")
                {

                    if (txtfoldertowatch.Text == txtpath1.Text || txtfoldertowatch.Text == txtpath2.Text || txtfoldertowatch.Text == txtpath3.Text ||
                            txtfoldertowatch.Text == txtpath3.Text || txtfoldertowatch.Text == txtpath4.Text || txtfoldertowatch.Text == txtpath5.Text)

                    {
                        MessageBox.Show("Configuration already available to other watcher" + Environment.NewLine +
                                        "Please check your entry.");
                        return;
                    }
                    else
                    {

                        txtpath4.Text = txtfoldertowatch.Text + "\\";
                        txtevent4.Text = txtbatchfile.Text;
                        txtfoldertowatch.Text = "";
                        txtbatchfile.Text = "";
                        MessageBox.Show("Config already save");
                    }
                }
                else if (txtpath5.Text == "" && txtevent5.Text == "")
                {

                    if (txtfoldertowatch.Text == txtpath1.Text || txtfoldertowatch.Text == txtpath2.Text || txtfoldertowatch.Text == txtpath3.Text ||
                            txtfoldertowatch.Text == txtpath3.Text || txtfoldertowatch.Text == txtpath4.Text || txtfoldertowatch.Text == txtpath5.Text)

                    {
                        MessageBox.Show("Configuration already available to other watcher" + Environment.NewLine +
                                        "Please check your entry.");
                        return;
                    }
                    else
                    {

                        txtpath5.Text = txtfoldertowatch.Text + "\\";
                        txtevent5.Text = txtbatchfile.Text;
                        txtfoldertowatch.Text = "";
                        txtbatchfile.Text = "";
                        MessageBox.Show("Config already save");
                    }  
                }
                else
                {
                    MessageBox.Show("All Watcher is Busy, check your watchers file.");

                }
            
        }

        private void btnbatch_Click(object sender, EventArgs e)
        {
            OpenFileDialog watcherfile = new OpenFileDialog();

            if (watcherfile.ShowDialog() == System.Windows.Forms.DialogResult.OK) ;
            {
                string watchfolder = watcherfile.FileName;
                txtbatchfile.Text = watchfolder;
            }
        }

        private void btnstart1_Click(object sender, EventArgs e)
        {
            try
            {
           


                if (my_Watcher1.EnableRaisingEvents)
                {
                    m_bIsWatching = false;
                    my_Watcher1.EnableRaisingEvents = false;
                    //my_Watcher1.Dispose();
                    btnstart1.BackColor = Color.LightSkyBlue;
                    btnstart1.Text = "Start Watching";

                }
                else
                {
                    m_bIsWatching = true;
                    btnstart1.BackColor = Color.Red;
                    btnstart1.Text = "Stop Watching";
                    



                    my_Watcher1.Filter = txtpath1.Text.Substring(txtpath1.Text.LastIndexOf('\\') + 1);
                    my_Watcher1.Path = txtpath1.Text;


                    my_Watcher1.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                                         | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                    //my_Watcher.Changed += new FileSystemEventHandler(OnChanged);
                    my_Watcher1.Created += new FileSystemEventHandler(OnChanged1);
                    //my_Watcher.Deleted += new FileSystemEventHandler(OnChanged);
                    //my_Watcher.Renamed += new RenamedEventHandler(OnRenamed);
                    my_Watcher1.EnableRaisingEvents = true;


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No directory was setup.");
                btnstart1.BackColor = Color.LightSkyBlue;
                btnstart1.Text = "Start Watching";

            }


        }  
                

        private void btnstart2_Click(object sender, EventArgs e)
        {
            try
            {
            
                //my_Watcher2 = new System.IO.FileSystemWatcher();
                if (my_Watcher2.EnableRaisingEvents)
                {
                    m_bIsWatching = false;
                    my_Watcher2.EnableRaisingEvents = false;
                    //my_Watcher2.Dispose();
                    btnstart2.BackColor = Color.LightSkyBlue;
                    btnstart2.Text = "Start Watching";

                }
                else
                {
                    m_bIsWatching = true;
                    btnstart2.BackColor = Color.Red;
                    btnstart2.Text = "Stop Watching";
                    my_Watcher2 = new System.IO.FileSystemWatcher();


                    my_Watcher2.Filter = txtpath2.Text.Substring(txtpath2.Text.LastIndexOf('\\') + 1);
                    my_Watcher2.Path = txtpath2.Text;

                    my_Watcher2.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                                         | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                    
                    my_Watcher2.Created += new FileSystemEventHandler(OnChanged2);
                    
                    my_Watcher2.EnableRaisingEvents = true;
                   
                  
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No directory was setup.");
                btnstart2.BackColor = Color.LightSkyBlue;
                btnstart2.Text = "Start Watching";
            }


        }

        private void btnstart3_Click(object sender, EventArgs e)
        {
            // my_Watcher3 = new System.IO.FileSystemWatcher();
            try
            {
                my_Watcher3.EnableRaisingEvents = true; 
           
                if (my_Watcher3.EnableRaisingEvents)
                {
                    m_bIsWatching = false;
                    my_Watcher3.EnableRaisingEvents = false;
                    //my_Watcher3.Dispose();
                    btnstart3.BackColor = Color.LightSkyBlue;
                    btnstart3.Text = "Start Watching";

                }
                else
                {
                    m_bIsWatching = true;
                    btnstart3.BackColor = Color.Red;
                    btnstart3.Text = "Stop Watching";

                    

                    my_Watcher3.Filter = txtpath3.Text.Substring(txtpath3.Text.LastIndexOf('\\') + 1);
                    my_Watcher3.Path = txtpath3.Text;

                    my_Watcher3.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                                         | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                   
                    my_Watcher3.Created += new FileSystemEventHandler(OnChanged3);
                    
                        my_Watcher3.EnableRaisingEvents = true; MessageBox.Show("");
                    



                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("No directory was setup.");
                btnstart3.BackColor = Color.LightSkyBlue;
                btnstart3.Text = "Start Watching";
            }

        }

        private void btnstart4_Click(object sender, EventArgs e)
        {
            try
            {
                //my_Watcher4 = new System.IO.FileSystemWatcher();
                if (my_Watcher4.EnableRaisingEvents)
                {
                    m_bIsWatching = false;
                    my_Watcher4.EnableRaisingEvents = false;
                    //my_Watcher4.Dispose();
                    btnstart4.BackColor = Color.LightSkyBlue;
                    btnstart4.Text = "Start Watching";

                }
                else
                {
                    m_bIsWatching = true;
                    btnstart4.BackColor = Color.Red;
                    btnstart4.Text = "Stop Watching";



                    my_Watcher4.Filter = txtpath4.Text.Substring(txtpath4.Text.LastIndexOf('\\') + 1);
                    my_Watcher4.Path = txtpath4.Text;

                    my_Watcher4.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                                         | NotifyFilters.FileName | NotifyFilters.DirectoryName;

                    my_Watcher4.Created += new FileSystemEventHandler(OnChanged4);

                    my_Watcher4.EnableRaisingEvents = true;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No directory was setup.");
                btnstart4.BackColor = Color.LightSkyBlue;
                btnstart4.Text = "Start Watching";
            }
            
        }

        private void btnstart5_Click(object sender, EventArgs e)
        {
            try
            { 
                //my_Watcher5 = new System.IO.FileSystemWatcher();
                if (my_Watcher5.EnableRaisingEvents)
                {
                    m_bIsWatching = false;
                    my_Watcher5.EnableRaisingEvents = false;
                    //my_Watcher5.Dispose();
                    btnstart5.BackColor = Color.LightSkyBlue;
                    btnstart5.Text = "Start Watching";

                }
                else
                {
                    m_bIsWatching = true;
                    btnstart5.BackColor = Color.Red;
                    btnstart5.Text = "Stop Watching";

                    

                    my_Watcher5.Filter = txtpath5.Text.Substring(txtpath5.Text.LastIndexOf('\\') + 1);
                    my_Watcher5.Path = txtpath5.Text;

                    my_Watcher5.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                                         | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                    
                    my_Watcher5.Created += new FileSystemEventHandler(OnChanged5);
                   
                    my_Watcher5.EnableRaisingEvents = true;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No directory was setup.");
                btnstart5.BackColor = Color.LightSkyBlue;
                btnstart5.Text = "Start Watching";
            }


        }

        private void OnChanged1(object sender, FileSystemEventArgs e)
        {
           
            m_SB.Remove(0, m_SB.Length);
            m_SB.Append(e.FullPath);
            m_SB.Append(" ");
            m_SB.Append(e.ChangeType.ToString());
            m_SB.Append("    ");
            m_SB.Append(DateTime.Now.ToString());
            m_bDirty = true;
            Process.Start(@txtevent1.Text);
        }
       
        private void OnChanged2(object sender, FileSystemEventArgs e)
        {
            
            m_SB.Remove(0, m_SB.Length);
            m_SB.Append(e.FullPath);
            m_SB.Append(" ");
            m_SB.Append(e.ChangeType.ToString());
            m_SB.Append("    ");
            m_SB.Append(DateTime.Now.ToString());
            m_bDirty = true;
            Process.Start(@txtevent2.Text);
        }
        private void OnChanged3(object sender, FileSystemEventArgs e)
        {
            
            m_SB.Remove(0, m_SB.Length);
            m_SB.Append(e.FullPath);
            m_SB.Append(" ");
            m_SB.Append(e.ChangeType.ToString());
            m_SB.Append("    ");
            m_SB.Append(DateTime.Now.ToString());
            m_bDirty = true;
            Process.Start(@txtevent3.Text);
        }
        private void OnChanged4(object sender, FileSystemEventArgs e)
        {
            
            m_SB.Remove(0, m_SB.Length);
            m_SB.Append(e.FullPath);
            m_SB.Append(" ");
            m_SB.Append(e.ChangeType.ToString());
            m_SB.Append("    ");
            m_SB.Append(DateTime.Now.ToString());
            m_bDirty = true;
            Process.Start(@txtevent4.Text);
        }
        private void OnChanged5(object sender, FileSystemEventArgs e)
        {

            m_SB.Remove(0, m_SB.Length);
            m_SB.Append(e.FullPath);
            m_SB.Append(" ");
            m_SB.Append(e.ChangeType.ToString());
            m_SB.Append("    ");
            m_SB.Append(DateTime.Now.ToString());
            m_bDirty = true;
            Process.Start(@txtevent5.Text);
        }


        /*private void OnChanged(object sender, FileSystemEventArgs e)
        {

            MessageBox.Show(nameof(sender).ToString());
            if (txtevent1.Text == "" || txtpath1.Text == "")
            {
                MessageBox.Show("No available event added, Please check your entry.");
                return;
            }
            else
            {
                if (!m_bDirty)
                {
                    MessageBox.Show(my_Watcher1.EnableRaisingEvents.ToString());
                    m_SB.Remove(0, m_SB.Length);
                    m_SB.Append(e.FullPath);
                    m_SB.Append(" ");
                    m_SB.Append(e.ChangeType.ToString());
                    m_SB.Append("    ");
                    m_SB.Append(DateTime.Now.ToString());
                    m_bDirty = true;
                      Process.Start(@txtevent1.Text);
                   
                    
                }

            }


        }*/
        private void tmrEditNotify_Tick(object sender, EventArgs e)
        {
            if (m_bDirty)
            {
                lstnotification.BeginUpdate();
                lstnotification.Items.Add(m_SB.ToString());
                lstnotification.EndUpdate();
                m_bDirty = false;
            }
        }

        private void lstnotification_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
