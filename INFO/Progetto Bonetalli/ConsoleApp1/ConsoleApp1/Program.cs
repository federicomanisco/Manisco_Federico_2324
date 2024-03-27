using System;

class Program {
    static int size = 10;
    static int[,] board = new int[size, size];
    static int currentNumber = 1;

    static void Main() {
        int startX = 5;
        int startY = 4;


        PopulateBoard();

        if (IsValidMove(startX, startY)) {
            board[startY, startX] = currentNumber;
            currentNumber++;
        }


        PrintSolution();
        Thread.Sleep(1000);

        

        if (SolvePuzzle(startX, startY)) {
            Console.Clear();
            PrintSolution();
        } else {
            Console.WriteLine("Nessuna soluzione trovata.");
        }
    }

    static bool SolvePuzzle(int x, int y) {
        if (currentNumber > (size * size)) {
            return true;
        }


        int[,] possibleMoves = { { 0, -3 }, { 2, -2 }, { 3, 0 }, { 2, 2 }, { 0, 3 }, { -2, 2 }, { -3, 0 }, { -2, -2 } };
        List<(int, int)> moves = new List<(int, int)>();

        for (int i = 0; i < possibleMoves.GetLength(0); i++) {
            int nextX = x + possibleMoves[i, 0];
            int nextY = y + possibleMoves[i, 1];
            if (IsValidMove(nextX, nextY)) {
                int numberOfPossibleMoves = CountValidMoves(nextX, nextY, possibleMoves);
                moves.Add((numberOfPossibleMoves, i));
            }
                      
        }

        List<int> indexesOfMin = new List<int>();
        int min = int.MaxValue;
        int indexOfMin = -1;
        foreach ((int, int) option in moves) {
            if (option.Item1 < min) {
                min = option.Item1;
                indexOfMin = option.Item2;
            }

            if (option.Item1 == min && min != 0) { 
                indexesOfMin.Add(option.Item2);
            }
        }

        int moveToMake = indexOfMin;

        int moveX = x + possibleMoves[moveToMake, 0];
        int moveY = y + possibleMoves[moveToMake, 1];

        board[moveY, moveX] = currentNumber;
        currentNumber++;
        
        Console.Clear();
        PrintSolution();
        Thread.Sleep(300);

        if (SolvePuzzle(moveX, moveY)) {
            return true;
        }
        return false;
    }

    static int CountValidMoves(int x, int y, int[,] possibleMoves) {
        int validMoves = 0;
        for (int i = 0; i < possibleMoves.GetLength(0); i++) {
            int nextX = x + possibleMoves[i, 0];
            int nextY = y + possibleMoves[i, 1];
            if (IsValidMove(nextX, nextY)) {
                validMoves++;
            }
        }
        return validMoves;
    }

    static bool IsValidMove(int x, int y) {
        return x >= 0 && x < size && y >= 0 && y < size && board[y, x] == 0;
    }

    static void PrintSolution() {
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                Console.Write($"{board[i, j], 5}");
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
