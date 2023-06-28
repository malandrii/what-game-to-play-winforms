﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace WhatGameToPlay
{
    public static class AdvancedMessageBoxModel
    {
        private const int WidthAfterLabel = 60;
        private const int HeightAfterLabel = 135;

        public static int GetFormWidth(int labelMessageWidth) => labelMessageWidth + WidthAfterLabel;

        public static int GetFormHeight(int labelMessageHeight) => labelMessageHeight + HeightAfterLabel;

        public static void SetButtonLocation(ref Button button, Button buttonYes, int panelHeight, int formWidth)
        {
            const int lastButtonX = 105, firstButtonX = lastButtonX + 85;
            int buttonY = panelHeight / 2 - 10, buttonX = formWidth;
            buttonX -= button == buttonYes ? firstButtonX : lastButtonX;
            button.Location = new Point(buttonX, buttonY);
        }

        public static bool TimerTick(ref Label labelTimer)
        {
            int secondsLeft = Convert.ToInt32(labelTimer.Text);
            bool continueTimer = secondsLeft != 0;
            if (continueTimer)
            {
                secondsLeft--;
                labelTimer.Text = Convert.ToString(secondsLeft);
            }
            return continueTimer;
        }
    }
}
