﻿using System;
using System.Windows.Forms;

namespace WhatGameToPlay
{
    public partial class GamesListForm : Form
    {
        private readonly GamesListFormModel _gamesListFormModel;

        public GamesListForm(MainForm mainForm)
        {
            _gamesListFormModel = new GamesListFormModel(this, mainForm);
            InitializeComponent();
            _gamesListFormModel.RefreshListBoxGames();
        }

        public ListBox ListBoxGames
        { 
            get => listBoxGames;
            set => listBoxGames = value; 
        }

        public string TextBoxGameNameText 
        { 
            get => textBoxGameName.Text; 
            set => textBoxGameName.Text = value;  
        }

        public decimal NumericUpDownMaxValue => numericUpDownMax.Value;

        public decimal NumericUpDownMinValue => numericUpDownMin.Value;

        public bool CheckBoxPlayersNumberLimitChecked
        {
            get => checkBoxPlayersNumberLimit.Checked;
            set => checkBoxPlayersNumberLimit.Checked = value;
        }

        private void GamesListForm_Load(object sender, EventArgs e)
        {
            FormsTheme.ColorControls(form: this);
        }

        public void UnableButtonAddGame() => buttonAddGame.Enabled = false;

        private void ListBoxGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGames.SelectedItem != null) 
            {
                textBoxGameName.Text = listBoxGames.SelectedItem.ToString();
            }
        }

        private void TextBoxGameName_TextChanged(object sender, EventArgs e)
        {
            _gamesListFormModel.TextBoxGameNameTextChanged();
        }

        private void ButtonAddGame_Click(object sender, EventArgs e)
        {
            _gamesListFormModel.AddGame();
        }

        private void ButtonDeleteGame_Click(object sender, EventArgs e)
        {
            _gamesListFormModel.DeleteGameConfirmation();
        }

        private void ListBoxGames_DoubleClick(object sender, EventArgs e)
        {
            _gamesListFormModel.DeleteGameFromListBox();
        }

        private void CheckBoxPlayersNumberLimit_CheckedChanged(object sender, EventArgs e)
        {
            SetNumericUpDownsEnables(enable: checkBoxPlayersNumberLimit.Checked);
            _gamesListFormModel.StartedLimitsEntering = checkBoxPlayersNumberLimit.Checked;
            if (checkBoxPlayersNumberLimit.Checked || !_gamesListFormModel.GamesLimitsFileExists) return;
            _gamesListFormModel.DeleteGameLimitsDialog();
        }

        public void SwitchGameButtonsEnables()
        {
            buttonAddGame.Enabled = !buttonAddGame.Enabled;
            buttonDeleteGame.Enabled = !buttonDeleteGame.Enabled;
        }

        public void SetNumericUpDownsEnables(bool enable)
        {
            numericUpDownMax.Enabled = enable;
            numericUpDownMin.Enabled = enable;
        }

        public void SetNumericUpDownsStandartValues()
        {
            numericUpDownMin.Value = numericUpDownMin.Minimum;
            numericUpDownMax.Value = numericUpDownMax.Maximum;
        }

        public void SetPlayersLimitsToNumericUpDowns()
        {
            checkBoxPlayersNumberLimit.Checked = _gamesListFormModel.PlayerLimitsExist;
            if (_gamesListFormModel.PlayerLimitsExist)
            {
                numericUpDownMin.Value = _gamesListFormModel.PlayersLimits[0];
                numericUpDownMax.Value = _gamesListFormModel.PlayersLimits[1];
            }
        }

        public void SetGameRelatedControlsEnables(bool enable)
        {
            SetGameButtonsEnables(enable: enable);
            checkBoxPlayersNumberLimit.Enabled = !enable;
        }

        private void SetGameButtonsEnables(bool enable)
        {
            buttonAddGame.Enabled = enable;
            buttonDeleteGame.Enabled = !enable;
            AcceptButton = enable ? buttonAddGame : buttonDeleteGame;
        }

        private void GamesListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _gamesListFormModel.GamesListFormClosing();
        }
    }
}
