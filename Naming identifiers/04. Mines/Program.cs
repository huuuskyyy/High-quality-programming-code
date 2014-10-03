namespace Minesweapers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Mines
    {
        public class Player
        {
            private string name;
            private int points;

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public int Points
            {
                get { return this.points; }
                set { this.points = value; }
            }

            public Player()
            {
            }

            public Player(string name, int points)
            {
                this.name = name;
                this.points = points;
            }
        }

        public static void Main()
        {
            string command = string.Empty;
            char[,] field = CreatePlayingField();
            char[,] bombs = CreateBombs();
            int score = 0;
            bool isMineHit = false;
            List<Player> highscoreList = new List<Player>(6);
            int row = 0;
            int column = 0;
            bool isNewGame = true;
            const int MAX_CELLS = 35;
            bool isAllCellsOpen = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Let's play minesweapers. Try to find the cells that has no mines." +
                    " Command 'top' shows the leaderboard, 'restart' starts a new game, 'exit' will terminate the current game and close the program!");
                    DrawField(field);
                    isNewGame = false;
                }

                Console.Write("Enter row and column : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= field.GetLength(0) && column <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ShowLeaderboard(highscoreList);
                        break;
                    case "restart":
                        field = CreatePlayingField();
                        bombs = CreateBombs();
                        DrawField(field);
                        isMineHit = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye!");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                ShowAdjacentMines(field, bombs, row, column);
                                score++;
                            }

                            if (MAX_CELLS == score)
                            {
                                isAllCellsOpen = true;
                            }
                            else
                            {
                                DrawField(field);
                            }
                        }
                        else
                        {
                            isMineHit = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Wrong command\n");
                        break;
                }

                if (isMineHit)
                {
                    DrawField(bombs);

                    Console.Write("\nHrrrrrr! Game over. You scored {0} points. " + "Enter nickname : ", score);
                    string nickname = Console.ReadLine();
                    Player newPlayer = new Player(nickname, score);

                    if (highscoreList.Count < 5)
                    {
                        highscoreList.Add(newPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < highscoreList.Count; i++)
                        {
                            if (highscoreList[i].Points < newPlayer.Points)
                            {
                                highscoreList.Insert(i, newPlayer);
                                highscoreList.RemoveAt(highscoreList.Count - 1);
                                break;
                            }
                        }
                    }

                    highscoreList.Sort((Player playerOne, Player playerTwo) => playerTwo.Name.CompareTo(playerOne.Name));
                    highscoreList.Sort((Player playerOne, Player playerTwo) => playerTwo.Points.CompareTo(playerOne.Points));
                    ShowLeaderboard(highscoreList);

                    field = CreatePlayingField();
                    bombs = CreateBombs();
                    score = 0;
                    isMineHit = false;
                    isNewGame = true;
                }

                if (isAllCellsOpen)
                {
                    Console.WriteLine("\nGreat! You opened 35 cells without stepping on a mine.");
                    DrawField(bombs);
                    Console.WriteLine("Enter your nickname, champ: ");
                    string playerName = Console.ReadLine();
                    Player playerPoints = new Player(playerName, score);
                    highscoreList.Add(playerPoints);
                    ShowLeaderboard(highscoreList);
                    field = CreatePlayingField();
                    bombs = CreateBombs();
                    score = 0;
                    isAllCellsOpen = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria");
            Console.Read();
        }

        private static void ShowLeaderboard(List<Player> currentPoints)
        {
            Console.WriteLine("\nPoints:");
            if (currentPoints.Count > 0)
            {
                for (int i = 0; i < currentPoints.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, currentPoints[i].Name, currentPoints[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No players in the leaderboard!\n");
            }
        }

        private static void ShowAdjacentMines(char[,] playingField, char[,] bombsList, int row, int column)
        {
            char adjacentBombs = CountAdjacentBombs(bombsList, row, column);
            bombsList[row, column] = adjacentBombs;
            playingField[row, column] = adjacentBombs;
        }

        private static void DrawField(char[,] board)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayingField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] CreateBombs()
        {
            int rows = 5;
            int columns = 10;
            char[,] playingField = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    playingField[i, j] = '-';
                }
            }

            List<int> bombsList = new List<int>();
            while (bombsList.Count < 15)
            {
                Random random = new Random();
                int bombSign = random.Next(50);
                if (!bombsList.Contains(bombSign))
                {
                    bombsList.Add(bombSign);
                }
            }

            foreach (int bomb in bombsList)
            {
                int col = bomb / columns;
                int row = bomb % columns;
                if (row == 0 && bomb != 0)
                {
                    col--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                playingField[col, row - 1] = '*';
            }

            return playingField;
        }

        private static char CountAdjacentBombs(char[,] field, int row, int col)
        {
            int totalBombs = 0;
            int totalRows = field.GetLength(0);
            int totalCols = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, col] == '*')
                {
                    totalBombs++;
                }
            }

            if (row + 1 < totalRows)
            {
                if (field[row + 1, col] == '*')
                {
                    totalBombs++;
                }
            }

            if (col - 1 >= 0)
            {
                if (field[row, col - 1] == '*')
                {
                    totalBombs++;
                }
            }

            if (col + 1 < totalCols)
            {
                if (field[row, col + 1] == '*')
                {
                    totalBombs++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (field[row - 1, col - 1] == '*')
                {
                    totalBombs++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < totalCols))
            {
                if (field[row - 1, col + 1] == '*')
                {
                    totalBombs++;
                }
            }

            if ((row + 1 < totalRows) && (col - 1 >= 0))
            {
                if (field[row + 1, col - 1] == '*')
                {
                    totalBombs++;
                }
            }

            if ((row + 1 < totalRows) && (col + 1 < totalCols))
            {
                if (field[row + 1, col + 1] == '*')
                {
                    totalBombs++;
                }
            }

            return char.Parse(totalBombs.ToString());
        }
    }
}
