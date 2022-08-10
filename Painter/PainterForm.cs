//Abida Adra assignment 2
// Fig 14.38: PainterForm.cs
// Using the mouse to draw on a Form.
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Painter
{
    public partial class PainterForm : Form
    {
        private Color brushColor;//the color of the brush when painting
        private int dotSize = 4;//size of a dot when drawing
        private bool shouldPaint;// determines whether to paint

		// default constructor
        public PainterForm()
        {
            InitializeComponent();
        }
		//end constructor
		
		//when user chooses red color
        private void redRadioButton_CheckedChanged(
            object sender, EventArgs e)
        {
            if (redRadioButton.Checked)
                brushColor = Color.Red;
        }
		
		//when user chooses blue color
        private void blueRadioButton_CheckedChanged(
            object sender, EventArgs e)
        {
            if (blueRadioButton.Checked)
                brushColor = Color.Blue;
        }
		
		//when user chooses green color
        private void greenRadioButton_CheckedChanged(
            object sender, EventArgs e)
        {
            if (greenRadioButton.Checked)
                brushColor = Color.Green;
        }

		//when user chooses black color
        private void blackRadioButton_CheckedChanged(
            object sender, EventArgs e)
        {
            if (blackRadioButton.Checked)
                brushColor = Color.Black;
        }
		
		//when user chooses small brush
        private void smallRadioButton_CheckedChanged(
            object sender, EventArgs e)
        {
            if (smallRadioButton.Checked)
                dotSize = 4;
        }
		
		//when user chooses medium brush
        private void mediumRadioButton_CheckedChanged(
            object sender, EventArgs e)
        {
            if (mediumRadioButton.Checked)
                dotSize = 8;
        }

		//when user chooses large brush
        private void largeRadioButton_CheckedChanged(
            object sender, EventArgs e)
        {
            if (largeRadioButton.Checked)
                dotSize = 10;
        }

		// should paint when mouse button is pressed down
        private void PainterPanel_MouseDown(object sender, MouseEventArgs e)
        {
			// indicate that user is dragging the mouse
            shouldPaint = true;
        }// end method Painter_MouseDown

		// stop painting when mouse button is released
        private void PainterPanel_MouseUp(object sender, MouseEventArgs e)
        {
			// indicate that user released the mouse button
            shouldPaint = false;
        }// end method Painter_MouseUp

		// draw circle whenever mouse moves with its button held down 
        private void PainterPanel_MouseMove(object sender, MouseEventArgs e)
        {
            
                    
            var graphics = PainterPanel.CreateGraphics();//adding a new panel called PainterPanel
            SolidBrush mySolidBrush = new SolidBrush(brushColor);
            
         

            // find index, draw proper shape
            switch (imageComboBox.SelectedIndex)
            {
                case 0: // case Filled Circle is selected
                    graphics.FillEllipse(mySolidBrush, 50, 50, 150, 150);
                    break;
                case 1: // case Filled Rectangle is selected
                    graphics.FillRectangle(mySolidBrush, 50, 50, 150,
                       150);
                    break;
                case 2: // case Filled Ellipse is selected
                    graphics.FillEllipse(mySolidBrush, 50, 85, 150, 115);
                    break;
                case 3: // case Filled Pie is selected
                    graphics.FillPie(mySolidBrush, 50, 50, 150, 150, 0,
                       45);
                    break;
            }

            if (!shouldPaint) return;// check if mouse button is being pressed
            graphics.FillEllipse(mySolidBrush, e.X, e.Y, dotSize, dotSize);
            graphics.Dispose();// end using; calls graphics.Dispose()
        }

        private void PainterPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}