using System;
using Xunit;

namespace LinkedList
{
    public class TestLinkedList
    {
        [Fact]
        public void TestSingleLinkedList()
        {
            SingleLinkedList singleLinkedList = new SingleLinkedList();

            singleLinkedList.InsetFront(5);
            singleLinkedList.InsertLast(7);

            singleLinkedList.InsertBetweenNode(singleLinkedList.Head, 6);

            singleLinkedList.PrintAllNode();

            var result = singleLinkedList.GetNodes();

            Assert.Equal(5, result.data);
            Assert.Equal(6, result.next.data);
            Assert.Equal(7, result.next.next.data);
        }

        [Fact]
        public void TestDeleteDataSingleLinkedList()
        {
            SingleLinkedList singleLinkedList = new SingleLinkedList();

            singleLinkedList.InsetFront(5);
            singleLinkedList.InsertBetweenNode(singleLinkedList.Head, 6);
            singleLinkedList.InsertLast(7);

            singleLinkedList.DeleteNodeByData(6);
            singleLinkedList.DeleteNodeByData(5);

            var result = singleLinkedList.GetNodes();

            Assert.Equal(7, result.data);
        }

        [Fact]
        public void TestDoubleLinkedList()
        {
            DoubleLinkedList doubleLinkedList = new DoubleLinkedList();
            doubleLinkedList.InsertFront(1);
            doubleLinkedList.InsertFront(3);
            doubleLinkedList.InsertBetween(doubleLinkedList.Head, 2);
            doubleLinkedList.InsertLastNode(10);

            var result = doubleLinkedList.GetNodes();
        }
    }
}
