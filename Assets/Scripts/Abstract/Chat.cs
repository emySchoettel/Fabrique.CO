using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fabrique.CO.Assets.Scripts.Abstract
{
    public class Chat : Animal 
    { 
        public string Speak(){
            return "Je fais miaou.";
        }
    }
}