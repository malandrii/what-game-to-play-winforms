﻿using System;
using System.Windows.Forms;

namespace WhatGameToPlay
{
    public partial class GamesListForm : Form
    {
        private readonly MainForm _mainForm;
        private readonly MessageController _messageController;
        private string _currentSelectedGame;
        private bool _startedLimitsEntering;
        private bool _playerLimitsExist;

        public GamesListForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            _messageController = new MessageController(_mainForm);
            InitializeComponent();
            RefreshListBoxGames();
        }

        private string SelectedGameName { get => textBoxGameName.Text; }

        private void GamesListForm_Load(object sender, EventArgs e)
        {
            ThemeController.SetFormControlsTheme(form: this);
        }

        private void RefreshListBoxGames()
        {
            listBoxGames.Items.Clear();
            foreach (string game in FilesController.GamesListFromFile)
            {
                listBoxGames.Items.Add(game);
            }
        }

        private bool GameInList(string gameToCheck)
        {
            foreach (string game in FilesController.GamesListFromFile)
            {
                if (gameToCheck == game)
                {
                    return true;
                }
            }
            return false;
        }

        private void ListBoxGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGames.SelectedItem != null) 
            {
                textBoxGameName.Text = listBoxGames.SelectedItem.ToString();
            }
        }

        private void TextBoxGameName_TextChanged(object sender, EventArgs e)
        {
            if (_startedLimitsEntering && !SavePlayersLimits())
            {
                _startedLimitsEntering = false;
                textBoxGameName.Text = _currentSelectedGame;
                listBoxGames.SelectedIndex = listBoxGames.FindString(_currentSelectedGame);
                return;
            }
            bool selectedGameInList = GameInList(SelectedGameName);
            SetNumericUpDownsStandartValues();
            if (selectedGameInList)
            {
                _currentSelectedGame = SelectedGameName;
                listBoxGames.SelectedIndex = listBoxGames.FindString(SelectedGameName);
            }
            else
            {
                listBoxGames.ClearSelected();
                SetNumericUpDownsEnables(enable: false);
            }
            checkBoxPlayersNumberLimit.Enabled = selectedGameInList;
            SetGameButtonsEnables(enable: !selectedGameInList);
            if (FilesController.StringContainsBannedSymbols(SelectedGameName))
            {
                buttonAddGame.Enabled = false;
            }
            SetPlayersLimitsToNumericUpDowns();
        }

        private decimal[] GetPlayersLimits()
        {
            const int limitsCount = 2;
            decimal[] limits = new decimal[limitsCount];
            _playerLimitsExist =
                FilesController.GetPlayersLimitsFromGameFile(SelectedGameName, ref limits);
            return limits;
        }

        private void SetGameButtonsEnables(bool enable)
        {
            buttonAddGame.Enabled = enable;
            buttonDeleteGame.Enabled = !enable;
            AcceptButton = enable ? buttonAddGame : buttonDeleteGame;
        }

        private void SwitchGameButtonsEnables()
        {
            buttonAddGame.Enabled = !buttonAddGame.Enabled;
            buttonDeleteGame.Enabled = !buttonDeleteGame.Enabled;
        }

        private void ButtonAddGame_Click(object sender, EventArgs e)
        {
            FilesController.AddGameToGameListFile(SelectedGameName);
            RefreshListBoxGames();
            GetPlayersLimits();
            if (!_playerLimitsExist)
            {
                FilesController.AppendGameToPlayersFiles(SelectedGameName);
            }
            _messageController.ShowGameAddedToListMessage(SelectedGameName);
            SwitchGameButtonsEnables();
            SetGameButtonsEnables(enable: false);
            checkBoxPlayersNumberLimit.Enabled = true;
        }

        private void ButtonDeleteGame_Click(object sender, EventArgs e)
        {
            DeleteGame();
        }

        private void ListBoxGames_DoubleClick(object sender, EventArgs e)
        {
            if (SelectedGameName == string.Empty) return;
            DeleteGame();
        }

        private void DeleteGame()
        {
            if (_mainForm.ShowConfirmationMessages() && !_messageController.ShowDeleteGameDialog(SelectedGameName)) return;
            DeleteGameFromGameList();
        }

        private void DeleteGameFromGameList()
        {
            foreach (string game in FilesController.GamesListFromFile)
            {
                if (game == SelectedGameName)
                {
                    FilesController.DeleteGameFromGameList(SelectedGameName);
                    break;
                }
            }
            RefreshListBoxGames();
            SwitchGameButtonsEnables();
            if (!_mainForm.SaveDeletedGamesData())
            {
                FilesController.DeletePlayersGameData(SelectedGameName);
            }
            textBoxGameName.Clear();
            SetNumericUpDownsStandartValues();
        }

        private void SetNumericUpDownsEnables(bool enable)
        {
            numericUpDownMax.Enabled = enable;
            numericUpDownMin.Enabled = enable;
        }

        private void SetNumericUpDownsStandartValues()
        {
            numericUpDownMin.Value = numericUpDownMin.Minimum;
            numericUpDownMax.Value = numericUpDownMax.Maximum;
        }

        private void CheckBoxPlayersNumberLimit_CheckedChanged(object sender, EventArgs e)
        {
            SetNumericUpDownsEnables(enable: checkBoxPlayersNumberLimit.Checked);
            _startedLimitsEntering = checkBoxPlayersNumberLimit.Checked;
            if (checkBoxPlayersNumberLimit.Checked
                || !FilesController.PlayersLimitsFileExist(SelectedGameName)) return;
            if (_mainForm.ShowConfirmationMessages())
            {
                if (_messageController.ShowDeletePlayersLimitsFileDialog(SelectedGameName))
                {
                    DeletePlayerLimits();
                }
                else
                {
                    checkBoxPlayersNumberLimit.Checked = true;
                }
            }
            else DeletePlayerLimits();
        }

        private void DeletePlayerLimits()
        {
            FilesController.DeletePlayersLimitsFile(SelectedGameName);
            SetNumericUpDownsStandartValues();
        }

        private void SetPlayersLimitsToNumericUpDowns()
        {
            GetPlayersLimits();
            checkBoxPlayersNumberLimit.Checked = _playerLimitsExist;
            decimal[] limits = GetPlayersLimits();
            if (_playerLimitsExist)
            {
                numericUpDownMin.Value = limits[0];
                numericUpDownMax.Value = limits[1];
            }
        }

        private bool SavePlayersLimits()
        {
            bool limitsFit = numericUpDownMax.Value > numericUpDownMin.Value;
            if (limitsFit)
            {
                FilesController.WritePlayersLimitsToFile(_currentSelectedGame,
                numericUpDownMin.Value, numericUpDownMax.Value);
            }
            else if (_mainForm.ShowMessages)
            {
                _messageController.ShowPlayersLimitsErrorMessage();
            }
            return limitsFit;
        }

        private void GamesListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBoxPlayersNumberLimit.Checked) SavePlayersLimits();
            _mainForm.ClearInformation();
        }
    }
}
