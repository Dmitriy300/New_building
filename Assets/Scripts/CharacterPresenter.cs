using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;



    public class CharacterPresenter : MonoBehaviour
    {
        public Character Character;
        private void Update()
        {
            Character.gameObject.SetActive(Character.IsDead);
        }
    }

