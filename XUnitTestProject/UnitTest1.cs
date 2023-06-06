using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]       
        public void itReturnsString()
        {
            //Arrange
            var controller = new SearchController();
            //Act
            var result = controller.Search("John doe");
            //Assert
            Assert.NotNull(result);
            Assert.IsType<string>(result);
        }

        [Fact]
        public void searchList()
        {
            //Arrange
            var controller = new SearchController();
            //Act
            var result = controller.SearchList(new List<string> { "John doe", "Jane doe", "John wick" }, "John doe");
            //Assert
            Assert.NotNull(result);
        }
    }
}
