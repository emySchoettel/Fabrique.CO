using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fabrique.CO.Assets.Scripts.Abstract
{
    public class Chien : Animal 
    {
        public string Speak()
        {
            return "Je fais wouaf wouaf."; 
        }
    }
}