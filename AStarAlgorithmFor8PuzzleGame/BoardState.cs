using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AStarAlgorithmFor8PuzzleGame
{
    public class BoardState
    {
        public Tile[,] tiles { get; private set; }
        public int emptyRow { get; private set; }
        public int emptyColumn { get; private set; }
        public int g { get; set; }
        public int h { get; set; }
        public int f => g + h;
        public BoardState parent { get; set; }
        public List<BoardState> possibleMoves { get; private set; }
        public String lastMove { get; set; }
        
        public BoardState(int[,] initialState)
        {
            tiles = new Tile[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tiles[i, j] = new Tile(initialState[i, j]);

                    if (initialState[i, j] == 0)
                    {
                        emptyRow = i;
                        emptyColumn = j;
                    }
                }
            }
        }

        public BoardState cloneCurrentBoardState()
        {
            int[,] values = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    values[i, j] = tiles[i, j].Value;
                }
            }
            return new BoardState(values);
        }


        public bool isEqual(BoardState other)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tiles[i, j].Value != other.tiles[i, j].Value)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public int calculateManhattanHeuristic(BoardState goalState)
        {
            int distance = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int tileValue = tiles[i, j].Value;

                    if (tileValue != 0)
                    {
                        int targetRow = -1;
                        int targetColumn = -1;

                        for (int m = 0; m < 3; m++)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                if (goalState.tiles[m, k].Value == tileValue)
                                {
                                    targetRow = m;
                                    targetColumn = k;
                                    break;
                                }
                            }

                            if (targetRow != -1)
                            {
                                break;
                            }
                        }
                        // Manhattan mesafe hesaplanmasi satir1- satir2 + sutun1 - sutun2 tabi mutlak deger icinde
                        distance += Math.Abs(i - targetRow) + Math.Abs(j - targetColumn);
                    }
                }
            }
            return distance;
        }


        public List<BoardState> getPossibleMoves()
        {
            List<BoardState> possibleMoves = new List<BoardState>();

            string[] moveNames = { "Yukari", "Asagi", "Sol", "Sag" };
            int[] dr = { -1, 1, 0, 0 };
            int[] dc = { 0, 0, -1, 1 };


            for (int i = 0; i < 4; i++)
            {
                int newEmptyRow = emptyRow + dr[i];
                int newEmptyColumn = emptyColumn + dc[i];


                if (newEmptyRow >= 0 && newEmptyRow < 3 && newEmptyColumn >= 0 && newEmptyColumn < 3)
                {
                    BoardState newBoardState = cloneCurrentBoardState();

                    newBoardState.tiles[emptyRow, emptyColumn].Value = newBoardState.tiles[newEmptyRow, newEmptyColumn].Value;
                    newBoardState.tiles[newEmptyRow, newEmptyColumn].Value = 0;

                    newBoardState.emptyRow = newEmptyRow;
                    newBoardState.emptyColumn = newEmptyColumn;

                    newBoardState.g = g + 1;
                    newBoardState.parent = this;

                    newBoardState.lastMove = moveNames[i];


                    possibleMoves.Add(newBoardState);
                }
            }
            this.possibleMoves = possibleMoves;
            return possibleMoves;
        }
    }
}
