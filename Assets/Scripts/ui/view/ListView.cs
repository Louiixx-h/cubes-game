using Assets.Scripts.data.entity;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.ui
{
    
    public class ListView : MonoBehaviour
    {

        [SerializeField]
        private Button _itemTemplate;

        [SerializeField]
        private List<Hat> _hats;

        public delegate void OnHatSelected(GameObject hat);
        public event OnHatSelected onItemSelected;

        void Start()
        {
            SetListView(_hats);
        }

        void SetListView(List<Hat> hats)
        {
            for(int i = 0; i < hats.Count; i++)
            {
                if (_hats[i].hat == null) new NullReferenceException("Objeto cabelo não pode ser null");
                _itemTemplate.transform.GetChild(0).GetComponent<Image>().sprite = hats[i].imageHat;
                SetListenerOnButtonAndSetHat(Instantiate(_itemTemplate, transform), _hats[i].hat); 
            }
        }

        void SetListenerOnButtonAndSetHat(Button button, GameObject hat)
        {
            button.onClick.AddListener(delegate () {
                onItemSelected.Invoke(hat);
            });
        }
    }
}