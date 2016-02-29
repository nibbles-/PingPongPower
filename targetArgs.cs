/*
 * Created by SharpDevelop.
 * User: johan
 * Date: 2013-01-19
 * Time: 15:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net.NetworkInformation;

namespace PingPongPower
{
    /// <summary>
    /// Description of targetArgs.
    /// </summary>
    public class targetArgs : System.EventArgs
    {
        public PingReply response { get; set; }
        public string label { get; set; }
        
        public targetArgs(PingReply pingreply)
        {
            this.response = pingreply;
        }
        public targetArgs(PingReply pingreply, string label)
        {
            this.response = pingreply;
            this.label = label;
        }
    }
}
