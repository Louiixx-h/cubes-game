using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.ui
{
    public class ColorButtonImpl : MonoBehaviour, ColorButton
    {
        [SerializeField]
        private List<Button> _buttons;

        public delegate void OnColorSelected(Color color);
        public event ColorButton.OnColorSelected onItemSelected;

        private void Start()
        {
            ChangeColor();
        }

        public void ChangeColor()
        {
            if (_buttons == null) throw new Exception("Lista de botões está vazia.");
            else
            {
                foreach (Button btn in _buttons)
                {
                    btn.onClick.AddListener(delegate () {
                        onItemSelected.Invoke(btn.GetComponent<Image>().color);
                    });
                }
            }
        }
    }
}