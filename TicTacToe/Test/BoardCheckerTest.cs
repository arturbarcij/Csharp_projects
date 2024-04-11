namespace TicTacToeTest;

using System;
using NUnit.Framework;
using TicTacToe;

public class BoardCheckerTest {

    public Board board;
    public BoardChecker boardChecker;

    [SetUp]
    public void Setup() {
        board = new Board(3);
        boardChecker = new BoardChecker();
    }

    [Test]
    public void DiagonalWinTest() {
        // CODE HERE!
        board.TryInsert(0,0, PlayerIdentifier.Cross);
        board.TryInsert(1,1, PlayerIdentifier.Cross);
        board.TryInsert(2,2, PlayerIdentifier.Cross);
        Assert.AreEqual(boardChecker.CheckBoardState(board),BoardState.Winner);
        
    }

    [Test]
    public void RowWinTest() {
        // CODE HERE!
        board.TryInsert(0,0, PlayerIdentifier.Cross);
        board.TryInsert(1,0, PlayerIdentifier.Cross);
        board.TryInsert(2,0, PlayerIdentifier.Cross);
        Assert.AreEqual(boardChecker.CheckBoardState(board),BoardState.Winner);
    }
    
    [Test]
    public void ColumnWinTest() {
    
        board.TryInsert(0,0, PlayerIdentifier.Cross);
        board.TryInsert(0,1, PlayerIdentifier.Cross);
        board.TryInsert(0,2, PlayerIdentifier.Cross);
        Assert.AreEqual(boardChecker.CheckBoardState(board),BoardState.Winner);
    }

    [Test]
    public void InconclusiveTest() {
        
        Assert.AreEqual(boardChecker.CheckBoardState(board),BoardState.Inconclusive);
    }

    [Test]
    public void TiedTest() {

        board.TryInsert(0,0, PlayerIdentifier.Naught);
        board.TryInsert(0,1, PlayerIdentifier.Cross);
        board.TryInsert(0,2, PlayerIdentifier.Naught);
        board.TryInsert(1,0, PlayerIdentifier.Cross);
        board.TryInsert(2,0, PlayerIdentifier.Naught);
        board.TryInsert(1,1, PlayerIdentifier.Cross);
        board.TryInsert(2,2, PlayerIdentifier.Naught);
        
        
        Assert.AreEqual(boardChecker.CheckBoardState(board),BoardState.Tied); 

    }
}
