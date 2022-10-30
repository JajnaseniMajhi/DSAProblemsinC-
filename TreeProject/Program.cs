// See https://aka.ms/new-console-template for more information
using TreeProject;
using TreeProject.HomeworkPractice;
using TreeProject.MorrisTraversal;
using TreeProject.TreeProblems;

Console.WriteLine("Hello, World!");

TreeOperations treeOperations = new TreeOperations();
var root = treeOperations.CreateTree();
//treeOperations.PrintPreOrder(root);
//Console.WriteLine(treeOperations.FindElement(root, 12));
LevelOrder levelOrder = new LevelOrder();
var result=levelOrder.LvelOrderTraversal(root);

//var result = levelOrder.solve(root);
//var result =levelOrder.VerticalOrderTraverse(root);
//var result= levelOrder.BottomView(root);
//foreach(var x in result)
//{
//    Console.WriteLine(x);
//}
//BalancedBinaryTree balancedBinaryTree = new BalancedBinaryTree();
//Console.WriteLine(balancedBinaryTree.IsBalanced(root));
//SerializeDeSerialize serializeDeSerialize = new SerializeDeSerialize();
//var rr = serializeDeSerialize.DeSearialize(new List<int> { 1, 2, 3, 4, 5, -1, -1, -1, -1, -1, 6, -1, -1 });
//    var xx= serializeDeSerialize.Serialize(rr);
//foreach (var x in xx)
//{
//    Console.WriteLine(x);
//}
//treeOperations.PrintPreOrder(rr);

//BinarySearchTree binarySearch = new BinarySearchTree();
//Console.WriteLine(binarySearch.IsValidBST(root));
//Console.WriteLine("Hello, World!");
//Console.WriteLine(binarySearch.FindLargestBST(root));
//CheckBSTOneChild checkBSTOneChild = new CheckBSTOneChild();
////var f = checkBSTOneChild.Solve(new List<int>() { 4, 10, 5, 8 });
//BSTPractice bSTPracice = new BSTPractice();
////var r1 = bSTPracice.Solve(new List<int>() { 12, 1, 9, 6, 2 });
//var r2=bSTPracice.SolveRange(root, 4, 7);
//HashSet<int> list = new HashSet<int>();
//var r3 = bSTPracice.Sum2T(root, 15, list);
//Console.WriteLine(r3
//treeOperations.PrintPreOrder(root);
treeOperations.PrintPreOrder(root);
Console.WriteLine("******************************");
//Tree5 tree5 = new Tree5();
//var p = tree5.InvertTree(root);

//treeOperations.PrintPreOrder(p);
Console.WriteLine("******************************");
MorrisTraversalProblems morrisTraversalProblem = new MorrisTraversalProblems();
morrisTraversalProblem.PrintMorrisPreOrder(root);



Console.ReadLine();
