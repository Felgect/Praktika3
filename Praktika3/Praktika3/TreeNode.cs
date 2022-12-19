using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika3
{
    public class TreeNode
    {
        private char info;
        private TreeNode left;
        private TreeNode right;

        public int Info { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode() { } 
        public TreeNode(int info)
        {
            Info = info;
        }
        public TreeNode(int info, TreeNode left, TreeNode right)
        {
            Info = info; Left = left; Right = right;
        }
    }

    public class BinaryTree
    {
        private TreeNode root;
        public TreeNode Root
        {
            get { return root; }
            set { root = value; }
        }

        public BinaryTree()
        {
            root = null;
        }

        /// <param name="n"></param>
        /// <returns></returns>
        public TreeNode Create_Balanced(int n)
        {
            int x;
            TreeNode root;
            if (n == 0)
                root = null;
            else
            {   // Заполнение поля корня  
                Console.WriteLine("Значение поля узла (символ):");
                x = int.Parse(Console.ReadLine());
                // Создать корень дерева  
                // ===========================
                root = new TreeNode(x);
                // Построить левое поддерево (*1*)
                root.Left = Create_Balanced(n / 2);
                // Построить правое поддерево  (*2*)
                root.Right = Create_Balanced(n - n / 2 - 1);
            }
            return root; //(*3*)
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        public void KLP(TreeNode root) 
        {
            // Проверка пустоты
            // ===========================
            if (root != null)
            {
                Console.WriteLine(root.Info);
                KLP(root.Left);
                KLP(root.Right); 
            }
            //(* 3 *) 
        }
    }
}
