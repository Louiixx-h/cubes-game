using Assets.Scripts;
using Assets.Scripts.ui;
using Assets.Scripts.ui.actor;
using UnityEngine;

public class SceneManager: MonoBehaviour
{
    private Cube _cube;
    private ColorButton _uiManager;
    private ListView _listView;

    public static SceneManager Instance { get; private set; }
    
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        _uiManager = FindObjectOfType<ColorButtonImpl>();
        _cube = FindObjectOfType<Cube>();
        _listView = FindObjectOfType<ListView>();

        _uiManager.onItemSelected += _cube.ChangeColor;
        _listView.onItemSelected += _cube.AddHat;
    }
}
