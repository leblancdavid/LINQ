using System;
using System.Collections.Generic;
using FluentAssertions;
using MyCollection;
using Xunit;

namespace List.Tests
{
    public class MyList
    {
        [Fact]
        public void AnyShouldReturnTrueIfContainsElement()
        {
            var myList = new MyList<int>(new List<int>()
            {
                1, 2, 3, 4, 5
            });

            myList.Any(x => x == 5).Should().BeTrue();
        }

        [Fact]
        public void AnyShouldReturnFalseWhenItDoesNotContainElement()
        {
            var myList = new MyList<int>(new List<int>()
            {
                1, 2, 3, 4, 5
            });

            myList.Any(x => x == 42).Should().BeFalse();
        }

        [Fact]
        public void All42()
        {
            var myList = new MyList<int>(new List<int>()
            {
                42, 42, 42
            });

            myList.All(x => x == 42).Should().BeTrue();
        }

        [Fact]
        public void SelectShouldMapToSomething()
        {
            var myList = new MyList<int>(new List<int>()
            {
                1, 2, 3, 4, 5
            });

            var myStringList = myList.Select(x => x.ToString());
            myStringList.Count.Should().Be(5);
            myStringList[0].Should().Be("1");
            myStringList[4].Should().Be("5");
        }

        [Fact]
        public void WhereShouldFilterStuff()
        {
            var myList = new MyList<int>(new List<int>()
            {
                2, 4, 6, 9, 17, 33, 42
            });

            var filteredList = myList.Where(x => x % 2 == 0);
            filteredList.Count.Should().Be(4);
            filteredList[0].Should().Be(2);
            filteredList[3].Should().Be(42);
        }     
    }
}
