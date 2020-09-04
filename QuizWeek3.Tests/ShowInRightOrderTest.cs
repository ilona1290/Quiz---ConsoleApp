using QuizWeek3.App.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;

namespace QuizWeek3.Tests
{
    public class ShowInRightOrderTest
    {
        [Fact]
        public void Check_If_Result_Of_First_User_Is_Bigger_Than_Result_Of_Second_User()
        {
            //Arrange
            ReturnBestScores returnBestScoresTest = new ReturnBestScores();
            var users = returnBestScoresTest.ReturningMethod();
            ShowInRightOrder showInRightOrder = new ShowInRightOrder();
            //Act
            var userInRightOrder = showInRightOrder.OrganizeTheList(users);
            bool condition = userInRightOrder[0].Result > userInRightOrder[1].Result;
            //Assert
            Assert.True(condition);
        }
    }
}
