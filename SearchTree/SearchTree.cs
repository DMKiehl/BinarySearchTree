using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTree
{
    class SearchTree
    {
        //member variables
        public Node root;


        //constructor
        public SearchTree()
        {
            root = null;
        }


        //member methods
        public void Add(int num)
        {
            Node node = new Node();
            node.data = num;
            node.leftChild = null;
            node.rightChild = null;

            if (root == null)
            {
                root = node;
            }

            else
            {
                Node newNode = root;
                Node parentNode;

                while (true)
                {
                    parentNode = newNode;
                    if (num < newNode.data)
                    {
                        newNode = newNode.leftChild;
                        if (newNode == null)
                        {
                            parentNode.leftChild = node;
                            return;
                        }
                    }

                    else
                    {
                        newNode = newNode.rightChild;
                        if (newNode == null)
                        {
                            parentNode.rightChild = node;
                            return;
                        }
                    }
                }
            }

        }

        public bool Search(int num)
        {
            Node node = root;

            while (node != null)
            {

                if(num == node.data)
                {
                    return true;
                }

                else if (num > node.data)
                {
                    node = node.rightChild;
                }

                else if (num < node.data)
                {
                    node = node.leftChild;
                }

                else
                {
                    return true;
                }
            }
            return false;


        }

    }
}

