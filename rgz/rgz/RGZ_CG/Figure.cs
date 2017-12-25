using System;
using System.Collections.Generic;
using System.IO;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Media.Media3D;

namespace RGZ_CG
{
    class Figure
    {
        struct Face
        {
            public List<int> points;
            public List<int> normales;
            public List<int> textures;
        }
        private bool drawWire = true;
        private bool drawPoints = true;
        private StreamReader stream;
        private List<Point3D> points = new List<Point3D> { }, normales = new List<Point3D> { };
        private List<PointF> textures = new List<PointF> { };
        private List<Face> faces = new List<Face> { };
        private SimpleOpenGlControl AnT;

        private int angleX = 0, angleY = 0, angleZ = 0;
        private double translateX = 0, translateY = 0, translateZ = 0;
        private double scale = 1;
        private bool ortho = true;
        private Vector3D lightDir = new Vector3D(0, 0, -1);

        public Figure(ref SimpleOpenGlControl SOGLC, string name)
        {
            try
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

                stream = new StreamReader(name);
                AnT = SOGLC;
                string tempStr;
                stream = new StreamReader(name);
                while (!stream.EndOfStream)
                {
                    tempStr = stream.ReadLine();
                    if (tempStr.Length > 0)
                        switch (tempStr[0])
                        {
                            case 'v':
                                LineTo(tempStr);
                                break;
                            case 'f':
                                LineToFaces(tempStr);
                                break;
                        }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void LineTo(string str)
        {
            string[] line = str.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            switch (str[1])
            {
                case ' ':
                    if (line.Length - 1 < 3)
                        MessageBox.Show("Ошибка в форматировании файла", "Ошибка");

                    points.Add(new Point3D(float.Parse(line[1]), float.Parse(line[2]), float.Parse(line[3])));
                    break;
                case 't':
                    if (line.Length - 1 < 2)
                        MessageBox.Show("Ошибка в форматировании файла", "Ошибка");

                    textures.Add(new PointF(float.Parse(line[1]), float.Parse(line[2])));
                    break;
                case 'n':
                    if (line.Length - 1 < 3)
                        MessageBox.Show("Ошибка в форматировании файла", "Ошибка");
                    normales.Add(new Point3D(float.Parse(line[1]), float.Parse(line[2]), float.Parse(line[3])));
                    break;
            }
        }
        private void LineToFaces(string str)
        {
            if (str[1] == ' ')
                try
                {
                    String[] line = str.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    Face face = new Face
                    {
                        points = new List<int> { },
                        normales = new List<int> { },
                        textures = new List<int> { }
                    };

                    for (int i = 1; i < line.Length; i++)
                    {
                        String[] s = line[i].Split(new Char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

                        face.points.Add(Int32.Parse(s[0].ToString()));
                        int temp = CountWords(line[i], "/");

                        if (temp == 1)
                        {
                            face.textures.Add(Int32.Parse(s[1].ToString()));
                        }
                        else if (temp == 2 && s.Length == 2)
                        {
                            face.normales.Add(Int32.Parse(s[1].ToString()));
                        }
                        else if (temp == 2 && s.Length == 3)
                        {
                            face.textures.Add(Int32.Parse(s[1].ToString()));
                            face.normales.Add(Int32.Parse(s[2].ToString()));
                        }
                    }
                    faces.Add(face);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
        }
        private int CountWords(string s, string s0)
        {
            int count = (s.Length - s.Replace(s0, "").Length) / s0.Length;
            return count;
        }
        public void Draw()
        {
            try
            {
                Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
                Gl.glClearColor(255.0f, 255.0f, 255.0f, 1.0f);
                Gl.glLoadIdentity();

                if (!ortho)
                {
                    Glu.gluLookAt(0.0f, 0.0f, 8.0f,
                              0.0f, 0.0f, 0.0f,
                              0.0f, 1.0f, 0.0f);
                }
                if (translateX != 0)
                    Gl.glTranslated(translateX, 0, 0);
                if (translateY != 0)
                    Gl.glTranslated(0, translateY, 0);
                if (translateZ != 0)
                    Gl.glTranslated(0, 0, translateZ);

                if (angleX != 0)
                    Gl.glRotated(angleX, 1, 0, 0);
                if (angleY != 0)
                    Gl.glRotated(angleY, 0, 1, 0);
                if (angleZ != 0)
                    Gl.glRotated(angleZ, 0, 0, 1);

                if (scale != 0)
                    Gl.glScaled(scale, scale, scale);
                //////////////////////////////////////////////////////////////////

                Gl.glColor3f(0.0f, 255.0f, 0.0f);
                if (points.Count > 0 && drawPoints)
                {
                    Gl.glPointSize(5.0f);
                    Gl.glBegin(Gl.GL_POINTS);
                    foreach (Point3D p in points)
                    {
                        Gl.glVertex3d(p.X, p.Y, p.Z);
                    }
                    Gl.glEnd();
                    Gl.glPointSize(1.0f);
                }
                //////////////////////////////////////////////////////////////////

                if (faces.Count > 0)
                {
                    if (drawWire)
                        foreach (Face f in faces)
                        {
                            Gl.glBegin(Gl.GL_LINE_LOOP);
                            foreach (int point in f.points)
                            {
                                Gl.glVertex3d(points[point - 1].X, points[point - 1].Y, points[point - 1].Z);
                            }
                            Gl.glEnd();
                        }
                    //////////////////////////////////////////////////////////////////

                    Gl.glEnable(Gl.GL_LIGHTING);

                    Gl.glColor3f(255, 0, 0);

                    foreach (Face f in faces)
                    {
                        switch (f.points.Count)
                        {
                            case 3:
                                Gl.glBegin(Gl.GL_TRIANGLES);
                                break;
                            case 4:
                                Gl.glBegin(Gl.GL_QUADS);
                                break;
                            default:
                                Gl.glBegin(Gl.GL_POLYGON);
                                break;
                        }
                        //////////////////////////////////////////////////////////////////
                        for (int j = 0; f.points.Count > j; j++)
                        {
                            if (f.normales.Count == f.points.Count)
                            {
                                Gl.glNormal3d(normales[f.normales[j] - 1].X, normales[f.normales[j] - 1].Y, normales[f.normales[j] - 1].Z);
                            }
                            else
                            {
                                Vector3D n;
                                var vec1 = points[f.points[1] - 1] - points[f.points[0] - 1];
                                var vec2 = points[f.points[2] - 1] - points[f.points[0] - 1];
                                Vector3D n1 = Vector3D.CrossProduct(vec1, vec2);
                                Vector3D n2 = Vector3D.CrossProduct(vec2, vec1);
                                n1.Normalize();
                                n2.Normalize();
                                var t1 = Vector3D.DotProduct(n1, lightDir);
                                var t2 = Vector3D.DotProduct(n2, lightDir);
                                n = t1 >= t2 ? n1 : n2;
                                Gl.glNormal3d(n.Z, n.Y, n.Z);
                            }
                            //////////////////////////////////////////////////////////////////

                            if (f.textures.Count > 0)
                                Gl.glTexCoord2f(textures[f.textures[j] - 1].X, textures[f.textures[j] - 1].Y);
                            Gl.glVertex3d(points[f.points[j] - 1].X, points[f.points[j] - 1].Y, points[f.points[j] - 1].Z);
                        }
                        Gl.glEnd();
                    }

                }
                else throw new Exception("Ошибка в файле. Не заданы грани.");

                Gl.glFlush();
                AnT.Invalidate();
                Gl.glDisable(Gl.GL_LIGHTING);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void Rotate(int x, int y, int z)
        {
            angleX = x;
            angleY = y;
            angleZ = z;
        }
        public void Translate(double x, double y, double z)
        {
            translateX = x;
            translateY = y;
            translateZ = z;
        }
        public void Scale(double s)
        {
            scale = s;
        }
        public void ChangeProjection(bool p)
        {
            ortho = p;
        }
        public void Wire(bool w)
        {
            drawWire = w;
        }
        public void Points(bool p)
        {
            drawPoints = p;
        }
    }
}
