﻿using System;
using Xamarin.Forms;

namespace EPServices.Controls
{
    public enum GradientColorStackMode
    {
        ToRight,
        ToLeft,
        ToTop,
        ToBottom,
        ToTopLeft,
        ToTopRight,
        ToBottomLeft,
        ToBottomRight
    }
    public class GradientLayout : StackLayout
    {
        public string ColorsList { get; set; }

        public Color[] Colors
        {
            get
            {
                string[] hex = ColorsList.Split(',');
                Color[] colors = new Color[hex.Length];

                for (int i = 0; i < hex.Length; i++)
                {
                    colors[i] = Color.FromHex(hex[i].Trim());
                }

                return colors;
            }
        }

        public GradientColorStackMode Mode { get; set; }
    }
}
