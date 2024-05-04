namespace modul10_1302223027
{
    public class Mahasiswa
    {
        public string name {  get; set; }
        public string nim { get; set; }
        public  List<string> courses { get; set; } = new List<string>();

        public int year { get; set; }

        public Mahasiswa(string name, string nim, List<string> courses, int year) {
            this.name = name;
            this.nim = nim;
            this.year = year;
            this.courses = courses;
        }
    }
}
