using System;
using System.IO;
using System.Text;
using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class ApprovalTest
    {
        [Test]
        public void ThirtyDays()
        {
            var expectedLines = File.ReadAllLines("ThirtyDays.txt");

            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader(""));

            Program.Main(new string[] { });
            String output = fakeoutput.ToString();

            var actualLines = output.Split(new[] { "\r\n", "\r", "\n"}, StringSplitOptions.None);
            for(var i = 0; i<Math.Min(expectedLines.Length, actualLines.Length); i++) 
            {
                Assert.AreEqual(expectedLines[i], actualLines[i]);
            }
        }
    }
}
