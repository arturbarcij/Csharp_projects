namespace TicTacToeTest;

using TicTacToe.IO;
using System;
using NUnit.Framework;
using TicTacToe;
using TicTacToe.Interfaces;


public class CursorTest {
    private Cursor cursor;

    [SetUp]
    public void Setup() {
        var keyToMoveMap = new KeyToMoveMap('i', 'k', 'j', 'l', 'q', ' ');
        cursor = new Cursor(3, keyToMoveMap);
        cursor.MoveDown();
        cursor.MoveRight();
        // Position positionStartSave = cursor.position;
        // Assert.True((positionStartSave.X == cursor.position.X) && 
        // (positionStartSave.Y == cursor.position.Y));
    }

    [Test]
    public void CursorCenterTest() {
        Assert.True(cursor.position.X == 1 && cursor.position.Y == 1);
    }

    [Test]
    public void MoveUpTest() {
        // CODE HERE!
        cursor.MoveUp();
        Position positionUpSave = cursor.position;
        cursor.MoveUp();
        Assert.True((positionUpSave.X == cursor.position.X) && 
        (positionUpSave.Y == cursor.position.Y));
    }

    [Test]
    public void MoveDownTest() {
        // CODE HERE!
        cursor.MoveDown();
        Position positionDownSave = cursor.position;
        cursor.MoveDown();
        Assert.True((positionDownSave.X == cursor.position.X) && 
        (positionDownSave.Y == cursor.position.Y));
        
    }
    
    [Test]
    public void MoveLeftTest() {
        // CODE HERE!
        cursor.MoveLeft();
        Position positionLeftSave = cursor.position;
        cursor.MoveLeft();
        Assert.True((positionLeftSave.X == cursor.position.X) && 
        (positionLeftSave.Y == cursor.position.Y));
        
    }

    [Test]
    public void MoveRightTest() {
        // CODE HERE!
        cursor.MoveRight();
        Position positionRightSave = cursor.position;
        cursor.MoveRight();
        Assert.True((positionRightSave.X == cursor.position.X) && 
        (positionRightSave.Y == cursor.position.Y));
        
    }   
}
