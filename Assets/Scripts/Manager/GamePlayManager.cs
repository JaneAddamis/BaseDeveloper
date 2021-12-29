using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayManager : MonoBehaviour
{
    public static GamePlayManager Instance;
    public List<UIToggle> lstGameTypeToggles;

    [HideInInspector]
    public CardGameType curGmaeType = CardGameType.FullBola;

    private void Awake()
    {
        // If Instance is not null (any time after the first time)
        // AND
        // If Instance is not 'this' (after the first time)
        if (Instance != null && Instance != this)
        {
            // ...then destroy the game object this script component is attached to.
            Destroy(gameObject);
        }
        else
        {
            // Tell Unity not to destory the GameObject this
            //  is attached to between scenes.
            DontDestroyOnLoad(gameObject);
            // Save an internal reference to the first instance of this class
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void fnSelectRoundType(CardGameType type)
    {
        curGmaeType = type;
        Debug.Log(curGmaeType.ToString());
    }

    public void fnStartTestGame()
    {
        SceneManager.LoadScene("scn_test_game_play_window", LoadSceneMode.Additive);
    }

}
