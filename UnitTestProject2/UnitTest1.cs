using Laba_1_KSKS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using System.Drawing;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ButDrawClick_ShouldClearDisplayInRed_WhenCommandIsClearDisplayWithRedColor()
        {
            Form1 form = new Form1();
            form.recBox.Text = "clear display";
            form.parBox.Text = "red";
            Graphics g = form.DrawingPanel.CreateGraphics();
            form.butDraw_Click(null, EventArgs.Empty);
        }

        [TestMethod]
        public void ButDrawClick_ShouldClearDisplayInBlue_WhenCommandIsClearDisplayWithBlueColor()
        {
            Form1 form = new Form1();
            form.recBox.Text = "clear display";
            form.parBox.Text = "blue";
            Graphics g = form.DrawingPanel.CreateGraphics();
            form.butDraw_Click(null, EventArgs.Empty);
        }

        [TestMethod]
        public void ButDrawClick_ShouldClearDisplayInGreen_WhenCommandIsClearDisplayWithGreenColor()
        {
            Form1 form = new Form1();
            form.recBox.Text = "clear display";
            form.parBox.Text = "green";
            Graphics g = form.DrawingPanel.CreateGraphics();
            form.butDraw_Click(null, EventArgs.Empty);
        }
    }
}

