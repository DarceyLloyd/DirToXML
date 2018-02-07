using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace DirToXML
{
    public partial class Form1 : Form
    {
        private String output = "";
        private FolderBrowserDialog fbd = new FolderBrowserDialog();
        private String CDataOpen = "";
        private String CDataClose = "";
        private String tabs = "";
        private int TabCount = 0;


        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        public Form1()
        {
            InitializeComponent();

            txtDir.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

        



        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        private void btnGetDir_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDir.Text = fbd.SelectedPath;
            }
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 


        



        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // init output
            output = "";
            TabCount = 0;
            tabs = "";
            txtDebug.Text = "";
            txtOutput.Text = "";
            CDataOpen = "<![CDATA[";
            CDataClose = "]]>";

            // Output
            if (!Directory.Exists(txtDir.Text))
            {
                txtDebug.Text = "DIR NOT FOUND!";
                return;
            }
            else
            {
                txtDebug.Text = "DIR FOUND - GENERATING - PLEASE WAIT";
            }

            
            
           

            
            // Process " to '
            String quotes = "'";
            if (cbUseQuotes.Checked)
            {
                quotes = "\"";
            }


            // XML Doc Root processing
            if (cbAddXMLRootNode.Checked)
            {
                output += "<?xml version=" + quotes + "1.0" + quotes + "?>\n";
                tabUp();
            }


            // XML Root node path attribute include
            if (cbIncludePathInRootNode.Checked)
            {
                output += tabs + "<" + txtRootNode.Text + " dir='" + txtDir.Text.Replace("\\", "/") + "'>\n";
            }
            else
            {
                output += tabs + "<" + txtRootNode.Text + ">\n";
            }

            
            // CDATA processing
            if (!cbCdata.Checked)
            {
                CDataOpen = "";
                CDataClose = "";
            }


            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // Loop start
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            tabUp();
            string[] fileEntries = Directory.GetFiles(txtDir.Text);
            foreach (string filePath in fileEntries)
            {
                FileInfo fi = new FileInfo(filePath);

                // Estimate type
                String type = "";
                if (cbAddTypeDetection.Checked)
                {
                    type = getType(fi.Extension);
                }

                // Process file name
                String fn = "";
                fn = fi.Name;

                if (!cbIncludeExtInFileName.Checked)
                {
                    fn = fn.Replace(fi.Extension, "");
                }


                // Process path
                String path = filePath.Replace("\\", "/");
                if (txtFind.Text.Length > 0)
                {
                    path = path.Replace(txtFind.Text, txtWith.Text);
                }


                // Process file size
                float fs = 0;
                String SizeLabel = "kb";
                if (cbFileSizeInBytes.Checked)
                {
                    fs = fi.Length / 1024; 
                }
                else
                {
                    fs = fi.Length;
                    SizeLabel = "bytes";
                }


                // Process appended attribute string
                String apa = "";
                if (txtAttributeAppend.Text.Length > 0)
                {
                    apa = txtAttributeAppend.Text;
                }


                
                if (cbFilePathAsAttribute.Checked)
                {
                    output += tabs + "<" + txtChildNode.Text + " ";
                    output += "name="+ quotes + fn + quotes + " ";
                    if (cbAddTypeDetection.Checked)
                    {
                        output += "type=" + quotes + type + quotes + " ";
                    }
                    output += "ext=" + quotes + fi.Extension.Replace(".", "") + quotes + " ";
                    output += "path=" + quotes + path + quotes + " ";
                    output += SizeLabel + "=" + quotes + fs + quotes + " ";
                    output += apa;
                    output += "/>" + "\n";
                }
                else
                {
                    output += tabs + "<" + txtChildNode.Text + " ";
                    output += "name=" + quotes + fn + quotes + " ";
                    if (cbAddTypeDetection.Checked)
                    {
                        output += "type=" + quotes + type + quotes + " ";
                    }
                    output += "ext=" + quotes + fi.Extension.Replace(".", "") + quotes + " ";
                    output += SizeLabel + "=" + quotes + fs + quotes + " ";
                    output += apa;
                    output += ">";
                    output += CDataOpen + path + CDataClose;
                    output += "</" + txtChildNode.Text + ">\n";
                }
            }
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // LOOP END
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            tabDown();
            output += tabs + "</" + txtRootNode.Text + ">\n";


            // XML Root node processing
            if (cbAddXMLRootNode.Checked)
            {
                output += "</xml>\n";
            }

            // Output
            txtOutput.Text = output;

        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 


        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        
        private void tabUp()
        {
            TabCount++;
            buildTabString();
        }
        private void tabDown()
        {
            TabCount--;
            buildTabString();
        }
        private void buildTabString()
        {
            tabs = "";
            for (int i = 1; i <= TabCount; i++)
            {
                tabs += string.Format(@"{0}", "\t");
            }
            //txtDebug.Text += "Tab loop complete\n";
            //txtDebug.Text += "tabs = [" + tabs + "]\n";
            //txtDebug.Text += "tabs = " + tabs + "\n";
            txtDebug.Text = "COMPLETE";
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 



        private String getType(String ext)
        {
            String type = "";
            
                switch (ext)
                {
                    case ".png":
                        type = "image";
                        break;
                    case ".gif":
                        type = "image";
                        break;
                    case ".jpg":
                        type = "image";
                        break;
                    case ".jpeg":
                        type = "image";
                        break;
                    case ".bmp":
                        type = "image";
                        break;
                    case ".xml":
                        type = "xml";
                        break;
                    case ".html":
                        type = "text";
                        break;
                    case ".txt":
                        type = "text";
                        break;
                    case ".css":
                        type = "text";
                        break;
                    case ".ttf":
                        type = "font";
                        break;
                    case ".otf":
                        type = "font";
                        break;
                    case ".mp3":
                        type = "sound";
                        break;
                    case ".wav":
                        type = "sound";
                        break;
                    case ".avi":
                        type = "video";
                        break;
                    case ".flv":
                        type = "video";
                        break;
                    case ".f4v":
                        type = "video";
                        break;
                    case ".mp4":
                        type = "video";
                        break;
                    case ".mov":
                        type = "image";
                        break;
                    case ".swf":
                        type = "swf";
                        break;
                    case ".swc":
                        type = "swc";
                        break;
                    default:
                        type = "unknown";
                        break;
                }

            return type;
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 


        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        private void btnGenerateSimpleList_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtDir.Text))
            {
                txtOutput.Text = "DIR NOT FOUND!";
                return;
            }
            else
            {
                txtOutput.Text = "DIR FOUND - GENERATING - PLEASE WAIT";
            }


            output = "";
          
            string[] fileEntries = Directory.GetFiles(txtDir.Text);
            foreach (string filePath in fileEntries)
            {
                 // Process path
                String path = filePath;
                if (txtFind.Text.Length > 0)
                {
                    path = path.Replace(txtFind.Text, txtWith.Text);
                    output += path + "\n";
                }
                else
                {
                    output += filePath + "\n";
                }

                //FileInfo fi = new FileInfo(filePath);   
            }


           


            txtOutput.Text = output;
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 



        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Length > 1)
            {
                Clipboard.SetText(txtOutput.Text);
            }
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 


        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        private void btnSaveXMLFile_Click(object sender, EventArgs e)
        {
            //new System.Xml.Linq.XDeclaration("1.0", "utf-8", null),
            //new System.Xml.Linq.XElement("root", new XAttribute("note", "boogers"))

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML File|*.xml";
            saveFileDialog1.Title = "Save XML file";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                var utf8WithoutBom = new System.Text.UTF8Encoding(false);
                using (var sink = new StreamWriter(saveFileDialog1.FileName, false, utf8WithoutBom))
                {
                    //sink.WriteLine("...");
                    sink.Write(txtOutput.Text);
                }
            }

            
            
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 





    }
}
