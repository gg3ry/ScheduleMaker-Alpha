using System.Formats.Tar;

namespace ScheduleMaker_Alpha
{
    public partial class Form1 : Form
    {
        static List<Tanar> tanarok = new List<Tanar>();
        static List<Tanterem> tantermek = new List<Tanterem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void TeachersBtn_Click(object sender, EventArgs e)
        {
            string FileName = "tanarok.csv";
            string filedest = Path.Combine(Application.StartupPath, FileName);
            CopyFile(filedest, FileName, label0, $"{FileName} kivalasztasa");
            StreamReader file = new StreamReader(FileName);
            while (!file.EndOfStream)
            {
                Tanar itanar = new Tanar();
                string[] line = file.ReadLine().Split(';');
                itanar.Név = line[0];
                itanar.BentTöltöttNapok = line[1].Split(',').Select(n => (Nap)Enum.Parse(typeof(Nap), n)).ToList();
                tanarok.Add(itanar);
            }
            file.Close();
        }
        void CopyFile(string fd, string f, Label l, string msg)
        {
            if (!File.Exists(fd))
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = msg;
                ofd.Filter = "CSV fájlok (*.csv)|*.csv|Minden fájl (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.Copy(ofd.FileName, fd, overwrite: true);
                        l.Text = $"Fájl bemásolva: {f}";
                    }
                    catch (Exception ex)
                    {
                        l.Text = "Hiba a másolás közben: " + ex.Message;
                        CopyFile(fd, f, l, msg);
                    }
                }
                else
                {
                    l.Text = "Nem lett kiválasztva fájl. Az alkalmazás nem tud tovább működni.";
                    CopyFile(fd, f, l, msg);
                }
            }
            else
            {
                l.Text = $"{f} fájl megtalálva";
            }
        }

        private void ClassRoomsBtn_Click(object sender, EventArgs e)
        {
            string FileName = "tantermek.csv";
            string filedest = Path.Combine(Application.StartupPath, FileName);
            CopyFile(filedest, FileName, label1, $"{FileName} kivalasztasa");
            StreamReader file = new StreamReader(FileName);
            while (!file.EndOfStream)
            {

            }
            file.Close();
        }
    }
}
