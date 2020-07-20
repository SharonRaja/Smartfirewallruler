using NetFwTypeLib;
using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Net;

namespace Smartfirewallruler
{
    public partial class Form1 : Form
    {
        private const String firewallid = "";
        private String wallstatus = "No";
        

        public Form1()
        {
            InitializeComponent();
            wallstatus = Firewallstatus();
            lblFirewallStatus.Text = "FirewallStatus: " + wallstatus;
            if (wallstatus.Equals("ON"))
            {
                Statuspane.BackColor = Color.Green;
            }
            AddRule();
        }

        public string Firewallstatus()
        {
            INetFwMgr manager = FirewallManager();
            bool isFirewallEnabled = manager.LocalPolicy.CurrentProfile.FirewallEnabled;
            if (isFirewallEnabled)
                return "ON";
            else
                return "OFF";
        }

        private static NetFwTypeLib.INetFwMgr FirewallManager()
        {
            //Type objectType = Type.GetTypeFromCLSID(new Guid(firewallid));
            //return Activator.CreateInstance(objectType) as NetFwTypeLib.INetFwMgr;
            Type TicfMgr = Type.GetTypeFromProgID("HNetCfg.FwMgr");
            INetFwMgr icfMgr = (INetFwMgr)Activator.CreateInstance(TicfMgr);
            return icfMgr;
        }
        // It is used to add the rule in th list box
        private void AddRule()
        {
            try
            {
                string snamelist = "";
               

                try
                {
                    snamelist = File.ReadAllText("firewallrule.txt");
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Creating a new file firewallrule.txt");
                    File.Create("firewallrule.txt").Close();
                    snamelist = File.ReadAllText("firewallrule.txt");
                }
                string[] sFwrule = snamelist.Split('|');
                if (sFwrule[0] != String.Empty)
                {
                    for (int i = 0; i < sFwrule.Length-1; i++)
                    {
                        cmdRules.Items.Add(sFwrule[i]);
                    }
                }
                //cmdRules.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //Add Inbound and Outbound Rules
        private void But_AddFilter_Click(object sender, EventArgs e)
        {
            try
            {
                /*  The INetFwRule interface provides access to the properties of a rule.   */
                INetFwRule firewallRule = FwInstance();

                if (cmdAction.SelectedItem.ToString() == "Block")
                {
                    firewallRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
                }
                else
                {
                    firewallRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
                }
                firewallRule.Name = txtName.Text.ToString();
                if (cmdDirection.SelectedItem.ToString() == "InBound")
                {
                    firewallRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
                    firewallRule.RemoteAddresses = txtIP.Text.Trim();
                }
                else if (cmdDirection.SelectedItem.ToString() == "OutBound")
                {
                    firewallRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
                    firewallRule.RemoteAddresses = txtIP.Text.Trim();
                }
                if (cmdPackets.SelectedItem.ToString() == "HTTP")
                {
                    firewallRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP;
                    firewallRule.RemotePorts = "80";
                }
                else if (cmdPackets.SelectedItem.ToString() == "HTTPS")
                {
                    firewallRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP;
                    firewallRule.RemotePorts = "443";
                }
                else
                {
                    txtIP.Enabled = true;
                }
                firewallRule.RemoteAddresses = txtIP.Text;
                firewallRule.Enabled = true;
                firewallRule.InterfaceTypes = "All";
                /*  The INetFwPolicy2 interface allows an application or service to access the firewall policy.*/
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                firewallPolicy.Rules.Add(firewallRule);

                cmdRules.Items.Add(txtName.Text);
                cmdRules.SelectedIndex = 0;

                using (FileStream fs = new FileStream("firewallrule.txt", FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(txtName.Text + "|");
                }


                MessageBox.Show(txtName.Text+" Rule Added Sucessfully ...","Added",MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        // To Create the instance for the INetFwRule firewallRule 
        private INetFwRule FwInstance()
        {
            try
            {
                INetFwRule firewallRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
                return firewallRule;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }

        }

        private void But_Find_Ip(object sender, EventArgs e)
        {
            String iplist = "";
            try
            {
                IPAddress[] addlis = Dns.GetHostAddresses(urlbox.Text);
                foreach (IPAddress ip in addlis)
                {
                    iplist = iplist + ip + "\n";
                }
                IPS.Text = iplist;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Unkown Host", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void But_Remove_Rule(object sender, EventArgs e)
        {
            try
            {
                String rmrule = cmdRules.SelectedItem.ToString();
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                firewallPolicy.Rules.Remove(rmrule);
                string snamelist = File.ReadAllText("firewallrule.txt");
                int start = snamelist.IndexOf(rmrule), end = rmrule.Length;
                snamelist = snamelist.Remove(start, end + 1);
                string[] sFwrule = snamelist.Split('|');
                using (FileStream fs = new FileStream("firewallrule.txt", FileMode.Truncate, FileAccess.ReadWrite))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(snamelist.Trim('\r','\n'));
                }
                MessageBox.Show(rmrule +" Rule Removed Sucessfully ...","Removed",MessageBoxButtons.OK);
                cmdRules.Items.Remove(rmrule);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }            
        }
    }
}
