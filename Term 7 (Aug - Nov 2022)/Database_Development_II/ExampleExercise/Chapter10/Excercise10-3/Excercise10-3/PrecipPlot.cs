using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace Excercise10_3
{
  class PrecipPlot
  {
    Graphics plot;
    Rectangle plotGrid;
    float pMin, pMax;
    float start, interval;
    int nIntervals;

    public PrecipPlot(System.Windows.Forms.Panel p)
    {
      p.BackgroundImage = new Bitmap(p.ClientSize.Width, p.ClientSize.Height, PixelFormat.Format24bppRgb);
      plot = Graphics.FromImage(p.BackgroundImage);
      plot.Clear(p.BackColor);
      plotGrid = new Rectangle(Convert.ToInt32(0.1 * p.ClientSize.Width), Convert.ToInt32(0.1 * p.ClientSize.Height), Convert.ToInt32(0.85 * p.ClientSize.Width), Convert.ToInt32(0.85 * p.ClientSize.Height));
      plot.FillRectangle(Brushes.LightYellow, plotGrid);
    }

    public void Draw(int n, float[] p)
    {
      // Constructs a  bar chart
      // n - number of points to plot
      // p - array of precipitation points (lower index is 0, upper index is n - 1)
      // find minimums and maximums
      pMin = 0.0F; pMax = 0.0F;
      for (int i = 0; i < n; i++)
      {
        if (p[i] > pMax)
          pMax = p[i];
      }
      PlotIntervals(5.5F, pMin, pMax); // computes start,interval,nIntervals
      DrawGrid(start, interval, nIntervals);
      // plot precipitation data
      PlotData(n, p, Color.DarkGreen);
    }

    private void PlotData(int n, float[] p, Color c)
    {
      Pen myPen = new Pen(c);
      // find first point
      for (int i = 0; i < n - 1; i++)
      {
        plot.DrawLine(myPen, Convert.ToInt32(plotGrid.X + (i + 1) * plotGrid.Width / (n + 1)), YuToYc(plotGrid, 0.0F, pMin, pMax), Convert.ToInt32(plotGrid.X + (i + 1) * plotGrid.Width / (n + 1)), YuToYc(plotGrid, p[i], pMin, pMax));
      }
    }

    private void DrawGrid(float start, float interval, int numberIntervals)
    {
      // draw grid and axis labels
      plot.DrawRectangle(Pens.Black, plotGrid);
      int y;
      Font myFont = new Font("Arial", 8);
      SizeF mySize;
      string s;
      pMin = start; pMax = start + numberIntervals * interval;
      for (int i = 0; i <= numberIntervals; i++)
      {
        y = YuToYc(plotGrid, start + i * interval, pMin, pMax);
        plot.DrawLine(Pens.Black, plotGrid.X, y, plotGrid.X + plotGrid.Width, y);
        s = String.Format("{0:f1}", start + i * interval);
        mySize = plot.MeasureString(s, myFont);
        plot.DrawString(s, myFont, Brushes.Black, plotGrid.X - mySize.Width, Convert.ToInt32(y - 0.5 * mySize.Height));
      }
    }
    
    private int YuToYc(Rectangle r, float yU, float yMin, float yMax)
    {
      return (Convert.ToInt32(r.Y + r.Height - r.Height * ((yU - yMin) / (yMax - yMin))));
    }
    
    private void PlotIntervals(float n, float min, float max)
    {
      // this is very old code to find 'nice' plot intervals
      // i've been using this since 1984!!
      float eps = 0.025F;
      if (min == max)
        min = (float) 0.9 * max;
      float a = Math.Abs(min);
      if (Math.Abs(min) < Math.Abs(max))
        a = Math.Abs(max);
      float scale = (float)Math.Pow(10, Convert.ToInt32(Math.Log(a) / Math.Log(10) / 10.0 - 0.5));
      float maxA, minA;
      float maxP, minP;
      float d, f, j;
      int e, v, g, h;
      do
      {
        scale *= 10;
        minA = min / scale; maxA = max / scale;
        d = (maxA - minA) / n; j = d * eps;
        e = Convert.ToInt32((Math.Log(d) / Math.Log(10)) - 0.5);
        f = (float) (d / Math.Pow(10, e)); v = 10;
        if (f < Math.Sqrt(50))
          v = 5;
        if (f < Math.Sqrt(10))
          v = 2;
        if (f < Math.Sqrt(2))
          v = 1;
        interval = (float) (v * Math.Pow(10, e));
        g = Convert.ToInt32(minA / interval - 0.5);
        if (Math.Abs(g + 1 - minA / interval) < j)
          g++;
        minP = interval * g;
        h = Convert.ToInt32(maxA / interval - 0.5) + 1;
        if (Math.Abs(maxA / interval + 1 - h) < j)
          h--;
        maxP = interval * h;
        nIntervals = h - g;
      }
      while (Math.Abs(maxP) >= 10 || Math.Abs(minP) >= 10);
      start = minP * scale; interval *= scale;
    }

  }
}
