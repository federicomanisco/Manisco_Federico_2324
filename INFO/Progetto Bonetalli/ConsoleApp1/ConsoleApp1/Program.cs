using System;

class Program {
    static int size = 10;
    static int[,] board = new int[size, size];
    static int currentNumber = 1;

    static void Main() {
        int startX = 5;
        int startY = 5;


        PopulateBoard();

        if (SolvePuzzle(startX, startY)) {
            PrintSolution();
        } else {
            Console.WriteLine("Nessuna soluzione trovata.");
        }
    }

    static bool SolvePuzzle(int x, int y) {
        if (currentNumber > size * size) {
            return true;
        }

        int[,] possibleMoves = { { 2, 1 }, { 2, -1 }, { -2, 1 }, { -2, -1 }, { 2, 0 }, { 0, 2 }, { -2, 0 }, { 0, -2 } };
        Random nextTry = new Random();

        for (int i = 0; i < possibleMoves.GetLength(0); i++) {
            int move = nextTry.Next(possibleMoves.GetLength(0) - 1);
            int nextX = x + possibleMoves[move, 0];
            int nextY = y + possibleMoves[move, 1];

            if (IsValidMove(nextX, nextY)) {
                board[nextX, nextY] = currentNumber;
                currentNumber++;
                PrintSolution();
                Thread.Sleep(2000);
                Console.Clear();

                if (SolvePuzzle(nextX, nextY)) {
                    return true;
                }

                board[nextX, nextY] = 0;
                currentNumber--;
            }
        }

        return false;
    }

    static bool IsValidMove(int x, int y) {
        return x >= 0 && x < size && y >= 0 && y < size && board[x, y] == 0;
    }

    static void PrintSolution() {
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                Console.Write($"{board[i, j],3}");
            }
            Console.WriteLine();
        }
    }

    static void PopulateBoard() {
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                board[i, j] = 0;
            }
        }
    }
}
