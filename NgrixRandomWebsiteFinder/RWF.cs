using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgrixRandomWebsiteFinder
{
    public class RWF
    {

        public static Dictionary<string, string> domain_extensions = new Dictionary<string, string>();
        public static bool topMost = true;
        private static int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        private static int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        public static Point logoForm = new Point((screenWidth / 2) - 700, (screenHeight / 2) - 350);
        public static Point thread2Form = new Point((screenWidth / 2) - 390, (screenHeight / 2) - 350);
        public static Point thread3Form = new Point((screenWidth / 2) - 80, (screenHeight / 2) - 350);
        public static Point thread4Form = new Point((screenWidth / 2) + 230, (screenHeight / 2) - 350);
        public static Point thread5Form = new Point((screenWidth / 2) + 540, (screenHeight / 2) - 350);
        public static Point main = new Point((screenWidth / 2) - 700, (screenHeight / 2) + 100);
        public static Point thread6Form = new Point((screenWidth / 2) - 390, (screenHeight / 2) + 100);
        public static Point thread8Form = new Point((screenWidth / 2) - 80, (screenHeight / 2) + 100);
        public static Point thread9Form = new Point((screenWidth / 2) + 230, (screenHeight / 2) + 100);
        public static Point thread10Form = new Point((screenWidth / 2) + 540, (screenHeight / 2) + 100);
        public static Point thread11Form = new Point((screenWidth / 2) + 790, (screenHeight / 2) + 100);

        public static List<string> tried_domains = new List<string>();
        public static List<string> working_domains = new List<string>();


    }
}
