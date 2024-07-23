
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

namespace TestTusk
{
    public class PlayerStateMachine : MonoBehaviour
    {
        public Dictionary<Type, Istate> behaivorMap;
        public Istate behavaiorCurrent;

        public Item _bulletscount;

        private void Awake()
        {

            this.InitialiseBehavior();
            this.SetBehaviorDeffault();

        }


        private void Update()
        {

          if (_bulletscount._bulletsCount == 0)

            {

                SetReloadBehavior();

            }


            if (this.behavaiorCurrent != null)

                this.behavaiorCurrent.Update();


        }


        public  void InitialiseBehavior()
        {
            this.behaivorMap = new Dictionary<Type, Istate>();


            this.behaivorMap[typeof(ShootingState)] = new ShootingState();

            this.behaivorMap[typeof(ReloadingState)] = new ReloadingState();

            this.behaivorMap[typeof(Idle)] = new Idle();

        }

        public  void SetBehavior(Istate behavior)
        {
            if (this.behavaiorCurrent != null)

                this.behavaiorCurrent.Exit();


            this.behavaiorCurrent = behavior;


            this.behavaiorCurrent.Enter();
        }

        public  void SetBehaviorDeffault()
        {
            var BehDeffault = this.GetBehavoir<ShootingState>();
            this.SetBehavior(BehDeffault);
        }

        public  T GetBehavoir<T>()
        {
            var type = typeof(T);
            return (T)this.behaivorMap[type];


        }

        public void SetShootBehavior()
        {


            var behavior = this.GetBehavoir<ShootingState>();
            this.SetBehavior(behavior);


        }

        public void SetReloadBehavior()
        {
            var behavior = this.GetBehavoir<ReloadingState>();
            this.SetBehavior(behavior);
        }


       



    }




}