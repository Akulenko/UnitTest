using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitProject;
using System.IO;

namespace TestPen
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Returns_Empty_String_If_Ink_Finished()
        {
            //arrange
            var pen = new Pen(0);

            //action
            var result = pen.write("word");

            //assert
            Assert.AreEqual(result, "");
        }

        [TestMethod]
        public void Write_Word_If_Pen_Works()
        {
            //arrange
            var pen = new Pen(10);

            //action
            var result = pen.write("word");

            //assert
            Assert.AreEqual(result, "word");
        }

        [TestMethod]
        public void Write_Part_Of_Word_While_Ink_Not_Finished_If_Pen_Works()
        {
            //arrange
            var pen = new Pen(5, 2);

            //action
            var result = pen.write("worldddd");

            //assert
            Assert.AreEqual(result, "world");
        }

        [TestMethod]
        public void Check_Correct_Colour_Of_Pen()
        {
            //arrange
            var pen = new Pen(5, 1.0, "RED");

            //action
            var result = pen.getColor();

            //assert
            Assert.AreEqual(result, "RED");
        }

        [TestMethod]
        public void Writes_Pen_Color_To_The_Console()
        {
            //arrange
            var pen = new Pen(5, 1, "RED");
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            //action
            pen.doSomethingElse();

            //assert
            string expected = string.Format("RED{0}", Environment.NewLine);
            Assert.AreEqual(expected, sw.ToString());

            sw.Close();
            sw.Dispose();
        }
    }
}
