using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.Util;

namespace FaceUp
{
    //Твой бэкенд
    class FaceUpManager
    {
        //возвращает лист путей к маскам из папки или битмапы, еще не известно

        public List<Picture> allPicturies; // all image list
        private VideoCapture captureDevice = new VideoCapture(); // web camera
        private CascadeClassifier haarCascade; // Haar Classifier

        public  CurrentMasks currentMasks;

        public enum MaskType
        {
            EYE,
            HAIR,
            CHIN
        };

        public struct Picture
        {
            public MaskType maskType;
            public string path;
            public Image source;

            private Size sizeOffsets;
            private Point positionOffsets;

            public Picture(MaskType maskType, string filePath, Image imageSource)
            {
                this.maskType = maskType;
                this.path = filePath;
                this.source = imageSource;

                sizeOffsets = new Size(0, 0);
                positionOffsets = new Point(0, 0);
            }

            public void ChangeSizeOffsets(int width, int height)
            {
                this.sizeOffsets.Width = width;
                this.sizeOffsets.Height = height;
            }

            public void ChangePositionOffsets(int x, int y)
            {
                this.positionOffsets.X = x;
                this.positionOffsets.Y = y;
            }

            public Point GetPositionOffsets() { return this.positionOffsets; }
            public Size GetSizeOffsets() { return this.sizeOffsets; }
        }

        public struct CurrentMasks
        {
            private Picture hair;
            private Picture eye;
            private Picture chin;

            public CurrentMasks(Picture hair, Picture eye, Picture chin)
            {
                this.hair = hair;
                this.eye = eye;
                this.chin = chin;
            }

            public void SetHair(Picture hair) { this.hair = hair; }
            public void SetEye(Picture eye) { this.eye = eye; }
            public void SetChin(Picture chin) { this.chin = chin; }

            public Picture GetHair() { return this.hair; }
            public Picture GetEye() { return this.eye; }
            public Picture GetChin() { return this.chin; }
        }

        

        public FaceUpManager()
        {
            allPicturies = new List<Picture>();

            if (!File.Exists(System.IO.Directory.GetCurrentDirectory() + @"\haarcascade_frontalface_default.xml"))
                throw new Exception("File with Haar cascade not found");

            haarCascade = new CascadeClassifier("haarcascade_frontalface_default.xml");
        }


        //загрузка картинок
        public bool LoadImages(string applicationPath)
        {
            string eyePath = applicationPath + @"\img\eye\",
                chinPath = applicationPath + @"\img\chin\",
                hairPath = applicationPath + @"\img\hair\";

            if (!Directory.Exists(eyePath) || !Directory.Exists(chinPath))
                return false;

            string[] eyeFilePaths = Directory.GetFiles(eyePath),
                chinFilePaths = Directory.GetFiles(chinPath),
                hairFilePaths = Directory.GetFiles(hairPath);

            foreach (string eyeFilePath in eyeFilePaths)
                this.allPicturies.Add(new Picture(MaskType.EYE, eyeFilePath, Image.FromFile(eyeFilePath)));

            foreach (string chinFilePath in chinFilePaths)
                this.allPicturies.Add(new Picture(MaskType.CHIN, chinFilePath, Image.FromFile(chinFilePath)));

            foreach (string hairFilePath in hairFilePaths)
                this.allPicturies.Add(new Picture(MaskType.HAIR, hairFilePath, Image.FromFile(hairFilePath)));

            return true;
        }

        public List<Picture> GetMaskImagesOf(MaskType maskType)
        {
            return allPicturies.Where(image => image.maskType == maskType).ToList<Picture>();
        }

        //обрабатывает фрейм и возвращает новый рисунок на вывод
        //!!! передача по ссылке экономит нам память и ускоряет процесс !!!
        public Bitmap DrawProcessedFrame(ref Image<Bgr, byte> imageFromCamera)
        {
            if (imageFromCamera == null)
                return null;

            Image<Gray, byte> grayImg = imageFromCamera.Convert<Gray, byte>();
            var faces = haarCascade.DetectMultiScale(grayImg, 1.4, 2);

            var image = imageFromCamera.ToBitmap();
            Graphics g = Graphics.FromImage(image);

            Picture hairMask = currentMasks.GetHair(),
                    eyeMask = currentMasks.GetEye(),
                    chinMasks = currentMasks.GetChin();

            foreach (var face in faces)
            {
                if (hairMask.source != null)
                    g.DrawImage(
                        new Bitmap(
                            Bitmap.FromFile(hairMask.path),
                            new Size(
                                face.Width + hairMask.GetSizeOffsets().Width,
                                face.Height + hairMask.GetSizeOffsets().Height)
                            ),
                        new Point(
                            face.X + hairMask.GetPositionOffsets().X, face.Y + hairMask.GetPositionOffsets().Y
                        )
                    );

                if (eyeMask.source != null)
                    g.DrawImage(
                    new Bitmap(
                            Bitmap.FromFile(eyeMask.path),
                            new Size(
                                     face.Width + eyeMask.GetSizeOffsets().Width,
                                     face.Height + eyeMask.GetSizeOffsets().Height)
                            ),
                    new Point(
                              face.X + eyeMask.GetPositionOffsets().X,
                              face.Y + eyeMask.GetPositionOffsets().Y
                    )
                );

                if (chinMasks.source != null)
                    g.DrawImage(
                            new Bitmap(
                            Bitmap.FromFile(chinMasks.path),
                            new Size(
                                face.Width + chinMasks.GetSizeOffsets().Width,
                                face.Height + chinMasks.GetSizeOffsets().Height)
                            ),
                            new Point(
                                      face.X + chinMasks.GetPositionOffsets().X,
                                      face.Y + chinMasks.GetPositionOffsets().Y
                            )
                );
            }

            /*
            foreach (var face in faces)
            {
                imageFromCamera.Draw(face, new Bgr(Color.Green), 3);
            }
            */
            return image;
        }
    }
}
