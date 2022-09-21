using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slower : Enemy
{
    [SerializeField] float _speedAmount =  2;
    // Start is called before the first frame update
    protected override void PlayerImpact(Player player)
    {
        TankController controller = player.GetComponent<TankController>();
        //base.PlayerImpact(player);
        if (controller != null)
        {
            controller.MaxSpeed /= _speedAmount;
        }
    }
}
