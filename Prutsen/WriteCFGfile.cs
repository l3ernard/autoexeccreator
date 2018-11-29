using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace Prutsen
{
    public class WriteCFGfile
    {
        
        public static void WriteMain(string[] values)
        {
            string[] lines = { "rate \"" +  values[0] + "\"", "cl_cmdrate \"" + values[1] + "\"", "cl_updaterate \"" + values[2] + "\"", "cl_interp \"" + values[3] + "\"" , "cl_interp_ratio \"" + values[4] + "\"", "cl_lagcompensation \"" + values[5] + "\"" }; //create the content for the file
            var savelocation = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents"); // get the location where itll save to.
            System.IO.File.WriteAllLines(@"" + savelocation + "/autoexec.cfg", lines); //make and write to the file

            System.Windows.Forms.MessageBox.Show("Saved successfully, find your autoexec.cfg file at: \"" + savelocation + "\""); //let the user know it saved properly
        }
    }
}
