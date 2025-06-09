using System;


namespace practicalwork
{
    public enum Status
    {
        EnRoute,
        Waiting,
        Docking,
        Docked
    }
    public class Train
    {
        protected string ID;
        protected Status status;
        protected int arrivalTime;
        protected string type;

        public Train(string ID, int arrivalTime, string type)
        {
            this.ID = ID;
            this.arrivalTime = arrivalTime;
            this.type = type;
            this.status = Status.EnRoute;
        }


        public string getID()
        {
            return this.ID;
        }

        public int getArrivalTime()
        {
            return this.arrivalTime;
        }

        public string getType()
        {
            return this.type;
        }

        public Status getStatus()
        {
            return this.status;
        }

        
    }

    
}