using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3GL11_CL19037_VS2015
{
    class Operaciones
    {
        double[,] datos;

        public double[,] Datos
        {
            get
            {
                return datos;
            }

            set
            {
                datos = value;
            }
        }

        public double ZonaMayor1Can()
        {
            double zonaMay = datos[0, 0];
            int i = 0;

            for (i = 0; i < 3; i++)
            {
                if (zonaMay < datos[i, 0])
                {
                    zonaMay = datos[i, 0];
                }
            }
            return zonaMay;
        }
        public double ZonaMayor2Can()
        {
            double zonaMay = datos[0, 1];
            int i = 0;

            for (i = 0; i < 3; i++)
            {
                if (zonaMay < datos[i, 1])
                {
                    zonaMay = datos[i, 1];
                }
            }
            return zonaMay;
        }
        public double ZonaMayor3Can()
        {
            double zonaMay = datos[0, 2];
            int i = 0;

            for (i = 0; i < 3; i++)
            {
                if (zonaMay < datos[i, 2])
                {
                    zonaMay = datos[i, 2];
                }
            }
            return zonaMay;
        }

        public string ZonaMayor1()
        {
            double zonaMay = datos[0, 0];
            string zone = null;
            int i = 0;

            for (i = 0; i < 3; i++)
            {
                if (zonaMay < datos[i, 0])
                {
                    zonaMay = datos[i, 0];
                }
            }

            if (zonaMay == datos[0,0])
            {
                zone = "Occidental";
            }
            else if (zonaMay == datos[1, 0])
            {
                zone = "Central";
            }
            else if (zonaMay == datos[2, 0])
            {
                zone = "Oriental";
            }

            return zone;
        }
        public string ZonaMayor2()
        {
            double zonaMay = datos[0, 1];
            string zone = null;
            int i = 0;

            for (i = 0; i < 3; i++)
            {
                if (zonaMay < datos[i, 1])
                {
                    zonaMay = datos[i, 1];
                }
            }

            if (zonaMay == datos[0, 1])
            {
                zone = "Occidental";
            }
            else if (zonaMay == datos[1, 1])
            {
                zone = "Central";
            }
            else if (zonaMay == datos[2, 1])
            {
                zone = "Oriental";
            }

            return zone;
        }
        public string ZonaMayor3()
        {
            double zonaMay = datos[0, 2];
            string zone = null;
            int i = 0;

            for (i = 0; i < 3; i++)
            {
                if (zonaMay < datos[i, 2])
                {
                    zonaMay = datos[i, 2];
                }
            }

            if (zonaMay == datos[0, 2])
            {
                zone = "Occidental";
            }
            else if (zonaMay == datos[1, 2])
            {
                zone = "Central";
            }
            else if (zonaMay == datos[2, 2])
            {
                zone = "Oriental";
            }

            return zone;
        }

        public double YearMenor1Can()
        {
            double zonaMay = datos[0, 0];
            int i = 0;

            for (i = 0; i < 3; i++)
            {
                if (zonaMay > datos[0, i])
                {
                    zonaMay = datos[0, i];
                }
            }
            return zonaMay;
        }
        public double YearMenor2Can()
        {
            double zonaMay = datos[1, 0];
            int i = 0;

            for (i = 0; i < 3; i++)
            {
                if (zonaMay > datos[1, i])
                {
                    zonaMay = datos[1, i];
                }
            }
            return zonaMay;
        }
        public double YearMenor3Can()
        {
            double zonaMay = datos[2, 0];
            int i = 0;

            for (i = 0; i < 3; i++)
            {
                if (zonaMay > datos[2, i])
                {
                    zonaMay = datos[2, i];
                }
            }
            return zonaMay;
        }

        public string YearMenor1()
        {
            double zonaMay = datos[0, 0];
            string zone = null;
            int i = 0;

            for (i = 0; i < 3; i++)
            {
                if (zonaMay > datos[0, i])
                {
                    zonaMay = datos[0, i];
                }
            }

            if (zonaMay == datos[0, 0])
            {
                zone = "2018";
            }
            else if (zonaMay == datos[0, 1])
            {
                zone = "2019";
            }
            else if (zonaMay == datos[0, 2])
            {
                zone = "2020";
            }

            return zone;
        }
        public string YearMenor2()
        {
            double zonaMay = datos[1, 0];
            string zone = null;
            int i = 0;

            for (i = 0; i < 3; i++)
            {
                if (zonaMay > datos[1, i])
                {
                    zonaMay = datos[1, i];
                }
            }

            if (zonaMay == datos[1, 0])
            {
                zone = "2018";
            }
            else if (zonaMay == datos[1, 1])
            {
                zone = "2019";
            }
            else if (zonaMay == datos[1, 2])
            {
                zone = "2020";
            }

            return zone;
        }
        public string YearMenor3()
        {
            double zonaMay = datos[2, 0];
            string zone = null;
            int i = 0;

            for (i = 0; i < 3; i++)
            {
                if (zonaMay > datos[2, i])
                {
                    zonaMay = datos[2, i];
                }
            }

            if (zonaMay == datos[2, 0])
            {
                zone = "2018";
            }
            else if (zonaMay == datos[2, 1])
            {
                zone = "2019";
            }
            else if (zonaMay == datos[2, 2])
            {
                zone = "2020";
            }

            return zone;
        }

        public double[] SumasXYear()
        {
            double[] sumas = new double[3] { 0, 0, 0 };
            int i = 0, j = 0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (i == 0 && (j == 0 || j == 1 || j == 2))
                    {
                        sumas[0] += datos[j, i];
                    }
                    else if (i == 1 && (j == 0 || j == 1 || j == 2))
                    {
                        sumas[1] += datos[j, i];
                    }
                    else if (i == 2 && (j == 0 || j == 1 || j == 2))
                    {
                        sumas[2] += datos[j, i];
                    }
                }
            }
            return sumas;
        }
        public double[] SumasXZone()
        {
            double[] sumas = new double[3] { 0, 0, 0 };
            int i = 0, j = 0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (i == 0 && (j == 0 || j == 1 || j == 2))
                    {
                        sumas[0] += datos[i, j];
                    }
                    else if (i == 1 && (j == 0 || j == 1 || j == 2))
                    {
                        sumas[1] += datos[i, j];
                    }
                    else if (i == 2 && (j == 0 || j == 1 || j == 2))
                    {
                        sumas[2] += datos[i, j];
                    }
                }
            }
            return sumas;
        }

    }
}
