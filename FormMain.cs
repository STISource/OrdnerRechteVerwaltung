using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using System.Security.AccessControl;

namespace OrdnerRechteVerwaltung
{
    public partial class frmMain : Form
    {
        public class Berechtigung
        {
            public string Pfad { get; set; }
            public bool berechtigt { get; set; }
        }

        public BindingList<Berechtigung> Berechtigungen = new BindingList<Berechtigung>();

        public frmMain()
        {
            InitializeComponent();
        }


        public static Boolean ReadFolderPermission(DirectoryInfo di, string AccountName)
        {
            Boolean ergebnis;
            ergebnis = false;

            //DirectoryInfo di = new DirectoryInfo(path);
            DirectorySecurity acl = di.GetAccessControl(AccessControlSections.All);
            AuthorizationRuleCollection rules = acl.GetAccessRules(true, true, typeof(NTAccount));

            //Go through the rules returned from the DirectorySecurity
            foreach (AuthorizationRule rule in rules)
            {
                //If we find one that matches the identity we are looking for
                if (rule.IdentityReference.Value.Equals(AccountName, StringComparison.CurrentCultureIgnoreCase))
                {
                    var filesystemAccessRule = (FileSystemAccessRule)rule;

                    //Cast to a FileSystemAccessRule to check for access rights
                    if ((filesystemAccessRule.FileSystemRights & FileSystemRights.WriteData) > 0 && filesystemAccessRule.AccessControlType != AccessControlType.Deny)
                    {
                        ergebnis = true;
                    }
                    else
                    {
                        ergebnis = false;
                    }
                }


            }
            return ergebnis;
        }


        public static void DenyFolderPermission(string folderPath, string userGrp)
        {
            var directoryInfo = new DirectoryInfo(folderPath);
            var directorySecurity = directoryInfo.GetAccessControl();

            var fileSystemRule = new FileSystemAccessRule(userGrp,
                                                          FileSystemRights.FullControl,
                                                          InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit,
                                                          PropagationFlags.None,
                                                          AccessControlType.Deny);

            directorySecurity.AddAccessRule(fileSystemRule);
            directoryInfo.SetAccessControl(directorySecurity);
        }



        private void butSearch_Click(object sender, EventArgs e)
        {
            Berechtigungen.Clear();
            grdPfade.Update();

            txtErr.Text = "";
            txtErr.Update();

            int count = 0;
            lbCounter.Text = "0";
            lbCounter.Update();

            Cursor = Cursors.WaitCursor;

            try
            {
                grdPfade.DataSource = Berechtigungen;

                // Take a snapshot of the file system.  
                DirectoryInfo dir = new DirectoryInfo(edBasis.Text);

                // This method assumes that the application has discovery permissions  
                // for all folders under the specified path.  
                IEnumerable<DirectoryInfo> dirList = dir.GetDirectories(edMaske.Text, SearchOption.AllDirectories);
               
                foreach (DirectoryInfo di in dirList)
                {

                    //Berechtigungen.Add(new Berechtigung { Pfad = di.FullName, berechtigt = ReadFolderPermission(di, edUser.Text) });
                    Berechtigungen.Add(new Berechtigung { Pfad = di.FullName, berechtigt = CanReadDirectory(di.FullName, edUser.Text) });

                    count = count + 1;
                    lbCounter.Text = count.ToString();
                    lbCounter.Update();
                }
                if (count == 0)
                {
                    txtErr.Text += "Keine Ordner gefunden die den Suchkriterien entsprechen.";
                }


            }
            catch (Exception err)
            {
                txtErr.Text += err.Message;
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }



        private bool CanReadDirectory(string folder, string user)
        {
            bool hasAccess = false;
            //Step 1. Get the user
            NTAccount acc = new NTAccount(user);
            SecurityIdentifier secId = acc.Translate(typeof(SecurityIdentifier)) as SecurityIdentifier;

            DirectorySecurity dirSec = Directory.GetAccessControl(folder);

            //Step 2. Get directory permission details for each user/group
            AuthorizationRuleCollection authRules = dirSec.GetAccessRules(true, true, typeof(SecurityIdentifier));

            foreach (FileSystemAccessRule ar in authRules)
            {
                if (secId.CompareTo(ar.IdentityReference as SecurityIdentifier) == 0)
                {
                    var fileSystemRights = ar.FileSystemRights;

                    // *** ERROR: BRÜCKSICHTIGT NICHT DASS DENY ALLE ANDEREN RECHTE ÜBERSTIMMT **************************
                    
                    //Step 3. Check file system rights here, read / write as required
                    if ((fileSystemRights == FileSystemRights.Read ||
                        fileSystemRights == FileSystemRights.ReadAndExecute ||
                        fileSystemRights == FileSystemRights.ReadData ||
                        fileSystemRights == FileSystemRights.ListDirectory) && (ar.AccessControlType != AccessControlType.Deny))
                    {
                        hasAccess = true;
                    }

                    if ((fileSystemRights == (FileSystemRights.ReadAndExecute | FileSystemRights.Synchronize)) && (ar.AccessControlType != AccessControlType.Deny))
                    {
                        hasAccess = true;
                    }

                    // DENY übersteuert alle anderen Rechte
                    if (ar.AccessControlType == AccessControlType.Deny)
                    {
                        hasAccess = false;
                        break;
                    }
                }
            }
            return hasAccess;
        }

        private void butDel_Click(object sender, EventArgs e)
        {
        
            Cursor = Cursors.WaitCursor;

            try
            {
                int count = 0;
                
                foreach (Berechtigung be in Berechtigungen)
                {
                    DenyFolderPermission(be.Pfad, edUser.Text);
                    
                    count = count + 1;
                    lbCounter.Text = count.ToString();
                    lbCounter.Update();
                }
            }
            catch (Exception err)
            {
                txtErr.Text += err.Message;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
