﻿using System.Drawing;

namespace DALib.Drawing
{
    public class ColorTableEntry
    {
        private Color[] _colors;

        public int ColorCount => _colors.Length;
        public Color this[int index] => _colors[index];

        public ColorTableEntry(Color[] colors)
        {
            _colors = colors;
        }
    }
}
