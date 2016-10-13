using System.IO;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;
using DataFormats     = System.Windows.Forms.DataFormats;
using DragDropEffects = System.Windows.Forms.DragDropEffects;
using DragEventArgs   = System.Windows.Forms.DragEventArgs;

namespace STLviewer
{
    /// <summary>
    /// Form that contains a STLviewerWPF user control
    /// Used to confim that a STL is valid using HelixToolKit
    /// </summary>
    public partial class FrmStlViewer : Form
    {
        /// <summary>
        /// The form that STL files can be dropped into /Drag-and-Drop
        /// </summary>
        public FrmStlViewer()
        {
            InitializeComponent();
        }


        /// <summary>
        /// DragEnter that shows the DragDropEffects.Copy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStlViewer_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }


        /// <summary>
        /// Files are dropped.. ONLY FIRST FILE IS ACCEPTED
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStlViewer_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                ViewNewStl(file);
                break; // Only the first file. Skip the other
            }
        }


        /// <summary>
        /// Create a visible model of the STL file
        /// </summary>
        /// <param name="filename">The STL file with full extension</param>
        private void ViewNewStl(string filename)
        {
            // WTF!! No file
            if (!File.Exists(filename)) return;

            // Check the file extension to be STL
            FileInfo fileInfo = new FileInfo(filename);
            if (fileInfo.Extension != ".stl") return;


            // Create a model of the STL file
            ModelImporter modellImporter = new ModelImporter();
            Model3DGroup model3DGroup = modellImporter.Load(filename);
            stLviewerWPF1.StlModel.Content = model3DGroup;

            //TODO: Center the STL
            //TODO: /Zoom/Pan/Max size on the loaded STL to fit within stLviewerWPF1 control    
        }



        //================================================================================================
        // Test with snapshots of the WPF control
        // 
        // status unknown. 
        //
        // The best result was a black bmp file.
        //
        // Included just as "Info"
        //================================================================================================
        
        
        
        
        
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    DrawingVisual visual = new DrawingVisual();
        //
        //    using (DrawingContext context = visual.RenderOpen())
        //    {
        //        VisualBrush visualBrush = new VisualBrush(stLviewerWPF1);
        //        context.DrawRectangle(visualBrush, null, new Rect(-0, 0, 1400, 800));
        //    }
        //
        //    RenderTargetBitmap renderTarget = new RenderTargetBitmap(900, 900, 92, 92, PixelFormats.Pbgra32);
        //
        //    renderTarget.Render(visual);
        //
        //    BitmapEncoder bitmapEncoder = new BmpBitmapEncoder();
        //    //PngBitmapEncoder bitmapEncoder = new PngBitmapEncoder();
        //    bitmapEncoder.Frames.Add(BitmapFrame.Create(renderTarget));
        //
        //    using (Stream stm = File.Create(@"C:\temp\stl.bmp"))
        //    {
        //        bitmapEncoder.Save(stm);
        //    }
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    RenderTargetBitmap rtb = new RenderTargetBitmap((int)100, (int)100, 96, 96, PixelFormats.Pbgra32);
        //    rtb.Render(stLviewerWPF1);
        //
        //    PngBitmapEncoder png = new PngBitmapEncoder();
        //    png.Frames.Add(BitmapFrame.Create(rtb));
        //    MemoryStream stream = new MemoryStream();
        //    png.Save(stream);
        //    //Image image = Image.FromStream(stream);
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    var hVp3D = new HelixViewport3D();
        //    var lights = new DefaultLights();
        //    var teaPot = new Teapot();
        //    hVp3D.Children.Add(lights);
        //    hVp3D.Children.Add(teaPot);
        //}





    }
}
