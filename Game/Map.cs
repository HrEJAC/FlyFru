using System;
using System.Collections.Generic;

namespace Game
{
    public class Map
    {
        List<Sequence> CurrentSeq;

        public Map()
        {
            CurrentSeq = new List<Sequence> { };

        }

        private Sequence CreateRandSeq(){
            var rand = new Random();

            switch (rand.Next(5)){
                case 1:
                    var seq = new aSequence();
                    seq.
                    return aSequence();
                case 2:
                    return aSequence();
                case 3:
                    return aSequence();
                case 4:
                    return aSequence();
                case 5:
                    return aSequence();
            }
        }

        public void Update(float step){
            foreach (Sequence seq in CurrentSeq){
                seq.Move(step);
            }

        }
    }
}
