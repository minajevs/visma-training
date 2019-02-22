using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Stack = UnitTesting.Stack<string>;

namespace UnitTests
{
    public class StackTests
    {
        [Fact]
        public void Push_CalledWithNull_ThrowAnException()
        {
            var stack = new Stack();
            
            Assert.Throws<ArgumentNullException>(() => stack.Push(null));   
        }

        [Fact]
        public void Push_CalledWithAString_AddsToStack()
        {
            var stack = new Stack();

            stack.Push("test");

            Assert.Equal(1, stack.Count);
        }

        [Fact]
        public void Pop_CalledOnEmptyStack_ThrowsAnError()
        {
            var stack = new Stack();

            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Fact]
        public void Pop_CalledOnFilledStack_ReturnsTopString()
        {
            var stack = new Stack();
            stack.Push("one");
            stack.Push("two");

            var result = stack.Pop();

            Assert.Equal("two", result);
        }

        [Fact]
        public void Pop_CalledOnFilledStack_RemovesTopStringFromStack()
        {
            var stack = new Stack();
            stack.Push("one");
            stack.Push("two");

            var result = stack.Pop();

            Assert.Equal(1, stack.Count);
        }

        [Fact]
        public void Peek_CalledOnEmptyStack_ThrowsAnError()
        {
            var stack = new Stack();

            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }

        [Fact]
        public void Peek_CalledOnFilledStack_ReturnsTopString()
        {
            var stack = new Stack();
            stack.Push("one");
            stack.Push("two");

            var result = stack.Peek();

            Assert.Equal("two", result);
        }

        [Fact]
        public void Peek_CalledOnFilledStack_DoesNotRemoveTopString()
        {
            var stack = new Stack();
            stack.Push("one");
            stack.Push("two");

            var result = stack.Peek();

            Assert.Equal(2, stack.Count);
        }
    }
}
