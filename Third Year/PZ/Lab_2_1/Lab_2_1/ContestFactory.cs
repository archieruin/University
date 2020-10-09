using System;
using System.Collections.Generic;

namespace Lab_2_1
{
    abstract class ContestCreator
    {
        public abstract IContest FactoryMethod();
    }

    class QualifyingContestCreator : ContestCreator
    {
        public override IContest FactoryMethod()
        {
            return new QualifyingContest();
        }
    }

    class FinalContestCreator : ContestCreator
    {
        public override IContest FactoryMethod()
        {
            return new FinalContest();
        }
    }
    
    public interface IContest
    {
        List<Swimmer> SortSwimmersByTracks(List<Swimmer> swimmers);
    }
    
    class QualifyingContest : IContest 
    {
        public List<Swimmer> SortSwimmersByTracks(List<Swimmer> swimmers)
        {
            List<Swimmer> newSwimmers = new List<Swimmer>();

            swimmers.ForEach((item)=>
            {
                newSwimmers.Add(new Swimmer(item.FullName, item.Age, item.Rating));
            });
            
            newSwimmers.Sort((xSwimmer, ySwimmer) =>
            {
                if (xSwimmer.Rating < ySwimmer.Rating) return 1;
                if (xSwimmer.Rating > ySwimmer.Rating) return -1;
                return xSwimmer.Rating.CompareTo(ySwimmer.Rating);
            });
            
            int track = 1;
            foreach (Swimmer swimmer in newSwimmers)
            {
                swimmer.Track = track;
                track++;
            }
            return newSwimmers;
        }
    }
    
    class FinalContest : IContest 
    {
        public List<Swimmer> SortSwimmersByTracks(List<Swimmer> swimmers)
        {
            List<Swimmer> newSwimmers = new List<Swimmer>();
            List<Swimmer> tempSwimmers = new List<Swimmer>();

            swimmers.ForEach((item)=>
            {
                newSwimmers.Add(new Swimmer(item.FullName, item.Age, item.Rating));
            });
            
            newSwimmers.Sort((xSwimmer, ySwimmer) =>
            {
                if (xSwimmer.Rating > ySwimmer.Rating) return 1;
                if (xSwimmer.Rating < ySwimmer.Rating) return -1;
                return xSwimmer.Rating.CompareTo(ySwimmer.Rating);
            });

            bool flag = false;
            foreach (Swimmer swimmer in newSwimmers)
            {
                if (!flag)
                {
                    tempSwimmers.Insert(0, swimmer);
                    flag = true;
                }
                else
                {
                    tempSwimmers.Add(swimmer);
                    flag = false;
                }
            }
            
            int track = 1;
            foreach (Swimmer swimmer in tempSwimmers)
            {
                swimmer.Track = track;
                track++;
            }
            
            return tempSwimmers;
        }
    }
}