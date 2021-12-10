using System.Collections;
using UnityEngine;

namespace Assets.Scripts.ui.actor
{
    public class Cube : MonoBehaviour
    {
        private Material _material;

        [SerializeField]
        private Transform _hatPosition;

        private void Start()
        {
            _material = GetComponent<Renderer>().material;
        }

        public void ChangeColor(Color color)
        {
            _material.color = color;
        }

        public void AddHat(GameObject obj)
        {
            if (_hatPosition.childCount > 0)
            {
                Destroy(_hatPosition.GetChild(0).gameObject);
            }
            Instantiate(obj, _hatPosition);
        }
    }
}