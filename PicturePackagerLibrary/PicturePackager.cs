using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace PicturePackagerLibrary
{
    /// <summary>
    /// Класс-утила, работающий с пакетами кускков изображений
    /// </summary>
    internal class PicturePackager
    {
        // Создание сегментов по изображению
        public static PicturePackage[] GetPicturePackages(string name, int id, Image picture)
        {
            return GetPicturePackages(name, id, picture, 4000);
        }

        // Возвращает сегменты изображения
        public static PicturePackage[] GetPicturePackages(string name, int id, 
            Image picture, int segmentSize)
        {
            MemoryStream stream = new MemoryStream();
            picture.Save(stream, ImageFormat.Jpeg);

            // вычисляем число сегментов, на которые будем разбивать изображение
            int numberSegments = (int)stream.Position / segmentSize + 1;

            PicturePackage[] packages = new PicturePackage[numberSegments];

            // создание сегментов изображения
            int sourceIndex = 0;
            for (int i = 0; i < numberSegments; i++)
            {
                // размер буфера сегмента
                int bytesToCopy = (int)stream.Position - sourceIndex;
                if (bytesToCopy > segmentSize)
                {
                    bytesToCopy = segmentSize;
                }
                byte[] segmentBuffer = new byte[bytesToCopy];

                Array.Copy(stream.GetBuffer(), sourceIndex, segmentBuffer, 0, bytesToCopy);

                packages[i] = new PicturePackage(name, id, i + 1, numberSegments, segmentBuffer);

                sourceIndex += bytesToCopy;
            }

            return packages;
        }

        // Возвращаем полную картинку собранную по сегментам
        public static Image GetPicture(PicturePackage[] packages)
        {
            int fullSizeNedded = 0;
            int numberPackages = packages[0].NumberOfSegments;
            int pictureId = packages[0].Id;

            for (int i = 0;i < numberPackages;i++)
            {
                fullSizeNedded += packages[i].SegmentBuffer.Length;
                if (packages[i].Id != pictureId)
                {
                    throw new Exception("Переданы несовместимые id!");
                }
            }

            // Merge segments
            byte[] buffer = new byte[fullSizeNedded];
            int destinationIndex = 0;
            for (int i = 0; i < numberPackages;i++)
            {
                int length = packages[i].SegmentBuffer.Length;
                Array.Copy(packages[i].SegmentBuffer, 0, buffer, destinationIndex, length);
                destinationIndex += length;
            }

            // создание изображения из бинарных данных
            MemoryStream stream = new MemoryStream(buffer);
            Image image = Image.FromStream(stream);

            return image;
        }
    }
}
