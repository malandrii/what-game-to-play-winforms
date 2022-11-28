﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WhatGameToPlay
{
    public static class FilesController
    {
        private static readonly string s_textFileExtension = ".txt";
        private static readonly string s_allTextFileExtension = "*" + s_textFileExtension;
        private static readonly string s_themeFileName = "Theme" + s_textFileExtension;
        private static readonly string s_optionsFileName = "Options" + s_textFileExtension;
        private static readonly string s_gamesListFileName = "GamesList" + s_textFileExtension;
        private static readonly string s_playersDirectoryName = "Players";
        private static readonly string s_limitsDirectoryName = "Limits";

        public static bool StandartFilesExist()
        {
            return File.Exists(s_themeFileName);
        }

        public static bool StringSpacesOnly(string @string)
        {
            return (!@string.Any(letter => char.IsLetter(letter) || char.IsDigit(letter))
                || @string.Length == 0);
        }

        public static bool PlayerFileExist(string checkPlayer)
        {
            return TextFileExist(GetPlayersTextFiles(), checkPlayer);
        }

        public static bool PlayersLimitsFileExist(string checkGame)
        {
            return TextFileExist(GetPlayersLimitsTextFiles(), checkGame);
        }

        private static bool TextFileExist(FileInfo[] filesCollection, string fileName)
        {
            foreach (FileInfo fileInfo in filesCollection)
                if (fileName == Path.GetFileNameWithoutExtension(fileInfo.Name)) return true;
            return false;
        }

        public static void CreateStartingFiles()
        {
            if (CreateFile(s_themeFileName))
                WriteThemeToFile(ThemeController.GetStandartThemeName());
            if (CreateFile(s_optionsFileName))
            {
                string[] standartOptions = { "True", "True", "True", "False", "True", "False" };
                WriteOptionsToFile(standartOptions);
            }
            if (CreateFile(s_gamesListFileName))
                AddGameToGameListFile("example game");
            if (CreateDirectory(s_playersDirectoryName))
                CreatePlayerFile("example player");
            CreateDirectory(s_limitsDirectoryName);
        }

        private static bool CreateFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Dispose();
                return true;
            }
            return false;
        }

        public static void CreatePlayerFile(string selectedPlayer)
        {
            CreateFile(fileName: GetSelectedPlayerFilePath(selectedPlayer));
        }

        private static bool CreateDirectory(string directoryName)
        {
            if (!Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
                return true;
            }
            return false;
        }

        private static string GetFullDirectoryFilePath(string directory, string fileName)
        {
            return directory + "\\" + fileName + s_textFileExtension;
        }

        public static string GetCurrentTheme()
        {
            string[] fileRead = File.ReadAllLines(s_themeFileName);
            return fileRead[0];
        }

        private static string GetSelectedGamePlayersLimitsFilePath(string gameName)
        {
            return GetFullDirectoryFilePath(s_limitsDirectoryName, gameName);
        }

        private static string GetSelectedPlayerFilePath(string selectedPlayer)
        {
            return GetFullDirectoryFilePath(s_playersDirectoryName, selectedPlayer);
        }

        public static bool GetPlayersLimitsFromGameFile(string gameName,
            ref decimal[] limits)
        {
            foreach (FileInfo file in GetPlayersLimitsTextFiles())
            {
                if (gameName == Path.GetFileNameWithoutExtension(file.Name))
                {
                    string[] fileRead = File.ReadAllLines(file.FullName);
                    for (int i = 0; i < limits.Length; i++)
                        limits[i] = Convert.ToDecimal(fileRead[i]);
                    return true;
                }
            }
            return false;
        }

        public static string[] GetOptionsFromFile()
        {
            return File.ReadAllLines(s_optionsFileName);
        }

        public static string[] GetGamesFromFile()
        {
            return File.ReadAllLines(s_gamesListFileName);
        }

        public static string[] GetGamesPlayerDoesntPlay(string selectedPlayer)
        {
            foreach (FileInfo file in GetPlayersTextFiles())
            {
                if (selectedPlayer == Path.GetFileNameWithoutExtension(file.Name))
                    return File.ReadAllLines(file.FullName);
            }
            return null;
        }
        
        private static FileInfo[] GetTextFiles(string directoryName)
        {
            DirectoryInfo directory = new DirectoryInfo(directoryName);
            return directory.GetFiles(s_allTextFileExtension);
        }

        private static FileInfo[] GetPlayersTextFiles()
        {
            return GetTextFiles(directoryName: s_playersDirectoryName);
        }

        private static FileInfo[] GetPlayersLimitsTextFiles()
        {
            return GetTextFiles(directoryName: s_limitsDirectoryName);
        }

        public static List<string> GetLimitedGamesFromDirectory(int checkedPlayersCount)
        {
            List<string> limitedGames = new List<string>();
            foreach (FileInfo fileInfo in GetPlayersLimitsTextFiles())
            {
                string[] lines = File.ReadAllLines(fileInfo.FullName);
                if (checkedPlayersCount < Convert.ToInt32(lines[0]) ||
                    checkedPlayersCount > Convert.ToInt32(lines[1]))
                    limitedGames.Add(Path.GetFileNameWithoutExtension(fileInfo.Name));
            }
            return limitedGames;
        }

        public static List<string> GetGamesListFromFile()
        {
            List<string> games = new List<string>();
            foreach (string game in File.ReadAllLines(s_gamesListFileName))
                games.Add(game);
            games.Sort();
            return games;
        }

        public static List<Player> GetPlayersListFromDirectory()
        {
            List<Player> players = new List<Player>();
            foreach (FileInfo fileInfo in GetPlayersTextFiles())
            {
                List<string> gamesNotPlaying = new List<string>();
                foreach (string gameDoesntPlay in File.ReadAllLines(fileInfo.FullName))
                    gamesNotPlaying.Add(gameDoesntPlay);
                players.Add(new Player(Path.GetFileNameWithoutExtension(fileInfo.Name), gamesNotPlaying));
            }
            return players;
        }

        public static void AppendGameToPlayersFiles(string gameName)
        {
            foreach (FileInfo file in GetPlayersTextFiles())
                File.AppendAllText(file.FullName, gameName + "\n");
        }

        public static void AddGameToGameListFile(string gameName)
        {
            File.AppendAllText(s_gamesListFileName, gameName + Environment.NewLine);
        }

        public static void WriteThemeToFile(string theme)
        {
            File.WriteAllText(s_themeFileName, theme);
        }

        public static void WriteOptionsToFile(string[] options)
        {
            File.WriteAllLines(s_optionsFileName, options);
        }

        public static void WritePlayersLimitsToFile(string gameName, decimal minValue, decimal maxValue)
        {
            string path = GetSelectedGamePlayersLimitsFilePath(gameName);
            CreateFile(path);
            using (TextWriter textWriter = new StreamWriter(path))
            {
                textWriter.WriteLine(Convert.ToString(minValue));
                textWriter.WriteLine(Convert.ToString(maxValue));
            }
        }
        
        public static void WriteGamesNotPlayingToFile(string selectedPlayer,
            List<string> gamesNotPlayingList)
        {
            string path = GetSelectedPlayerFilePath(selectedPlayer);
            CreatePlayerFile(selectedPlayer);
            using (TextWriter textWriter = new StreamWriter(path))
                foreach (string gameNotPlaying in gamesNotPlayingList)
                    textWriter.WriteLine(gameNotPlaying.ToString());
        }

        public static void DeleteGameFromGameList(string gameToDelete)
        {
            string[] games = GetGamesFromFile();
            File.WriteAllText(s_gamesListFileName, string.Empty);
            foreach (string game in games)
                if (game != gameToDelete) AddGameToGameListFile(game);
        }

        private static void DeleteGameFromPlayersFiles(string gameToDelete)
        {
            foreach (FileInfo fileInfo in GetPlayersTextFiles())
            {
                File.WriteAllLines(fileInfo.FullName,
                    File.ReadLines(fileInfo.FullName).Where(game => game != gameToDelete).ToList());
            }
        }

        public static void DeletePlayersLimitsFile(string gameName)
        {
            string path = GetSelectedGamePlayersLimitsFilePath(gameName);
            if (File.Exists(path)) File.Delete(path);
        }

        public static void DeletePlayersGameData(string gameToDelete)
        {
            DeletePlayersLimitsFile(gameName: gameToDelete);
            DeleteGameFromPlayersFiles(gameToDelete: gameToDelete);
        }

        public static void DeleteSelectedPlayerFile(string selectedPlayer)
        {
            File.Delete(GetSelectedPlayerFilePath(selectedPlayer));
        }
    }
}
