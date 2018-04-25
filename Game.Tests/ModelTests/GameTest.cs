using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameApp.Models;
using System.Collections.Generic;

namespace GameApp.Tests
{
  [TestClass]
  public class GameTest
  {
    [TestMethod]
    public void GetPlayer1_PlayerChoice_String()
    {
      //Arrange
      Game newGame = new Game ("scissors", "paper");
      string testChoice = "scissors";
      //Act
      string player1Choice = newGame.GetPlayer1();
      //Assert
      Assert.AreEqual(testChoice, player1Choice);
    }

    [TestMethod]
    public void GetPlayer2_PlayerChoice_String()
    {
      //Arrange
      Game newGame = new Game ("rock", "paper");
      string testChoice = "paper";
      //Act
      string player2Choice = newGame.GetPlayer2();
      //Assert
      Assert.AreEqual(testChoice, player2Choice);
    }

    [TestMethod]
    public void Game_PlayerChoice_return_Draw()
    {
      //Arrange
      string expectedResult = "Draw";

      //Act
      Game game = new Game("scissors", "scissors");
      string result = "rock";

      //Assert
      Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void Game_PlayerChoice_return_Draw2()
    {
      //Arrange
      string expectedResult = "Draw";

      //Act
      Game game = new Game("scissors", "scissors");
      string result = "Draw";

      //Assert
      Assert.AreEqual(expectedResult, result);
    }
  }
}
