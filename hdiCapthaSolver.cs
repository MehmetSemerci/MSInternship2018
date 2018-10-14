private static string HDICaptchaSolver(string path)
        {
            try
            {

                List<Point> harf1List = new List<Point>();
                List<Point> harf2List = new List<Point>();
                List<Point> harf3List = new List<Point>();

                Bitmap img = new Bitmap(path);

                for (int i = 30; i < 38; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        var pixel = img.GetPixel(i, j).Name;
                        if (pixel == "ff000000")
                        {
                            harf1List.Add(new Point(i - 30, j));
                        }

                    }
                }

                for (int i = 51; i < 59; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        var pixel = img.GetPixel(i, j).Name;
                        if (pixel == "ff000000")
                        {
                            harf2List.Add(new Point(i - 51, j));
                        }

                    }
                }

                for (int i = 72; i < 80; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        var pixel = img.GetPixel(i, j).Name;
                        if (pixel == "ff000000")
                        {
                            harf3List.Add(new Point(i - 72, j));
                        }

                    }
                }

                List<Point> aPointList = new List<Point>() { new Point(0, 6), new Point(0, 7), new Point(0, 8), new Point(0, 9), new Point(0, 10), new Point(0, 11), new Point(0, 12), new Point(1, 5), new Point(1, 6), new Point(1, 7), new Point(1, 8), new Point(1, 9), new Point(1, 10), new Point(1, 11), new Point(1, 12), new Point(2, 4), new Point(2, 5), new Point(2, 9), new Point(3, 3), new Point(3, 4), new Point(3, 9), new Point(4, 3), new Point(4, 4), new Point(4, 9), new Point(5, 4), new Point(5, 5), new Point(5, 9), new Point(6, 5), new Point(6, 6), new Point(6, 7), new Point(6, 8), new Point(6, 9), new Point(6, 10), new Point(6, 11), new Point(6, 12), new Point(7, 6), new Point(7, 7), new Point(7, 8), new Point(7, 9), new Point(7, 10), new Point(7, 11), new Point(7, 12) };
                List<Point> bPointList = new List<Point>() { new Point(0, 3), new Point(0, 4), new Point(0, 5), new Point(0, 6), new Point(0, 7), new Point(0, 8), new Point(0, 9), new Point(0, 10), new Point(0, 11), new Point(0, 12), new Point(1, 3), new Point(1, 4), new Point(1, 5), new Point(1, 6), new Point(1, 7), new Point(1, 8), new Point(1, 9), new Point(1, 10), new Point(1, 11), new Point(1, 12), new Point(2, 3), new Point(2, 7), new Point(2, 12), new Point(3, 3), new Point(3, 7), new Point(3, 12), new Point(4, 3), new Point(4, 7), new Point(4, 12), new Point(5, 3), new Point(5, 4), new Point(5, 6), new Point(5, 7), new Point(5, 8), new Point(5, 11), new Point(5, 12), new Point(6, 4), new Point(6, 5), new Point(6, 6), new Point(6, 8), new Point(6, 9), new Point(6, 10), new Point(6, 11), new Point(7, 5), new Point(7, 9), new Point(7, 10) };
                List<Point> cPointList = new List<Point>() { new Point(0, 5), new Point(0, 6), new Point(0, 7), new Point(0, 8), new Point(0, 9), new Point(0, 10), new Point(1, 4), new Point(1, 5), new Point(1, 6), new Point(1, 7), new Point(1, 8), new Point(1, 9), new Point(1, 10), new Point(1, 11), new Point(2, 3), new Point(2, 4), new Point(2, 11), new Point(2, 12), new Point(3, 3), new Point(3, 12), new Point(4, 3), new Point(4, 12), new Point(5, 3), new Point(5, 12), new Point(6, 3), new Point(6, 4), new Point(6, 11), new Point(6, 12), new Point(7, 4), new Point(7, 5), new Point(7, 10), new Point(7, 11) };
                List<Point> dPointList = new List<Point>() { new Point(0, 3), new Point(0, 4), new Point(0, 5), new Point(0, 6), new Point(0, 7), new Point(0, 8), new Point(0, 9), new Point(0, 10), new Point(0, 11), new Point(0, 12), new Point(1, 3), new Point(1, 4), new Point(1, 5), new Point(1, 6), new Point(1, 7), new Point(1, 8), new Point(1, 9), new Point(1, 10), new Point(1, 11), new Point(1, 12), new Point(2, 3), new Point(2, 12), new Point(3, 3), new Point(3, 12), new Point(4, 3), new Point(4, 12), new Point(5, 3), new Point(5, 4), new Point(5, 11), new Point(5, 12), new Point(6, 4), new Point(6, 5), new Point(6, 6), new Point(6, 7), new Point(6, 8), new Point(6, 9), new Point(6, 10), new Point(6, 11), new Point(7, 5), new Point(7, 6), new Point(7, 7), new Point(7, 8), new Point(7, 9), new Point(7, 10) };
                List<Point> ePointList = new List<Point>() { new Point(0, 3), new Point(0, 4), new Point(0, 5), new Point(0, 6), new Point(0, 7), new Point(0, 8), new Point(0, 9), new Point(0, 10), new Point(0, 11), new Point(0, 12), new Point(1, 3), new Point(1, 4), new Point(1, 5), new Point(1, 6), new Point(1, 7), new Point(1, 8), new Point(1, 9), new Point(1, 10), new Point(1, 11), new Point(1, 12), new Point(2, 3), new Point(2, 7), new Point(2, 12), new Point(3, 3), new Point(3, 7), new Point(3, 12), new Point(4, 3), new Point(4, 7), new Point(4, 12), new Point(5, 3), new Point(5, 7), new Point(5, 12), new Point(6, 3), new Point(6, 12) };
                List<Point> fPointList = new List<Point>() { new Point(0, 3), new Point(0, 4), new Point(0, 5), new Point(0, 6), new Point(0, 7), new Point(0, 8), new Point(0, 9), new Point(0, 10), new Point(0, 11), new Point(0, 12), new Point(1, 3), new Point(1, 4), new Point(1, 5), new Point(1, 6), new Point(1, 7), new Point(1, 8), new Point(1, 9), new Point(1, 10), new Point(1, 11), new Point(1, 12), new Point(2, 3), new Point(2, 7), new Point(3, 3), new Point(3, 7), new Point(4, 3), new Point(4, 7), new Point(5, 3), new Point(5, 7), new Point(6, 3), new Point(7, 3) };
                List<Point> birPointList = new List<Point>() { new Point(1, 5), new Point(1, 12), new Point(2, 4), new Point(2, 5), new Point(2, 12), new Point(3, 3), new Point(3, 4), new Point(3, 5), new Point(3, 6), new Point(3, 7), new Point(3, 8), new Point(3, 9), new Point(3, 10), new Point(3, 11), new Point(3, 12), new Point(4, 3), new Point(4, 4), new Point(4, 5), new Point(4, 6), new Point(4, 7), new Point(4, 8), new Point(4, 9), new Point(4, 10), new Point(4, 11), new Point(4, 12), new Point(5, 12), new Point(6, 12) };
                List<Point> ikiPointList = new List<Point>() { new Point(0, 5), new Point(0, 12), new Point(1, 4), new Point(1, 5), new Point(1, 11), new Point(1, 12), new Point(2, 3), new Point(2, 4), new Point(2, 10), new Point(2, 11), new Point(2, 12), new Point(3, 3), new Point(3, 9), new Point(3, 10), new Point(3, 12), new Point(4, 3), new Point(4, 8), new Point(4, 9), new Point(4, 12), new Point(5, 3), new Point(5, 4), new Point(5, 7), new Point(5, 8), new Point(5, 12), new Point(6, 4), new Point(6, 5), new Point(6, 6), new Point(6, 7), new Point(6, 12), new Point(7, 5), new Point(7, 6), new Point(7, 12) };
                List<Point> ucPointList = new List<Point>() { new Point(0, 4), new Point(0, 11), new Point(1, 3), new Point(1, 4), new Point(1, 11), new Point(1, 12), new Point(2, 3), new Point(2, 12), new Point(3, 3), new Point(3, 7), new Point(3, 12), new Point(4, 3), new Point(4, 7), new Point(4, 12), new Point(5, 3), new Point(5, 4), new Point(5, 6), new Point(5, 7), new Point(5, 8), new Point(5, 11), new Point(5, 12), new Point(6, 4), new Point(6, 5), new Point(6, 6), new Point(6, 8), new Point(6, 9), new Point(6, 10), new Point(6, 11), new Point(7, 5), new Point(7, 9), new Point(7, 10) };
                List<Point> dortPointList = new List<Point>() { new Point(0, 8), new Point(0, 9), new Point(1, 7), new Point(1, 8), new Point(1, 9), new Point(2, 6), new Point(2, 7), new Point(2, 9), new Point(3, 5), new Point(3, 6), new Point(3, 9), new Point(4, 4), new Point(4, 5), new Point(4, 9), new Point(5, 3), new Point(5, 4), new Point(5, 5), new Point(5, 6), new Point(5, 7), new Point(5, 8), new Point(5, 9), new Point(5, 10), new Point(5, 11), new Point(5, 12), new Point(6, 3), new Point(6, 4), new Point(6, 5), new Point(6, 6), new Point(6, 7), new Point(6, 8), new Point(6, 9), new Point(6, 10), new Point(6, 11), new Point(6, 12), new Point(7, 9) };
                List<Point> besPointList = new List<Point>() { new Point(0, 3), new Point(0, 4), new Point(0, 5), new Point(0, 6), new Point(0, 7), new Point(0, 10), new Point(1, 3), new Point(1, 4), new Point(1, 5), new Point(1, 6), new Point(1, 7), new Point(1, 10), new Point(1, 11), new Point(2, 3), new Point(2, 7), new Point(2, 11), new Point(2, 12), new Point(3, 3), new Point(3, 6), new Point(3, 12), new Point(4, 3), new Point(4, 6), new Point(4, 12), new Point(5, 3), new Point(5, 6), new Point(5, 7), new Point(5, 11), new Point(5, 12), new Point(6, 3), new Point(6, 7), new Point(6, 8), new Point(6, 9), new Point(6, 10), new Point(6, 11), new Point(7, 8), new Point(7, 9), new Point(7, 10) };
                List<Point> altiPointList = new List<Point>() { new Point(0, 5), new Point(0, 6), new Point(0, 7), new Point(0, 8), new Point(0, 9), new Point(0, 10), new Point(1, 4), new Point(1, 5), new Point(1, 6), new Point(1, 7), new Point(1, 8), new Point(1, 9), new Point(1, 10), new Point(1, 11), new Point(2, 3), new Point(2, 4), new Point(2, 8), new Point(2, 11), new Point(2, 12), new Point(3, 3), new Point(3, 7), new Point(3, 12), new Point(4, 3), new Point(4, 7), new Point(4, 12), new Point(5, 3), new Point(5, 4), new Point(5, 7), new Point(5, 8), new Point(5, 11), new Point(5, 12), new Point(6, 4), new Point(6, 5), new Point(6, 8), new Point(6, 9), new Point(6, 10), new Point(6, 11), new Point(7, 9), new Point(7, 10) };
                List<Point> yediPointList = new List<Point>() { new Point(0, 3), new Point(0, 11), new Point(0, 12), new Point(1, 3), new Point(1, 10), new Point(1, 11), new Point(1, 12), new Point(2, 3), new Point(2, 9), new Point(2, 10), new Point(3, 3), new Point(3, 8), new Point(3, 9), new Point(4, 3), new Point(4, 7), new Point(4, 8), new Point(5, 3), new Point(5, 6), new Point(5, 7), new Point(6, 3), new Point(6, 4), new Point(6, 5), new Point(6, 6), new Point(7, 3), new Point(7, 4), new Point(7, 5) };
                List<Point> sekizPointList = new List<Point>() { new Point(0, 5), new Point(0, 9), new Point(0, 10), new Point(1, 4), new Point(1, 5), new Point(1, 6), new Point(1, 8), new Point(1, 9), new Point(1, 10), new Point(1, 11), new Point(2, 3), new Point(2, 4), new Point(2, 6), new Point(2, 7), new Point(2, 8), new Point(2, 11), new Point(2, 12), new Point(3, 3), new Point(3, 7), new Point(3, 12), new Point(4, 3), new Point(4, 7), new Point(4, 12), new Point(5, 3), new Point(5, 4), new Point(5, 6), new Point(5, 7), new Point(5, 8), new Point(5, 11), new Point(5, 12), new Point(6, 4), new Point(6, 5), new Point(6, 6), new Point(6, 8), new Point(6, 9), new Point(6, 10), new Point(6, 11), new Point(7, 5), new Point(7, 9), new Point(7, 10) };
                List<Point> dokuzPointList = new List<Point>() { new Point(0, 5), new Point(0, 6), new Point(1, 4), new Point(1, 5), new Point(1, 6), new Point(1, 7), new Point(1, 10), new Point(1, 11), new Point(2, 3), new Point(2, 4), new Point(2, 7), new Point(2, 8), new Point(2, 11), new Point(2, 12), new Point(3, 3), new Point(3, 8), new Point(3, 12), new Point(4, 3), new Point(4, 8), new Point(4, 12), new Point(5, 3), new Point(5, 4), new Point(5, 7), new Point(5, 11), new Point(5, 12), new Point(6, 4), new Point(6, 5), new Point(6, 6), new Point(6, 7), new Point(6, 8), new Point(6, 9), new Point(6, 10), new Point(6, 11), new Point(7, 5), new Point(7, 6), new Point(7, 7), new Point(7, 8), new Point(7, 9), new Point(7, 10) };

                int rateA = 0, rateB = 0, rateC = 0, rateD = 0, rateE = 0, rateF = 0, rateBir = 0, rateIki = 0;
                int rateUc = 0, rateDort = 0, rateBes = 0, rateAlti = 0, rateYedi = 0, rateSekiz = 0, rateDokuz = 0;

                Dictionary<string, int> liste = new Dictionary<string, int>();
                var sonucHarf1 = string.Empty;

                if (harf1List.Count == 32 || harf1List.Count == 39)
                {
                    for (int k = 0; k < harf1List.Count; k++)
                    {
                        Point item = harf1List[k];

                        if (birPointList.Contains(item)) rateBir++;
                        if (ikiPointList.Contains(item)) rateIki++;
                        if (ucPointList.Contains(item)) rateUc++;
                        if (dortPointList.Contains(item)) rateDort++;
                        if (besPointList.Contains(item)) rateBes++;
                        if (altiPointList.Contains(item)) rateAlti++;
                        if (yediPointList.Contains(item)) rateYedi++;
                        if (sekizPointList.Contains(item)) rateSekiz++;
                        if (dokuzPointList.Contains(item)) rateDokuz++;
                        if (aPointList.Contains(item)) rateA++;
                        if (bPointList.Contains(item)) rateB++;
                        if (cPointList.Contains(item)) rateC++;
                        if (dPointList.Contains(item)) rateD++;
                        if (ePointList.Contains(item)) rateE++;
                        if (fPointList.Contains(item)) rateF++;
                    }

                    liste.Add("1", rateBir);
                    liste.Add("2", rateIki);
                    liste.Add("3", rateUc);
                    liste.Add("4", rateDort);
                    liste.Add("5", rateBes);
                    liste.Add("6", rateAlti);
                    liste.Add("7", rateYedi);
                    liste.Add("8", rateSekiz);
                    liste.Add("9", rateDokuz);
                    liste.Add("A", rateA);
                    liste.Add("B", rateB);
                    liste.Add("C", rateC);
                    liste.Add("D", rateD);
                    liste.Add("E", rateE);
                    liste.Add("F", rateF);

                    sonucHarf1 = liste.OrderByDescending(v => v.Value).FirstOrDefault().Key;
                }
                else if (harf1List.Count == 27) sonucHarf1 = "1";
                else if (harf1List.Count == 31) sonucHarf1 = "3";
                else if (harf1List.Count == 35) sonucHarf1 = "4";
                else if (harf1List.Count == 37) sonucHarf1 = "5";
                else if (harf1List.Count == 26) sonucHarf1 = "7";
                else if (harf1List.Count == 40) sonucHarf1 = "8";
                else if (harf1List.Count == 42) sonucHarf1 = "A";
                else if (harf1List.Count == 46) sonucHarf1 = "B";
                else if (harf1List.Count == 44) sonucHarf1 = "D";
                else if (harf1List.Count == 34) sonucHarf1 = "E";
                else if (harf1List.Count == 30) sonucHarf1 = "F";

                rateA = 0; rateB = 0; rateC = 0; rateD = 0; rateE = 0; rateF = 0; rateBir = 0; rateIki = 0;
                rateUc = 0; rateDort = 0; rateBes = 0; rateAlti = 0; rateYedi = 0; rateSekiz = 0; rateDokuz = 0;

                liste = new Dictionary<string, int>();
                var sonucHarf2 = string.Empty;

                if (harf2List.Count == 32 || harf2List.Count == 39)
                {
                    for (int k = 0; k < harf2List.Count; k++)
                    {
                        Point item = harf2List[k];

                        if (birPointList.Contains(item)) rateBir++;
                        if (ikiPointList.Contains(item)) rateIki++;
                        if (ucPointList.Contains(item)) rateUc++;
                        if (dortPointList.Contains(item)) rateDort++;
                        if (besPointList.Contains(item)) rateBes++;
                        if (altiPointList.Contains(item)) rateAlti++;
                        if (yediPointList.Contains(item)) rateYedi++;
                        if (sekizPointList.Contains(item)) rateSekiz++;
                        if (dokuzPointList.Contains(item)) rateDokuz++;
                        if (aPointList.Contains(item)) rateA++;
                        if (bPointList.Contains(item)) rateB++;
                        if (cPointList.Contains(item)) rateC++;
                        if (dPointList.Contains(item)) rateD++;
                        if (ePointList.Contains(item)) rateE++;
                        if (fPointList.Contains(item)) rateF++;
                    }

                    liste.Add("1", rateBir);
                    liste.Add("2", rateIki);
                    liste.Add("3", rateUc);
                    liste.Add("4", rateDort);
                    liste.Add("5", rateBes);
                    liste.Add("6", rateAlti);
                    liste.Add("7", rateYedi);
                    liste.Add("8", rateSekiz);
                    liste.Add("9", rateDokuz);
                    liste.Add("A", rateA);
                    liste.Add("B", rateB);
                    liste.Add("C", rateC);
                    liste.Add("D", rateD);
                    liste.Add("E", rateE);
                    liste.Add("F", rateF);

                    sonucHarf2 = liste.OrderByDescending(v => v.Value).FirstOrDefault().Key;
                }
                else if (harf2List.Count == 27) sonucHarf2 = "1";
                else if (harf2List.Count == 31) sonucHarf2 = "3";
                else if (harf2List.Count == 35) sonucHarf2 = "4";
                else if (harf2List.Count == 37) sonucHarf2 = "5";
                else if (harf2List.Count == 26) sonucHarf2 = "7";
                else if (harf2List.Count == 40) sonucHarf2 = "8";
                else if (harf2List.Count == 42) sonucHarf2 = "A";
                else if (harf2List.Count == 46) sonucHarf2 = "B";
                else if (harf2List.Count == 44) sonucHarf2 = "D";
                else if (harf2List.Count == 34) sonucHarf2 = "E";
                else if (harf2List.Count == 30) sonucHarf2 = "F";

                rateA = 0; rateB = 0; rateC = 0; rateD = 0; rateE = 0; rateF = 0; rateBir = 0; rateIki = 0;
                rateUc = 0; rateDort = 0; rateBes = 0; rateAlti = 0; rateYedi = 0; rateSekiz = 0; rateDokuz = 0;

                liste = new Dictionary<string, int>();
                var sonucHarf3 = string.Empty;

                if (harf3List.Count == 32 || harf3List.Count == 39)
                {
                    for (int k = 0; k < harf3List.Count; k++)
                    {
                        Point item = harf3List[k];

                        if (birPointList.Contains(item)) rateBir++;
                        if (ikiPointList.Contains(item)) rateIki++;
                        if (ucPointList.Contains(item)) rateUc++;
                        if (dortPointList.Contains(item)) rateDort++;
                        if (besPointList.Contains(item)) rateBes++;
                        if (altiPointList.Contains(item)) rateAlti++;
                        if (yediPointList.Contains(item)) rateYedi++;
                        if (sekizPointList.Contains(item)) rateSekiz++;
                        if (dokuzPointList.Contains(item)) rateDokuz++;
                        if (aPointList.Contains(item)) rateA++;
                        if (bPointList.Contains(item)) rateB++;
                        if (cPointList.Contains(item)) rateC++;
                        if (dPointList.Contains(item)) rateD++;
                        if (ePointList.Contains(item)) rateE++;
                        if (fPointList.Contains(item)) rateF++;
                    }

                    liste.Add("1", rateBir);
                    liste.Add("2", rateIki);
                    liste.Add("3", rateUc);
                    liste.Add("4", rateDort);
                    liste.Add("5", rateBes);
                    liste.Add("6", rateAlti);
                    liste.Add("7", rateYedi);
                    liste.Add("8", rateSekiz);
                    liste.Add("9", rateDokuz);
                    liste.Add("A", rateA);
                    liste.Add("B", rateB);
                    liste.Add("C", rateC);
                    liste.Add("D", rateD);
                    liste.Add("E", rateE);
                    liste.Add("F", rateF);

                    sonucHarf3 = liste.OrderByDescending(v => v.Value).FirstOrDefault().Key;
                }
                else if (harf3List.Count == 27) sonucHarf3 = "1";
                else if (harf3List.Count == 31) sonucHarf3 = "3";
                else if (harf3List.Count == 35) sonucHarf3 = "4";
                else if (harf3List.Count == 37) sonucHarf3 = "5";
                else if (harf3List.Count == 26) sonucHarf3 = "7";
                else if (harf3List.Count == 40) sonucHarf3 = "8";
                else if (harf3List.Count == 42) sonucHarf3 = "A";
                else if (harf3List.Count == 46) sonucHarf3 = "B";
                else if (harf3List.Count == 44) sonucHarf3 = "D";
                else if (harf3List.Count == 34) sonucHarf3 = "E";
                else if (harf3List.Count == 30) sonucHarf3 = "F";

                return (sonucHarf1 + sonucHarf2 + sonucHarf3);
                
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            
        }