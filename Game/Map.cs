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
            CurrentSeq.Add(CreateRandSeq(1.0f));
            CurrentSeq.Add(CreateRandSeq(1.0f+CurrentSeq[0].Length));
        }

        private Sequence CreateRandSeq(float startX){
            var rand = new Random();

            switch (rand.Next(1,1)){
                default:
                    var seq = new SplitSequence(startX);
                    seq.CreateObstacles();
                    return seq;
            }
        }

        public void Update(float step){
            foreach (Sequence seq in CurrentSeq){
                seq.Move(step);
            }
            if (CurrentSeq[0].Length + CurrentSeq[0].PosX <= 0.0f){
                CurrentSeq.RemoveAt(0);
                CurrentSeq.Add(
                    CreateRandSeq(CurrentSeq[0].PosX + CurrentSeq[0].Length));
            }
        }
    }
}
