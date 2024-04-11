namespace TicTacToe;

using System;
using TicTacToe.Interfaces;



/// <summary>
/// A basic board checker that will determine if for a given row, diagonal or column, if all of
/// the elements is equal to eachother and not equal to null. It will also determine if the board
/// is in a tied position.
/// </summary>
public class BoardChecker : IBoardChecker {

    /// <summary>
    /// Method that is used to check if all elements in a row is equal to eachother and is not
    /// equal to null.
    /// </summary>
    /// <param name="board">A given board.</param>
    /// <returns>
    /// True if there is a win where all identifiers in the row is equal else false.
    /// </returns>
    private bool IsRowWin(Board board) {
        // CODE HERE!
        if ((board.Get(0,0) == PlayerIdentifier.Cross) && 
           (board.Get(1,0) == PlayerIdentifier.Cross) &&
           (board.Get(2,0) == PlayerIdentifier.Cross)) {
            return true;
        }
        else {
            return false;
        }

        
    }

    /// <summary>
    /// Method that is used to check if all elements in a column is equal to eachother and is not
    /// equal to null.
    /// </summary>
    /// <param name="board">A given board.</param>
    /// <returns>
    /// True if there is a win where all identifiers in the column is equal else false.
    /// </returns>
    private bool IsColWin(Board board) {
         if ((board.Get(0,0) == PlayerIdentifier.Cross) && 
           (board.Get(0,1) == PlayerIdentifier.Cross) &&
           (board.Get(0,2) == PlayerIdentifier.Cross)) {
            return true;
        }
        else {
            return false;
        }
    }

    /// <summary>
    /// Method that is used to check if all elements in a diagonal is equal to eachother and is not
    /// equal to null. This diagonal will always be the two longest in a square.
    /// </summary>
    /// <param name="board">A given board.</param>
    /// <returns>
    /// True if there is a win where all identifiers in the diagonal is equal else false.
    /// </returns>
    private bool IsDiagWin(Board board) {
         if ((board.Get(0,0) == PlayerIdentifier.Cross) && 
           (board.Get(1,1) == PlayerIdentifier.Cross) &&
           (board.Get(2,2) == PlayerIdentifier.Cross)) {
            return true;
        }
        else {
            return false;
        }
    }

    /// <summary>
    /// Method that will determine what the state of the board is. If there is a winner, a tied or
    /// the game is still inconclusive.
    /// </summary>
    /// <param name="board">A given board.</param>
    /// <returns> The state of the board.</returns>
    public BoardState CheckBoardState(Board board) {
       if ((IsDiagWin(board)) || (IsColWin(board)) || (IsRowWin(board))) {
           return BoardState.Winner;
       }
       else if (board.IsFull()) {
           return BoardState.Tied;
       }
       else {
           return BoardState.Inconclusive;
       }
    }
}