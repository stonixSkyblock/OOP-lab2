using System.Buffers.Text;

namespace MusicLab2
{
    public class MainGenre
    {
        private string name;
        public  string Name
        {
            get { return name; }
        }

        public MainGenre()
        {
            name = Name;
        }
        public MainGenre(string name)
        {
            this.name = name;
        }
    }
    public class SubGenre: MainGenre
    {
        private string name;
        public string Name
        {
            get { return name; }
        }
        public SubGenre()
        {
            name = "Genre3 " + base.Name;
        }
        public SubGenre(string name)
        {
            this.name = name + " " + base.Name;
        }
    }
}