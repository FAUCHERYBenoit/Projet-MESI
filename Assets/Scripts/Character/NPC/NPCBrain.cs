using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBrain : MonoBehaviour
{

}

public enum AI_States{
    Appearing,
    Idle,
    LookingForTarget,
    ChasingTarget,
    Attacking,
    Dying,
}
