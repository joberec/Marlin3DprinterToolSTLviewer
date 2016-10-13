using System.Drawing;
using System.Runtime.InteropServices;
using SharpShell.Attributes;
using SharpShell.SharpThumbnailHandler;

namespace StlViewerThumbnailHandler
{
    // ====================================================================================================================================================================
    // 
    //     N E E D E D     E X T E N S I O N S 
    // 
    // If you have Nuget installed, just do a quick search for SharpShell and install it directly - or get the package details at https://www.nuget.org/packages/SharpShell.
    // 
    // More info can be found at: http://www.codeproject.com/Articles/563114/NET-Shell-Extensions-Shell-Thumbnail-Handlers    
    // ====================================================================================================================================================================

    /// <summary>
    /// Derived StlViewerThumbnailHandlerClass from SharpThumbnailHandler  (Nuget)
    /// 
    /// 
    /// </summary>
    /// ComVisible attribute to class. This because our class is a COM server and must be visible to other code trying to use it. 
    /// Associate our extension with some the types of shell items we want to use it for. This is done with the COMServerAssociation attribute
    [ComVisible(true)]
    [COMServerAssociation(AssociationType.FileExtension, ".stl")]
    public class StlViewerThumbnailHandlerClass : SharpThumbnailHandler
    {
        /// <summary>
        /// Creates a thumbnail for a 3D object (.STL)
        /// 
        /// The Stlfile is available in the SelectedItemStream property. 
        /// 
        /// </summary>
        /// <param name="width">With of the bitmap thats needs to be created. (Height is equal. The thumbnail cannot be higher than it is wide. )</param>
        /// <returns></returns>
        protected override Bitmap GetThumbnailImage(uint width) // Implemented abstract function in the base class
        {

            return CreateThumbnailForSTL(width);
        }


        /// <summary>
        /// Creates a thumbnail for STL file. (Replace static bitmap with bitmap from STL stream)
        /// </summary>
        /// <param name="width">The width of the thumbnail</param>
        /// <returns></returns>
        private Bitmap CreateThumbnailForSTL(uint width)
        {
            // Reader for the STL Stream 
            // using (var STLreader = new StreamReader(SelectedItemStream))
            //{
            // ....
            //}


            
            // This is the Mockup that creates a dummy thumbnail on STL files
            Bitmap thumbnailBitmap = (Bitmap) Image.FromFile(@"C:\temp\dummySTLthumbnail.bmp", true);

            return thumbnailBitmap;
        }
    }
}
    