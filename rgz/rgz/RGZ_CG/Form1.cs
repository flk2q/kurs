using System;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;

namespace RGZ_CG
{
    public partial class Form1 : Form
    {
        private Figure figure;
        private bool orthoProjection = true;
        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            float[] LightAmbient = { 0.5f, 0.5f, 0.5f, 1.0f };
            float[] LightDiffuse = { 1.0f, 1.0f, 1.0f, 1.0f };
            float[] LightDirection = { 0.0f, 0.0f, 1.0f, 0.0f };

            // инициализация Glut
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_SINGLE | Glut.GLUT_DEPTH);

            // отчитка окна
            Gl.glClearColor(255, 255, 255, 1);

            // установка порта вывода в соответствии с размерами элемента anT
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);

            // настройка проекции
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            float delta = AnT.Width / (float)AnT.Height;
            Gl.glOrtho(-5.0 * delta, 5.0 * delta, -5.0, 5.0, -50, 50);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glEnable(Gl.GL_DEPTH_TEST);

            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_DIFFUSE, LightDiffuse);
            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_AMBIENT, LightAmbient);
            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_POSITION, LightDirection);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, LightDirection);

            Gl.glEnable(Gl.GL_NORMALIZE);

            Gl.glLightModelf(Gl.GL_LIGHT_MODEL_TWO_SIDE, Gl.GL_TRUE);
            Gl.glEnable(Gl.GL_LIGHT1);
            Gl.glEnable(Gl.GL_LIGHT0);

          /*  MessageBox.Show("Выберите файл .obj");
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = openFileDialog1.SafeFileName;
            string fullFileName = openFileDialog1.FileName;
            labelFile.Text = fileName;
            figure = new Figure(ref AnT, fullFileName);
            comboBoxProjection.SelectedIndex = 1;
            figure.Draw();*/
        }
        
        private void trackBarScale_ValueChanged(object sender, EventArgs e)
        {
            double t = trackBarScale.Value / 1000.0;
            if (figure != null)
            {
                figure.Scale(t);
                figure.Draw();
            }

        }
        private void comboBoxProjection_SelectedIndexChanged(object sender, EventArgs e)
        {

            orthoProjection = comboBoxProjection.SelectedIndex == 0 ? true : false;

            Gl.glMatrixMode(Gl.GL_PROJECTION);

            if (orthoProjection)
                Gl.glPopMatrix();
            else
            {
                Gl.glPushMatrix();
                Gl.glLoadIdentity();
                //устанавливаем перспективу
                Glu.gluPerspective(60, (float)AnT.Width / AnT.Height, 0.1, 200);
                Gl.glHint(Gl.GL_PERSPECTIVE_CORRECTION_HINT, Gl.GL_NICEST);
            }

            Gl.glMatrixMode(Gl.GL_MODELVIEW);

            resetValues();

            if (figure != null)
            {
                figure.ChangeProjection(orthoProjection);
                figure.Draw();
            }

        }
        private void trackBarRotate_ValueChanged(object sender, EventArgs e)
        {
            int x = trackBarRotateX.Value;
            int y = trackBarRotateY.Value;
            int z = trackBarRotateZ.Value;

            if (figure != null)
            {
                figure.Rotate(x, y, z);
                labelX.Text = x.ToString();
                labelY.Text = y.ToString();
                labelZ.Text = z.ToString();
                figure.Draw();
            }
        }
        private void trackBarTranslate_ValueChanged(object sender, EventArgs e)
        {
            double x = trackBarTranslateX.Value / 5000.0;
            double y = trackBarTranslateY.Value / 5000.0;
            double z = trackBarTranslateZ.Value / 5000.0;

            if (figure != null)
            {
                figure.Translate(x, y, z);
                figure.Draw();
            }

            labelTrX.Text = x.ToString();
            labelTrY.Text = y.ToString();
            labelTrZ.Text = z.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            if (result == DialogResult.OK)
            {
                resetValues();
                string fileName = openFileDialog1.SafeFileName;
                string fullFileName = openFileDialog1.FileName;
                labelFile.Text = fileName;
                figure = new Figure(ref AnT, fullFileName);
                figure.ChangeProjection(comboBoxProjection.SelectedIndex == 0 ? true : false);
                figure.Draw();
                FindForm().Focus();
            }
        }
        private void resetValues()
        {
            trackBarRotateX.Value = 0;
            trackBarRotateY.Value = 0;
            trackBarRotateZ.Value = 0;
            trackBarScale.Value = 1000;
            trackBarTranslateX.Value = 0;
            trackBarTranslateY.Value = 0;
            trackBarTranslateZ.Value = 0;
            checkBoxPoints.Checked = true;
            checkBoxWire.Checked = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);
            comboBoxProjection.SelectedIndex = comboBoxProjection.SelectedIndex == 0 ? 0 : 1;
            if (figure != null)
                figure.Draw();
        }

        private void checkBoxWire_CheckedChanged(object sender, EventArgs e)
        {
            if(figure != null)
            {
                figure.Wire(checkBoxWire.Checked);
                figure.Draw();
            }
        }

        private void checkBoxPoints_CheckedChanged(object sender, EventArgs e)
        {
            if (figure != null)
            {
                figure.Points(checkBoxPoints.Checked);
                figure.Draw();
            }
        }
    }
}
