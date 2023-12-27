﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_05.Trees;

public class CustomBinarySearchTree
{
   public Node root;
   public CustomBinarySearchTree()
   {
      this.root = null;
   }
   public void Insert(int value)
   {
      Node newNode = new Node(value);
      if (this.root == null)
      {
         this.root = newNode;
         return;
      }
      Node curretNode = this.root;
      while (true)
      {
         if (curretNode.Value > value)
         {
            if (curretNode.Left == null)
            {
               curretNode.Left = newNode;
               return;
            }
            curretNode = curretNode.Left;
         }
         else
         {
            if (curretNode.Right == null)
            {
               curretNode.Right = newNode;
               return;
            }
            curretNode = curretNode.Right;
         }
      }
   }
   public Node Lookup(int value)
   {
      if (this.root == null)
      {
         return null;
      }
      Node curretNode = this.root;
      while (curretNode != null)
      {
         if (curretNode.Value > value)
         {
            curretNode = curretNode.Left;
         }
         else if(curretNode.Value < value)
         {
            curretNode = curretNode.Right;
         }
         else if (curretNode.Value == value)
         {
            return curretNode;
         }
      }
      return null;
   }
   public void Remove(int value)
   {
      if (root == null)
      {
         return;
      }
      Node nodeToRemove = root;
      Node parentNode = null;
      while (nodeToRemove.Value != value)
      { //Searching for the node to remove and it's parent
         parentNode = nodeToRemove;
         if (value < nodeToRemove.Value)
         {
            nodeToRemove = nodeToRemove.Left;
         }
         else if (value > nodeToRemove.Value)
         {
            nodeToRemove = nodeToRemove.Right;
         }
      }
      Node replacementNode = null;
      if (nodeToRemove.Right != null)
      { //We have a right node
         replacementNode = nodeToRemove.Right;
         if (replacementNode.Left == null)
         { //We don't have a left node
            replacementNode.Left = nodeToRemove.Left;
         }
         else
         { //We have a have a left node, lets find the leftmost
            Node replacementParentNode = nodeToRemove;
            while (replacementNode.Left != null)
            {
               replacementParentNode = replacementNode;
               replacementNode = replacementNode.Left;
            }
            replacementParentNode.Left = null;
            replacementNode.Left = nodeToRemove.Left;
            replacementNode.Right = nodeToRemove.Right;
         }
      }
      else if (nodeToRemove.Left != null)
      {//We only have a left node
         replacementNode = nodeToRemove.Left;
      }

      if (parentNode == null)
      {
         root = replacementNode;
      }
      else if (parentNode.Left == nodeToRemove)
      { //We are a left child
         parentNode.Left = replacementNode;
      }
      else
      { //We are a right child
         parentNode.Right = replacementNode;
      }
   }

   int COUNT = 5;
   public void printTree(Node node)
   {
      print2DUtil(root, 0);
   }
   private void print2DUtil(Node root, int space)
   {
      // Base case  
      if (root == null)
         return;

      // Increase distance between levels  
      space += COUNT;

      // Process right child first  
      print2DUtil(root.Right, space);

      // Print current node after space  
      // count  
      Console.Write("\n");
      for (int i = COUNT; i < space; i++)
      {
         Console.Write(" ");
      }
      Console.Write(root.Value + "\n");

      // Process left child  
      print2DUtil(root.Left, space);
   }
}










