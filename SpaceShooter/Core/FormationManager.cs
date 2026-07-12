using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShooter.Core
{
    public static class FormationManager
    {
        public static List<PointF> GenerateFormation(RectangleF gameArea , float sidePadding , int rows , int cols , float topPadding , float EnemyWidth , float EnemyHeight , float rowSpace = 15f)
        {
            var points = new List<PointF>();

            float cellWidth = (gameArea.Width - 2 * sidePadding) / cols;


            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    float cellCenterX = gameArea.X + sidePadding + (j * cellWidth) + cellWidth / 2f;
                    float x = cellCenterX - EnemyWidth / 2f;
                    float y = gameArea.Y + topPadding + i * (EnemyHeight + rowSpace);

                    points.Add(new PointF(x, y));
                }
            }
            return points;
        }
    }
}
