using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace character
{
    public abstract class AbstractCharacterManager : MonoBehaviour
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
    }
}

