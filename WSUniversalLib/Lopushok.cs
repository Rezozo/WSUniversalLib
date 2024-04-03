using System;

namespace WSUniversalLib
{
    public class Lopushok
    {
        private double[] coefficients = new double[] { 1.1, 2.5, 8.43 };
        private double[] rejects = new double[] { 0.3, 0.12 };

        public int GetProductQuantity(int productType, int materialType, int count, double width, double length)
        {
            if (productType <= 0 || productType > coefficients.Length 
                || materialType <= 0 || materialType > rejects.Length
                || count <= 0 || width <= 0 || length <= 0)
            {
                return -1;
            }

            double square = width * length;
            double materialAmount = square * coefficients[productType - 1] / (1 - rejects[materialType - 1] / 100);
            int materialCount = (int)Math.Ceiling(materialAmount * count);
            return materialCount;
        }
    }
}
