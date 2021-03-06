# Binary Tree and Binary Search Tree

## Challenge
* Binary Tree implementation that supports pre-order, in-order, and post-order traversal. Each method has been implemented recursively.
* Binary Search Tree implementation that supports Add() and Search(). Both Add() and Search() are implemented recursively.

## Approach and Efficiency
Traversals: Time is O(n) since we must visit each node, Space is O(h) where h is the height of the tree 
Add to a BST: Time is O(logn), space is O(1)
Search a BST: Time is O(logn), space is O(1)

## API
BinaryTree
  * PreOrder(Node root, List<int> values): takes the tree's root and an empty list of ints. Fills that list of ints with the node values
  of the binary tree as they're visited (in pre-order).
  * InOrder(Node root, List<int> values): takes the tree's root and an empty list of ints. Fills that list of ints with the node values
  of the binary tree as they're visited (in order).
  * PostOrder(Node root, List<int> values): takes the tree's root and an empty list of ints. Fills that list of ints with the node values
  of the binary tree as they're visited (in post-order).
 
BinarySearchTree
  * Add(Node root, int value): takes the tree's root and a new value to insert. Returns the tree's root to effectively replace the original root value.
  * Search(Node root, int value): takes the tree's root and a value to be searched for. If found, returns the node with the specified value, otherwise returns null.
