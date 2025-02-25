using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStarAlgorithmFor8PuzzleGame
{
    public class BoardStateSolver
    {
        public BoardState initialBoardState { get;private set; }
        public BoardState goalBoardState { get;private set;}

        public BoardStateSolver(int[,] initialBoard,int[,] goalBoard)
        {
            this.initialBoardState = new BoardState(initialBoard);
            this.goalBoardState = new BoardState(goalBoard);

            initialBoardState.g = 0;

            initialBoardState.h = initialBoardState.calculateManhattanHeuristic(goalBoardState);
        }

        public List<BoardState> solveBoard()
        {
            List<BoardState> evaluableBoardStateList = new List<BoardState>();
            List<BoardState> closeBoardStateList = new List<BoardState>();

            evaluableBoardStateList.Add(initialBoardState);

            while(evaluableBoardStateList.Count > 0)
            {
                evaluableBoardStateList.Sort((a, b) => a.f.CompareTo(b.f));
                BoardState currentBoardState = evaluableBoardStateList[0];
                evaluableBoardStateList.RemoveAt(0);

                if (currentBoardState.isEqual(goalBoardState))
                {
                    Console.WriteLine("Goal Found");
                    return reConstructPath(currentBoardState);
                }
                closeBoardStateList.Add(currentBoardState);

                foreach (var nextBoardState in currentBoardState.getPossibleMoves())
                {

                    bool skipBoardState = false;

                    foreach(var closedBoardState in closeBoardStateList)
                    {
                        if (closedBoardState.isEqual(nextBoardState))
                        {
                            skipBoardState = true;
                            break;
                        }

                        if (closedBoardState.isEqual(goalBoardState))
                        {
                            Console.WriteLine("Goal Board state found !");
                            return reConstructPath(currentBoardState);
                        }
                    }

                    if (skipBoardState)
                    {
                        continue;
                    }

                    nextBoardState.h = nextBoardState.calculateManhattanHeuristic(goalBoardState);

                    bool inEvaluableBoardState = false;
                    for(int i = 0; i < evaluableBoardStateList.Count; i++)
                    {
                        if (evaluableBoardStateList[i].isEqual(nextBoardState))
                        {
                            inEvaluableBoardState = true;

                            if (evaluableBoardStateList[i].g  > nextBoardState.g)
                            {
                                evaluableBoardStateList[i].g = nextBoardState.g;
                                evaluableBoardStateList[i].parent = currentBoardState;
                                evaluableBoardStateList[i].lastMove = nextBoardState.lastMove;
                            }

                            break;
                        }
                    }
                }
            }
            return null;
        }

        public List<BoardState> reConstructPath(BoardState finalBoardState)
        {
            List<BoardState> path = new List<BoardState>();
            BoardState currentBoardState = finalBoardState;

            while(currentBoardState != null)
            {
                path.Add(currentBoardState);
                currentBoardState = currentBoardState.parent;
            }

            path.Reverse();

            return path;
        }
    }
}
