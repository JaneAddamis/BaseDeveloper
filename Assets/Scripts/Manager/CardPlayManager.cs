using estimation.ai;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPlayManager : MonoBehaviour
{
    public static CardPlayManager Instance;

    [HideInInspector]
    public State mainState;

    private int nFirstBidderIndex, nFirstPlayerIndex;

    /// <summary>
    /// AI level value
    /// </summary>
    private int aiTime = 1000;

    private int nTurnIndex = 0;

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
        if (!mainState.IsBidFinish() && mainState.canNextBid())
        {
            int nUserIndex = (nTurnIndex + nFirstBidderIndex) % State.PLAYER_COUNT;
            mainState.questionBid(nUserIndex);
            nTurnIndex++;
        }
    }

    public void InitCardGameState()
    {
        nFirstBidderIndex = 0;
        nTurnIndex = 0;
        State.DECK_SIZE = 52;
        State.MAX_HAND_SIZE = 13;
        State.PLAYER_COUNT = 4;
        State.MELD_SIZE = 4;
        InitRound();
    }

    public void InitRound()
    {
        mainState = new State(nFirstBidderIndex);
    }

    public enum TurnType
    {
        BidTurn,
        ConfirmTurn,
        CardTurn
    }
}
