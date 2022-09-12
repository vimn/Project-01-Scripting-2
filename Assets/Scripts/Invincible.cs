using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincible : PowerUpBase
{
    [SerializeField] Material _powerMat;
    public Material _powerDownMat;
    MeshRenderer color;
    public Component[] Renderer;
    bool powerUpState = false;
    float powerTime = 5;
    Player powerPlayer;
    
    protected override void PowerUp(Player player, bool pState)
    {
        
        powerPlayer = player;
        color = player.GetComponentInChildren<MeshRenderer>();
        Player frames = player.GetComponent<Player>();
        frames.invincible = true;
       // _powerDownMat = color.material;
        if (color != null)
        {
            color.material = _powerMat;
        }
        powerUpState = true;
        pState = powerUpState;
    }
    protected override void PowerDown(Player player, bool pState)
    {
        MeshRenderer colors = player.GetComponentInChildren<MeshRenderer>();
        colors.material = _powerDownMat;
        pState = false;
    }

    void Update()
    {   
        if (powerUpState) 
        {
            if (powerTime > 0)
            {
                powerTime -= Time.deltaTime;
            }
            else 
            {
                PowerDown(powerPlayer, false);
                powerUpState = false;
            }
        }
    }
}
