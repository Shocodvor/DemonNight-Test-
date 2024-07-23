using System.Threading;
using UnityEngine;

namespace TestTusk
{
    public interface Istate
    {

        void Enter( );
        void Exit( );
        void Update();


    }
}