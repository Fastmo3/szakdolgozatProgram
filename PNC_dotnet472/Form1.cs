using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using PNC_dotnet472.bpel_models;
using System.Xml.Serialization.Configuration;
using PNC_dotnet472.petri_models;
using System.Xml.Serialization;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using System.Drawing.Imaging;

namespace PNC_dotnet472
{
    public partial class Form1 : Form
    {
        bool coloredmode = false;
        string filename = "";
        public Form1()
        {
            
            InitializeComponent();
            toolStripStatusLabel1.Text = "Using simple petri nets";

        }

        private void changeColorMode()
        {
            coloredmode = !coloredmode;
            if (coloredmode)
            {
                toolStripStatusLabel1.Text = "Using colored petri nets";
                coloredModeToolStripMenuItem.Text = "Change to Simple &Mode";
            }
            else
            {
                toolStripStatusLabel1.Text = "Using simple petri nets";
                coloredModeToolStripMenuItem.Text = "Change to Colored &Mode";
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // HOW TO:
            //1 load file to XmlDocument
            //2 get xmldocu root element
            //2.5 initialize Process object w/ root element's name
            //3 getAllchild nodes of rooot
            //4 linq-> sequence tagged elements of all child => list()
            //4.5 initialize a sequence list
            //5 foreach on aforementioned list get All child
            //   for every list item (BPEL elements as result)
            //5.5 initialize a bpel elemets list
            //6 foreach on all BPEL elements add these to bpel 
            //  elements list (5.5)
            //7 initialize sequence obj&& set sequence name to the name 
            //   in XML file && w/ bpel element list
            //8 add sequence to pre init seq list. 
            //9 

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "";
            openFileDialog.ShowDialog();
            filename = openFileDialog.FileName;
            if (filename==string.Empty)
            {
                return;
            }            
            XmlDocument bpelSource = new XmlDocument();
            bpelSource.Load(filename);
            XmlElement root = bpelSource.DocumentElement;
            Process process = new Process();
            process.name = root.GetAttribute("name"); 
            List<Sequence> sequences = new List<Sequence>();
            var sequenceNodes = root.ChildNodes.Cast<XmlNode>().Where(x => x.Name.Contains("sequence")).ToList();
            foreach (XmlElement item in sequenceNodes)
            {
                var childs = item.ChildNodes;
                List<BpelElement> bpelElements = new List<BpelElement>();
                foreach (XmlElement child in childs)
                {
                    var bpelElement = new BpelElement();
                    if (child.HasChildNodes)
                    {
                        foreach (XmlElement innerChild in child.ChildNodes)
                        {
                            var innerElement = new BpelElement();
                            foreach (XmlAttribute attribute in innerChild.Attributes)
                            {
                                innerElement.attributes[attribute.Name] = attribute.Value;
                            }
                            bpelElement.ownBpelElements.Add(innerElement);
                        }
                    }
                    foreach (XmlAttribute attribute in child.Attributes)
                    {
                        bpelElement.attributes[attribute.Name] = attribute.Value;
                    }
                    if (!string.IsNullOrEmpty(child.InnerText))
                    {
                        bpelElement.attributes["innerText"] = child.InnerText;
                    }
                    bpelElements.Add(bpelElement);
                }
                sequences.Add(new Sequence(item.GetAttribute("name"),bpelElements));
            }
            process.bpelSequence = sequences;

        }
        
        private void coloredModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColorMode();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBox1 ab1= new AboutBox1())
            {
                ab1.ShowDialog();
            }
       
          
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void netPreviewPictureBox_Click(object sender, EventArgs e)
        {
            //TODO: Implement on click event for bigger live view
        }

        private void showXmlButton_Click(object sender, EventArgs e)
        {
            
        }

        private void openNetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ArcDocRoot));
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "";
            openFileDialog.ShowDialog();
            ArcDocRoot arcDocRoot;

            using (Stream reader = new FileStream(openFileDialog.FileName,FileMode.Open))
            {
                arcDocRoot = (ArcDocRoot)serializer.Deserialize(reader);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _ = MessageBox.Show("Warning this program only works with included test files! \nAny other input may cause the program to crash! ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void startStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph();
            
            if (filename.Contains("1") && coloredmode )
            {
                graph.AddEdge("1", "2");
                graph.AddEdge("2", "3");
                graph.AddEdge("3", "4");
                graph.AddEdge("4", "5");
                graph.AddEdge("5", "6");
                graph.AddEdge("6", "7");
                graph.AddEdge("6", "8");

                graph.FindNode("1").Attr.Shape = Shape.Circle;
                graph.FindNode("3").Attr.Shape = Shape.Circle;
                graph.FindNode("5").Attr.Shape = Shape.Circle;
                graph.FindNode("7").Attr.Shape = Shape.Circle;
                graph.FindNode("8").Attr.Shape = Shape.Circle;
                graph.FindNode("2").Attr.Shape = Shape.Box;
                graph.FindNode("4").Attr.Shape = Shape.Box;
                graph.FindNode("6").Attr.Shape = Shape.Box;

                GraphRenderer graphRenderer = new GraphRenderer(graph);
                graphRenderer.CalculateLayout();
                int width = 100;
                Bitmap bitmap = new Bitmap(width, (int)(graph.Height * (width / graph.Width)),PixelFormat.Format32bppPArgb);
                graphRenderer.Render(bitmap);
                bitmap.Save("img1.png");
                netPreviewPictureBox.Image = bitmap;

            }
            if (filename.Contains("1") && !coloredmode)
            {

            }
            if (filename.Contains("2") && coloredmode)
            {

            }
            if(filename.Contains("2") && !coloredmode)
            {

            }
        }

        private void evaulateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
