using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Exercise2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "兎田ぺこら Usada Pekora BGM.wav");
            

            if (File.Exists(filePath))
            {
                SoundPlayer soundPlayer = new SoundPlayer(filePath);
                soundPlayer.Play();
            }
            else
            {
                MessageBox.Show("File not found: " + filePath);
            }

            Application.Run(new DangNhap());
        }
    }
}
