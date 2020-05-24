using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Msagl.Drawing;

namespace MaxFlow_MinCut
{
    public class Nodes
    {
        public List<Node> nodes = new List<Node>();

        /// <summary>
        /// nodes listesine gönderilen düğümü ekler. düğüm zaten varsa false yoksa true döndürür.
        /// </summary>
        /// <param name="node">Eklenecek düğüm</param>
        /// <returns></returns>
        public bool AddNode(Node node)
        {
            if (nodes.Contains(node))
            {
                return false;
            }
            else
            {
                nodes.Add(node);
                return true;
            }
        }
    }
}