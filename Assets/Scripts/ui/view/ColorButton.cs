using UnityEngine;

namespace Assets.Scripts.ui
{
    public interface ColorButton
    {
        public delegate void OnColorSelected(Color color);
        public event OnColorSelected onItemSelected;

        void ChangeColor();
    }
}