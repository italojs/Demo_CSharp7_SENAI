using System.IO;

namespace OthersExamples_.net4._6._2
{
    public class ExpressionBodiedMembers
    {
        private string _tempPath;

        public string TempPath2
        {
            get => _tempPath;
            set => _tempPath = value ?? "SomeValue";
        }

        public ExpressionBodiedMembers(string somePath) =>
            _tempPath = somePath;

        ~ExpressionBodiedMembers() => Directory.Delete(_tempPath);

        public void Execute()
        {
            Directory.CreateDirectory(_tempPath);

            //do somithing...
        }
    }
}
