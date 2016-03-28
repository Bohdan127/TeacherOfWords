namespace TeacherOfWords.Data.Tables
{
    public class Version
    {
        public int Current { get; set; }

        public override string ToString()
        {
            return "Current DB Version is " + Current;
        }
    }
}
