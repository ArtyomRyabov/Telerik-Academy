namespace Point3D
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Path                        //Problem 4
    {
        private List<Point3D> pathList;

        public Path()             
        {
            this.pathList = new List<Point3D>();
        }
      
        public void AddPath(Point3D points)
        {
            
           this.pathList.Add(points);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            int counter = 1;

            foreach (Point3D item in pathList)
            {
                builder.Append(String.Format("{0} coordinates: ({1})\n", counter, item));
                counter++;
            }

            return builder.ToString();
        }
    }
}
